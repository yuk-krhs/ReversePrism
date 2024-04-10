using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 PanelViewObjects                         000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 WorkingDaysText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 FirstWorkDayText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ProduceIdolText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 EvolveCountText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 LimitBreakCountText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 CostumeCountText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 SupportIdolText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 MasterTrainingCountText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TotalFanText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 StoryReadTotalCountText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 StoryReadMainCountText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 StoryReadIdolCountText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 LivePlayTotalCountText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 LivePlayCountTexts                       000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0A0 FullComboTotalCountText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 FullComboCountTexts                      000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0B0 AllGreatTotalCountText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 AllGreatCountTexts                       000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0C0 AllPerfectTotalCountText                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 AllPerfectCountTexts                     000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0D0 ProduceFinishTotalCountText              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D8 ProduceFinishCountTexts                  000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0E0 UnitTotalRankCountText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E8 UnitRankCountDetailButton                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0F0 ProduceCardText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0F8 ProduceCardSummaryButton                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 100 EventListView                            0001865B1E60 ModelClassType ProfileEventArchiveListView ProfileEventArchiveListView ProfileEventArchiveListView Pointer
    // 108 SeasonListView                           0001865C1D40 ModelClassType ProfileSeasonArchiveListView ProfileSeasonArchiveListView ProfileSeasonArchiveListView Pointer
    // 110 onSeletedTab                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 118 onClickHistoryEventDetail                Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ProfileHistoryPanelView : DataModel
    {
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public List<GameObject>?                        PanelViewObjects                        { get; set; }
        public UITextMeshProUGUI?                       WorkingDaysText                         { get; set; }
        public UITextMeshProUGUI?                       FirstWorkDayText                        { get; set; }
        public UITextMeshProUGUI?                       ProduceIdolText                         { get; set; }
        public UITextMeshProUGUI?                       EvolveCountText                         { get; set; }
        public UITextMeshProUGUI?                       LimitBreakCountText                     { get; set; }
        public UITextMeshProUGUI?                       CostumeCountText                        { get; set; }
        public UITextMeshProUGUI?                       SupportIdolText                         { get; set; }
        public UITextMeshProUGUI?                       MasterTrainingCountText                 { get; set; }
        public UITextMeshProUGUI?                       TotalFanText                            { get; set; }
        public UITextMeshProUGUI?                       StoryReadTotalCountText                 { get; set; }
        public UITextMeshProUGUI?                       StoryReadMainCountText                  { get; set; }
        public UITextMeshProUGUI?                       StoryReadIdolCountText                  { get; set; }
        public UITextMeshProUGUI?                       LivePlayTotalCountText                  { get; set; }
        public List<UITextMeshProUGUI>?                 LivePlayCountTexts                      { get; set; }
        public UITextMeshProUGUI?                       FullComboTotalCountText                 { get; set; }
        public List<UITextMeshProUGUI>?                 FullComboCountTexts                     { get; set; }
        public UITextMeshProUGUI?                       AllGreatTotalCountText                  { get; set; }
        public List<UITextMeshProUGUI>?                 AllGreatCountTexts                      { get; set; }
        public UITextMeshProUGUI?                       AllPerfectTotalCountText                { get; set; }
        public List<UITextMeshProUGUI>?                 AllPerfectCountTexts                    { get; set; }
        public UITextMeshProUGUI?                       ProduceFinishTotalCountText             { get; set; }
        public List<UITextMeshProUGUI>?                 ProduceFinishCountTexts                 { get; set; }
        public UITextMeshProUGUI?                       UnitTotalRankCountText                  { get; set; }
        public UIButton?                                UnitRankCountDetailButton               { get; set; }
        public UITextMeshProUGUI?                       ProduceCardText                         { get; set; }
        public UIButton?                                ProduceCardSummaryButton                { get; set; }
        public ProfileEventArchiveListView?             EventListView                           { get; set; }
        public ProfileSeasonArchiveListView?            SeasonListView                          { get; set; }

        public static ProfileHistoryPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileHistoryPanelView() { Pointer= p0 };

            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466B76E4E0 0x20 UiTabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.PanelViewObjects                          = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466B76E500 0x28 PanelViewObjects            ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.WorkingDaysText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E520 0x30 WorkingDaysText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FirstWorkDayText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E540 0x38 FirstWorkDayText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProduceIdolText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E560 0x40 ProduceIdolText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EvolveCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E580 0x48 EvolveCountText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitBreakCountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E5A0 0x50 LimitBreakCountText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeCountText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E5C0 0x58 CostumeCountText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportIdolText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E5E0 0x60 SupportIdolText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MasterTrainingCountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E600 0x68 MasterTrainingCountText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalFanText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E620 0x70 TotalFanText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryReadTotalCountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E640 0x78 StoryReadTotalCountText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryReadMainCountText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E660 0x80 StoryReadMainCountText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryReadIdolCountText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E680 0x88 StoryReadIdolCountText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LivePlayTotalCountText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E6A0 0x90 LivePlayTotalCountText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LivePlayCountTexts                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E6C0 0x98 LivePlayCountTexts          ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.FullComboTotalCountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E6E0 0xA0 FullComboTotalCountText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FullComboCountTexts                       = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E700 0xA8 FullComboCountTexts         ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.AllGreatTotalCountText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E720 0xB0 AllGreatTotalCountText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AllGreatCountTexts                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E740 0xB8 AllGreatCountTexts          ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.AllPerfectTotalCountText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E760 0xC0 AllPerfectTotalCountText    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AllPerfectCountTexts                      = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E780 0xC8 AllPerfectCountTexts        ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ProduceFinishTotalCountText               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E7A0 0xD0 ProduceFinishTotalCountText ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProduceFinishCountTexts                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E7C0 0xD8 ProduceFinishCountTexts     ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.UnitTotalRankCountText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E7E0 0xE0 UnitTotalRankCountText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitRankCountDetailButton                 = GetObject<UIButton>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.UIButton.FromPointer); // 02466B76E800 0xE8 UnitRankCountDetailButton   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ProduceCardText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B76E820 0xF0 ProduceCardText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProduceCardSummaryButton                  = GetObject<UIButton>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.UIButton.FromPointer); // 02466B76E840 0xF8 ProduceCardSummaryButton    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.EventListView                             = GetObject<ProfileEventArchiveListView>(new IntPtr(p + 0x100), ReversePrism.DataModels.ProfileEventArchiveListView.FromPointer); // 02466B76E860 0x100 EventListView               ( 0001865B1E60 ModelClassType ProfileEventArchiveListView ProfileEventArchiveListView ProfileEventArchiveListView Pointer )
            value.SeasonListView                            = GetObject<ProfileSeasonArchiveListView>(new IntPtr(p + 0x108), ReversePrism.DataModels.ProfileSeasonArchiveListView.FromPointer); // 02466B76E880 0x108 SeasonListView              ( 0001865C1D40 ModelClassType ProfileSeasonArchiveListView ProfileSeasonArchiveListView ProfileSeasonArchiveListView Pointer )

            return value;
        }
    }
}
