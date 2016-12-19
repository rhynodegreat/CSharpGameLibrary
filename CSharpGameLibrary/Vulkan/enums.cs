//autogenerated on 12/19/2016 5:09:19 PM
using System;

namespace CSGL.Vulkan {
    [Flags]
    public enum VkFramebufferCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkQueryPoolCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkRenderPassCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkSamplerCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineLayoutCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineCacheCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineDepthStencilStateCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineDynamicStateCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineColorBlendStateCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineMultisampleStateCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineRasterizationStateCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineViewportStateCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineTessellationStateCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineInputAssemblyStateCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineVertexInputStateCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineShaderStageCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkDescriptorSetLayoutCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkBufferViewCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkInstanceCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkDeviceCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkDeviceQueueCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkQueueFlags : uint {
        None = 0,
        GraphicsBit = 1,
        ComputeBit = 2,
        TransferBit = 4,
        SparseBindingBit = 8,
    }

    [Flags]
    public enum VkMemoryPropertyFlags : uint {
        None = 0,
        DeviceLocalBit = 1,
        HostVisibleBit = 2,
        HostCoherentBit = 4,
        HostCachedBit = 8,
        LazilyAllocatedBit = 16,
    }

    [Flags]
    public enum VkMemoryHeapFlags : uint {
        None = 0,
        DeviceLocalBit = 1,
    }

    [Flags]
    public enum VkAccessFlags : uint {
        None = 0,
        IndirectCommandReadBit = 1,
        IndexReadBit = 2,
        VertexAttributeReadBit = 4,
        UniformReadBit = 8,
        InputAttachmentReadBit = 16,
        ShaderReadBit = 32,
        ShaderWriteBit = 64,
        ColorAttachmentReadBit = 128,
        ColorAttachmentWriteBit = 256,
        DepthStencilAttachmentReadBit = 512,
        DepthStencilAttachmentWriteBit = 1024,
        TransferReadBit = 2048,
        TransferWriteBit = 4096,
        HostReadBit = 8192,
        HostWriteBit = 16384,
        MemoryReadBit = 32768,
        MemoryWriteBit = 65536,
    }

    [Flags]
    public enum VkBufferUsageFlags : uint {
        None = 0,
        TransferSrcBit = 1,
        TransferDstBit = 2,
        UniformTexelBufferBit = 4,
        StorageTexelBufferBit = 8,
        UniformBufferBit = 16,
        StorageBufferBit = 32,
        IndexBufferBit = 64,
        VertexBufferBit = 128,
        IndirectBufferBit = 256,
    }

    [Flags]
    public enum VkBufferCreateFlags : uint {
        None = 0,
        SparseBindingBit = 1,
        SparseResidencyBit = 2,
        SparseAliasedBit = 4,
    }

    [Flags]
    public enum VkShaderStageFlags : uint {
        None = 0,
        VertexBit = 1,
        TessellationControlBit = 2,
        TessellationEvaluationBit = 4,
        GeometryBit = 8,
        FragmentBit = 16,
        ComputeBit = 32,
        AllGraphics = 0x0000001F,
        All = 0x7FFFFFFF,
    }

    [Flags]
    public enum VkImageUsageFlags : uint {
        None = 0,
        TransferSrcBit = 1,
        TransferDstBit = 2,
        SampledBit = 4,
        StorageBit = 8,
        ColorAttachmentBit = 16,
        DepthStencilAttachmentBit = 32,
        TransientAttachmentBit = 64,
        InputAttachmentBit = 128,
    }

    [Flags]
    public enum VkImageCreateFlags : uint {
        None = 0,
        SparseBindingBit = 1,
        SparseResidencyBit = 2,
        SparseAliasedBit = 4,
        MutableFormatBit = 8,
        CubeCompatibleBit = 16,
    }

