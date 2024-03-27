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
    public partial class NativeRectParams
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
            var value   = new NativeRectParams();

            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0270067DEE60 0x10 Rect                        ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.SubRect                                   = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0270067DEE80 0x20 SubRect                     ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.Uv                                        = (Rect)GetInt32(new IntPtr(p + 0x030)); // 0270067DEEA0 0x30 Uv                          ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.UvRegion                                  = (Rect)GetInt32(new IntPtr(p + 0x040)); // 0270067DEEC0 0x40 UvRegion                    ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x050)); // 0270067DEEE0 0x50 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.ScaleMode                                 = (ScaleMode)GetInt32(new IntPtr(p + 0x060)); // 0270067DEF00 0x60 ScaleMode                   ( 0001866C1AA0 ModelEnumType ScaleMode ScaleMode ScaleMode Int32 )
            value.TopLeftRadius                             = (Vector2)GetInt32(new IntPtr(p + 0x064)); // 0270067DEF20 0x64 TopLeftRadius               ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TopRightRadius                            = (Vector2)GetInt32(new IntPtr(p + 0x06C)); // 0270067DEF40 0x6C TopRightRadius              ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomRightRadius                         = (Vector2)GetInt32(new IntPtr(p + 0x074)); // 0270067DEF60 0x74 BottomRightRadius           ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomLeftRadius                          = (Vector2)GetInt32(new IntPtr(p + 0x07C)); // 0270067DEF80 0x7C BottomLeftRadius            ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ContentSize                               = (Vector2)GetInt32(new IntPtr(p + 0x084)); // 0270067DEFA0 0x84 ContentSize                 ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TextureSize                               = (Vector2)GetInt32(new IntPtr(p + 0x08C)); // 0270067DEFC0 0x8C TextureSize                 ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TexturePixelsPerPoint                     = GetSingle(new IntPtr(p + 0x094)); // 0270067DEFE0 0x94 TexturePixelsPerPoint       ( 000186666050 ModelPrimitiveType float float float Single )
            value.LeftSlice                                 = GetInt32(new IntPtr(p + 0x098)); // 0270067DF000 0x98 LeftSlice                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TopSlice                                  = GetInt32(new IntPtr(p + 0x09C)); // 0270067DF020 0x9C TopSlice                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RightSlice                                = GetInt32(new IntPtr(p + 0x0A0)); // 0270067DF040 0xA0 RightSlice                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BottomSlice                               = GetInt32(new IntPtr(p + 0x0A4)); // 0270067DF060 0xA4 BottomSlice                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SliceScale                                = GetSingle(new IntPtr(p + 0x0A8)); // 0270067DF080 0xA8 SliceScale                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.ColorPage                                 = (NativeColorPage)GetInt32(new IntPtr(p + 0x0AC)); // 0270067DF0A0 0xAC ColorPage                   ( 000186701230 ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32 )

            return value;
        }
    }
}
