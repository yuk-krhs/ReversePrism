using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 3C8 M_ScaleMode                              0001866C1850 ModelEnumType ScaleMode ScaleMode ScaleMode Int32
    // 3D0 M_Image                                  00018664CFB0 ModelClassType Texture Texture Texture Pointer
    // 3D8 M_Sprite                                 00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 3E0 M_VectorImage                            0001866B01A0 ModelClassType VectorImage VectorImage VectorImage Pointer
    // 3E8 M_UV                                     00018664F620 ModelEnumType Rect Rect Rect Int32
    // 3F8 M_TintColor                              0001865AA8E0 ModelEnumType Color Color Color Int32
    // 408 M_ImageIsInline                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 409 M_ScaleModeIsInline                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 40A M_TintColorIsInline                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 s_ImageProperty                          CustomStyleProperty`1<Texture2D> IL2CPP_TYPE_GENERICINST
    // 010 s_SpriteProperty                         CustomStyleProperty`1<Sprite> IL2CPP_TYPE_GENERICINST
    // 018 s_VectorImageProperty                    CustomStyleProperty`1<VectorImage> IL2CPP_TYPE_GENERICINST
    // 020 s_ScaleModeProperty                      CustomStyleProperty`1<string> IL2CPP_TYPE_GENERICINST
    // 028 s_TintColorProperty                      CustomStyleProperty`1<Color> IL2CPP_TYPE_GENERICINST
    public partial class Image
    {
        public ScaleMode                                M_ScaleMode                             { get; set; }
        public Texture?                                 M_Image                                 { get; set; }
        public Sprite?                                  M_Sprite                                { get; set; }
        public VectorImage?                             M_VectorImage                           { get; set; }
        public Rect                                     M_UV                                    { get; set; }
        public Color                                    M_TintColor                             { get; set; }
        public bool                                     M_ImageIsInline                         { get; set; }
        public bool                                     M_ScaleModeIsInline                     { get; set; }
        public bool                                     M_TintColorIsInline                     { get; set; }

        public static Image? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Image();

            value.M_ScaleMode                               = (ScaleMode)GetInt32(new IntPtr(p + 0x3C8)); // 0270067154D0 0x3C8 M_ScaleMode                 ( 0001866C1850 ModelEnumType ScaleMode ScaleMode ScaleMode Int32 )
            value.M_Image                                   = GetObject<Texture>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.Texture.FromPointer); // 0270067154F0 0x3D0 M_Image                     ( 00018664CFB0 ModelClassType Texture Texture Texture Pointer )
            value.M_Sprite                                  = GetObject<Sprite>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.Sprite.FromPointer); // 027006715510 0x3D8 M_Sprite                    ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.M_VectorImage                             = GetObject<VectorImage>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.VectorImage.FromPointer); // 027006715530 0x3E0 M_VectorImage               ( 0001866B01A0 ModelClassType VectorImage VectorImage VectorImage Pointer )
            value.M_UV                                      = (Rect)GetInt32(new IntPtr(p + 0x3E8)); // 027006715550 0x3E8 M_UV                        ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.M_TintColor                               = (Color)GetInt32(new IntPtr(p + 0x3F8)); // 027006715570 0x3F8 M_TintColor                 ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_ImageIsInline                           = GetBool(new IntPtr(p + 0x408)); // 027006715590 0x408 M_ImageIsInline             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_ScaleModeIsInline                       = GetBool(new IntPtr(p + 0x409)); // 0270067155B0 0x409 M_ScaleModeIsInline         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TintColorIsInline                       = GetBool(new IntPtr(p + 0x40A)); // 0270067155D0 0x40A M_TintColorIsInline         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