    [Flags]
    public enum VkImageViewCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineCreateFlags : uint {
        None = 0,
        DisableOptimizationBit = 1,
        AllowDerivativesBit = 2,
        DerivativeBit = 4,
    }

    [Flags]
    public enum VkColorComponentFlags : uint {
        None = 0,
        RBit = 1,
        GBit = 2,
        BBit = 4,
        ABit = 8,
    }

    [Flags]
    public enum VkFenceCreateFlags : uint {
        None = 0,
        SignaledBit = 1,
    }

    [Flags]
    public enum VkSemaphoreCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkFormatFeatureFlags : uint {
        None = 0,
        SampledImageBit = 1,
        StorageImageBit = 2,
        StorageImageAtomicBit = 4,
        UniformTexelBufferBit = 8,
        StorageTexelBufferBit = 16,
        StorageTexelBufferAtomicBit = 32,
        VertexBufferBit = 64,
        ColorAttachmentBit = 128,
        ColorAttachmentBlendBit = 256,
        DepthStencilAttachmentBit = 512,
        BlitSrcBit = 1024,
        BlitDstBit = 2048,
        SampledImageFilterLinearBit = 4096,
    }

    [Flags]
    public enum VkQueryControlFlags : uint {
        None = 0,
        PreciseBit = 1,
    }

    [Flags]
    public enum VkQueryResultFlags : uint {
        None = 0,
        _64Bit = 1,
        WaitBit = 2,
        WithAvailabilityBit = 4,
        PartialBit = 8,
    }

    [Flags]
    public enum VkShaderModuleCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkEventCreateFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkCommandPoolCreateFlags : uint {
        None = 0,
        TransientBit = 1,
        ResetCommandBufferBit = 2,
    }

    [Flags]
    public enum VkCommandPoolResetFlags : uint {
        None = 0,
        ReleaseResourcesBit = 1,
    }

    [Flags]
    public enum VkCommandBufferResetFlags : uint {
        None = 0,
        ReleaseResourcesBit = 1,
    }

    [Flags]
    public enum VkCommandBufferUsageFlags : uint {
        None = 0,
        OneTimeSubmitBit = 1,
        RenderPassContinueBit = 2,
        SimultaneousUseBit = 4,
    }

    [Flags]
    public enum VkQueryPipelineStatisticFlags : uint {
        None = 0,
        InputAssemblyVerticesBit = 1,
        InputAssemblyPrimitivesBit = 2,
        VertexShaderInvocationsBit = 4,
        GeometryShaderInvocationsBit = 8,
        GeometryShaderPrimitivesBit = 16,
        ClippingInvocationsBit = 32,
        ClippingPrimitivesBit = 64,
        FragmentShaderInvocationsBit = 128,
        TessellationControlShaderPatchesBit = 256,
        TessellationEvaluationShaderInvocationsBit = 512,
        ComputeShaderInvocationsBit = 1024,
    }

    [Flags]
    public enum VkMemoryMapFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkImageAspectFlags : uint {
        None = 0,
        ColorBit = 1,
        DepthBit = 2,
        StencilBit = 4,
        MetadataBit = 8,
    }

    [Flags]
    public enum VkSparseMemoryBindFlags : uint {
        None = 0,
        MetadataBit = 1,
    }

    [Flags]
    public enum VkSparseImageFormatFlags : uint {
        None = 0,
        SingleMiptailBit = 1,
        AlignedMipSizeBit = 2,
        NonstandardBlockSizeBit = 4,
    }

    [Flags]
    public enum VkSubpassDescriptionFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkPipelineStageFlags : uint {
        None = 0,
        TopOfPipeBit = 1,
        DrawIndirectBit = 2,
        VertexInputBit = 4,
        VertexShaderBit = 8,
        TessellationControlShaderBit = 16,
        TessellationEvaluationShaderBit = 32,
        GeometryShaderBit = 64,
        FragmentShaderBit = 128,
        EarlyFragmentTestsBit = 256,
        LateFragmentTestsBit = 512,
        ColorAttachmentOutputBit = 1024,
        ComputeShaderBit = 2048,
        TransferBit = 4096,
        BottomOfPipeBit = 8192,
        HostBit = 16384,
        AllGraphicsBit = 32768,
        AllCommandsBit = 65536,
    }

