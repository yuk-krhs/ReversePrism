using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WsPos                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Radius                                   ModelPrimitiveType float float float Single
    // 020 Color                                    ModelEnumType Vector4 Vector4 Vector4 Int32
    // 030 Attenuation                              ModelEnumType Vector4 Vector4 Vector4 Int32
    // 040 SpotDirection                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 04C Flags                                    ModelPrimitiveType int int int Int32
    // 050 OcclusionProbeInfo                       ModelEnumType Vector4 Vector4 Vector4 Int32
    // 060 LayerMask                                ModelPrimitiveType uint uint uint UInt32
    public partial class PunctualLightData : DataModel
    {
        public Vector3                                  WsPos                                   { get; set; }
        public float                                    Radius                                  { get; set; }
        public Vector4                                  Color                                   { get; set; }
        public Vector4                                  Attenuation                             { get; set; }
        public Vector3                                  SpotDirection                           { get; set; }
        public int                                      Flags                                   { get; set; }
        public Vector4                                  OcclusionProbeInfo                      { get; set; }
        public uint                                     LayerMask                               { get; set; }

        public static PunctualLightData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PunctualLightData() { Pointer= p0 };

            value.WsPos                                     = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 WsPos                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Radius                                    = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Radius                      ( ModelPrimitiveType float float float Single )
            value.Color                                     = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0x20 Color                       ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Attenuation                               = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0x30 Attenuation                 ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SpotDirection                             = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 0x40 SpotDirection               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Flags                                     = GetInt32(new IntPtr(p + 0x04C)); // 0x4C Flags                       ( ModelPrimitiveType int int int Int32 )
            value.OcclusionProbeInfo                        = (Vector4)GetInt32(new IntPtr(p + 0x050)); // 0x50 OcclusionProbeInfo          ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.LayerMask                                 = GetUInt32(new IntPtr(p + 0x060)); // 0x60 LayerMask                   ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
