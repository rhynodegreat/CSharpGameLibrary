﻿using System;
using System.Collections.Generic;

using CSGL.GLFW;
using CSGL.GLFW.Unmanaged;

namespace CSGL.Vulkan {
    public class VkSurface : IDisposable, INative<Unmanaged.VkSurfaceKHR> {
        Unmanaged.VkSurfaceKHR surface;
        bool disposed = false;

        public VkInstance Instance { get; private set; }

        public Unmanaged.VkSurfaceKHR Native {
            get {
                return surface;
            }
        }

        public VkSurface(VkInstance instance, Window window) {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            if (window == null) throw new ArgumentNullException(nameof(window));

            Init(instance, window.Native);
        }

        public VkSurface(VkInstance instance, WindowPtr window) {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            if (window == WindowPtr.Null) throw new ArgumentNullException(nameof(window));

            Init(instance, window);
        }

        void Init(VkInstance instance, WindowPtr window) {
            Instance = instance;

            CreateSurface(window);
        }

        void CreateSurface(WindowPtr window) {
            var result = (VkResult)GLFW.GLFW.CreateWindowSurface(Instance.Native.native, window, Instance.AllocationCallbacks, out surface.native);
            if (result != VkResult.Success) throw new SurfaceException(result, string.Format("Error creating surface: {0}", result));
        }

        public VkSurfaceCapabilitiesKHR GetCapabilities(VkPhysicalDevice physicalDevice) {
            if (physicalDevice == null) throw new ArgumentNullException(nameof(physicalDevice));

            unsafe {
                Unmanaged.VkSurfaceCapabilitiesKHR cap;
                Instance.Commands.getCapabilities(physicalDevice.Native, surface, (IntPtr)(&cap));
                return new VkSurfaceCapabilitiesKHR(cap);
            }
        }

        public IList<VkSurfaceFormatKHR> GetFormats(VkPhysicalDevice physicalDevice) {
            if (physicalDevice == null) throw new ArgumentNullException(nameof(physicalDevice));

            unsafe {
                var formats = new List<VkSurfaceFormatKHR>();

                uint count = 0;
                Instance.Commands.getFormats(physicalDevice.Native, surface, ref count, IntPtr.Zero);
                var formatsNative = stackalloc Unmanaged.VkSurfaceFormatKHR[(int)count];
                Instance.Commands.getFormats(physicalDevice.Native, surface, ref count, (IntPtr)formatsNative);
                
                for (int i = 0; i < count; i++) {
                    formats.Add(new VkSurfaceFormatKHR(formatsNative[i]));
                }

                return formats;
            }
        }

        public IList<VkPresentModeKHR> GetPresentModes(VkPhysicalDevice physicalDevice) {
            if (physicalDevice == null) throw new ArgumentNullException(nameof(physicalDevice));

            unsafe {
                var presentModes = new List<VkPresentModeKHR>();

                uint count = 0;
                Instance.Commands.getModes(physicalDevice.Native, surface, ref count, IntPtr.Zero);
                var presentModesNative = stackalloc VkPresentModeKHR[(int)count];
                Instance.Commands.getModes(physicalDevice.Native, surface, ref count, (IntPtr)presentModesNative);
                
                for (int i = 0; i < count; i++) {
                    presentModes.Add(presentModesNative[i]);
                }

                return presentModes;
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool disposing) {
            if (disposed) return;

            Instance.Commands.destroySurface(Instance.Native, surface, Instance.AllocationCallbacks);

            disposed = true;
        }

        ~VkSurface() {
            Dispose(false);
        }
    }

    public class SurfaceException : VulkanException {
        public SurfaceException(VkResult result, string message) : base(result, message) { }
    }
}
