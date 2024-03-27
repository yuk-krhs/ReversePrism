using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScreenRect                               00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 020 SourceRect                               00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 030 LeftBorder                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 RightBorder                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 TopBorder                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C BottomBorder                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 LeftBorderColor                          0001865AB0A0 ModelEnumType Color Color Color Int32
    // 050 RightBorderColor                         0001865AB0A0 ModelEnumType Color Color Color Int32
    // 060 TopBorderColor                           0001865AB0A0 ModelEnumType Color Color Color Int32
    // 070 BottomBorderColor                        0001865AB0A0 ModelEnumType Color Color Color Int32
    // 080 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 090 BorderWidths                             0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0A0 CornerRadiuses                           0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0B0 SmoothCorners                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B4 Pass                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 0B8 Texture                                  00018664D720 ModelClassType Texture Texture Texture Pointer
    // 0C0 Mat                                      00018660C4B0 ModelClassType Material Material Material Pointer
    public partial class Internal_DrawTextureArguments
    {
        public Rect                                     ScreenRect                              { get; set; }
        public Rect                                     SourceRect                              { get; set; }
        public int                                      LeftBorder                              { get; set; }
        public int                                      RightBorder                             { get; set; }
        public int                                      TopBorder                               { get; set; }
        public int                                      BottomBorder                            { get; set; }
        public Color                                    LeftBorderColor                         { get; set; }
        public Color                                    RightBorderColor                        { get; set; }
        public Color                                    TopBorderColor                          { get; set; }
        public Color                                    BottomBorderColor                       { get; set; }
        public Color                                    Color                                   { get; set; }
        public Vector4                                  BorderWidths                            { get; set; }
        public Vector4                                  CornerRadiuses                          { get; set; }
        public bool                                     SmoothCorners                           { get; set; }
        public int                                      Pass                                    { get; set; }
        public Texture?                                 Texture                                 { get; set; }
        public Material?                                Mat                                     { get; set; }

        public static Internal_DrawTextureArguments? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Internal_DrawTextureArguments();

            value.ScreenRect                                = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0270068AB1C8 0x10 ScreenRect                  ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.SourceRect                                = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0270068AB1E8 0x20 SourceRect                  ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.LeftBorder                                = GetInt32(new IntPtr(p + 0x030)); // 0270068AB208 0x30 LeftBorder                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RightBorder                               = GetInt32(new IntPtr(p + 0x034)); // 0270068AB228 0x34 RightBorder                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TopBorder                                 = GetInt32(new IntPtr(p + 0x038)); // 0270068AB248 0x38 TopBorder                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BottomBorder                              = GetInt32(new IntPtr(p + 0x03C)); // 0270068AB268 0x3C BottomBorder                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LeftBorderColor                           = (Color)GetInt32(new IntPtr(p + 0x040)); // 0270068AB288 0x40 LeftBorderColor             ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.RightBorderColor                          = (Color)GetInt32(new IntPtr(p + 0x050)); // 0270068AB2A8 0x50 RightBorderColor            ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.TopBorderColor                            = (Color)GetInt32(new IntPtr(p + 0x060)); // 0270068AB2C8 0x60 TopBorderColor              ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BottomBorderColor                         = (Color)GetInt32(new IntPtr(p + 0x070)); // 0270068AB2E8 0x70 BottomBorderColor           ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x080)); // 0270068AB308 0x80 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BorderWidths                              = (Vector4)GetInt32(new IntPtr(p + 0x090)); // 0270068AB328 0x90 BorderWidths                ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.CornerRadiuses                            = (Vector4)GetInt32(new IntPtr(p + 0x0A0)); // 0270068AB348 0xA0 CornerRadiuses              ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SmoothCorners                             = GetBool(new IntPtr(p + 0x0B0)); // 0270068AB368 0xB0 SmoothCorners               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Pass                                      = GetInt32(new IntPtr(p + 0x0B4)); // 0270068AB388 0xB4 Pass                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Texture                                   = GetObject<Texture>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Texture.FromPointer); // 0270068AB3A8 0xB8 Texture                     ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.Mat                                       = GetObject<Material>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Material.FromPointer); // 0270068AB3C8 0xC0 Mat                         ( 00018660C4B0 ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
