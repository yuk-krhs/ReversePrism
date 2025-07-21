using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 RawImage                                 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    public partial class HowToPlayCarouselCell : DataModel
    {
        public UIRawImage?                              RawImage                                { get; set; }

        public static HowToPlayCarouselCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HowToPlayCarouselCell() { Pointer= p0 };

            value.RawImage                                  = GetObject<UIRawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x38 RawImage                    ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )

            return value;
        }
    }
}
