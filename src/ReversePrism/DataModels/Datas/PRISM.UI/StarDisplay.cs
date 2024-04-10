using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Stars                                    000185CA7248 ModelClassListType StarView[] StarView[] List<StarView> Pointer
    // 028 ImgStar                                  00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 030 ImgBlankStar                             00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 038 ImgMaxStar                               00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    public partial class StarDisplay : DataModel
    {
        public List<StarView>?                          Stars                                   { get; set; }
        public Sprite?                                  ImgStar                                 { get; set; }
        public Sprite?                                  ImgBlankStar                            { get; set; }
        public Sprite?                                  ImgMaxStar                              { get; set; }

        public static StarDisplay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StarDisplay() { Pointer= p0 };

            value.Stars                                     = GetObjectList<StarView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StarView.FromPointer); // 0245A5B0A360 0x20 Stars                       ( 000185CA7248 ModelClassListType StarView[] StarView[] List<StarView> Pointer )
            value.ImgStar                                   = GetObject<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0245A5B0A380 0x28 ImgStar                     ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.ImgBlankStar                              = GetObject<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 0245A5B0A3A0 0x30 ImgBlankStar                ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.ImgMaxStar                                = GetObject<Sprite>(new IntPtr(p + 0x038), ReversePrism.DataModels.Sprite.FromPointer); // 0245A5B0A3C0 0x38 ImgMaxStar                  ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
