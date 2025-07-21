using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ToggleDetailButton                       ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 068 HeaderView                               ModelClassType MusicRankingHeaderView MusicRankingHeaderView MusicRankingHeaderView Pointer
    // 070 IdolIcon                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 078 UserName                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 Score                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 ScoreDivisionLabels                      ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 090 AchievementIcons                         ModelClassListType SimpleAchievementIcon[] SimpleAchievementIcon[] List<SimpleAchievementIcon> Pointer
    // 098 MyselfCellBase                           ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 ExtendArea                               ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 TotalPower                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 UserIdolIcons                            ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer
    // 0B8 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 0C0 CurrentIconStatus                        ModelEnumType LiveIdolIconStatusDisplayType LiveIdolIconStatusDisplayType LiveIdolIconStatusDisplayType Int32
    public partial class MusicScoreRankingCell : DataModel
    {
        public ToggleButton?                            ToggleDetailButton                      { get; set; }
        public MusicRankingHeaderView?                  HeaderView                              { get; set; }
        public PFIdolIconView?                          IdolIcon                                { get; set; }
        public UITextMeshProUGUI?                       UserName                                { get; set; }
        public UITextMeshProUGUI?                       Score                                   { get; set; }
        public List<GameObject>?                        ScoreDivisionLabels                     { get; set; }
        public List<SimpleAchievementIcon>?             AchievementIcons                        { get; set; }
        public GameObject?                              MyselfCellBase                          { get; set; }
        public GameObject?                              ExtendArea                              { get; set; }
        public UITextMeshProUGUI?                       TotalPower                              { get; set; }
        public List<PFIdolIconView>?                    UserIdolIcons                           { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public LiveIdolIconStatusDisplayType            CurrentIconStatus                       { get; set; }

        public static MusicScoreRankingCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicScoreRankingCell() { Pointer= p0 };

            value.ToggleDetailButton                        = GetObject<ToggleButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x60 ToggleDetailButton          ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.HeaderView                                = GetObject<MusicRankingHeaderView>(new IntPtr(p + 0x068), ReversePrism.DataModels.MusicRankingHeaderView.FromPointer); // 0x68 HeaderView                  ( ModelClassType MusicRankingHeaderView MusicRankingHeaderView MusicRankingHeaderView Pointer )
            value.IdolIcon                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x070), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x70 IdolIcon                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.UserName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 UserName                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Score                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 Score                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScoreDivisionLabels                       = GetObjectList<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 ScoreDivisionLabels         ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.AchievementIcons                          = GetObjectList<SimpleAchievementIcon>(new IntPtr(p + 0x090), ReversePrism.DataModels.SimpleAchievementIcon.FromPointer); // 0x90 AchievementIcons            ( ModelClassListType SimpleAchievementIcon[] SimpleAchievementIcon[] List<SimpleAchievementIcon> Pointer )
            value.MyselfCellBase                            = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 MyselfCellBase              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExtendArea                                = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 ExtendArea                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TotalPower                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 TotalPower                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UserIdolIcons                             = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0xB0 UserIdolIcons               ( ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.CurrentIconStatus                         = (LiveIdolIconStatusDisplayType)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 CurrentIconStatus           ( ModelEnumType LiveIdolIconStatusDisplayType LiveIdolIconStatusDisplayType LiveIdolIconStatusDisplayType Int32 )

            return value;
        }
    }
}
