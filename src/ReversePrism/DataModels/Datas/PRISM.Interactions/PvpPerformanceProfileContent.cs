using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NameText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 AchievementArea                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 AchievementIconPrefab                    000186675550 ModelClassType AchievementIcon AchievementIcon AchievementIcon Pointer
    // 038 RankingText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BgCharaArea                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 FrCharaArea                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class PvpPerformanceProfileContent : DataModel
    {
        public UITextMeshProUGUI?                       NameText                                { get; set; }
        public Transform?                               AchievementArea                         { get; set; }
        public AchievementIcon?                         AchievementIconPrefab                   { get; set; }
        public UITextMeshProUGUI?                       RankingText                             { get; set; }
        public Transform?                               BgCharaArea                             { get; set; }
        public Transform?                               FrCharaArea                             { get; set; }

        public static PvpPerformanceProfileContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPerformanceProfileContent() { Pointer= p0 };

            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BF85640 0x20 NameText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AchievementArea                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466BF85660 0x28 AchievementArea             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.AchievementIconPrefab                     = GetObject<AchievementIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.AchievementIcon.FromPointer); // 02466BF85680 0x30 AchievementIconPrefab       ( 000186675550 ModelClassType AchievementIcon AchievementIcon AchievementIcon Pointer )
            value.RankingText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BF856A0 0x38 RankingText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BgCharaArea                               = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 02466BF856C0 0x40 BgCharaArea                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.FrCharaArea                               = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 02466BF856E0 0x48 FrCharaArea                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