    [Flags]
    public enum VkSampleCountFlags : uint {
        None = 0,
        _1Bit = 1,
        _2Bit = 2,
        _4Bit = 4,
        _8Bit = 8,
        _16Bit = 16,
        _32Bit = 32,
        _64Bit = 64,
    }

    [Flags]
    public enum VkAttachmentDescriptionFlags : uint {
        None = 0,
        MayAliasBit = 1,
    }

    [Flags]
    public enum VkStencilFaceFlags : uint {
        None = 0,
        FrontBit = 1,
        BackBit = 2,
        FrontAndBack = 0x00000003,
    }

    [Flags]
    public enum VkCullModeFlags : uint {
        None = 0,
        FrontBit = 1,
        BackBit = 2,
        FrontAndBack = 0x00000003,
    }

    [Flags]
    public enum VkDescriptorPoolCreateFlags : uint {
        None = 0,
        FreeDescriptorSetBit = 1,
    }

    [Flags]
    public enum VkDescriptorPoolResetFlags : uint {
        None = 0,
    }

    [Flags]
    public enum VkDependencyFlags : uint {
        None = 0,
        ByRegionBit = 1,
    }

    [Flags]
    public enum VkCompositeAlphaFlagsKHR : uint {
        None = 0,
        OpaqueBitKhr = 1,
        PreMultipliedBitKhr = 2,
        PostMultipliedBitKhr = 4,
        InheritBitKhr = 8,
    }

    [Flags]
    public enum VkDisplayPlaneAlphaFlagsKHR : uint {
        None = 0,
        OpaqueBitKhr = 1,
        GlobalBitKhr = 2,
        PerPixelBitKhr = 4,
        PerPixelPremultipliedBitKhr = 8,
    }

    [Flags]
    public enum VkSurfaceTransformFlagsKHR : uint {
        None = 0,
        IdentityBitKhr = 1,
        Rotate_90BitKhr = 2,
        Rotate_180BitKhr = 4,
        Rotate_270BitKhr = 8,
        HorizontalMirrorBitKhr = 16,
        HorizontalMirrorRotate_90BitKhr = 32,
        HorizontalMirrorRotate_180BitKhr = 64,
        HorizontalMirrorRotate_270BitKhr = 128,
        InheritBitKhr = 256,
    }

    [Flags]
    public enum VkSwapchainCreateFlagsKHR : uint {
        None = 0,
    }

    [Flags]
    public enum VkDisplayModeCreateFlagsKHR : uint {
        None = 0,
    }

    [Flags]
    public enum VkDisplaySurfaceCreateFlagsKHR : uint {
        None = 0,
    }

    [Flags]
    public enum VkAndroidSurfaceCreateFlagsKHR : uint {
        None = 0,
    }

    [Flags]
    public enum VkMirSurfaceCreateFlagsKHR : uint {
        None = 0,
    }

    [Flags]
    public enum VkWaylandSurfaceCreateFlagsKHR : uint {
        None = 0,
    }

    [Flags]
    public enum VkWin32SurfaceCreateFlagsKHR : uint {
        None = 0,
    }

    [Flags]
    public enum VkXlibSurfaceCreateFlagsKHR : uint {
        None = 0,
    }

    [Flags]
    public enum VkXcbSurfaceCreateFlagsKHR : uint {
        None = 0,
    }

    [Flags]
    public enum VkDebugReportFlagsEXT : uint {
        None = 0,
        InformationBitExt = 1,
        WarningBitExt = 2,
        PerformanceWarningBitExt = 4,
        ErrorBitExt = 8,
        DebugBitExt = 16,
    }

    public enum VkAttachmentLoadOp {
        Load = 0,
        Clear = 1,
        DontCare = 2,
    }

