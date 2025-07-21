using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Image                                    ModelClassType UIImage UIImage UIImage Pointer
    // 028 LampSprites                              ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 030 LampAnimator                             ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 038 NewLampImage                             ModelClassType UIImage UIImage UIImage Pointer
    // 040 NewLampAnimator                          ModelClassType Animator Animator Animator Pointer
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

            value.Image                                     = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 Image                       ( ModelClassType UIImage UIImage UIImage Pointer )
            value.LampSprites                               = GetObjectList<Sprite>(new IntPtr(p + 0x028), ReversePrism.DataModels.Sprite.FromPointer); // 0x28 LampSprites                 ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.LampAnimator                              = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0x30 LampAnimator                ( ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.NewLampImage                              = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0x38 NewLampImage                ( ModelClassType UIImage UIImage UIImage Pointer )
            value.NewLampAnimator                           = GetObject<Animator>(new IntPtr(p + 0x040), ReversePrism.DataModels.Animator.FromPointer); // 0x40 NewLampAnimator             ( ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
