using System;
using System.Collections.Generic;
using System.Text;

namespace CASS.OpenCL
{
    #region Driver Types
    public struct CLPlatformID
    {
        public IntPtr Value;
    }

    public struct CLDeviceID
    {
        public IntPtr Value;
    }

    public struct CLContext
    {
        public IntPtr Value;
    }

    public struct CLCommandQueue
    {
        public IntPtr Value;
    }

    public struct CLMem
    {
        public IntPtr Value;
    }

    public struct CLProgram
    {
        public IntPtr Value;
    }

    public struct CLKernel
    {
        public IntPtr Value;
    }

    public struct CLEvent
    {
        public IntPtr Value;
    }

    public struct CLSampler
    {
        public IntPtr Value;
    }

    public struct CLImageFormat
    {
        public CLChannelOrder image_channel_order;
        public CLChannelType image_channel_data_type;
    }
    #endregion

    #region Enums
    // Error Codes
    public enum CLError
    {
        Success = 0,
        DeviceNotFound = -1,
        DeviceNotAvailable = -2,
        DeviceCompilerNotAvailable = -3,
        MemObjectAllocationFailure = -4,
        OutOfResources = -5,
        OutOfHostMemory = -6,
        ProfilingInfoNotAvailable = -7,
        MemCopyOverlap = -8,
        ImageFormatMismatch = -9,
        ImageFormatNotSupported = -10,
        BuildProgramFailure = -11,
        MapFailure = -12,

        InvalidValue = -30,
        InvalidDeviceType = -31,
        InvalidPlatform = -32,
        InvalidDevice = -33,
        InvalidContext = -34,
        InvalidQueueProperties = -35,
        InvalidCommandQueue = -36,
        InvalidHostPtr = -37,
        InvalidMemObject = -38,
        InvalidImageFormatDescriptor = -39,
        InvalidImageSize = -40,
        InvalidSampler = -41,
        InvalidBinary = -42,
        InvalidBuildOptions = -43,
        InvalidProgram = -44,
        InvalidProgramExecutable = -45,
        InvalidKernelName = -46,
        InvalidKernelDefinition = -47,
        InvalidKernel = -48,
        InvalidArgIndex = -49,
        InvalidArgValue = -50,
        InvalidArgSize = -51,
        InvalidKernelArgs = -52,
        InvalidWorkDimension = -53,
        InvalidWorkGroupSize = -54,
        InvalidWorkItemSize = -55,
        InvalidGlobalOffset = -56,
        InvalidEventWaitList = -57,
        InvalidEvent = -58,
        InvalidOperation = -59,
        InvalidGLObject = -60,
        InvalidBufferSize = -61,
        InvalidMipLevel = -62,
        InvalidGlobalWorkSize = -63,

        /* cl_khr_gl_sharing extension */
        InvalidGLShareGroupReferenceKHR = -1000,
    }

    // OpenCL Version    
    public enum OpenCLVersion : uint
    {
        Version_1_0 = 1,
    }

    // cl_bool
    public enum CLBool : uint
    {
        False = 0,
        True = 1
    }

    // cl_platform_info
    public enum CLPlatformInfo : uint
    {
        Profile = 0x0900,
        Version = 0x0901,
        Name = 0x0902,
        Vendor = 0x0903,
        Extensions = 0x0904,
    }

    // cl_device_type - bitfield
    public enum CLDeviceType : ulong
    {
        Default = (1 << 0),
        CPU = (1 << 1),
        GPU = (1 << 2),
        Accelerator = (1 << 3),
        All = 0xFFFFFFFF,
    }