    public enum VkAttachmentStoreOp {
        Store = 0,
        DontCare = 1,
    }

    public enum VkBlendFactor {
        Zero = 0,
        One = 1,
        SrcColor = 2,
        OneMinusSrcColor = 3,
        DstColor = 4,
        OneMinusDstColor = 5,
        SrcAlpha = 6,
        OneMinusSrcAlpha = 7,
        DstAlpha = 8,
        OneMinusDstAlpha = 9,
        ConstantColor = 10,
        OneMinusConstantColor = 11,
        ConstantAlpha = 12,
        OneMinusConstantAlpha = 13,
        SrcAlphaSaturate = 14,
        Src1Color = 15,
        OneMinusSrc1Color = 16,
        Src1Alpha = 17,
        OneMinusSrc1Alpha = 18,
    }

    public enum VkBlendOp {
        Add = 0,
        Subtract = 1,
        ReverseSubtract = 2,
        Min = 3,
        Max = 4,
    }

    public enum VkBorderColor {
        FloatTransparentBlack = 0,
        IntTransparentBlack = 1,
        FloatOpaqueBlack = 2,
        IntOpaqueBlack = 3,
        FloatOpaqueWhite = 4,
        IntOpaqueWhite = 5,
    }

    public enum VkPipelineCacheHeaderVersion {
        One = 1,
    }

    public enum VkComponentSwizzle {
        Identity = 0,
        Zero = 1,
        One = 2,
        R = 3,
        G = 4,
        B = 5,
        A = 6,
    }

    public enum VkCommandBufferLevel {
        Primary = 0,
        Secondary = 1,
    }

    public enum VkCompareOp {
        Never = 0,
        Less = 1,
        Equal = 2,
        LessOrEqual = 3,
        Greater = 4,
        NotEqual = 5,
        GreaterOrEqual = 6,
        Always = 7,
    }

    public enum VkDescriptorType {
        Sampler = 0,
        CombinedImageSampler = 1,
        SampledImage = 2,
        StorageImage = 3,
        UniformTexelBuffer = 4,
        StorageTexelBuffer = 5,
        UniformBuffer = 6,
        StorageBuffer = 7,
        UniformBufferDynamic = 8,
        StorageBufferDynamic = 9,
        InputAttachment = 10,
    }

    public enum VkDynamicState {
        Viewport = 0,
        Scissor = 1,
        LineWidth = 2,
        DepthBias = 3,
        BlendConstants = 4,
        DepthBounds = 5,
        StencilCompareMask = 6,
        StencilWriteMask = 7,
        StencilReference = 8,
    }

    public enum VkPolygonMode {
        Fill = 0,
        Line = 1,
        Point = 2,
    }

