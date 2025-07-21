using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RankImage                                ModelClassType UIImage UIImage UIImage Pointer
    // 028 RewardItem                               ModelClassType RewardItem RewardItem RewardItem Pointer
    // 030 ConditionText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ClearAnimator                            ModelClassType Animator Animator Animator Pointer
    // 040 ResourceConfig                           ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer
    // 000 NotClearedAnimationHash                  int IL2CPP_TYPE_I4
    // 004 ClearedAnimationHash                     int IL2CPP_TYPE_I4
    // 008 NewClearAnimationHash                    int IL2CPP_TYPE_I4
    // 048 ClearStampAnimationHash                  ModelPrimitiveType int int int Int32
    public partial class MusicRewardInfoCell : DataModel
    {
        public UIImage?                                 RankImage                               { get; set; }
        public RewardItem?                              RewardItem                              { get; set; }
        public UITextMeshProUGUI?                       ConditionText                           { get; set; }
        public Animator?                                ClearAnimator                           { get; set; }
        public LiveUIResourceConfig?                    ResourceConfig                          { get; set; }
        public int                                      ClearStampAnimationHash                 { get; set; }

        public static MusicRewardInfoCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRewardInfoCell() { Pointer= p0 };

            value.RankImage                                 = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 RankImage                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.RewardItem                                = GetObject<RewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItem.FromPointer); // 0x28 RewardItem                  ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ConditionText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ConditionText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClearAnimator                             = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 0x38 ClearAnimator               ( ModelClassType Animator Animator Animator Pointer )
            value.ResourceConfig                            = GetObject<LiveUIResourceConfig>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveUIResourceConfig.FromPointer); // 0x40 ResourceConfig              ( ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer )
            value.ClearStampAnimationHash                   = GetInt32(new IntPtr(p + 0x048)); // 0x48 ClearStampAnimationHash     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
