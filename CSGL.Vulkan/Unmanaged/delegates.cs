//autogenerated on 09/08/2017 6:57:13 PM
using System;

namespace CSGL.Vulkan.Unmanaged {
    public delegate VkResult vkCreateInstanceDelegate(
        ref VkInstanceCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkInstance pInstance
    );
    public delegate void vkDestroyInstanceDelegate(
        VkInstance instance,
        IntPtr pAllocator
    );
    public delegate VkResult vkEnumeratePhysicalDevicesDelegate(
        VkInstance instance,
        ref uint pPhysicalDeviceCount,
        IntPtr pPhysicalDevices
    );
    public delegate IntPtr vkGetDeviceProcAddrDelegate(
        VkDevice device,
        byte[] pName
    );
    public delegate IntPtr vkGetInstanceProcAddrDelegate(
        VkInstance instance,
        byte[] pName
    );
    public delegate void vkGetPhysicalDevicePropertiesDelegate(
        VkPhysicalDevice physicalDevice,
        IntPtr pProperties
    );
    public delegate void vkGetPhysicalDeviceQueueFamilyPropertiesDelegate(
        VkPhysicalDevice physicalDevice,
        ref uint pQueueFamilyPropertyCount,
        IntPtr pQueueFamilyProperties
    );
    public delegate void vkGetPhysicalDeviceMemoryPropertiesDelegate(
        VkPhysicalDevice physicalDevice,
        IntPtr pMemoryProperties
    );
    public delegate void vkGetPhysicalDeviceFeaturesDelegate(
        VkPhysicalDevice physicalDevice,
        IntPtr pFeatures
    );
    public delegate void vkGetPhysicalDeviceFormatPropertiesDelegate(
        VkPhysicalDevice physicalDevice,
        VkFormat format,
        IntPtr pFormatProperties
    );
    public delegate VkResult vkGetPhysicalDeviceImageFormatPropertiesDelegate(
        VkPhysicalDevice physicalDevice,
        VkFormat format,
        VkImageType type,
        VkImageTiling tiling,
        VkImageUsageFlags usage,
        VkImageCreateFlags flags,
        IntPtr pImageFormatProperties
    );
    public delegate VkResult vkCreateDeviceDelegate(
        VkPhysicalDevice physicalDevice,
        ref VkDeviceCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkDevice pDevice
    );
    public delegate void vkDestroyDeviceDelegate(
        VkDevice device,
        IntPtr pAllocator
    );
    public delegate VkResult vkEnumerateInstanceLayerPropertiesDelegate(
        ref uint pPropertyCount,
        IntPtr pProperties
    );
    public delegate VkResult vkEnumerateInstanceExtensionPropertiesDelegate(
        byte[] pLayerName,
        ref uint pPropertyCount,
        IntPtr pProperties
    );
    public delegate VkResult vkEnumerateDeviceLayerPropertiesDelegate(
        VkPhysicalDevice physicalDevice,
        ref uint pPropertyCount,
        IntPtr pProperties
    );
    public delegate VkResult vkEnumerateDeviceExtensionPropertiesDelegate(
        VkPhysicalDevice physicalDevice,
        byte[] pLayerName,
        ref uint pPropertyCount,
        IntPtr pProperties
    );
    public delegate void vkGetDeviceQueueDelegate(
        VkDevice device,
        uint queueFamilyIndex,
        uint queueIndex,
        out VkQueue pQueue
    );
    public delegate VkResult vkQueueSubmitDelegate(
        VkQueue queue,
        uint submitCount,
        IntPtr pSubmits,
        VkFence fence
    );
    public delegate VkResult vkQueueWaitIdleDelegate(
        VkQueue queue
    );
    public delegate VkResult vkDeviceWaitIdleDelegate(
        VkDevice device
    );
    public delegate VkResult vkAllocateMemoryDelegate(
        VkDevice device,
        ref VkMemoryAllocateInfo pAllocateInfo,
        IntPtr pAllocator,
        out VkDeviceMemory pMemory
    );
    public delegate void vkFreeMemoryDelegate(
        VkDevice device,
        VkDeviceMemory memory,
        IntPtr pAllocator
    );
    public delegate VkResult vkMapMemoryDelegate(
        VkDevice device,
        VkDeviceMemory memory,
        ulong offset,
        ulong size,
        VkMemoryMapFlags flags,
        out IntPtr ppData
    );
    public delegate void vkUnmapMemoryDelegate(
        VkDevice device,
        VkDeviceMemory memory
    );
    public delegate VkResult vkFlushMappedMemoryRangesDelegate(
        VkDevice device,
        uint memoryRangeCount,
        IntPtr pMemoryRanges
    );
    public delegate VkResult vkInvalidateMappedMemoryRangesDelegate(
        VkDevice device,
        uint memoryRangeCount,
        IntPtr pMemoryRanges
    );
    public delegate void vkGetDeviceMemoryCommitmentDelegate(
        VkDevice device,
        VkDeviceMemory memory,
        ref ulong pCommittedMemoryInBytes
    );
    public delegate void vkGetBufferMemoryRequirementsDelegate(
        VkDevice device,
        VkBuffer buffer,
        out VkMemoryRequirements pMemoryRequirements
    );
    public delegate VkResult vkBindBufferMemoryDelegate(
        VkDevice device,
        VkBuffer buffer,
        VkDeviceMemory memory,
        ulong memoryOffset
    );
    public delegate void vkGetImageMemoryRequirementsDelegate(
        VkDevice device,
        VkImage image,
        out VkMemoryRequirements pMemoryRequirements
    );
    public delegate VkResult vkBindImageMemoryDelegate(
        VkDevice device,
        VkImage image,
        VkDeviceMemory memory,
        ulong memoryOffset
    );
    public delegate void vkGetImageSparseMemoryRequirementsDelegate(
        VkDevice device,
        VkImage image,
        ref uint pSparseMemoryRequirementCount,
        IntPtr pSparseMemoryRequirements
    );
    public delegate void vkGetPhysicalDeviceSparseImageFormatPropertiesDelegate(
        VkPhysicalDevice physicalDevice,
        VkFormat format,
        VkImageType type,
        VkSampleCountFlags samples,
        VkImageUsageFlags usage,
        VkImageTiling tiling,
        ref uint pPropertyCount,
        IntPtr pProperties
    );
    public delegate VkResult vkQueueBindSparseDelegate(
        VkQueue queue,
        uint bindInfoCount,
        IntPtr pBindInfo,
        VkFence fence
    );
    public delegate VkResult vkCreateFenceDelegate(
        VkDevice device,
        ref VkFenceCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkFence pFence
    );
    public delegate void vkDestroyFenceDelegate(
        VkDevice device,
        VkFence fence,
        IntPtr pAllocator
    );
    public delegate VkResult vkResetFencesDelegate(
        VkDevice device,
        uint fenceCount,
        IntPtr pFences
    );
    public delegate VkResult vkGetFenceStatusDelegate(
        VkDevice device,
        VkFence fence
    );
    public delegate VkResult vkWaitForFencesDelegate(
        VkDevice device,
        uint fenceCount,
        IntPtr pFences,
        uint waitAll,
        ulong timeout
    );
    public delegate VkResult vkCreateSemaphoreDelegate(
        VkDevice device,
        ref VkSemaphoreCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkSemaphore pSemaphore
    );
    public delegate void vkDestroySemaphoreDelegate(
        VkDevice device,
        VkSemaphore semaphore,
        IntPtr pAllocator
    );
    public delegate VkResult vkCreateEventDelegate(
        VkDevice device,
        ref VkEventCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkEvent pEvent
    );
    public delegate void vkDestroyEventDelegate(
        VkDevice device,
        VkEvent _event,
        IntPtr pAllocator
    );
    public delegate VkResult vkGetEventStatusDelegate(
        VkDevice device,
        VkEvent _event
    );
    public delegate VkResult vkSetEventDelegate(
        VkDevice device,
        VkEvent _event
    );
    public delegate VkResult vkResetEventDelegate(
        VkDevice device,
        VkEvent _event
    );
    public delegate VkResult vkCreateQueryPoolDelegate(
        VkDevice device,
        ref VkQueryPoolCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkQueryPool pQueryPool
    );
    public delegate void vkDestroyQueryPoolDelegate(
        VkDevice device,
        VkQueryPool queryPool,
        IntPtr pAllocator
    );
    public delegate VkResult vkGetQueryPoolResultsDelegate(
        VkDevice device,
        VkQueryPool queryPool,
        uint firstQuery,
        uint queryCount,
        IntPtr dataSize,
        IntPtr pData,
        ulong stride,
        VkQueryResultFlags flags
    );
    public delegate VkResult vkCreateBufferDelegate(
        VkDevice device,
        ref VkBufferCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkBuffer pBuffer
    );
    public delegate void vkDestroyBufferDelegate(
        VkDevice device,
        VkBuffer buffer,
        IntPtr pAllocator
    );
    public delegate VkResult vkCreateBufferViewDelegate(
        VkDevice device,
        ref VkBufferViewCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkBufferView pView
    );
    public delegate void vkDestroyBufferViewDelegate(
        VkDevice device,
        VkBufferView bufferView,
        IntPtr pAllocator
    );
    public delegate VkResult vkCreateImageDelegate(
        VkDevice device,
        ref VkImageCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkImage pImage
    );
    public delegate void vkDestroyImageDelegate(
        VkDevice device,
        VkImage image,
        IntPtr pAllocator
    );
    public delegate void vkGetImageSubresourceLayoutDelegate(
        VkDevice device,
        VkImage image,
        ref VkImageSubresource pSubresource,
        out VkSubresourceLayout pLayout
    );
    public delegate VkResult vkCreateImageViewDelegate(
        VkDevice device,
        ref VkImageViewCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkImageView pView
    );
    public delegate void vkDestroyImageViewDelegate(
        VkDevice device,
        VkImageView imageView,
        IntPtr pAllocator
    );
    public delegate VkResult vkCreateShaderModuleDelegate(
        VkDevice device,
        ref VkShaderModuleCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkShaderModule pShaderModule
    );
    public delegate void vkDestroyShaderModuleDelegate(
        VkDevice device,
        VkShaderModule shaderModule,
        IntPtr pAllocator
    );
    public delegate VkResult vkCreatePipelineCacheDelegate(
        VkDevice device,
        ref VkPipelineCacheCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkPipelineCache pPipelineCache
    );
    public delegate void vkDestroyPipelineCacheDelegate(
        VkDevice device,
        VkPipelineCache pipelineCache,
        IntPtr pAllocator
    );
    public delegate VkResult vkGetPipelineCacheDataDelegate(
        VkDevice device,
        VkPipelineCache pipelineCache,
        ref ulong pDataSize,
        IntPtr pData
    );
    public delegate VkResult vkMergePipelineCachesDelegate(
        VkDevice device,
        VkPipelineCache dstCache,
        uint srcCacheCount,
        IntPtr pSrcCaches
    );
    public delegate VkResult vkCreateGraphicsPipelinesDelegate(
        VkDevice device,
        VkPipelineCache pipelineCache,
        uint createInfoCount,
        IntPtr pCreateInfos,
        IntPtr pAllocator,
        IntPtr pPipelines
    );
    public delegate VkResult vkCreateComputePipelinesDelegate(
        VkDevice device,
        VkPipelineCache pipelineCache,
        uint createInfoCount,
        IntPtr pCreateInfos,
        IntPtr pAllocator,
        IntPtr pPipelines
    );
    public delegate void vkDestroyPipelineDelegate(
        VkDevice device,
        VkPipeline pipeline,
        IntPtr pAllocator
    );
    public delegate VkResult vkCreatePipelineLayoutDelegate(
        VkDevice device,
        ref VkPipelineLayoutCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkPipelineLayout pPipelineLayout
    );
    public delegate void vkDestroyPipelineLayoutDelegate(
        VkDevice device,
        VkPipelineLayout pipelineLayout,
        IntPtr pAllocator
    );
    public delegate VkResult vkCreateSamplerDelegate(
        VkDevice device,
        ref VkSamplerCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkSampler pSampler
    );
    public delegate void vkDestroySamplerDelegate(
        VkDevice device,
        VkSampler sampler,
        IntPtr pAllocator
    );
    public delegate VkResult vkCreateDescriptorSetLayoutDelegate(
        VkDevice device,
        ref VkDescriptorSetLayoutCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkDescriptorSetLayout pSetLayout
    );
    public delegate void vkDestroyDescriptorSetLayoutDelegate(
        VkDevice device,
        VkDescriptorSetLayout descriptorSetLayout,
        IntPtr pAllocator
    );
    public delegate VkResult vkCreateDescriptorPoolDelegate(
        VkDevice device,
        ref VkDescriptorPoolCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkDescriptorPool pDescriptorPool
    );
    public delegate void vkDestroyDescriptorPoolDelegate(
        VkDevice device,
        VkDescriptorPool descriptorPool,
        IntPtr pAllocator
    );
    public delegate VkResult vkResetDescriptorPoolDelegate(
        VkDevice device,
        VkDescriptorPool descriptorPool,
        VkDescriptorPoolResetFlags flags
    );
    public delegate VkResult vkAllocateDescriptorSetsDelegate(
        VkDevice device,
        ref VkDescriptorSetAllocateInfo pAllocateInfo,
        IntPtr pDescriptorSets
    );
    public delegate VkResult vkFreeDescriptorSetsDelegate(
        VkDevice device,
        VkDescriptorPool descriptorPool,
        uint descriptorSetCount,
        IntPtr pDescriptorSets
    );
    public delegate void vkUpdateDescriptorSetsDelegate(
        VkDevice device,
        uint descriptorWriteCount,
        IntPtr pDescriptorWrites,
        uint descriptorCopyCount,
        IntPtr pDescriptorCopies
    );
    public delegate VkResult vkCreateFramebufferDelegate(
        VkDevice device,
        ref VkFramebufferCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkFramebuffer pFramebuffer
    );
    public delegate void vkDestroyFramebufferDelegate(
        VkDevice device,
        VkFramebuffer framebuffer,
        IntPtr pAllocator
    );
    public delegate VkResult vkCreateRenderPassDelegate(
        VkDevice device,
        ref VkRenderPassCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkRenderPass pRenderPass
    );
    public delegate void vkDestroyRenderPassDelegate(
        VkDevice device,
        VkRenderPass renderPass,
        IntPtr pAllocator
    );
    public delegate void vkGetRenderAreaGranularityDelegate(
        VkDevice device,
        VkRenderPass renderPass,
        out VkExtent2D pGranularity
    );
    public delegate VkResult vkCreateCommandPoolDelegate(
        VkDevice device,
        ref VkCommandPoolCreateInfo pCreateInfo,
        IntPtr pAllocator,
        out VkCommandPool pCommandPool
    );
    public delegate void vkDestroyCommandPoolDelegate(
        VkDevice device,
        VkCommandPool commandPool,
        IntPtr pAllocator
    );
    public delegate VkResult vkResetCommandPoolDelegate(
        VkDevice device,
        VkCommandPool commandPool,
        VkCommandPoolResetFlags flags
    );
    public delegate VkResult vkAllocateCommandBuffersDelegate(
        VkDevice device,
        ref VkCommandBufferAllocateInfo pAllocateInfo,
        IntPtr pCommandBuffers
    );
    public delegate void vkFreeCommandBuffersDelegate(
        VkDevice device,
        VkCommandPool commandPool,
        uint commandBufferCount,
        IntPtr pCommandBuffers
    );
    public delegate VkResult vkBeginCommandBufferDelegate(
        VkCommandBuffer commandBuffer,
        ref VkCommandBufferBeginInfo pBeginInfo
    );
    public delegate VkResult vkEndCommandBufferDelegate(
        VkCommandBuffer commandBuffer
    );
    public delegate VkResult vkResetCommandBufferDelegate(
        VkCommandBuffer commandBuffer,
        VkCommandBufferResetFlags flags
    );
    public delegate void vkCmdBindPipelineDelegate(
        VkCommandBuffer commandBuffer,
        VkPipelineBindPoint pipelineBindPoint,
        VkPipeline pipeline
    );
    public delegate void vkCmdSetViewportDelegate(
        VkCommandBuffer commandBuffer,
        uint firstViewport,
        uint viewportCount,
        IntPtr pViewports
    );
    public delegate void vkCmdSetScissorDelegate(
        VkCommandBuffer commandBuffer,
        uint firstScissor,
        uint scissorCount,
        IntPtr pScissors
    );
    public delegate void vkCmdSetLineWidthDelegate(
        VkCommandBuffer commandBuffer,
        float lineWidth
    );
    public delegate void vkCmdSetDepthBiasDelegate(
        VkCommandBuffer commandBuffer,
        float depthBiasConstantFactor,
        float depthBiasClamp,
        float depthBiasSlopeFactor
    );
    public delegate void vkCmdSetBlendConstantsDelegate(
        VkCommandBuffer commandBuffer,
        IntPtr blendConstants
    );
    public delegate void vkCmdSetDepthBoundsDelegate(
        VkCommandBuffer commandBuffer,
        float minDepthBounds,
        float maxDepthBounds
    );
    public delegate void vkCmdSetStencilCompareMaskDelegate(
        VkCommandBuffer commandBuffer,
        VkStencilFaceFlags faceMask,
        uint compareMask
    );
    public delegate void vkCmdSetStencilWriteMaskDelegate(
        VkCommandBuffer commandBuffer,
        VkStencilFaceFlags faceMask,
        uint writeMask
    );
    public delegate void vkCmdSetStencilReferenceDelegate(
        VkCommandBuffer commandBuffer,
        VkStencilFaceFlags faceMask,
        uint reference
    );
    public delegate void vkCmdBindDescriptorSetsDelegate(
        VkCommandBuffer commandBuffer,
        VkPipelineBindPoint pipelineBindPoint,
        VkPipelineLayout layout,
        uint firstSet,
        uint descriptorSetCount,
        IntPtr pDescriptorSets,
        uint dynamicOffsetCount,
        IntPtr pDynamicOffsets
    );
    public delegate void vkCmdBindIndexBufferDelegate(
        VkCommandBuffer commandBuffer,
        VkBuffer buffer,
        ulong offset,
        VkIndexType indexType
    );
    public delegate void vkCmdBindVertexBuffersDelegate(
        VkCommandBuffer commandBuffer,
        uint firstBinding,
        uint bindingCount,
        IntPtr pBuffers,
        ref ulong pOffsets
    );
    public delegate void vkCmdDrawDelegate(
        VkCommandBuffer commandBuffer,
        uint vertexCount,
        uint instanceCount,
        uint firstVertex,
        uint firstInstance
    );
    public delegate void vkCmdDrawIndexedDelegate(
        VkCommandBuffer commandBuffer,
        uint indexCount,
        uint instanceCount,
        uint firstIndex,
        int vertexOffset,
        uint firstInstance
    );
    public delegate void vkCmdDrawIndirectDelegate(
        VkCommandBuffer commandBuffer,
        VkBuffer buffer,
        ulong offset,
        uint drawCount,
        uint stride
    );
    public delegate void vkCmdDrawIndexedIndirectDelegate(
        VkCommandBuffer commandBuffer,
        VkBuffer buffer,
        ulong offset,
        uint drawCount,
        uint stride
    );
    public delegate void vkCmdDispatchDelegate(
        VkCommandBuffer commandBuffer,
        uint groupCountX,
        uint groupCountY,
        uint groupCountZ
    );
    public delegate void vkCmdDispatchIndirectDelegate(
        VkCommandBuffer commandBuffer,
        VkBuffer buffer,
        ulong offset
    );
    public delegate void vkCmdCopyBufferDelegate(
        VkCommandBuffer commandBuffer,
        VkBuffer srcBuffer,
        VkBuffer dstBuffer,
        uint regionCount,
        IntPtr pRegions
    );
    public delegate void vkCmdCopyImageDelegate(
        VkCommandBuffer commandBuffer,
        VkImage srcImage,
        VkImageLayout srcImageLayout,
        VkImage dstImage,
        VkImageLayout dstImageLayout,
        uint regionCount,
        IntPtr pRegions
    );
    public delegate void vkCmdBlitImageDelegate(
        VkCommandBuffer commandBuffer,
        VkImage srcImage,
        VkImageLayout srcImageLayout,
        VkImage dstImage,
        VkImageLayout dstImageLayout,
        uint regionCount,
        IntPtr pRegions,
        VkFilter filter
    );
    public delegate void vkCmdCopyBufferToImageDelegate(
        VkCommandBuffer commandBuffer,
        VkBuffer srcBuffer,
        VkImage dstImage,
        VkImageLayout dstImageLayout,
        uint regionCount,
        IntPtr pRegions
    );
    public delegate void vkCmdCopyImageToBufferDelegate(
        VkCommandBuffer commandBuffer,
        VkImage srcImage,
        VkImageLayout srcImageLayout,
        VkBuffer dstBuffer,
        uint regionCount,
        IntPtr pRegions
    );
    public delegate void vkCmdUpdateBufferDelegate(
        VkCommandBuffer commandBuffer,
        VkBuffer dstBuffer,
        ulong dstOffset,
        ulong dataSize,
        IntPtr pData
    );
    public delegate void vkCmdFillBufferDelegate(
        VkCommandBuffer commandBuffer,
        VkBuffer dstBuffer,
        ulong dstOffset,
        ulong size,
        uint data
    );
    public delegate void vkCmdClearColorImageDelegate(
        VkCommandBuffer commandBuffer,
        VkImage image,
        VkImageLayout imageLayout,
        ref VkClearColorValue pColor,
        uint rangeCount,
        IntPtr pRanges
    );
    public delegate void vkCmdClearDepthStencilImageDelegate(
        VkCommandBuffer commandBuffer,
        VkImage image,
        VkImageLayout imageLayout,
        ref VkClearDepthStencilValue pDepthStencil,
        uint rangeCount,
        IntPtr pRanges
    );
    public delegate void vkCmdClearAttachmentsDelegate(
        VkCommandBuffer commandBuffer,
        uint attachmentCount,
        IntPtr pAttachments,
        uint rectCount,
        IntPtr pRects
    );
    public delegate void vkCmdResolveImageDelegate(
        VkCommandBuffer commandBuffer,
        VkImage srcImage,
        VkImageLayout srcImageLayout,
        VkImage dstImage,
        VkImageLayout dstImageLayout,
        uint regionCount,
        IntPtr pRegions
    );
    public delegate void vkCmdSetEventDelegate(
        VkCommandBuffer commandBuffer,
        VkEvent _event,
        VkPipelineStageFlags stageMask
    );
    public delegate void vkCmdResetEventDelegate(
        VkCommandBuffer commandBuffer,
        VkEvent _event,
        VkPipelineStageFlags stageMask
    );
    public delegate void vkCmdWaitEventsDelegate(
        VkCommandBuffer commandBuffer,
        uint eventCount,
        IntPtr pEvents,
        VkPipelineStageFlags srcStageMask,
        VkPipelineStageFlags dstStageMask,
        uint memoryBarrierCount,
        IntPtr pMemoryBarriers,
        uint bufferMemoryBarrierCount,
        IntPtr pBufferMemoryBarriers,
        uint imageMemoryBarrierCount,
        IntPtr pImageMemoryBarriers
    );
    public delegate void vkCmdPipelineBarrierDelegate(
        VkCommandBuffer commandBuffer,
        VkPipelineStageFlags srcStageMask,
        VkPipelineStageFlags dstStageMask,
        VkDependencyFlags dependencyFlags,
        uint memoryBarrierCount,
        IntPtr pMemoryBarriers,
        uint bufferMemoryBarrierCount,
        IntPtr pBufferMemoryBarriers,
        uint imageMemoryBarrierCount,
        IntPtr pImageMemoryBarriers
    );
    public delegate void vkCmdBeginQueryDelegate(
        VkCommandBuffer commandBuffer,
        VkQueryPool queryPool,
        uint query,
        VkQueryControlFlags flags
    );
    public delegate void vkCmdEndQueryDelegate(
        VkCommandBuffer commandBuffer,
        VkQueryPool queryPool,
        uint query
    );
    public delegate void vkCmdResetQueryPoolDelegate(
        VkCommandBuffer commandBuffer,
        VkQueryPool queryPool,
        uint firstQuery,
        uint queryCount
    );
    public delegate void vkCmdWriteTimestampDelegate(
        VkCommandBuffer commandBuffer,
        VkPipelineStageFlags pipelineStage,
        VkQueryPool queryPool,
        uint query
    );
    public delegate void vkCmdCopyQueryPoolResultsDelegate(
        VkCommandBuffer commandBuffer,
        VkQueryPool queryPool,
        uint firstQuery,
        uint queryCount,
        VkBuffer dstBuffer,
        ulong dstOffset,
        ulong stride,
        VkQueryResultFlags flags
    );
    public delegate void vkCmdPushConstantsDelegate(
        VkCommandBuffer commandBuffer,
        VkPipelineLayout layout,
        VkShaderStageFlags stageFlags,
        uint offset,
        uint size,
        IntPtr pValues
    );
    public delegate void vkCmdBeginRenderPassDelegate(
        VkCommandBuffer commandBuffer,
        ref VkRenderPassBeginInfo pRenderPassBegin,
        VkSubpassContents contents
    );
    public delegate void vkCmdNextSubpassDelegate(
        VkCommandBuffer commandBuffer,
        VkSubpassContents contents
    );
    public delegate void vkCmdEndRenderPassDelegate(
        VkCommandBuffer commandBuffer
    );
    public delegate void vkCmdExecuteCommandsDelegate(
        VkCommandBuffer commandBuffer,
        uint commandBufferCount,
        IntPtr pCommandBuffers
    );
    public delegate void vkDestroySurfaceKHRDelegate(
        VkInstance instance,
        VkSurfaceKHR surface,
        IntPtr pAllocator
    );
    public delegate VkResult vkGetPhysicalDeviceSurfaceSupportKHRDelegate(
        VkPhysicalDevice physicalDevice,
        uint queueFamilyIndex,
        VkSurfaceKHR surface,
        out bool pSupported
    );
    public delegate VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHRDelegate(
        VkPhysicalDevice physicalDevice,
        VkSurfaceKHR surface,
        IntPtr pSurfaceCapabilities
    );
    public delegate VkResult vkGetPhysicalDeviceSurfaceFormatsKHRDelegate(
        VkPhysicalDevice physicalDevice,
        VkSurfaceKHR surface,
        ref uint pSurfaceFormatCount,
        IntPtr pSurfaceFormats
    );
    public delegate VkResult vkGetPhysicalDeviceSurfacePresentModesKHRDelegate(
        VkPhysicalDevice physicalDevice,
        VkSurfaceKHR surface,
        ref uint pPresentModeCount,
        IntPtr pPresentModes
    );
    public delegate VkResult vkCreateSwapchainKHRDelegate(
        VkDevice device,
        ref VkSwapchainCreateInfoKHR pCreateInfo,
        IntPtr pAllocator,
        out VkSwapchainKHR pSwapchain
    );
    public delegate void vkDestroySwapchainKHRDelegate(
        VkDevice device,
        VkSwapchainKHR swapchain,
        IntPtr pAllocator
    );
    public delegate VkResult vkGetSwapchainImagesKHRDelegate(
        VkDevice device,
        VkSwapchainKHR swapchain,
        ref uint pSwapchainImageCount,
        IntPtr pSwapchainImages
    );
    public delegate VkResult vkAcquireNextImageKHRDelegate(
        VkDevice device,
        VkSwapchainKHR swapchain,
        ulong timeout,
        VkSemaphore semaphore,
        VkFence fence,
        out uint pImageIndex
    );
    public delegate VkResult vkQueuePresentKHRDelegate(
        VkQueue queue,
        ref VkPresentInfoKHR pPresentInfo
    );
    public delegate VkResult vkCreateDebugReportCallbackEXTDelegate(
        VkInstance instance,
        ref VkDebugReportCallbackCreateInfoEXT pCreateInfo,
        IntPtr pAllocator,
        out VkDebugReportCallbackEXT pCallback
    );
    public delegate void vkDestroyDebugReportCallbackEXTDelegate(
        VkInstance instance,
        VkDebugReportCallbackEXT callback,
        IntPtr pAllocator
    );
    public delegate void vkDebugReportMessageEXTDelegate(
        VkInstance instance,
        VkDebugReportFlagsEXT flags,
        VkDebugReportObjectTypeEXT objectType,
        ulong _object,
        IntPtr location,
        int messageCode,
        IntPtr pLayerPrefix,
        IntPtr pMessage
    );
}
