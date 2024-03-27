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
    // 010 MainLightColorID                         0001865F4BC0 ModelPrimitiveType int int int Int32
    // 014 MainLightPositionID                      0001865F4BC0 ModelPrimitiveType int int int Int32
    // 018 SaturateLightColorAmbientSkyID           0001865F4BC0 ModelPrimitiveType int int int Int32
    // 01C DefaultLightPosition                     0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 02C DefaultLightColor                        0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class Lighting
    {
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
            var value   = new Lighting();

            value.MainLightColorID                          = GetInt32(new IntPtr(p + 0x010)); // 027003FEDC90 0x10 MainLightColorID            ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.MainLightPositionID                       = GetInt32(new IntPtr(p + 0x014)); // 027003FEDCB0 0x14 MainLightPositionID         ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.SaturateLightColorAmbientSkyID            = GetInt32(new IntPtr(p + 0x018)); // 027003FEDCD0 0x18 SaturateLightColorAmbientSkyID ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.DefaultLightPosition                      = (Vector4)GetInt32(new IntPtr(p + 0x01C)); // 027003FEDCF0 0x1C DefaultLightPosition        ( 0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.DefaultLightColor                         = (Vector4)GetInt32(new IntPtr(p + 0x02C)); // 027003FEDD10 0x2C DefaultLightColor           ( 0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
