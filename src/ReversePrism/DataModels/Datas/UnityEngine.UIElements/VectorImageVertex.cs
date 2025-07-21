using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Tint                                     ModelEnumType Color32 Color32 Color32 Int32
    // 020 Uv                                       ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 SettingIndex                             ModelPrimitiveType uint uint uint UInt32
    // 02C Flags                                    ModelEnumType Color32 Color32 Color32 Int32
    // 030 Circle                                   ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class VectorImageVertex : DataModel
    {
        public Vector3                                  Position                                { get; set; }
        public Color32                                  Tint                                    { get; set; }
        public Vector2                                  Uv                                      { get; set; }
        public uint                                     SettingIndex                            { get; set; }
        public Color32                                  Flags                                   { get; set; }
        public Vector4                                  Circle                                  { get; set; }

        public static VectorImageVertex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VectorImageVertex() { Pointer= p0 };

            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Tint                                      = (Color32)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Tint                        ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.Uv                                        = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0x20 Uv                          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.SettingIndex                              = GetUInt32(new IntPtr(p + 0x028)); // 0x28 SettingIndex                ( ModelPrimitiveType uint uint uint UInt32 )
            value.Flags                                     = (Color32)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Flags                       ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.Circle                                    = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0x30 Circle                      ( ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
