using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 nearZ                                    float IL2CPP_TYPE_R4
    // 010 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Tint                                     ModelEnumType Color32 Color32 Color32 Int32
    // 020 Uv                                       ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 XformClipPages                           ModelEnumType Color32 Color32 Color32 Int32
    // 02C Ids                                      ModelEnumType Color32 Color32 Color32 Int32
    // 030 Flags                                    ModelEnumType Color32 Color32 Color32 Int32
    // 034 OpacityColorPages                        ModelEnumType Color32 Color32 Color32 Int32
    // 038 SettingIndex                             ModelEnumType Color32 Color32 Color32 Int32
    // 03C Circle                                   ModelEnumType Vector4 Vector4 Vector4 Int32
    // 04C TextureId                                ModelPrimitiveType float float float Single
    public partial class Vertex : DataModel
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
            var value   = new Vertex() { Pointer= p0 };

            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Tint                                      = (Color32)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Tint                        ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.Uv                                        = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0x20 Uv                          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.XformClipPages                            = (Color32)GetInt32(new IntPtr(p + 0x028)); // 0x28 XformClipPages              ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.Ids                                       = (Color32)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Ids                         ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.Flags                                     = (Color32)GetInt32(new IntPtr(p + 0x030)); // 0x30 Flags                       ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.OpacityColorPages                         = (Color32)GetInt32(new IntPtr(p + 0x034)); // 0x34 OpacityColorPages           ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.SettingIndex                              = (Color32)GetInt32(new IntPtr(p + 0x038)); // 0x38 SettingIndex                ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.Circle                                    = (Vector4)GetInt32(new IntPtr(p + 0x03C)); // 0x3C Circle                      ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.TextureId                                 = GetSingle(new IntPtr(p + 0x04C)); // 0x4C TextureId                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
