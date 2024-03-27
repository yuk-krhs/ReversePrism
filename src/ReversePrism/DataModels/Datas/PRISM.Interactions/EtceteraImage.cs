using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RawImage                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 RectImage                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 AttachedAspectRatioFitter                0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer
    public partial class EtceteraImage
    {
        public UIRawImage?                              RawImage                                { get; set; }
        public RectTransform?                           RectImage                               { get; set; }
        public UIButton?                                Btn                                     { get; set; }
        public AspectRatioFitter?                       AttachedAspectRatioFitter               { get; set; }

        public static EtceteraImage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtceteraImage();

            value.RawImage                                  = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA2A8EB8 0x20 RawImage                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.RectImage                                 = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA2A8ED8 0x28 RectImage                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2A8EF8 0x30 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AttachedAspectRatioFitter                 = GetObject<AspectRatioFitter>(new IntPtr(p + 0x038), ReversePrism.DataModels.AspectRatioFitter.FromPointer); // 0270DA2A8F18 0x38 AttachedAspectRatioFitter   ( 0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer )

            return value;
        }
    }
}
