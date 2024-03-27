using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteSprite                           00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 028 UnfavoriteSprite                         00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 030 Icon                                     0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 038 Button                                   000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 IsFavorite                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ADVFavoriteButton
    {
        public Sprite?                                  FavoriteSprite                          { get; set; }
        public Sprite?                                  UnfavoriteSprite                        { get; set; }
        public UIImage?                                 Icon                                    { get; set; }
        public ButtonBase?                              Button                                  { get; set; }
        public bool                                     IsFavorite                              { get; set; }

        public static ADVFavoriteButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVFavoriteButton();

            value.FavoriteSprite                            = GetObject<Sprite>(new IntPtr(p + 0x020), ReversePrism.DataModels.Sprite.FromPointer); // 0270D5DD3F30 0x20 FavoriteSprite              ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.UnfavoriteSprite                          = GetObject<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0270D5DD3F50 0x28 UnfavoriteSprite            ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.Icon                                      = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0270D5DD3F70 0x30 Icon                        ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D5DD3F90 0x38 Button                      ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.IsFavorite                                = GetBool(new IntPtr(p + 0x040)); // 0270D5DD3FB0 0x40 IsFavorite                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
