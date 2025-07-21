using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ScheduleLevelUI                          ModelClassType GameObject GameObject GameObject Pointer
    // 030 ScheduleLevelText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ProduceProgressText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ProgressBar                              ModelClassType Image Image Image Pointer
    // 048 RewardPrefab                             ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer
    // 050 RewardViewArea                           ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 AnimatorWithEvent                        ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 060 TipsAnimatorEvent                        ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 068 WaitTipsAnimationFrame                   ModelPrimitiveType int int int Int32
    public partial class ProduceFailureResultRewardView : DataModel
    {
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public GameObject?                              ScheduleLevelUI                         { get; set; }
        public UITextMeshProUGUI?                       ScheduleLevelText                       { get; set; }
        public UITextMeshProUGUI?                       ProduceProgressText                     { get; set; }
        public Image?                                   ProgressBar                             { get; set; }
        public LiveResultRewardItem?                    RewardPrefab                            { get; set; }
        public RectTransform?                           RewardViewArea                          { get; set; }
        public AnimatorWithEvent?                       AnimatorWithEvent                       { get; set; }
        public AnimatorWithEvent?                       TipsAnimatorEvent                       { get; set; }
        public int                                      WaitTipsAnimationFrame                  { get; set; }

        public static ProduceFailureResultRewardView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFailureResultRewardView() { Pointer= p0 };

            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleLevelUI                           = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ScheduleLevelUI             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLevelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ScheduleLevelText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProduceProgressText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 ProduceProgressText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProgressBar                               = GetObject<Image>(new IntPtr(p + 0x040), ReversePrism.DataModels.Image.FromPointer); // 0x40 ProgressBar                 ( ModelClassType Image Image Image Pointer )
            value.RewardPrefab                              = GetObject<LiveResultRewardItem>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveResultRewardItem.FromPointer); // 0x48 RewardPrefab                ( ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer )
            value.RewardViewArea                            = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0x50 RewardViewArea              ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x058), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x58 AnimatorWithEvent           ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.TipsAnimatorEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x060), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x60 TipsAnimatorEvent           ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitTipsAnimationFrame                    = GetInt32(new IntPtr(p + 0x068)); // 0x68 WaitTipsAnimationFrame      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
