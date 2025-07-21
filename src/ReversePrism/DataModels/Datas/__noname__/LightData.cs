using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 020 Color                                    ModelEnumType Vector4 Vector4 Vector4 Int32
    // 030 Attenuation                              ModelEnumType Vector4 Vector4 Vector4 Int32
    // 040 SpotDirection                            ModelEnumType Vector4 Vector4 Vector4 Int32
    // 050 OcclusionProbeChannels                   ModelEnumType Vector4 Vector4 Vector4 Int32
    // 060 LayerMask                                ModelPrimitiveType uint uint uint UInt32
    public partial class LightData : DataModel
    {
        public Vector4                                  Position                                { get; set; }
        public Vector4                                  Color                                   { get; set; }
        public Vector4                                  Attenuation                             { get; set; }
        public Vector4                                  SpotDirection                           { get; set; }
        public Vector4                                  OcclusionProbeChannels                  { get; set; }
        public uint                                     LayerMask                               { get; set; }

        public static LightData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightData() { Pointer= p0 };

            value.Position                                  = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Color                                     = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0x20 Color                       ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Attenuation                               = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0x30 Attenuation                 ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SpotDirection                             = (Vector4)GetInt32(new IntPtr(p + 0x040)); // 0x40 SpotDirection               ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.OcclusionProbeChannels                    = (Vector4)GetInt32(new IntPtr(p + 0x050)); // 0x50 OcclusionProbeChannels      ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.LayerMask                                 = GetUInt32(new IntPtr(p + 0x060)); // 0x60 LayerMask                   ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
