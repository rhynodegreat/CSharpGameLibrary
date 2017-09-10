﻿using System;
using System.Collections.Generic;

namespace CSGL.Vulkan {
    public class PipelineLayoutCreateInfo {
        public List<DescriptorSetLayout> setLayouts;
        public List<VkPushConstantRange> pushConstantRanges;
    }

    public class PipelineLayout : IDisposable, INative<VkPipelineLayout> {
        VkPipelineLayout pipelineLayout;
        bool disposed = false;

        public Device Device { get; private set; }
        public List<DescriptorSetLayout> Layouts { get; private set; }
        public List<VkPushConstantRange> PushConstantRanges { get; private set; }

        public VkPipelineLayout Native {
            get {
                return pipelineLayout;
            }
        }

        public PipelineLayout(Device device, PipelineLayoutCreateInfo info) {
            if (device == null) throw new ArgumentNullException(nameof(device));
            if (info == null) throw new ArgumentNullException(nameof(info));

            Device = device;
            CreateLayout(info);

            if (info.setLayouts != null) Layouts = new List<DescriptorSetLayout>(info.setLayouts);
            if (info.pushConstantRanges != null) PushConstantRanges = new List<VkPushConstantRange>(info.pushConstantRanges);
        }

        void CreateLayout(PipelineLayoutCreateInfo mInfo) {
            VkPipelineLayoutCreateInfo info = new VkPipelineLayoutCreateInfo();
            info.sType = VkStructureType.PipelineLayoutCreateInfo;

            NativeArray<VkDescriptorSetLayout> layoutsMarshalled = null;
            if (mInfo.setLayouts != null) {
                layoutsMarshalled = new NativeArray<VkDescriptorSetLayout>(mInfo.setLayouts.Count);
                for (int i = 0; i < mInfo.setLayouts.Count; i++) {
                    layoutsMarshalled[i] = mInfo.setLayouts[i].Native;
                }
                info.setLayoutCount = (uint)layoutsMarshalled.Count;
                info.pSetLayouts = layoutsMarshalled.Address;
            }

            var pushConstantsMarshalled = new MarshalledArray<VkPushConstantRange>(mInfo.pushConstantRanges);
            info.pushConstantRangeCount = (uint)pushConstantsMarshalled.Count;
            info.pPushConstantRanges = pushConstantsMarshalled.Address;

            using (layoutsMarshalled)
            using (pushConstantsMarshalled) {
                var result = Device.Commands.createPipelineLayout(Device.Native, ref info, Device.Instance.AllocationCallbacks, out pipelineLayout);
                if (result != VkResult.Success) throw new PipelineLayoutException(result, string.Format("Error creating pipeline layout: {0}", result));
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool disposing) {
            if (disposed) return;
            Device.Commands.destroyPipelineLayout(Device.Native, pipelineLayout, Device.Instance.AllocationCallbacks);
            disposed = true;
        }

        ~PipelineLayout() {
            Dispose(false);
        }
    }

    public class PipelineLayoutException : VulkanException {
        public PipelineLayoutException(VkResult result, string message) : base(result, message) { }
    }
}
