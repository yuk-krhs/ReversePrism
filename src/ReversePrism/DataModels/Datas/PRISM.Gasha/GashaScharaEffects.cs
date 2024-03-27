using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AniSchara                                0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 028 ImgBase                                  0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 AspectRatioFitterBase                    0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer
    // 038 Img                                      0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 040 AspectRatioFitter                        0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer
    // 048 AspectRatioFitterLight                   0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer
    public partial class GashaScharaEffects
    {
        public Animator?                                AniSchara                               { get; set; }
        public UIRawImage?                              ImgBase                                 { get; set; }
        public AspectRatioFitter?                       AspectRatioFitterBase                   { get; set; }
        public UIRawImage?                              Img                                     { get; set; }
        public AspectRatioFitter?                       AspectRatioFitter                       { get; set; }
        public AspectRatioFitter?                       AspectRatioFitterLight                  { get; set; }

        public static GashaScharaEffects? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaScharaEffects();

            value.AniSchara                                 = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0270D53B7D68 0x20 AniSchara                   ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ImgBase                                   = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D53B7D88 0x28 ImgBase                     ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.AspectRatioFitterBase                     = GetObject<AspectRatioFitter>(new IntPtr(p + 0x030), ReversePrism.DataModels.AspectRatioFitter.FromPointer); // 0270D53B7DA8 0x30 AspectRatioFitterBase       ( 0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer )
            value.Img                                       = GetObject<UIRawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D53B7DC8 0x38 Img                         ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.AspectRatioFitter                         = GetObject<AspectRatioFitter>(new IntPtr(p + 0x040), ReversePrism.DataModels.AspectRatioFitter.FromPointer); // 0270D53B7DE8 0x40 AspectRatioFitter           ( 0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer )
            value.AspectRatioFitterLight                    = GetObject<AspectRatioFitter>(new IntPtr(p + 0x048), ReversePrism.DataModels.AspectRatioFitter.FromPointer); // 0270D53B7E08 0x48 AspectRatioFitterLight      ( 0001866DD380 ModelClassType AspectRatioFitter AspectRatioFitter AspectRatioFitter Pointer )

            return value;
        }
    }
}
