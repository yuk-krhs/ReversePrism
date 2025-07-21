using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     ModelClassType Image Image Image Pointer
    // 028 IconSprites                              ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    public partial class LiveEventRankingGradeIcon : DataModel
    {
        public Image?                                   Icon                                    { get; set; }
        public List<Sprite>?                            IconSprites                             { get; set; }

        public static LiveEventRankingGradeIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingGradeIcon() { Pointer= p0 };

            value.Icon                                      = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 Icon                        ( ModelClassType Image Image Image Pointer )
            value.IconSprites                               = GetObjectList<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0x28 IconSprites                 ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )

            return value;
        }
    }
}
