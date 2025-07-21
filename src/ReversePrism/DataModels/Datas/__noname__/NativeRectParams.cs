using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rect                                     ModelEnumType Rect Rect Rect Int32
    // 020 SubRect                                  ModelEnumType Rect Rect Rect Int32
    // 030 Uv                                       ModelEnumType Rect Rect Rect Int32
    // 040 UvRegion                                 ModelEnumType Rect Rect Rect Int32
    // 050 Color                                    ModelEnumType Color Color Color Int32
    // 060 ScaleMode                                ModelEnumType ScaleMode ScaleMode ScaleMode Int32
    // 064 TopLeftRadius                            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 06C TopRightRadius                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 074 BottomRightRadius                        ModelEnumType Vector2 Vector2 Vector2 Int32
    // 07C BottomLeftRadius                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 084 ContentSize                              ModelEnumType Vector2 Vector2 Vector2 Int32
    // 08C TextureSize                              ModelEnumType Vector2 Vector2 Vector2 Int32
    // 094 TexturePixelsPerPoint                    ModelPrimitiveType float float float Single
    // 098 LeftSlice                                ModelPrimitiveType int int int Int32
    // 09C TopSlice                                 ModelPrimitiveType int int int Int32
    // 0A0 RightSlice                               ModelPrimitiveType int int int Int32
    // 0A4 BottomSlice                              ModelPrimitiveType int int int Int32
    // 0A8 SliceScale                               ModelPrimitiveType float float float Single
    // 0AC RectInset                                ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0BC ColorPage                                ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32
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
        public Vector4                                  RectInset                               { get; set; }
        public NativeColorPage                          ColorPage                               { get; set; }

        public static NativeRectParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeRectParams() { Pointer= p0 };

            value.Rect                                      = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0x10 Rect                        ( ModelEnumType Rect Rect Rect Int32 )
            value.SubRect                                   = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0x20 SubRect                     ( ModelEnumType Rect Rect Rect Int32 )
            value.Uv                                        = (Rect)GetInt32(new IntPtr(p + 0x030)); // 0x30 Uv                          ( ModelEnumType Rect Rect Rect Int32 )
            value.UvRegion                                  = (Rect)GetInt32(new IntPtr(p + 0x040)); // 0x40 UvRegion                    ( ModelEnumType Rect Rect Rect Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x050)); // 0x50 Color                       ( ModelEnumType Color Color Color Int32 )
            value.ScaleMode                                 = (ScaleMode)GetInt32(new IntPtr(p + 0x060)); // 0x60 ScaleMode                   ( ModelEnumType ScaleMode ScaleMode ScaleMode Int32 )
            value.TopLeftRadius                             = (Vector2)GetInt32(new IntPtr(p + 0x064)); // 0x64 TopLeftRadius               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TopRightRadius                            = (Vector2)GetInt32(new IntPtr(p + 0x06C)); // 0x6C TopRightRadius              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomRightRadius                         = (Vector2)GetInt32(new IntPtr(p + 0x074)); // 0x74 BottomRightRadius           ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BottomLeftRadius                          = (Vector2)GetInt32(new IntPtr(p + 0x07C)); // 0x7C BottomLeftRadius            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ContentSize                               = (Vector2)GetInt32(new IntPtr(p + 0x084)); // 0x84 ContentSize                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TextureSize                               = (Vector2)GetInt32(new IntPtr(p + 0x08C)); // 0x8C TextureSize                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.TexturePixelsPerPoint                     = GetSingle(new IntPtr(p + 0x094)); // 0x94 TexturePixelsPerPoint       ( ModelPrimitiveType float float float Single )
            value.LeftSlice                                 = GetInt32(new IntPtr(p + 0x098)); // 0x98 LeftSlice                   ( ModelPrimitiveType int int int Int32 )
            value.TopSlice                                  = GetInt32(new IntPtr(p + 0x09C)); // 0x9C TopSlice                    ( ModelPrimitiveType int int int Int32 )
            value.RightSlice                                = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 RightSlice                  ( ModelPrimitiveType int int int Int32 )
            value.BottomSlice                               = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 BottomSlice                 ( ModelPrimitiveType int int int Int32 )
            value.SliceScale                                = GetSingle(new IntPtr(p + 0x0A8)); // 0xA8 SliceScale                  ( ModelPrimitiveType float float float Single )
            value.RectInset                                 = (Vector4)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC RectInset                   ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ColorPage                                 = (NativeColorPage)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC ColorPage                   ( ModelEnumType NativeColorPage NativeColorPage NativeColorPage Int32 )

            return value;
        }
    }
}
