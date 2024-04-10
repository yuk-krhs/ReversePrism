using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CardEffectIconImageList                  000185D18558 ModelClassListType List`1<UIRawImage> List`1<UIRawImage> List<UIRawImage> Pointer
    public partial class PCardEffectIconAreaContent : DataModel
    {
        public List<UIRawImage>?                        CardEffectIconImageList                 { get; set; }

        public static PCardEffectIconAreaContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardEffectIconAreaContent() { Pointer= p0 };

            value.CardEffectIconImageList                   = GetObjectList<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 024665D90948 0x20 CardEffectIconImageList     ( 000185D18558 ModelClassListType List`1<UIRawImage> List`1<UIRawImage> List<UIRawImage> Pointer )

            return value;
        }
    }
}
