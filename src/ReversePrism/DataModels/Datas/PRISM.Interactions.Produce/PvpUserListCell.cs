using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameText                                 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 068 RankText                                 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 070 FUnitIcon                                ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 078 AchievementPanelView                     ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    // 080 IdolIcons                                ModelClassListType List`1<PvpIdolIcon> List`1<PvpIdolIcon> List<PvpIdolIcon> Pointer
    public partial class PvpUserListCell : DataModel
    {
        public TextMeshProUGUI?                         NameText                                { get; set; }
        public TextMeshProUGUI?                         RankText                                { get; set; }
        public FUnitIconView?                           FUnitIcon                               { get; set; }
        public AchievementPanelView?                    AchievementPanelView                    { get; set; }
        public List<PvpIdolIcon>?                       IdolIcons                               { get; set; }

        public static PvpUserListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUserListCell() { Pointer= p0 };

            value.NameText                                  = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x60 NameText                    ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.RankText                                  = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x68 RankText                    ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.FUnitIcon                                 = GetObject<FUnitIconView>(new IntPtr(p + 0x070), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x70 FUnitIcon                   ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x078), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 0x78 AchievementPanelView        ( ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )
            value.IdolIcons                                 = GetObjectList<PvpIdolIcon>(new IntPtr(p + 0x080), ReversePrism.DataModels.PvpIdolIcon.FromPointer); // 0x80 IdolIcons                   ( ModelClassListType List`1<PvpIdolIcon> List`1<PvpIdolIcon> List<PvpIdolIcon> Pointer )

            return value;
        }
    }
}
