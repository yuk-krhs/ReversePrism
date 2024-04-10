using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Image                                    0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 018 Sprites                                  000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    public partial class LevelImage : DataModel
    {
        public UIImage?                                 Image                                   { get; set; }
        public List<Sprite>?                            Sprites                                 { get; set; }

        public static LevelImage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LevelImage() { Pointer= p0 };

            value.Image                                     = GetObject<UIImage>(new IntPtr(p + 0x010), ReversePrism.DataModels.UIImage.FromPointer); // 0246651A7E80 0x10 Image                       ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Sprites                                   = GetObjectList<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0246651A7EA0 0x18 Sprites                     ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )

            return value;
        }
    }
}
