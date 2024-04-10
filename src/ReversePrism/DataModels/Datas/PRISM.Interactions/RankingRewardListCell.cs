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
    public partial class RankingRewardListCell : DataModel
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
            var value   = new RankingRewardListCell() { Pointer= p0 };

            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B5FF8A8 0x40 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardIconContainer                       = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 02466B5FF8C8 0x48 RewardIconContainer         ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.RewardIconBase                            = GetObject<RewardItem>(new IntPtr(p + 0x050), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B5FF8E8 0x50 RewardIconBase              ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.AchievementIconBase                       = GetObject<RankingRewardAchievementIcon>(new IntPtr(p + 0x058), ReversePrism.DataModels.RankingRewardAchievementIcon.FromPointer); // 02466B5FF908 0x58 AchievementIconBase         ( 00018660E280 ModelClassType RankingRewardAchievementIcon RankingRewardAchievementIcon RankingRewardAchievementIcon Pointer )
            value.AchievementDetailPopupCaller              = GetObject<AchievementDetailPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.AchievementDetailPopupCaller.FromPointer); // 02466B5FF928 0x60 AchievementDetailPopupCaller ( 000186674050 ModelClassType AchievementDetailPopupCaller AchievementDetailPopupCaller AchievementDetailPopupCaller Pointer )

            return value;
        }
    }
}
