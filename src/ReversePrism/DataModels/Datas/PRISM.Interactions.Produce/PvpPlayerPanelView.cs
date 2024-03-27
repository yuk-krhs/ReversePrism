using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 IdolImageParent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 040 RankText                                 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 UserNameText                             0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 050 StaminaText                              0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 058 IdolIconView                             000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 060 AchievementPanelView                     000186676870 ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    public partial class PvpPlayerPanelView
    {
        public Transform?                               IdolImageParent                         { get; set; }
        public TextMeshProUGUI?                         RankText                                { get; set; }
        public TextMeshProUGUI?                         UserNameText                            { get; set; }
        public TextMeshProUGUI?                         StaminaText                             { get; set; }
        public PFIdolIconView?                          IdolIconView                            { get; set; }
        public AchievementPanelView?                    AchievementPanelView                    { get; set; }

        public static PvpPlayerPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPlayerPanelView();

            value.IdolImageParent                           = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0270DA14A228 0x38 IdolImageParent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.RankText                                  = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DA14A248 0x40 RankText                    ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.UserNameText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DA14A268 0x48 UserNameText                ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.StaminaText                               = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DA14A288 0x50 StaminaText                 ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.IdolIconView                              = GetObject<PFIdolIconView>(new IntPtr(p + 0x058), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DA14A2A8 0x58 IdolIconView                ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x060), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 0270DA14A2C8 0x60 AchievementPanelView        ( 000186676870 ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )

            return value;
        }
    }
}
