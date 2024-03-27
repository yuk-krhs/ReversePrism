using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Image                                    0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 LampSprites                              000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 030 LampAnimator                             00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 038 NewLampImage                             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 040 NewLampAnimator                          0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    public partial class MusicClearStatusLamp
    {
        public UIImage?                                 Image                                   { get; set; }
        public List<Sprite>?                            LampSprites                             { get; set; }
        public ParamRememberableAnimator?               LampAnimator                            { get; set; }
        public UIImage?                                 NewLampImage                            { get; set; }
        public Animator?                                NewLampAnimator                         { get; set; }

        public static MusicClearStatusLamp? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicClearStatusLamp();

            value.Image                                     = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270D512C220 0x20 Image                       ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.LampSprites                               = GetObjectList<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0270D512C240 0x28 LampSprites                 ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.LampAnimator                              = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0270D512C260 0x30 LampAnimator                ( 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.NewLampImage                              = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0270D512C280 0x38 NewLampImage                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.NewLampAnimator                           = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 0270D512C2A0 0x40 NewLampAnimator             ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
