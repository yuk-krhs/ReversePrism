using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ToggleDetailButton                       000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 068 HeaderView                               000186669DB0 ModelClassType MusicRankingHeaderView MusicRankingHeaderView MusicRankingHeaderView Pointer
    // 070 IdolIcon                                 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 078 UserName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 Score                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 ScoreDivisionLabels                      000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 090 AchievementIcons                         000185B6F170 ModelClassListType AchievementIconView[] AchievementIconView[] List<AchievementIconView> Pointer
    // 098 MyselfCellBase                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 ExtendArea                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 TotalPower                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 UserIdolIcons                            000185B99CC0 ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer
    // 0B8 CurrentIconStatus                        000186557DF0 ModelEnumType LiveIdolIconStatusDisplayType LiveIdolIconStatusDisplayType LiveIdolIconStatusDisplayType Int32
    public partial class MusicScoreRankingCell
    {
        public ToggleButton?                            ToggleDetailButton                      { get; set; }
        public MusicRankingHeaderView?                  HeaderView                              { get; set; }
        public PFIdolIconView?                          IdolIcon                                { get; set; }
        public UITextMeshProUGUI?                       UserName                                { get; set; }
        public UITextMeshProUGUI?                       Score                                   { get; set; }
        public List<GameObject>?                        ScoreDivisionLabels                     { get; set; }
        public List<AchievementIconView>?               AchievementIcons                        { get; set; }
        public GameObject?                              MyselfCellBase                          { get; set; }
        public GameObject?                              ExtendArea                              { get; set; }
        public UITextMeshProUGUI?                       TotalPower                              { get; set; }
        public List<PFIdolIconView>?                    UserIdolIcons                           { get; set; }
        public LiveIdolIconStatusDisplayType            CurrentIconStatus                       { get; set; }

        public static MusicScoreRankingCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicScoreRankingCell();

            value.ToggleDetailButton                        = GetObject<ToggleButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DB3F6E40 0x60 ToggleDetailButton          ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.HeaderView                                = GetObject<MusicRankingHeaderView>(new IntPtr(p + 0x068), ReversePrism.DataModels.MusicRankingHeaderView.FromPointer); // 0270DB3F6E60 0x68 HeaderView                  ( 000186669DB0 ModelClassType MusicRankingHeaderView MusicRankingHeaderView MusicRankingHeaderView Pointer )
            value.IdolIcon                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x070), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DB3F6E80 0x70 IdolIcon                    ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.UserName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB3F6EA0 0x78 UserName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Score                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB3F6EC0 0x80 Score                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScoreDivisionLabels                       = GetObjectList<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3F6EE0 0x88 ScoreDivisionLabels         ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.AchievementIcons                          = GetObjectList<AchievementIconView>(new IntPtr(p + 0x090), ReversePrism.DataModels.AchievementIconView.FromPointer); // 0270DB3F6F00 0x90 AchievementIcons            ( 000185B6F170 ModelClassListType AchievementIconView[] AchievementIconView[] List<AchievementIconView> Pointer )
            value.MyselfCellBase                            = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3F6F20 0x98 MyselfCellBase              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExtendArea                                = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3F6F40 0xA0 ExtendArea                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TotalPower                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB3F6F60 0xA8 TotalPower                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UserIdolIcons                             = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DB3F6F80 0xB0 UserIdolIcons               ( 000185B99CC0 ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer )
            value.CurrentIconStatus                         = (LiveIdolIconStatusDisplayType)GetInt32(new IntPtr(p + 0x0B8)); // 0270DB3F6FA0 0xB8 CurrentIconStatus           ( 000186557DF0 ModelEnumType LiveIdolIconStatusDisplayType LiveIdolIconStatusDisplayType LiveIdolIconStatusDisplayType Int32 )

            return value;
        }
    }
}
