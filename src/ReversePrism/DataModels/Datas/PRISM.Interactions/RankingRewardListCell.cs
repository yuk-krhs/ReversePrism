using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 RewardIconContainer                      0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 050 RewardIconBase                           00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 058 AchievementIconBase                      00018660E280 ModelClassType RankingRewardAchievementIcon RankingRewardAchievementIcon RankingRewardAchievementIcon Pointer
    // 060 AchievementDetailPopupCaller             000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer
    public partial class RankingRewardListCell
    {
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public Transform?                               RewardIconContainer                     { get; set; }
        public RewardItem?                              RewardIconBase                          { get; set; }
        public RankingRewardAchievementIcon?            AchievementIconBase                     { get; set; }
        public AchievementDetailPopupCaller?            AchievementDetailPopupCaller            { get; set; }

        public static RankingRewardListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankingRewardListCell();

            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB57B7C0 0x40 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardIconContainer                       = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0270DB57B7E0 0x48 RewardIconContainer         ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.RewardIconBase                            = GetObject<RewardItem>(new IntPtr(p + 0x050), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB57B800 0x50 RewardIconBase              ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.AchievementIconBase                       = GetObject<RankingRewardAchievementIcon>(new IntPtr(p + 0x058), ReversePrism.DataModels.RankingRewardAchievementIcon.FromPointer); // 0270DB57B820 0x58 AchievementIconBase         ( 00018660E280 ModelClassType RankingRewardAchievementIcon RankingRewardAchievementIcon RankingRewardAchievementIcon Pointer )
            value.AchievementDetailPopupCaller              = GetObject<AchievementDetailPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.AchievementDetailPopupCaller.FromPointer); // 0270DB57B840 0x60 AchievementDetailPopupCaller ( 000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer )

            return value;
        }
    }
}