    public enum VkFormat {
        Undefined = 0,
        R4g4UnormPack8 = 1,
        R4g4b4a4UnormPack16 = 2,
        B4g4r4a4UnormPack16 = 3,
        R5g6b5UnormPack16 = 4,
        B5g6r5UnormPack16 = 5,
        R5g5b5a1UnormPack16 = 6,
        B5g5r5a1UnormPack16 = 7,
        A1r5g5b5UnormPack16 = 8,
        R8Unorm = 9,
        R8Snorm = 10,
        R8Uscaled = 11,
        R8Sscaled = 12,
        R8Uint = 13,
        R8Sint = 14,
        R8Srgb = 15,
        R8g8Unorm = 16,
        R8g8Snorm = 17,
        R8g8Uscaled = 18,
        R8g8Sscaled = 19,
        R8g8Uint = 20,
        R8g8Sint = 21,
        R8g8Srgb = 22,
        R8g8b8Unorm = 23,
        R8g8b8Snorm = 24,
        R8g8b8Uscaled = 25,
        R8g8b8Sscaled = 26,
        R8g8b8Uint = 27,
        R8g8b8Sint = 28,
        R8g8b8Srgb = 29,
        B8g8r8Unorm = 30,
        B8g8r8Snorm = 31,
        B8g8r8Uscaled = 32,
        B8g8r8Sscaled = 33,
        B8g8r8Uint = 34,
        B8g8r8Sint = 35,
        B8g8r8Srgb = 36,
        R8g8b8a8Unorm = 37,
        R8g8b8a8Snorm = 38,
        R8g8b8a8Uscaled = 39,
        R8g8b8a8Sscaled = 40,
        R8g8b8a8Uint = 41,
        R8g8b8a8Sint = 42,
        R8g8b8a8Srgb = 43,
        B8g8r8a8Unorm = 44,
        B8g8r8a8Snorm = 45,
        B8g8r8a8Uscaled = 46,
        B8g8r8a8Sscaled = 47,
        B8g8r8a8Uint = 48,
        B8g8r8a8Sint = 49,
        B8g8r8a8Srgb = 50,
        A8b8g8r8UnormPack32 = 51,
        A8b8g8r8SnormPack32 = 52,
        A8b8g8r8UscaledPack32 = 53,
        A8b8g8r8SscaledPack32 = 54,
        A8b8g8r8UintPack32 = 55,
        A8b8g8r8SintPack32 = 56,
        A8b8g8r8SrgbPack32 = 57,
        A2r10g10b10UnormPack32 = 58,
        A2r10g10b10SnormPack32 = 59,
        A2r10g10b10UscaledPack32 = 60,
        A2r10g10b10SscaledPack32 = 61,
        A2r10g10b10UintPack32 = 62,
        A2r10g10b10SintPack32 = 63,
        A2b10g10r10UnormPack32 = 64,
        A2b10g10r10SnormPack32 = 65,
        A2b10g10r10UscaledPack32 = 66,
        A2b10g10r10SscaledPack32 = 67,
        A2b10g10r10UintPack32 = 68,
        A2b10g10r10SintPack32 = 69,
        R16Unorm = 70,
        R16Snorm = 71,
        R16Uscaled = 72,
        R16Sscaled = 73,
        R16Uint = 74,
        R16Sint = 75,
        R16Sfloat = 76,
        R16g16Unorm = 77,
        R16g16Snorm = 78,
        R16g16Uscaled = 79,
        R16g16Sscaled = 80,
        R16g16Uint = 81,
        R16g16Sint = 82,
        R16g16Sfloat = 83,
        R16g16b16Unorm = 84,
        R16g16b16Snorm = 85,
        R16g16b16Uscaled = 86,
        R16g16b16Sscaled = 87,
        R16g16b16Uint = 88,
        R16g16b16Sint = 89,
        R16g16b16Sfloat = 90,
        R16g16b16a16Unorm = 91,
        R16g16b16a16Snorm = 92,
        R16g16b16a16Uscaled = 93,
        R16g16b16a16Sscaled = 94,
        R16g16b16a16Uint = 95,
        R16g16b16a16Sint = 96,
        R16g16b16a16Sfloat = 97,
        R32Uint = 98,
        R32Sint = 99,
        R32Sfloat = 100,
        R32g32Uint = 101,
        R32g32Sint = 102,
        R32g32Sfloat = 103,
        R32g32b32Uint = 104,
        R32g32b32Sint = 105,
        R32g32b32Sfloat = 106,
        R32g32b32a32Uint = 107,
        R32g32b32a32Sint = 108,
        R32g32b32a32Sfloat = 109,
        R64Uint = 110,
        R64Sint = 111,
        R64Sfloat = 112,
        R64g64Uint = 113,
        R64g64Sint = 114,
        R64g64Sfloat = 115,
        R64g64b64Uint = 116,
        R64g64b64Sint = 117,
        R64g64b64Sfloat = 118,
        R64g64b64a64Uint = 119,
        R64g64b64a64Sint = 120,
        R64g64b64a64Sfloat = 121,
        B10g11r11UfloatPack32 = 122,
        E5b9g9r9UfloatPack32 = 123,
        D16Unorm = 124,
        X8D24UnormPack32 = 125,
        D32Sfloat = 126,
        S8Uint = 127,
        D16UnormS8Uint = 128,
        D24UnormS8Uint = 129,
        D32SfloatS8Uint = 130,
        Bc1RgbUnormBlock = 131,
        Bc1RgbSrgbBlock = 132,
        Bc1RgbaUnormBlock = 133,
        Bc1RgbaSrgbBlock = 134,
        Bc2UnormBlock = 135,
        Bc2SrgbBlock = 136,
        Bc3UnormBlock = 137,
        Bc3SrgbBlock = 138,
        Bc4UnormBlock = 139,
        Bc4SnormBlock = 140,
        Bc5UnormBlock = 141,
        Bc5SnormBlock = 142,
        Bc6hUfloatBlock = 143,
        Bc6hSfloatBlock = 144,
        Bc7UnormBlock = 145,
        Bc7SrgbBlock = 146,
        Etc2R8g8b8UnormBlock = 147,
        Etc2R8g8b8SrgbBlock = 148,
        Etc2R8g8b8a1UnormBlock = 149,
        Etc2R8g8b8a1SrgbBlock = 150,
        Etc2R8g8b8a8UnormBlock = 151,
        Etc2R8g8b8a8SrgbBlock = 152,
        EacR11UnormBlock = 153,
        EacR11SnormBlock = 154,
        EacR11g11UnormBlock = 155,
        EacR11g11SnormBlock = 156,
        Astc_4x4UnormBlock = 157,
        Astc_4x4SrgbBlock = 158,
        Astc_5x4UnormBlock = 159,
        Astc_5x4SrgbBlock = 160,
        Astc_5x5UnormBlock = 161,
        Astc_5x5SrgbBlock = 162,
        Astc_6x5UnormBlock = 163,
        Astc_6x5SrgbBlock = 164,
        Astc_6x6UnormBlock = 165,
        Astc_6x6SrgbBlock = 166,
        Astc_8x5UnormBlock = 167,
        Astc_8x5SrgbBlock = 168,
        Astc_8x6UnormBlock = 169,
        Astc_8x6SrgbBlock = 170,
        Astc_8x8UnormBlock = 171,
        Astc_8x8SrgbBlock = 172,
        Astc_10x5UnormBlock = 173,
        Astc_10x5SrgbBlock = 174,
        Astc_10x6UnormBlock = 175,
        Astc_10x6SrgbBlock = 176,
        Astc_10x8UnormBlock = 177,
        Astc_10x8SrgbBlock = 178,
        Astc_10x10UnormBlock = 179,
        Astc_10x10SrgbBlock = 180,
        Astc_12x10UnormBlock = 181,
        Astc_12x10SrgbBlock = 182,
        Astc_12x12UnormBlock = 183,
        Astc_12x12SrgbBlock = 184,
    }

