﻿using System;
using System.Collections.Generic;

namespace CSGL.Vulkan {
    public class VkDescriptorSetAllocateInfo {
        public IList<VkDescriptorSetLayout> setLayouts;
    }

    public class VkDescriptorBufferInfo {
        public VkBuffer buffer;
        public long offset;
        public long range;
    }

    public class VkDescriptorImageInfo {
        public VkSampler sampler;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
    }

    public class VkWriteDescriptorSet {
        public VkDescriptorSet dstSet;
        public int dstBinding;
        public int dstArrayElement;
        public VkDescriptorType descriptorType;
        public IList<VkDescriptorImageInfo> imageInfo;
        public IList<VkDescriptorBufferInfo> bufferInfo;
        public IList<VkBufferView> texelBufferView;
    }

    public class VkCopyDescriptorSet {
        public VkDescriptorSet srcSet;
        public int srcBinding;
        public int srcArrayElement;
        public VkDescriptorSet dstSet;
        public int dstBinding;
        public int dstArrayElement;
        public int descriptorCount;
    }

    public class VkDescriptorSet : IDisposable, INative<Unmanaged.VkDescriptorSet> {
        Unmanaged.VkDescriptorSet descriptorSet;
        bool disposed;

        public VkDevice Device { get; private set; }
        public VkDescriptorPool Pool { get; private set; }
        public VkDescriptorSetLayout Layout { get; private set; }

        public Unmanaged.VkDescriptorSet Native {
            get {
                return descriptorSet;
            }
        }

        //set when pool is reset
        //prevents double free
        internal bool CanDispose { get; set; }

        internal VkDescriptorSet(VkDevice device, VkDescriptorPool pool, Unmanaged.VkDescriptorSet descriptorSet, VkDescriptorSetLayout setLayout) {
            Device = device;
            Pool = pool;
            this.descriptorSet = descriptorSet;
            Layout = setLayout;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool disposing) {
            if (disposed) return;

            if (CanDispose) {
                Pool.Free(this);
            }

            disposed = true;
        }

        ~VkDescriptorSet() {
            Dispose(false);
        }

        public static void Update(VkDevice device, IList<VkWriteDescriptorSet> writes, IList<VkCopyDescriptorSet> copies) {
            if (device == null) throw new ArgumentNullException(nameof(device));

            int copyCount = 0;
            int writeCount = 0;

            int totalBuffers = 0;
            int totalImages = 0;
            int totalBufferViews = 0;

            if (writes != null) {
                writeCount = writes.Count;
                for (int i = 0; i < writeCount; i++) {
                    var write = writes[i];

                    if (write.bufferInfo != null) totalBuffers += write.bufferInfo.Count;
                    if (write.imageInfo != null) totalImages += write.imageInfo.Count;
                    if (write.texelBufferView != null) totalBufferViews += write.texelBufferView.Count;
                }
            }

            if (copies != null) {
                copyCount = copies.Count;
            }

            unsafe {
                var bufferInfos = stackalloc Unmanaged.VkDescriptorBufferInfo[totalBuffers];
                var imageInfos = stackalloc Unmanaged.VkDescriptorImageInfo[totalImages];
                var bufferViews = stackalloc Unmanaged.VkBufferView[totalBufferViews];

                int bufferIndex = 0;
                int imageIndex = 0;
                int bufferViewIndex = 0;

                var writesNative = stackalloc Unmanaged.VkWriteDescriptorSet[writeCount];
                var copiesNative = stackalloc Unmanaged.VkCopyDescriptorSet[copyCount];

                for (int i = 0; i < writeCount; i++) {
                    var mWrite = writes[i];

                    writesNative[i].sType = VkStructureType.WriteDescriptorSet;
                    writesNative[i].dstSet = mWrite.dstSet.Native;
                    writesNative[i].dstBinding = (uint)mWrite.dstBinding;
                    writesNative[i].dstArrayElement = (uint)mWrite.dstArrayElement;
                    writesNative[i].descriptorType = mWrite.descriptorType;

                    if (mWrite.bufferInfo != null) {
                        writesNative[i].descriptorCount = (uint)mWrite.bufferInfo.Count;
                        writesNative[i].pBufferInfo = (IntPtr)(&bufferInfos[bufferViewIndex]);

                        for (int j = 0; j < writesNative[i].descriptorCount; j++) {
                            var bufferInfo = new Unmanaged.VkDescriptorBufferInfo();
                            bufferInfo.buffer = mWrite.bufferInfo[j].buffer.Native;
                            bufferInfo.offset = (ulong)mWrite.bufferInfo[j].offset;
                            bufferInfo.range = (ulong)mWrite.bufferInfo[j].range;

                            bufferInfos[bufferIndex] = bufferInfo;
                            bufferIndex++;
                        }
                    } else if (mWrite.imageInfo != null) {
                        writesNative[i].descriptorCount = (uint)mWrite.imageInfo.Count;
                        writesNative[i].pImageInfo = (IntPtr)(&imageInfos[imageIndex]);

                        for (int j = 0; j < writesNative[i].descriptorCount; j++) {
                            var imageInfo = new Unmanaged.VkDescriptorImageInfo();
                            imageInfo.sampler = Unmanaged.VkSampler.Null;
                            imageInfo.imageView = Unmanaged.VkImageView.Null;

                            if (mWrite.imageInfo[j].sampler != null) {
                                imageInfo.sampler = mWrite.imageInfo[j].sampler.Native;
                            }

                            if (mWrite.imageInfo[j].imageView != null) {
                                imageInfo.imageView = mWrite.imageInfo[j].imageView.Native;
                            }

                            imageInfo.imageLayout = mWrite.imageInfo[j].imageLayout;

                            imageInfos[imageIndex] = imageInfo;
                            imageIndex++;
                        }
                    } else if (mWrite.texelBufferView != null) {
                        writesNative[i].descriptorCount = (uint)mWrite.texelBufferView.Count;
                        writesNative[i].pTexelBufferView = (IntPtr)(&bufferViews[bufferViewIndex]);

                        for (int j = 0; j < writesNative[i].descriptorCount; j++) {
                            bufferViews[j] = mWrite.texelBufferView[j].Native;
                            bufferViewIndex++;
                        }
                    }
                }

                for (int i = 0; i < copyCount; i++) {
                    var mCopy = copies[i];

                    copiesNative[i].sType = VkStructureType.CopyDescriptorSet;
                    copiesNative[i].srcSet = mCopy.srcSet.Native;
                    copiesNative[i].srcBinding = (uint)mCopy.srcBinding;
                    copiesNative[i].srcArrayElement = (uint)mCopy.srcArrayElement;
                    copiesNative[i].dstSet = mCopy.dstSet.Native;
                    copiesNative[i].dstBinding = (uint)mCopy.dstBinding;
                    copiesNative[i].dstArrayElement = (uint)mCopy.dstArrayElement;
                    copiesNative[i].descriptorCount = (uint)mCopy.descriptorCount;
                }

                device.Commands.updateDescriptorSets(device.Native, (uint)writeCount, (IntPtr)writesNative, (uint)copyCount, (IntPtr)copiesNative);
            }
        }

        public void Update(IList<VkWriteDescriptorSet> writes, IList<VkCopyDescriptorSet> copies) {
            Update(Device, writes, copies);
        }
    }
}
