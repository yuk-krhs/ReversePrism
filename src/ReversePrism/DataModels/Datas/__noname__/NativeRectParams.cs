using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rect                                     00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 020 SubRect                                  00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 030 Uv                                       00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 040 UvRegion                                 00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 050 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 060 ScaleMode                                0001866C1AA0 ModelEnumType ScaleMode ScaleMode ScaleMode Int32
    // 064 TopLeftRadius                            0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 06C TopRightRadius                           0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 074 BottomRightRadius                        0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 07C BottomLeftRadius                         0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 084 ContentSize                              0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 08C TextureSize                              0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 094 TexturePixelsPerPoint                    000186666050 ModelPrimitiveType float float float Single
    // 098 LeftSlice                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 09C TopSlice                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A0 RightSlice                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A4 BottomSlice                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 0A8 SliceScale                               000186666050 ModelPrimitiveType float float float Single
    // 0AC ColorPage                                000186701230 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32
    public partial class NativeRectParams : DataModel
    {
        public Rect                                     Rect                                    { get; set; }
        public Rect                                     SubRect                                 { get; set; }
        public Rect                                     Uv                                      { get; set; }
        public Rect                                     UvRegion                                { get; set; }
        public Color                                    Color                                   { get; set; }
        public ScaleMode                                ScaleMode                               { get; set; }
        public Vector2                                  TopLeftRadius                           { get; set; }
        public Vector2                                  TopRightRadius                          { get; set; }
        public Vector2                                  BottomRightRadius                       { get; set; }
        public Vector2                                  BottomLeftRadius                        { get; set; }
        public Vector2                                  ContentSize                             { get; set; }
        public Vector2                                  TextureSize                             { get; set; }
        public float                                    TexturePixelsPerPoint                   { get; set; }
        public int                                      LeftSlice                               { get; set; }
        public int                                      TopSlice                                { get; set; }
        public int                                      RightSlice                              { get; set; }
        public int                                      BottomSlice                             { get; set; }
        public float                                    SliceScale                              { get; set; }
        public NativeColorPage                          ColorPage                               { get; set; }

        public static NativeRectParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeRectParams() { Pointer= p0 };

            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0245A67A0F58 0x10 Rect                        ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.SubRect                                   = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0245A67A0F78 0x20 SubRect                     ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.Uv                                        = (Rect)GetInt32(new IntPtr(p + 0x030)); // 0245A67A0F98 0x30 Uv                          ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.UvRegion                                  = (Rect)GetInt32(new IntPtr(p + 0x040)); // 0245A67A0FB8 0x40 UvRegion                    ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x050)); // 0245A67A0FD8 0x50 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.ScaleMode                                 = (ScaleMode)GetInt32(new IntPtr(p + 0x060)); // 0245A67A0FF8 0x60 ScaleMode                   ( 0001866C1AA0 ModelEnumType ScaleMode ScaleMode ScaleMode Int32 )
            value.TopLeftRadius                             = (Vector2)GetInt32(new IntPtr(p + 0x064)); // 0245A67A1018 0x64 TopLeftRadius               ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TopRightRadius                            = (Vector2)GetInt32(new IntPtr(p + 0x06C)); // 0245A67A1038 0x6C TopRightRadius              ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomRightRadius                         = (Vector2)GetInt32(new IntPtr(p + 0x074)); // 0245A67A1058 0x74 BottomRightRadius           ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomLeftRadius                          = (Vector2)GetInt32(new IntPtr(p + 0x07C)); // 0245A67A1078 0x7C BottomLeftRadius            ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ContentSize                               = (Vector2)GetInt32(new IntPtr(p + 0x084)); // 0245A67A1098 0x84 ContentSize                 ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TextureSize                               = (Vector2)GetInt32(new IntPtr(p + 0x08C)); // 0245A67A10B8 0x8C TextureSize                 ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TexturePixelsPerPoint                     = GetSingle(new IntPtr(p + 0x094)); // 0245A67A10D8 0x94 TexturePixelsPerPoint       ( 000186666050 ModelPrimitiveType float float float Single )
            value.LeftSlice                                 = GetInt32(new IntPtr(p + 0x098)); // 0245A67A10F8 0x98 LeftSlice                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TopSlice                                  = GetInt32(new IntPtr(p + 0x09C)); // 0245A67A1118 0x9C TopSlice                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RightSlice                                = GetInt32(new IntPtr(p + 0x0A0)); // 0245A67A1138 0xA0 RightSlice                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BottomSlice                               = GetInt32(new IntPtr(p + 0x0A4)); // 0245A67A1158 0xA4 BottomSlice                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SliceScale                                = GetSingle(new IntPtr(p + 0x0A8)); // 0245A67A1178 0xA8 SliceScale                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.ColorPage                                 = (NativeColorPage)GetInt32(new IntPtr(p + 0x0AC)); // 0245A67A1198 0xAC ColorPage                   ( 000186701230 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32 )

            return value;
        }
    }
}