    // cl_device_info
    public enum CLDeviceInfo : uint
    {
        Type = 0x1000,
        VendorID = 0x1001,
        MaxComputeUnits = 0x1002,
        MaxWorkItemDimensions = 0x1003,
        MaxWorkGroupSize = 0x1004,
        MaxWorkItemSizes = 0x1005,
        PreferredVectorWidthChar = 0x1006,
        PreferredVectorWidthShort = 0x1007,
        PreferredVectorWidthInt = 0x1008,
        PreferredVectorWidthLong = 0x1009,
        PreferredVectorWidthFloat = 0x100A,
        PreferredVectorWidthDouble = 0x100B,
        MaxClockFrequency = 0x100C,
        AddressBits = 0x100D,
        MaxReadImageArgs = 0x100E,
        MaxWriteImageArgs = 0x100F,
        MaxMemAllocSize = 0x1010,
        Image2DMaxWidth = 0x1011,
        Image2DMaxHeight = 0x1012,
        Image3DMaxWidth = 0x1013,
        Image3DMaxHeight = 0x1014,
        Image3DMaxDepth = 0x1015,
        ImageSupport = 0x1016,
        MaxParameterSize = 0x1017,
        MaxSamplers = 0x1018,
        MemBaseAddrAlign = 0x1019,
        MinDataTypeAlignSize = 0x101A,
        SingleFPConfig = 0x101B,
        GlobalMemCacheType = 0x101C,
        GlobalMemCacheLineSize = 0x101D,
        GlobalMemCacheSize = 0x101E,
        GlobalMemSize = 0x101F,
        MaxConstantBufferSize = 0x1020,
        MaxConstantArgs = 0x1021,
        LocalMemType = 0x1022,
        LocalMemSize = 0x1023,
        ErrorCorrectionSupport = 0x1024,
        ProfilingTimerResolution = 0x1025,
        EndianLittle = 0x1026,
        Available = 0x1027,
        CompilerAvailable = 0x1028,
        ExecutionCapabilities = 0x1029,
        QueueProperties = 0x102A,
        Name = 0x102B,
        Vendor = 0x102C,
        DriverVersion = 0x102D,
        Profile = 0x102E,
        Version = 0x102F,
        Extensions = 0x1030,
        Platform = 0x1031,
    }

    // cl_device_address_info - bitfield
    public enum CLDeviceAddressInfo : ulong
    {
        Address32Bits = (1 << 0),
        Address64Bits = (1 << 1),
    }

    // cl_device_fp_config - bitfield
    public enum CLDeviceFPConfig : ulong
    {
        Denorm = (1 << 0),
        InfNan = (1 << 1),
        RoundToNearest = (1 << 2),
        RoundToZero = (1 << 3),
        RoundToInf = (1 << 4),
        FMA = (1 << 5),
    }

    // cl_device_mem_cache_type
    public enum CLDeviceMemCacheType : uint
    {
        None = 0x0,
        ReadOnlyCache = 0x1,
        ReadWriteCache = 0x2,
    }

    // cl_device_local_mem_type
    public enum CLDeviceLocalMemType : uint
    {
        Local = 0x1,
        Global = 0x2
    }

    // cl_device_exec_capabilities - bitfield
    public enum CLDeviceExecCapabilities : ulong
    {
        Kernel = (1 << 0),
        NativeKernel = (1 << 1),
    }
    
    // cl_command_queue_properties - bitfield
    public enum CLCommandQueueProperties : ulong
    {
        OutOfOrderExecModeEnable = (1 << 0),
        ProfilingEnable = (1 << 1),
    }
    
    // cl_context_info
    public enum CLContextInfo : uint
    {
        ReferenceCount = 0x1080,
        Devices = 0x1081,
        Properties = 0x1082,
    }

    // cl_context_properties
    public enum CLContextProperties : uint
    {
        Platform = 0x1084,

        /* cl_khr_gl_sharing extension */
        GLContextKHR = 0x2008,
        EGLDisplayKHR = 0x2009,
        GLXDisplayKHR = 0x200A,
        WGLHDCKHR = 0x200B,
        CGLShareGroupKHR = 0x200C,
    }

    // cl_command_queue_info
    public enum CLCommandQueueInfo : uint
    {
        Context = 0x1090,
        Device = 0x1091,
        ReferenceCount = 0x1092,
        Properties = 0x1093,
    }

    // cl_mem_flags - bitfield
    [Flags]
    public enum CLMemFlags : ulong
    {
        ReadWrite = (1 << 0),
        WriteOnly = (1 << 1),
        ReadOnly = (1 << 2),
        UseHostPtr = (1 << 3),
        AllocHostPtr = (1 << 4),
        CopyHostPtr = (1 << 5),
    }

    // cl_channel_order
    public enum CLChannelOrder : uint
    {
        R = 0x10B0,
        A = 0x10B1,
        RG = 0x10B2,
        RA = 0x10B3,
        RGB = 0x10B4,
        RGBA = 0x10B5,
        BGRA = 0x10B6,
        ARGB = 0x10B7,
        Intensity = 0x10B8,
        Luminance = 0x10B9,
    }

    // cl_channel_type
    public enum CLChannelType : uint
    {
        SNormInt8 = 0x10D0,
        SNormInt16 = 0x10D1,
        UNormInt8 = 0x10D2,
        UNormInt16 = 0x10D3,
        UNormShort565 = 0x10D4,
        UNormShort555 = 0x10D5,
        UNormInt101010 = 0x10D6,
        SignedInt8 = 0x10D7,
        SignedInt16 = 0x10D8,
        SignedInt32 = 0x10D9,
        UnSignedInt8 = 0x10DA,
        UnSignedInt16 = 0x10DB,
        UnSignedInt32 = 0x10DC,
        HalfFloat = 0x10DD,
        Float = 0x10DE,
    }

