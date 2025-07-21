using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 IdolImageParent                          ModelClassType Transform Transform Transform Pointer
    // 040 RankText                                 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 048 UserNameText                             ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 050 StaminaText                              ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 058 IdolIconView                             ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 060 AchievementPanelView                     ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    public partial class PvpPlayerPanelView : DataModel
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
            var value   = new PvpPlayerPanelView() { Pointer= p0 };

            value.IdolImageParent                           = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 IdolImageParent             ( ModelClassType Transform Transform Transform Pointer )
            value.RankText                                  = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x40 RankText                    ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.UserNameText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x48 UserNameText                ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.StaminaText                               = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x50 StaminaText                 ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.IdolIconView                              = GetObject<PFIdolIconView>(new IntPtr(p + 0x058), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x58 IdolIconView                ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x060), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 0x60 AchievementPanelView        ( ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )

            return value;
        }
    }
}
