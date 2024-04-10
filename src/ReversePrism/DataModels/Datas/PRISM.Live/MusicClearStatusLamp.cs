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
    public partial class MusicClearStatusLamp : DataModel
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
            var value   = new MusicClearStatusLamp() { Pointer= p0 };

            value.Image                                     = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 02466519F778 0x20 Image                       ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.LampSprites                               = GetObjectList<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 02466519F798 0x28 LampSprites                 ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.LampAnimator                              = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 02466519F7B8 0x30 LampAnimator                ( 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.NewLampImage                              = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 02466519F7D8 0x38 NewLampImage                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.NewLampAnimator                           = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 02466519F7F8 0x40 NewLampAnimator             ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
