using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 RewardIconContainer                      ModelClassType Transform Transform Transform Pointer
    // 050 RewardIconBase                           ModelClassType RewardItem RewardItem RewardItem Pointer
    // 058 AchievementIconBase                      ModelClassType SimpleAchievementIcon SimpleAchievementIcon SimpleAchievementIcon Pointer
    // 060 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class RankingRewardListCell : DataModel
    {
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public Transform?                               RewardIconContainer                     { get; set; }
        public RewardItem?                              RewardIconBase                          { get; set; }
        public SimpleAchievementIcon?                   AchievementIconBase                     { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static RankingRewardListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankingRewardListCell() { Pointer= p0 };

            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardIconContainer                       = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0x48 RewardIconContainer         ( ModelClassType Transform Transform Transform Pointer )
            value.RewardIconBase                            = GetObject<RewardItem>(new IntPtr(p + 0x050), ReversePrism.DataModels.RewardItem.FromPointer); // 0x50 RewardIconBase              ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.AchievementIconBase                       = GetObject<SimpleAchievementIcon>(new IntPtr(p + 0x058), ReversePrism.DataModels.SimpleAchievementIcon.FromPointer); // 0x58 AchievementIconBase         ( ModelClassType SimpleAchievementIcon SimpleAchievementIcon SimpleAchievementIcon Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x060)); // 0x60 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
