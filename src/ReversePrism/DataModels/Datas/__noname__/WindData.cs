using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Flag                                     ModelEnumType BitField32 BitField32 BitField32 Int32
    // 014 Mode                                     ModelEnumType Mode Mode Mode Int32
    // 018 Size                                     ModelEnumType float3 float3 float3 Int32
    // 024 Main                                     ModelPrimitiveType float float float Single
    // 028 Turbulence                               ModelPrimitiveType float float float Single
    // 02C ZoneVolume                               ModelPrimitiveType float float float Single
    // 030 WorldWindDirection                       ModelEnumType float3 float3 float3 Int32
    // 03C WorldPositin                             ModelEnumType float3 float3 float3 Int32
    // 048 WorldRotation                            ModelEnumType quaternion quaternion quaternion Int32
    // 058 WorldScale                               ModelEnumType float3 float3 float3 Int32
    // 064 WorldToLocalMatrix                       ModelEnumType float4x4 float4x4 float4x4 Int32
    // 0A4 Attenuation                              ModelEnumType float4x4 float4x4 float4x4 Int32
    public partial class WindData : DataModel
    {
        public BitField32                               Flag                                    { get; set; }
        public Mode                                     Mode                                    { get; set; }
        public float3                                   Size                                    { get; set; }
        public float                                    Main                                    { get; set; }
        public float                                    Turbulence                              { get; set; }
        public float                                    ZoneVolume                              { get; set; }
        public float3                                   WorldWindDirection                      { get; set; }
        public float3                                   WorldPositin                            { get; set; }
        public quaternion                               WorldRotation                           { get; set; }
        public float3                                   WorldScale                              { get; set; }
        public float4x4                                 WorldToLocalMatrix                      { get; set; }
        public float4x4                                 Attenuation                             { get; set; }

        public static WindData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WindData() { Pointer= p0 };

            value.Flag                                      = (BitField32)GetInt32(new IntPtr(p + 0x010)); // 0x10 Flag                        ( ModelEnumType BitField32 BitField32 BitField32 Int32 )
            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x014)); // 0x14 Mode                        ( ModelEnumType Mode Mode Mode Int32 )
            value.Size                                      = (float3)GetInt32(new IntPtr(p + 0x018)); // 0x18 Size                        ( ModelEnumType float3 float3 float3 Int32 )
            value.Main                                      = GetSingle(new IntPtr(p + 0x024)); // 0x24 Main                        ( ModelPrimitiveType float float float Single )
            value.Turbulence                                = GetSingle(new IntPtr(p + 0x028)); // 0x28 Turbulence                  ( ModelPrimitiveType float float float Single )
            value.ZoneVolume                                = GetSingle(new IntPtr(p + 0x02C)); // 0x2C ZoneVolume                  ( ModelPrimitiveType float float float Single )
            value.WorldWindDirection                        = (float3)GetInt32(new IntPtr(p + 0x030)); // 0x30 WorldWindDirection          ( ModelEnumType float3 float3 float3 Int32 )
            value.WorldPositin                              = (float3)GetInt32(new IntPtr(p + 0x03C)); // 0x3C WorldPositin                ( ModelEnumType float3 float3 float3 Int32 )
            value.WorldRotation                             = (quaternion)GetInt32(new IntPtr(p + 0x048)); // 0x48 WorldRotation               ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.WorldScale                                = (float3)GetInt32(new IntPtr(p + 0x058)); // 0x58 WorldScale                  ( ModelEnumType float3 float3 float3 Int32 )
            value.WorldToLocalMatrix                        = (float4x4)GetInt32(new IntPtr(p + 0x064)); // 0x64 WorldToLocalMatrix          ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.Attenuation                               = (float4x4)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 Attenuation                 ( ModelEnumType float4x4 float4x4 float4x4 Int32 )

            return value;
        }
    }
}
