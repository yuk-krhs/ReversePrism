using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enabled                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 UseMipBias                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 012 EnableDLSS                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 DLSSPerfQualitySetting                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 DLSSInjectionPoint                       0001865CC140 ModelEnumType UpsamplerScheduleType UpsamplerScheduleType UpsamplerScheduleType Int32
    // 01C DLSSUseOptimalSettings                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 DLSSSharpness                            000186666050 ModelPrimitiveType float float float Single
    // 024 FsrOverrideSharpness                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 FsrSharpness                             000186666050 ModelPrimitiveType float float float Single
    // 02C MaxPercentage                            000186666050 ModelPrimitiveType float float float Single
    // 030 MinPercentage                            000186666050 ModelPrimitiveType float float float Single
    // 034 DynResType                               000186713D60 ModelEnumType DynamicResolutionType DynamicResolutionType DynamicResolutionType Int32
    // 035 UpsampleFilter                           000186712E90 ModelEnumType DynamicResUpscaleFilter DynamicResUpscaleFilter DynamicResUpscaleFilter Int32
    // 036 ForceResolution                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 038 ForcedPercentage                         000186666050 ModelPrimitiveType float float float Single
    // 03C LowResTransparencyMinimumThreshold       000186666050 ModelPrimitiveType float float float Single
    // 040 RayTracingHalfResThreshold               000186666050 ModelPrimitiveType float float float Single
    public partial class GlobalDynamicResolutionSettings : DataModel
    {
        public bool                                     Enabled                                 { get; set; }
        public bool                                     UseMipBias                              { get; set; }
        public bool                                     EnableDLSS                              { get; set; }
        public uint                                     DLSSPerfQualitySetting                  { get; set; }
        public UpsamplerScheduleType                    DLSSInjectionPoint                      { get; set; }
        public bool                                     DLSSUseOptimalSettings                  { get; set; }
        public float                                    DLSSSharpness                           { get; set; }
        public bool                                     FsrOverrideSharpness                    { get; set; }
        public float                                    FsrSharpness                            { get; set; }
        public float                                    MaxPercentage                           { get; set; }
        public float                                    MinPercentage                           { get; set; }
        public DynamicResolutionType                    DynResType                              { get; set; }
        public DynamicResUpscaleFilter                  UpsampleFilter                          { get; set; }
        public bool                                     ForceResolution                         { get; set; }
        public float                                    ForcedPercentage                        { get; set; }
        public float                                    LowResTransparencyMinimumThreshold      { get; set; }
        public float                                    RayTracingHalfResThreshold              { get; set; }

        public static GlobalDynamicResolutionSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalDynamicResolutionSettings() { Pointer= p0 };

            value.Enabled                                   = GetBool(new IntPtr(p + 0x010)); // 0245A3FC1090 0x10 Enabled                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseMipBias                                = GetBool(new IntPtr(p + 0x011)); // 0245A3FC10B0 0x11 UseMipBias                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.EnableDLSS                                = GetBool(new IntPtr(p + 0x012)); // 0245A3FC10D0 0x12 EnableDLSS                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DLSSPerfQualitySetting                    = GetUInt32(new IntPtr(p + 0x014)); // 0245A3FC10F0 0x14 DLSSPerfQualitySetting      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DLSSInjectionPoint                        = (UpsamplerScheduleType)GetInt32(new IntPtr(p + 0x018)); // 0245A3FC1110 0x18 DLSSInjectionPoint          ( 0001865CC140 ModelEnumType UpsamplerScheduleType UpsamplerScheduleType UpsamplerScheduleType Int32 )
            value.DLSSUseOptimalSettings                    = GetBool(new IntPtr(p + 0x01C)); // 0245A3FC1130 0x1C DLSSUseOptimalSettings      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DLSSSharpness                             = GetSingle(new IntPtr(p + 0x020)); // 0245A3FC1150 0x20 DLSSSharpness               ( 000186666050 ModelPrimitiveType float float float Single )
            value.FsrOverrideSharpness                      = GetBool(new IntPtr(p + 0x024)); // 0245A3FC1170 0x24 FsrOverrideSharpness        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FsrSharpness                              = GetSingle(new IntPtr(p + 0x028)); // 0245A3FC1190 0x28 FsrSharpness                ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxPercentage                             = GetSingle(new IntPtr(p + 0x02C)); // 0245A3FC11B0 0x2C MaxPercentage               ( 000186666050 ModelPrimitiveType float float float Single )
            value.MinPercentage                             = GetSingle(new IntPtr(p + 0x030)); // 0245A3FC11D0 0x30 MinPercentage               ( 000186666050 ModelPrimitiveType float float float Single )
            value.DynResType                                = (DynamicResolutionType)GetInt32(new IntPtr(p + 0x034)); // 0245A3FC11F0 0x34 DynResType                  ( 000186713D60 ModelEnumType DynamicResolutionType DynamicResolutionType DynamicResolutionType Int32 )
            value.UpsampleFilter                            = (DynamicResUpscaleFilter)GetInt32(new IntPtr(p + 0x035)); // 0245A3FC1210 0x35 UpsampleFilter              ( 000186712E90 ModelEnumType DynamicResUpscaleFilter DynamicResUpscaleFilter DynamicResUpscaleFilter Int32 )
            value.ForceResolution                           = GetBool(new IntPtr(p + 0x036)); // 0245A3FC1230 0x36 ForceResolution             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ForcedPercentage                          = GetSingle(new IntPtr(p + 0x038)); // 0245A3FC1250 0x38 ForcedPercentage            ( 000186666050 ModelPrimitiveType float float float Single )
            value.LowResTransparencyMinimumThreshold        = GetSingle(new IntPtr(p + 0x03C)); // 0245A3FC1270 0x3C LowResTransparencyMinimumThreshold ( 000186666050 ModelPrimitiveType float float float Single )
            value.RayTracingHalfResThreshold                = GetSingle(new IntPtr(p + 0x040)); // 0245A3FC1290 0x40 RayTracingHalfResThreshold  ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
