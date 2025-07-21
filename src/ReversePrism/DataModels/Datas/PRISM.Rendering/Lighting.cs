using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _Time                                    int IL2CPP_TYPE_I4
    // 004 ambientSkyColorID                        int IL2CPP_TYPE_I4
    // 008 ambientEquatorColorID                    int IL2CPP_TYPE_I4
    // 00C ambientGroundColorID                     int IL2CPP_TYPE_I4
    // 010 MainLightShadowParams                    ModelPrimitiveType int int int Int32
    // 014 MainLightColorID                         ModelPrimitiveType int int int Int32
    // 018 MainLightPositionID                      ModelPrimitiveType int int int Int32
    // 01C SaturateLightColorAmbientSkyID           ModelPrimitiveType int int int Int32
    // 020 DefaultLightPosition                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 030 DefaultLightColor                        ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class Lighting : DataModel
    {
        public int                                      MainLightShadowParams                   { get; set; }
        public int                                      MainLightColorID                        { get; set; }
        public int                                      MainLightPositionID                     { get; set; }
        public int                                      SaturateLightColorAmbientSkyID          { get; set; }
        public Vector4                                  DefaultLightPosition                    { get; set; }
        public Vector4                                  DefaultLightColor                       { get; set; }

        public static Lighting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Lighting() { Pointer= p0 };

            value.MainLightShadowParams                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 MainLightShadowParams       ( ModelPrimitiveType int int int Int32 )
            value.MainLightColorID                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 MainLightColorID            ( ModelPrimitiveType int int int Int32 )
            value.MainLightPositionID                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 MainLightPositionID         ( ModelPrimitiveType int int int Int32 )
            value.SaturateLightColorAmbientSkyID            = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SaturateLightColorAmbientSkyID ( ModelPrimitiveType int int int Int32 )
            value.DefaultLightPosition                      = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0x20 DefaultLightPosition        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.DefaultLightColor                         = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0x30 DefaultLightColor           ( ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
