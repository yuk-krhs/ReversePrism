using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 rateTypeObjects                          SerializableNestedArray`1<GameObject>[] IL2CPP_TYPE_SZARRAY
    // 030 BeforeViews                              000185B97BA0 ModelClassListType MusicRateView[] MusicRateView[] List<MusicRateView> Pointer
    // 038 AfterViews                               000185B97BA0 ModelClassListType MusicRateView[] MusicRateView[] List<MusicRateView> Pointer
    // 040 Gradients                                000185B82DC0 ModelClassListType Gradient[] Gradient[] List<Gradient> Pointer
    // 048 BeforeBackground                         0001866E9F60 ModelClassType UIGradient UIGradient UIGradient Pointer
    // 050 AfterBackground                          0001866E9F60 ModelClassType UIGradient UIGradient UIGradient Pointer
    // 058 RateText                                 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 060 Animator                                 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer
    // 068 BeforeStarAnimators                      000185B9A3E0 ModelClassListType ParamRememberableAnimator[] ParamRememberableAnimator[] List<ParamRememberableAnimator> Pointer
    // 070 AfterStarAnimators                       000185B9A3E0 ModelClassListType ParamRememberableAnimator[] ParamRememberableAnimator[] List<ParamRememberableAnimator> Pointer
    // 078 AfterStarEffects                         000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 080 RateTriggerAnimators                     000185B9A3E0 ModelClassListType ParamRememberableAnimator[] ParamRememberableAnimator[] List<ParamRememberableAnimator> Pointer
    // 088 OkButton                                 0001865140C0 ModelClassType Button Button Button Pointer
    public partial class RatingGradeUpAnimationPresenter : DataModel
    {
        public List<MusicRateView>?                     BeforeViews                             { get; set; }
        public List<MusicRateView>?                     AfterViews                              { get; set; }
        public List<Gradient>?                          Gradients                               { get; set; }
        public UIGradient?                              BeforeBackground                        { get; set; }
        public UIGradient?                              AfterBackground                         { get; set; }
        public TextMeshProUGUI?                         RateText                                { get; set; }
        public ParamRememberableAnimator?               Animator                                { get; set; }
        public List<ParamRememberableAnimator>?         BeforeStarAnimators                     { get; set; }
        public List<ParamRememberableAnimator>?         AfterStarAnimators                      { get; set; }
        public List<GameObject>?                        AfterStarEffects                        { get; set; }
        public List<ParamRememberableAnimator>?         RateTriggerAnimators                    { get; set; }
        public Button?                                  OkButton                                { get; set; }

        public static RatingGradeUpAnimationPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RatingGradeUpAnimationPresenter() { Pointer= p0 };

            value.BeforeViews                               = GetObjectList<MusicRateView>(new IntPtr(p + 0x030), ReversePrism.DataModels.MusicRateView.FromPointer); // 0246652C2D48 0x30 BeforeViews                 ( 000185B97BA0 ModelClassListType MusicRateView[] MusicRateView[] List<MusicRateView> Pointer )
            value.AfterViews                                = GetObjectList<MusicRateView>(new IntPtr(p + 0x038), ReversePrism.DataModels.MusicRateView.FromPointer); // 0246652C2D68 0x38 AfterViews                  ( 000185B97BA0 ModelClassListType MusicRateView[] MusicRateView[] List<MusicRateView> Pointer )
            value.Gradients                                 = GetObjectList<Gradient>(new IntPtr(p + 0x040), ReversePrism.DataModels.Gradient.FromPointer); // 0246652C2D88 0x40 Gradients                   ( 000185B82DC0 ModelClassListType Gradient[] Gradient[] List<Gradient> Pointer )
            value.BeforeBackground                          = GetObject<UIGradient>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIGradient.FromPointer); // 0246652C2DA8 0x48 BeforeBackground            ( 0001866E9F60 ModelClassType UIGradient UIGradient UIGradient Pointer )
            value.AfterBackground                           = GetObject<UIGradient>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIGradient.FromPointer); // 0246652C2DC8 0x50 AfterBackground             ( 0001866E9F60 ModelClassType UIGradient UIGradient UIGradient Pointer )
            value.RateText                                  = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0246652C2DE8 0x58 RateText                    ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<ParamRememberableAnimator>(new IntPtr(p + 0x060), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0246652C2E08 0x60 Animator                    ( 00018671A280 ModelClassType ParamRememberableAnimator ParamRememberableAnimator ParamRememberableAnimator Pointer )
            value.BeforeStarAnimators                       = GetObjectList<ParamRememberableAnimator>(new IntPtr(p + 0x068), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0246652C2E28 0x68 BeforeStarAnimators         ( 000185B9A3E0 ModelClassListType ParamRememberableAnimator[] ParamRememberableAnimator[] List<ParamRememberableAnimator> Pointer )
            value.AfterStarAnimators                        = GetObjectList<ParamRememberableAnimator>(new IntPtr(p + 0x070), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0246652C2E48 0x70 AfterStarAnimators          ( 000185B9A3E0 ModelClassListType ParamRememberableAnimator[] ParamRememberableAnimator[] List<ParamRememberableAnimator> Pointer )
            value.AfterStarEffects                          = GetObjectList<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0246652C2E68 0x78 AfterStarEffects            ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.RateTriggerAnimators                      = GetObjectList<ParamRememberableAnimator>(new IntPtr(p + 0x080), ReversePrism.DataModels.ParamRememberableAnimator.FromPointer); // 0246652C2E88 0x80 RateTriggerAnimators        ( 000185B9A3E0 ModelClassListType ParamRememberableAnimator[] ParamRememberableAnimator[] List<ParamRememberableAnimator> Pointer )
            value.OkButton                                  = GetObject<Button>(new IntPtr(p + 0x088), ReversePrism.DataModels.Button.FromPointer); // 0246652C2EA8 0x88 OkButton                    ( 0001865140C0 ModelClassType Button Button Button Pointer )

            return value;
        }
    }
}