    // cl_mem_object_type
    public enum CLMemObjectType : uint
    {
        Buffer = 0x10F0,
        Image2D = 0x10F1,
        Image3D = 0x10F2,
    }

    // cl_mem_info
    public enum CLMemInfo : uint
    {
        Type = 0x1100,
        Flags = 0x1101,
        Size = 0x1102,
        HostPtr = 0x1103,
        MapCount = 0x1104,
        ReferenceCount = 0x1105,
        Context = 0x1106,
    }

    // cl_image_info
    public enum CLImageInfo : uint
    {
        Format = 0x1110,
        ElementSize = 0x1111,
        RowPitch = 0x1112,
        SlicePitch = 0x1113,
        Width = 0x1114,
        Height = 0x1115,
        Depth = 0x1116,
    }

    // cl_addressing_mode
    public enum CLAddressingMode : uint
    {
        None = 0x1130,
        ClampToEdge = 0x1131,
        Clamp = 0x1132,
        Repeat = 0x1133,
    }

    // cl_filter_mode
    public enum CLFilterMode : uint
    {
        Nearest = 0x1140,
        Linear = 0x1141,
    }

    // cl_sampler_info
    public enum CLSamplerInfo : uint
    {
        ReferenceCount = 0x1150,
        Context = 0x1151,
        NormalizedCoords = 0x1152,
        AddressingMode = 0x1153,
        FilterMode = 0x1154,
    }

    // cl_map_flags - bitfield
    public enum CLMapFlags : ulong
    {
        Read = (1 << 0),
        Write = (1 << 1),
    }

    // cl_program_info
    public enum CLProgramInfo : uint
    {
        ReferenceCount = 0x1160,
        Context = 0x1161,
        NumDevices = 0x1162,
        Devices = 0x1163,
        Source = 0x1164,
        BinarySizes = 0x1165,
        Binaries = 0x1166,
    }

    // cl_program_build_info
    public enum CLProgramBuildInfo : uint
    {
        Status = 0x1181,
        Options = 0x1182,
        Log = 0x1183,
    }

    // cl_build_status
    public enum CLBuildStatus : int
    {
        Success = 0,
        None = -1,
        Error = -2,
        InProgress = -3,
    }

    // cl_kernel_info
    public enum CLKernelInfo : uint
    {
        FunctionName = 0x1190,
        NumArgs = 0x1191,
        ReferenceCount = 0x1192,
        Context = 0x1193,
        Program = 0x1194,
    }

    // cl_kernel_work_group_info
    public enum CLKernelWorkGroupInfo : uint
    {
        WorkGroupSize = 0x11B0,
        CompileWithWorkGroupSize = 0x11B1,
        LocalMemSize = 0x11B2,
    }

    // cl_event_info
    public enum CLEventInfo : uint
    {
        CommandQueue = 0x11D0,
        CommandType = 0x11D1,
        ReferenceCount = 0x11D2,
        CommandExecutionStatus = 0x11D3,
    }

    // cl_command_type
    public enum CLCommandType : uint
    {
        NDRangeKernel = 0x11F0,
        Task = 0x11F1,
        NativeKernel = 0x11F2,
        ReadBuffer = 0x11F3,
        WriteBuffer = 0x11F4,
        CopyBuffer = 0x11F5,
        ReadImage = 0x11F6,
        WriteImage = 0x11F7,
        CopyImage = 0x11F8,
        CopyImageToBuffer = 0x11F9,
        CopyBufferToImage = 0x11FA,
        MapBuffer = 0x11FB,
        MapImage = 0x11FC,
        UnmapMemObject = 0x11FD,
        Marker = 0x11FE,
        AcquireGLObjects = 0x11FF,
        ReleaseGLObjects = 0x1200,

        /* cl_khr_gl_event extension */
        GLFenceSyncObjectKHR = 0x200D,
    }

    // command execution status
    public enum CLExecutionStatus : uint
    {
        Complete = 0x0,
        Running = 0x1,
        Submitted = 0x2,
        Queued = 0x3,
    }

    // cl_profiling_info
    public enum CLProfilingInfo : uint
    {
        Queued = 0x1280,
        Submit = 0x1281,
        Start = 0x1282,
        End = 0x1283,
    }
    #endregion
}
