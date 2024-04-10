using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Normal                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 Tangent                                  0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 038 Color                                    0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 03C Uv0                                      0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 04C Uv1                                      0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 05C Uv2                                      0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 06C Uv3                                      0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 000 s_DefaultColor                           Color32 IL2CPP_TYPE_VALUETYPE
    // 004 s_DefaultTangent                         Vector4 IL2CPP_TYPE_VALUETYPE
    // 014 SimpleVert                               000186696240 ModelEnumType UIVertex UIVertex UIVertex Int32
    public partial class UIVertex : DataModel
    {
        public Vector3                                  Position                                { get; set; }
        public Vector3                                  Normal                                  { get; set; }
        public Vector4                                  Tangent                                 { get; set; }
        public Color32                                  Color                                   { get; set; }
        public Vector4                                  Uv0                                     { get; set; }
        public Vector4                                  Uv1                                     { get; set; }
        public Vector4                                  Uv2                                     { get; set; }
        public Vector4                                  Uv3                                     { get; set; }
        public UIVertex                                 SimpleVert                              { get; set; }

        public static UIVertex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIVertex() { Pointer= p0 };

            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0245A2189268 0x10 Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Normal                                    = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 0245A2189288 0x1C Normal                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Tangent                                   = (Vector4)GetInt32(new IntPtr(p + 0x028)); // 0245A21892A8 0x28 Tangent                     ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Color                                     = (Color32)GetInt32(new IntPtr(p + 0x038)); // 0245A21892C8 0x38 Color                       ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.Uv0                                       = (Vector4)GetInt32(new IntPtr(p + 0x03C)); // 0245A21892E8 0x3C Uv0                         ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Uv1                                       = (Vector4)GetInt32(new IntPtr(p + 0x04C)); // 0245A2189308 0x4C Uv1                         ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Uv2                                       = (Vector4)GetInt32(new IntPtr(p + 0x05C)); // 0245A2189328 0x5C Uv2                         ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Uv3                                       = (Vector4)GetInt32(new IntPtr(p + 0x06C)); // 0245A2189348 0x6C Uv3                         ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SimpleVert                                = (UIVertex)GetInt32(new IntPtr(p + 0x014)); // 0245A21893A8 0x14 SimpleVert                  ( 000186696240 ModelEnumType UIVertex UIVertex UIVertex Int32 )

            return value;
        }
    }
}
