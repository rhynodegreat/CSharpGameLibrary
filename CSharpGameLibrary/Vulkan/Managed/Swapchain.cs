﻿using System;
using System.Collections.Generic;

using CSGL;
using CSGL.Vulkan;
using CSGL.Vulkan.Unmanaged;

namespace CSGL.Vulkan.Managed {
    public class SwapchainCreateInfo {
        public Surface surface;
        public uint minImageCount;
        public VkFormat imageFormat;
        public VkColorSpaceKHR colorSpace;
        public VkExtent2D imageExtent;
        public uint imageArrayLayers;
        public VkImageUsageFlags imageUsageFlags;
        public VkSharingMode imageSharingMode;
        public uint[] queueFamilyIndices;
        public VkSurfaceTransformFlagsKHR preTransform;
        public VkCompositeAlphaFlagsKHR compositeAlpha;
        public VkPresentModeKHR presentMode;
        public bool clipped;
        public Swapchain oldSwapchain;

        public SwapchainCreateInfo(Surface surface, Swapchain oldSwapchain) {
            this.surface = surface;
            this.oldSwapchain = oldSwapchain;
        }
    }

    public class Swapchain : IDisposable {
        VkSwapchainKHR swapchain;
        bool disposed;
        
        vkGetSwapchainImagesKHRDelegate getImages;

        public Instance Instance { get; private set; }
        public Surface Surface { get; private set; }
        public Device Device { get; private set; }
        public List<Image> Images { get; private set; }

        public VkSwapchainKHR Native {
            get {
                return swapchain;
            }
        }

        public Swapchain(Device device, SwapchainCreateInfo info) {
            if (device == null) throw new ArgumentNullException(nameof(device));
            if (info == null) throw new ArgumentNullException(nameof(info));
            if (info.surface == null) throw new ArgumentNullException(nameof(info.surface));

            Surface = info.surface;
            Instance = Surface.Instance;
            Device = device;
            
            getImages = Device.Commands.getSwapchainImages;

            CreateSwapchain(info);

            GetImages();
        }

        void GetImages() {
            Images = new List<Image>();

            uint count = 0;
            getImages(Device.Native, swapchain, ref count, IntPtr.Zero);
            var images = new MarshalledArray<VkImage>((int)count);
            getImages(Device.Native, swapchain, ref count, images.Address);

            for (int i = 0; i < count; i++) {
                var image = images[i];
                Images.Add(new Image(Device, image));
            }
        }

        void CreateSwapchain(SwapchainCreateInfo mInfo) {
            var info = new VkSwapchainCreateInfoKHR();
            info.sType = VkStructureType.StructureTypeSwapchainCreateInfoKhr;
            info.surface = mInfo.surface.Native;
            info.minImageCount = mInfo.minImageCount;
            info.imageFormat = mInfo.imageFormat;
            info.imageColorSpace = mInfo.colorSpace;
            info.imageExtent = mInfo.imageExtent;
            info.imageArrayLayers = mInfo.imageArrayLayers;
            info.imageUsage = mInfo.imageUsageFlags;
            info.imageSharingMode = mInfo.imageSharingMode;

            var indicesMarshalled = new PinnedArray<uint>(mInfo.queueFamilyIndices);
            info.queueFamilyIndexCount = (uint)indicesMarshalled.Length;
            info.pQueueFamilyIndices = indicesMarshalled.Address;

            info.preTransform = mInfo.preTransform;
            info.compositeAlpha = mInfo.compositeAlpha;
            info.presentMode = mInfo.presentMode;
            info.clipped = mInfo.clipped ? 1u : 0u;
            if (mInfo.oldSwapchain != null) {
                info.oldSwapchain = mInfo.oldSwapchain.Native;
            }

            try {
                var result = Device.Commands.createSwapchain(Device.Native, ref info, Instance.AllocationCallbacks, out swapchain);
                if (result != VkResult.Success) throw new SwapchainException(string.Format("Error creating swapchain: {0}", result));
            }
            finally {
            }
        }

        public VkResult AcquireNextImage(ulong timeout, Semaphore semaphore, Fence fence, out uint index) {
            VkSemaphore sTemp = VkSemaphore.Null;
            VkFence fTemp = VkFence.Null;
            if (semaphore != null) sTemp = semaphore.Native;
            if (fence != null) fTemp = fence.Native;

            var result = Device.Commands.acquireNextImage(Device.Native, swapchain, timeout, sTemp, fTemp, out index);
            return result;
        }

        public VkResult AcquireNextImage(Semaphore semaphore, out uint index) {
            return AcquireNextImage(ulong.MaxValue, semaphore, null, out index);
        }

        public VkResult AcquireNextImage(ulong timeout, Semaphore semaphore, out uint index) {
            return AcquireNextImage(timeout, semaphore, null, out index);
        }

        public VkResult AcquireNextImage(Fence fence, out uint index) {
            return AcquireNextImage(ulong.MaxValue, null, fence, out index);
        }

        public VkResult AcquireNextImage(ulong timeout, Fence fence, out uint index) {
            return AcquireNextImage(timeout, null, fence, out index);
        }

        public VkResult AcquireNextImage(Semaphore semaphore, Fence fence, out uint index) {
            return AcquireNextImage(ulong.MaxValue, semaphore, fence, out index);
        }

        public void Dispose() {
            if (disposed) return;

            unsafe {
                Device.Commands.destroySwapchain(Device.Native, swapchain, Instance.AllocationCallbacks);
            }

            disposed = true;
        }
    }

    public class SwapchainException : Exception {
        public SwapchainException(string message) : base(message) { }
    }
}