    public enum VkFrontFace {
        CounterClockwise = 0,
        Clockwise = 1,
    }

    public enum VkImageLayout {
        Undefined = 0,
        General = 1,
        ColorAttachmentOptimal = 2,
        DepthStencilAttachmentOptimal = 3,
        DepthStencilReadOnlyOptimal = 4,
        ShaderReadOnlyOptimal = 5,
        TransferSrcOptimal = 6,
        TransferDstOptimal = 7,
        Preinitialized = 8,
        PresentSrcKhr = 1000001002,
    }

    public enum VkImageTiling {
        Optimal = 0,
        Linear = 1,
    }

    public enum VkImageType {
        _1d = 0,
        _2d = 1,
        _3d = 2,
    }

    public enum VkImageViewType {
        _1d = 0,
        _2d = 1,
        _3d = 2,
        Cube = 3,
        _1dArray = 4,
        _2dArray = 5,
        CubeArray = 6,
    }

    public enum VkSharingMode {
        Exclusive = 0,
        Concurrent = 1,
    }

    public enum VkIndexType {
        Uint16 = 0,
        Uint32 = 1,
    }

    public enum VkLogicOp {
        Clear = 0,
        And = 1,
        AndReverse = 2,
        Copy = 3,
        AndInverted = 4,
        NoOp = 5,
        Xor = 6,
        Or = 7,
        Nor = 8,
        Equivalent = 9,
        Invert = 10,
        OrReverse = 11,
        CopyInverted = 12,
        OrInverted = 13,
        Nand = 14,
        Set = 15,
    }

