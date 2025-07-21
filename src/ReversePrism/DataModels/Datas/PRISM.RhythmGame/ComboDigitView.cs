using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ComboNumberSprites                       ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 028 ComboNumberImages                        ModelClassListType SpriteRendererOrImage[] SpriteRendererOrImage[] List<SpriteRendererOrImage> Pointer
    public partial class ComboDigitView : DataModel
    {
        public List<Sprite>?                            ComboNumberSprites                      { get; set; }
        public List<SpriteRendererOrImage>?             ComboNumberImages                       { get; set; }

        public static ComboDigitView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComboDigitView() { Pointer= p0 };

            value.ComboNumberSprites                        = GetObjectList<Sprite>(new IntPtr(p + 0x020), ReversePrism.DataModels.Sprite.FromPointer); // 0x20 ComboNumberSprites          ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.ComboNumberImages                         = GetObjectList<SpriteRendererOrImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpriteRendererOrImage.FromPointer); // 0x28 ComboNumberImages           ( ModelClassListType SpriteRendererOrImage[] SpriteRendererOrImage[] List<SpriteRendererOrImage> Pointer )

            return value;
        }
    }
}
