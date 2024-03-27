using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 nearZ                                    float IL2CPP_TYPE_R4
    // 010 Position                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Tint                                     0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32
    // 020 Uv                                       0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 XformClipPages                           0001865ACA60 ModelEnumType Color32 Color32 Color32 Int32
    // 02C Ids                                      0001865ACA60 ModelEnumType Color32 Color32 Color32 Int32
    // 030 Flags                                    0001865ACA60 ModelEnumType Color32 Color32 Color32 Int32
    // 034 OpacityColorPages                        0001865ACA60 ModelEnumType Color32 Color32 Color32 Int32
    // 038 SettingIndex                             0001865ACA60 ModelEnumType Color32 Color32 Color32 Int32
    // 03C Circle                                   0001866AEB50 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 04C TextureId                                000186665900 ModelPrimitiveType float float float Single
    public partial class Vertex
    {
        public Vector3                                  Position                                { get; set; }
        public Color32                                  Tint                                    { get; set; }
        public Vector2                                  Uv                                      { get; set; }
        public Color32                                  XformClipPages                          { get; set; }
        public Color32                                  Ids                                     { get; set; }
        public Color32                                  Flags                                   { get; set; }
        public Color32                                  OpacityColorPages                       { get; set; }
        public Color32                                  SettingIndex                            { get; set; }
        public Vector4                                  Circle                                  { get; set; }
        public float                                    TextureId                               { get; set; }

        public static Vertex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vertex();

            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0270067E3798 0x10 Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Tint                                      = (Color32)GetInt32(new IntPtr(p + 0x01C)); // 0270067E37B8 0x1C Tint                        ( 0001865ACF10 ModelEnumType Color32 Color32 Color32 Int32 )
            value.Uv                                        = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0270067E37D8 0x20 Uv                          ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.XformClipPages                            = (Color32)GetInt32(new IntPtr(p + 0x028)); // 0270067E37F8 0x28 XformClipPages              ( 0001865ACA60 ModelEnumType Color32 Color32 Color32 Int32 )
            value.Ids                                       = (Color32)GetInt32(new IntPtr(p + 0x02C)); // 0270067E3818 0x2C Ids                         ( 0001865ACA60 ModelEnumType Color32 Color32 Color32 Int32 )
            value.Flags                                     = (Color32)GetInt32(new IntPtr(p + 0x030)); // 0270067E3838 0x30 Flags                       ( 0001865ACA60 ModelEnumType Color32 Color32 Color32 Int32 )
            value.OpacityColorPages                         = (Color32)GetInt32(new IntPtr(p + 0x034)); // 0270067E3858 0x34 OpacityColorPages           ( 0001865ACA60 ModelEnumType Color32 Color32 Color32 Int32 )
            value.SettingIndex                              = (Color32)GetInt32(new IntPtr(p + 0x038)); // 0270067E3878 0x38 SettingIndex                ( 0001865ACA60 ModelEnumType Color32 Color32 Color32 Int32 )
            value.Circle                                    = (Vector4)GetInt32(new IntPtr(p + 0x03C)); // 0270067E3898 0x3C Circle                      ( 0001866AEB50 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.TextureId                                 = GetSingle(new IntPtr(p + 0x04C)); // 0270067E38B8 0x4C TextureId                   ( 000186665900 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