    public enum VkPhysicalDeviceType {
        Other = 0,
        IntegratedGpu = 1,
        DiscreteGpu = 2,
        VirtualGpu = 3,
        Cpu = 4,
    }

    public enum VkPipelineBindPoint {
        Graphics = 0,
        Compute = 1,
    }

    public enum VkPrimitiveTopology {
        PointList = 0,
        LineList = 1,
        LineStrip = 2,
        TriangleList = 3,
        TriangleStrip = 4,
        TriangleFan = 5,
        LineListWithAdjacency = 6,
        LineStripWithAdjacency = 7,
        TriangleListWithAdjacency = 8,
        TriangleStripWithAdjacency = 9,
        PatchList = 10,
    }

    public enum VkQueryType {
        Occlusion = 0,
        PipelineStatistics = 1,
        Timestamp = 2,
    }

    public enum VkSubpassContents {
        Inline = 0,
        SecondaryCommandBuffers = 1,
    }

    public enum VkResult {
        Success = 0,
        NotReady = 1,
        Timeout = 2,
        EventSet = 3,
        EventReset = 4,
        Incomplete = 5,
        ErrorOutOfHostMemory = -1,
        ErrorOutOfDeviceMemory = -2,
        ErrorInitializationFailed = -3,
        ErrorDeviceLost = -4,
        ErrorMemoryMapFailed = -5,
        ErrorLayerNotPresent = -6,
        ErrorExtensionNotPresent = -7,
        ErrorFeatureNotPresent = -8,
        ErrorIncompatibleDriver = -9,
        ErrorTooManyObjects = -10,
        ErrorFormatNotSupported = -11,
        ErrorFragmentedPool = -12,
        ErrorSurfaceLostKhr = -1000000000,
        ErrorNativeWindowInUseKhr = -1000000001,
        SuboptimalKhr = 1000001003,
        ErrorOutOfDateKhr = -1000001004,
        ErrorIncompatibleDisplayKhr = -1000003001,
        ErrorValidationFailedExt = -1000011001,
    }

    public enum VkStencilOp {
        Keep = 0,
        Zero = 1,
        Replace = 2,
        IncrementAndClamp = 3,
        DecrementAndClamp = 4,
        Invert = 5,
        IncrementAndWrap = 6,
        DecrementAndWrap = 7,
    }

