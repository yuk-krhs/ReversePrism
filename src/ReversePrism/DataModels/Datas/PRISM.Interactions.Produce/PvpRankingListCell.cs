using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameText                                 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 068 FUnitIcon                                00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 070 AchievementPanelView                     000186676870 ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer
    // 078 IdolIcons                                000185CFEC88 ModelClassListType List`1<PvpIdolIcon> List`1<PvpIdolIcon> List<PvpIdolIcon> Pointer
    // 080 Rank1st                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 Rank2nd                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 Rank3rd                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 098 Rank1d                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 Rank3d                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 Rank4dover                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 RankTexts                                000185D13838 ModelClassListType List`1<TextMeshProUGUI> List`1<TextMeshProUGUI> List<TextMeshProUGUI> Pointer
    public partial class PvpRankingListCell : DataModel
    {
        public TextMeshProUGUI?                         NameText                                { get; set; }
        public FUnitIconView?                           FUnitIcon                               { get; set; }
        public AchievementPanelView?                    AchievementPanelView                    { get; set; }
        public List<PvpIdolIcon>?                       IdolIcons                               { get; set; }
        public GameObject?                              Rank1st                                 { get; set; }
        public GameObject?                              Rank2nd                                 { get; set; }
        public GameObject?                              Rank3rd                                 { get; set; }
        public GameObject?                              Rank1d                                  { get; set; }
        public GameObject?                              Rank3d                                  { get; set; }
        public GameObject?                              Rank4dover                              { get; set; }
        public List<TextMeshProUGUI>?                   RankTexts                               { get; set; }

        public static PvpRankingListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpRankingListCell() { Pointer= p0 };

            value.NameText                                  = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 02466A268F58 0x60 NameText                    ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.FUnitIcon                                 = GetObject<FUnitIconView>(new IntPtr(p + 0x068), ReversePrism.DataModels.FUnitIconView.FromPointer); // 02466A268F78 0x68 FUnitIcon                   ( 00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.AchievementPanelView                      = GetObject<AchievementPanelView>(new IntPtr(p + 0x070), ReversePrism.DataModels.AchievementPanelView.FromPointer); // 02466A268F98 0x70 AchievementPanelView        ( 000186676870 ModelClassType AchievementPanelView AchievementPanelView AchievementPanelView Pointer )
            value.IdolIcons                                 = GetObjectList<PvpIdolIcon>(new IntPtr(p + 0x078), ReversePrism.DataModels.PvpIdolIcon.FromPointer); // 02466A268FB8 0x78 IdolIcons                   ( 000185CFEC88 ModelClassListType List`1<PvpIdolIcon> List`1<PvpIdolIcon> List<PvpIdolIcon> Pointer )
            value.Rank1st                                   = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 02466A268FD8 0x80 Rank1st                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Rank2nd                                   = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 02466A268FF8 0x88 Rank2nd                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Rank3rd                                   = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 02466A269018 0x90 Rank3rd                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Rank1d                                    = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 02466A269038 0x98 Rank1d                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Rank3d                                    = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 02466A269058 0xA0 Rank3d                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Rank4dover                                = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 02466A269078 0xA8 Rank4dover                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RankTexts                                 = GetObjectList<TextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 02466A269098 0xB0 RankTexts                   ( 000185D13838 ModelClassListType List`1<TextMeshProUGUI> List`1<TextMeshProUGUI> List<TextMeshProUGUI> Pointer )

            return value;
        }
    }
}
