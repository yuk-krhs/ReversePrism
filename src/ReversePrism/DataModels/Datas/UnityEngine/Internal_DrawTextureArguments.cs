using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScreenRect                               ModelEnumType Rect Rect Rect Int32
    // 020 SourceRect                               ModelEnumType Rect Rect Rect Int32
    // 030 LeftBorder                               ModelPrimitiveType int int int Int32
    // 034 RightBorder                              ModelPrimitiveType int int int Int32
    // 038 TopBorder                                ModelPrimitiveType int int int Int32
    // 03C BottomBorder                             ModelPrimitiveType int int int Int32
    // 040 LeftBorderColor                          ModelEnumType Color Color Color Int32
    // 050 RightBorderColor                         ModelEnumType Color Color Color Int32
    // 060 TopBorderColor                           ModelEnumType Color Color Color Int32
    // 070 BottomBorderColor                        ModelEnumType Color Color Color Int32
    // 080 Color                                    ModelEnumType Color Color Color Int32
    // 090 BorderWidths                             ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0A0 CornerRadiuses                           ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0B0 SmoothCorners                            ModelPrimitiveType bool bool bool Bool
    // 0B4 Pass                                     ModelPrimitiveType int int int Int32
    // 0B8 Texture                                  ModelClassType Texture Texture Texture Pointer
    // 0C0 Mat                                      ModelClassType Material Material Material Pointer
    public partial class Internal_DrawTextureArguments : DataModel
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
            var value   = new Internal_DrawTextureArguments() { Pointer= p0 };

            value.ScreenRect                                = (Rect)GetInt32(new IntPtr(p + 0x010)); // 0x10 ScreenRect                  ( ModelEnumType Rect Rect Rect Int32 )
            value.SourceRect                                = (Rect)GetInt32(new IntPtr(p + 0x020)); // 0x20 SourceRect                  ( ModelEnumType Rect Rect Rect Int32 )
            value.LeftBorder                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 LeftBorder                  ( ModelPrimitiveType int int int Int32 )
            value.RightBorder                               = GetInt32(new IntPtr(p + 0x034)); // 0x34 RightBorder                 ( ModelPrimitiveType int int int Int32 )
            value.TopBorder                                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 TopBorder                   ( ModelPrimitiveType int int int Int32 )
            value.BottomBorder                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C BottomBorder                ( ModelPrimitiveType int int int Int32 )
            value.LeftBorderColor                           = (Color)GetInt32(new IntPtr(p + 0x040)); // 0x40 LeftBorderColor             ( ModelEnumType Color Color Color Int32 )
            value.RightBorderColor                          = (Color)GetInt32(new IntPtr(p + 0x050)); // 0x50 RightBorderColor            ( ModelEnumType Color Color Color Int32 )
            value.TopBorderColor                            = (Color)GetInt32(new IntPtr(p + 0x060)); // 0x60 TopBorderColor              ( ModelEnumType Color Color Color Int32 )
            value.BottomBorderColor                         = (Color)GetInt32(new IntPtr(p + 0x070)); // 0x70 BottomBorderColor           ( ModelEnumType Color Color Color Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x080)); // 0x80 Color                       ( ModelEnumType Color Color Color Int32 )
            value.BorderWidths                              = (Vector4)GetInt32(new IntPtr(p + 0x090)); // 0x90 BorderWidths                ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.CornerRadiuses                            = (Vector4)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 CornerRadiuses              ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SmoothCorners                             = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 SmoothCorners               ( ModelPrimitiveType bool bool bool Bool )
            value.Pass                                      = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 Pass                        ( ModelPrimitiveType int int int Int32 )
            value.Texture                                   = GetObject<Texture>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Texture.FromPointer); // 0xB8 Texture                     ( ModelClassType Texture Texture Texture Pointer )
            value.Mat                                       = GetObject<Material>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Material.FromPointer); // 0xC0 Mat                         ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