    public enum VkStructureType {
        ApplicationInfo = 0,
        InstanceCreateInfo = 1,
        DeviceQueueCreateInfo = 2,
        DeviceCreateInfo = 3,
        SubmitInfo = 4,
        MemoryAllocateInfo = 5,
        MappedMemoryRange = 6,
        BindSparseInfo = 7,
        FenceCreateInfo = 8,
        SemaphoreCreateInfo = 9,
        EventCreateInfo = 10,
        QueryPoolCreateInfo = 11,
        BufferCreateInfo = 12,
        BufferViewCreateInfo = 13,
        ImageCreateInfo = 14,
        ImageViewCreateInfo = 15,
        ShaderModuleCreateInfo = 16,
        PipelineCacheCreateInfo = 17,
        PipelineShaderStageCreateInfo = 18,
        PipelineVertexInputStateCreateInfo = 19,
        PipelineInputAssemblyStateCreateInfo = 20,
        PipelineTessellationStateCreateInfo = 21,
        PipelineViewportStateCreateInfo = 22,
        PipelineRasterizationStateCreateInfo = 23,
        PipelineMultisampleStateCreateInfo = 24,
        PipelineDepthStencilStateCreateInfo = 25,
        PipelineColorBlendStateCreateInfo = 26,
        PipelineDynamicStateCreateInfo = 27,
        GraphicsPipelineCreateInfo = 28,
        ComputePipelineCreateInfo = 29,
        PipelineLayoutCreateInfo = 30,
        SamplerCreateInfo = 31,
        DescriptorSetLayoutCreateInfo = 32,
        DescriptorPoolCreateInfo = 33,
        DescriptorSetAllocateInfo = 34,
        WriteDescriptorSet = 35,
        CopyDescriptorSet = 36,
        FramebufferCreateInfo = 37,
        RenderPassCreateInfo = 38,
        CommandPoolCreateInfo = 39,
        CommandBufferAllocateInfo = 40,
        CommandBufferInheritanceInfo = 41,
        CommandBufferBeginInfo = 42,
        RenderPassBeginInfo = 43,
        BufferMemoryBarrier = 44,
        ImageMemoryBarrier = 45,
        MemoryBarrier = 46,
        LoaderInstanceCreateInfo = 47,
        LoaderDeviceCreateInfo = 48,
        SwapchainCreateInfoKhr = 1000001000,
        PresentInfoKhr = 1000001001,
        DisplayModeCreateInfoKhr = 1000002000,
        DisplaySurfaceCreateInfoKhr = 1000002001,
        DisplayPresentInfoKhr = 1000003000,
        DebugReportCallbackCreateInfoExt = 1000011000,
    }

    public enum VkSystemAllocationScope {
        Command = 0,
        Object = 1,
        Cache = 2,
        Device = 3,
        Instance = 4,
    }

    public enum VkInternalAllocationType {
        Executable = 0,
    }

    public enum VkSamplerAddressMode {
        Repeat = 0,
        MirroredRepeat = 1,
        ClampToEdge = 2,
        ClampToBorder = 3,
    }

    public enum VkFilter {
        Nearest = 0,
        Linear = 1,
    }

    public enum VkSamplerMipmapMode {
        Nearest = 0,
        Linear = 1,
    }

    public enum VkVertexInputRate {
        Vertex = 0,
        Instance = 1,
    }

    public enum VkColorSpaceKHR {
        SrgbNonlinearKhr = 0,
    }

    public enum VkPresentModeKHR {
        ImmediateKhr = 0,
        MailboxKhr = 1,
        FifoKhr = 2,
        FifoRelaxedKhr = 3,
    }

    public enum VkDebugReportObjectTypeEXT {
        UnknownExt = 0,
        InstanceExt = 1,
        PhysicalDeviceExt = 2,
        DeviceExt = 3,
        QueueExt = 4,
        SemaphoreExt = 5,
        CommandBufferExt = 6,
        FenceExt = 7,
        DeviceMemoryExt = 8,
        BufferExt = 9,
        ImageExt = 10,
        EventExt = 11,
        QueryPoolExt = 12,
        BufferViewExt = 13,
        ImageViewExt = 14,
        ShaderModuleExt = 15,
        PipelineCacheExt = 16,
        PipelineLayoutExt = 17,
        RenderPassExt = 18,
        PipelineExt = 19,
        DescriptorSetLayoutExt = 20,
        SamplerExt = 21,
        DescriptorPoolExt = 22,
        DescriptorSetExt = 23,
        FramebufferExt = 24,
        CommandPoolExt = 25,
        SurfaceKhrExt = 26,
        SwapchainKhrExt = 27,
        DebugReportExt = 28,
    }

    public enum VkDebugReportErrorEXT {
        NoneExt = 0,
        CallbackRefExt = 1,
    }

    public enum VkRasterizationOrderAMD {
        StrictAmd = 0,
        RelaxedAmd = 1,
    }

}
