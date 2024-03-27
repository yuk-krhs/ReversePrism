using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 IdolViews                                000185B8A920 ModelClassListType IdolLevelUpIdolView[] IdolLevelUpIdolView[] List<IdolLevelUpIdolView> Pointer
    // 030 OkButton                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 StoryUnlockPopupCaller                   0001865B1490 ModelClassType StoryUnlockPopupCaller StoryUnlockPopupCaller StoryUnlockPopupCaller Pointer
    // 040 Animator                                 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 048 AnimationCompletionSource                000186704DA0 ModelClassType UniTaskCompletionSource UniTaskCompletionSource UniTaskCompletionSource Pointer
    public partial class IdolLevelUpAnimationPresenter
    {
        public List<IdolLevelUpIdolView>?               IdolViews                               { get; set; }
        public ButtonBase?                              OkButton                                { get; set; }
        public StoryUnlockPopupCaller?                  StoryUnlockPopupCaller                  { get; set; }
        public ParamRememberableAnimator?               Animator                                { get; set; }
        public UniTaskCompletionSource?                 AnimationCompletionSource               { get; set; }

        public static IdolLevelUpAnimationPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolLevelUpAnimationPresenter();

            value.IdolViews                                 = GetObjectList<IdolLevelUpIdolView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolLevelUpIdolView.FromPointer); // 0270D4C52710 0x28 IdolViews                   ( 000185B8A920 ModelClassListType IdolLevelUpIdolView[] IdolLevelUpIdolView[] List<IdolLevelUpIdolView> Pointer )
            value.OkButton                                  = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D4C52730 0x30 OkButton                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StoryUnlockPopupCaller                    = GetObject<StoryUnlockPopupCaller>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryUnlockPopupCaller.FromPointer); // 0270D4C52750 0x38 StoryUnlockPopupCaller      ( 0001865B1490 ModelClassType StoryUnlockPopupCaller StoryUnlockPopupCaller StoryUnlockPopupCaller Pointer )
            value.Animator                                  = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0270D4C52770 0x40 Animator                    ( 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.AnimationCompletionSource                 = GetObject<UniTaskCompletionSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.UniTaskCompletionSource.FromPointer); // 0270D4C52790 0x48 AnimationCompletionSource   ( 000186704DA0 ModelClassType UniTaskCompletionSource UniTaskCompletionSource UniTaskCompletionSource Pointer )

            return value;
        }
    }
}
