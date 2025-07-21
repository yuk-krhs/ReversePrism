using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 IdolViews                                ModelClassListType IdolLevelUpIdolView[] IdolLevelUpIdolView[] List<IdolLevelUpIdolView> Pointer
    // 030 OkButton                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 StoryUnlockPopupCaller                   ModelClassType StoryUnlockPopupCaller StoryUnlockPopupCaller StoryUnlockPopupCaller Pointer
    // 040 Animator                                 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 048 AnimationCompletionSource                ModelClassType UniTaskCompletionSource UniTaskCompletionSource UniTaskCompletionSource Pointer
    public partial class IdolLevelUpAnimationPresenter : DataModel
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
            var value   = new IdolLevelUpAnimationPresenter() { Pointer= p0 };

            value.IdolViews                                 = GetObjectList<IdolLevelUpIdolView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolLevelUpIdolView.FromPointer); // 0x28 IdolViews                   ( ModelClassListType IdolLevelUpIdolView[] IdolLevelUpIdolView[] List<IdolLevelUpIdolView> Pointer )
            value.OkButton                                  = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 OkButton                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StoryUnlockPopupCaller                    = GetObject<StoryUnlockPopupCaller>(new IntPtr(p + 0x038), ReversePrism.DataModels.StoryUnlockPopupCaller.FromPointer); // 0x38 StoryUnlockPopupCaller      ( ModelClassType StoryUnlockPopupCaller StoryUnlockPopupCaller StoryUnlockPopupCaller Pointer )
            value.Animator                                  = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0x40 Animator                    ( ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.AnimationCompletionSource                 = GetObject<UniTaskCompletionSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.UniTaskCompletionSource.FromPointer); // 0x48 AnimationCompletionSource   ( ModelClassType UniTaskCompletionSource UniTaskCompletionSource UniTaskCompletionSource Pointer )

            return value;
        }
    }
}
