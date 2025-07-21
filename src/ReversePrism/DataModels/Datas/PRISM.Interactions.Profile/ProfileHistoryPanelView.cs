using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 PanelViewObjects                         ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 WorkingDaysText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 FirstWorkDayText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ProduceIdolText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 EvolveCountText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 LimitBreakCountText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 CostumeCountText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 SupportIdolText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 MasterTrainingCountText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TotalFanText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 StoryReadTotalCountText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 StoryReadMainCountText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 StoryReadIdolCountText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 LivePlayCountView                        ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 098 FullComboCountView                       ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 0A0 AllGreatCountView                        ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 0A8 AllPerfectCountView                      ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 0B0 AllShinyCountView                        ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer
    // 0B8 ProduceFinishTotalCountText              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 ProduceFinishCountTexts                  ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0C8 UnitTotalRankCountText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 UnitRankCountDetailButton                ModelClassType UIButton UIButton UIButton Pointer
    // 0D8 ProduceCardText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E0 ProduceCardSummaryButton                 ModelClassType UIButton UIButton UIButton Pointer
    // 0E8 EventListView                            ModelClassType ProfileEventArchiveListView ProfileEventArchiveListView ProfileEventArchiveListView Pointer
    // 0F0 SeasonListView                           ModelClassType ProfileSeasonArchiveListView ProfileSeasonArchiveListView ProfileSeasonArchiveListView Pointer
    // 0F8 onSeletedTab                             Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 100 onClickHistoryEventDetail                Subject`1<int> IL2CPP_TYPE_GENERICINST
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
        public ProfileLiveCountView?                    LivePlayCountView                       { get; set; }
        public ProfileLiveCountView?                    FullComboCountView                      { get; set; }
        public ProfileLiveCountView?                    AllGreatCountView                       { get; set; }
        public ProfileLiveCountView?                    AllPerfectCountView                     { get; set; }
        public ProfileLiveCountView?                    AllShinyCountView                       { get; set; }
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

            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.PanelViewObjects                          = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 PanelViewObjects            ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.WorkingDaysText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 WorkingDaysText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FirstWorkDayText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 FirstWorkDayText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProduceIdolText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 ProduceIdolText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EvolveCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 EvolveCountText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitBreakCountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 LimitBreakCountText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeCountText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 CostumeCountText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportIdolText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 SupportIdolText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MasterTrainingCountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 MasterTrainingCountText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalFanText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TotalFanText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryReadTotalCountText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 StoryReadTotalCountText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryReadMainCountText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 StoryReadMainCountText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryReadIdolCountText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 StoryReadIdolCountText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LivePlayCountView                         = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x90 LivePlayCountView           ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.FullComboCountView                        = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0x98 FullComboCountView          ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.AllGreatCountView                         = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0xA0 AllGreatCountView           ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.AllPerfectCountView                       = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0xA8 AllPerfectCountView         ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.AllShinyCountView                         = GetObject<ProfileLiveCountView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ProfileLiveCountView.FromPointer); // 0xB0 AllShinyCountView           ( ModelClassType ProfileLiveCountView ProfileLiveCountView ProfileLiveCountView Pointer )
            value.ProduceFinishTotalCountText               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB8 ProduceFinishTotalCountText ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProduceFinishCountTexts                   = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC0 ProduceFinishCountTexts     ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.UnitTotalRankCountText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC8 UnitTotalRankCountText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitRankCountDetailButton                 = GetObject<UIButton>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UIButton.FromPointer); // 0xD0 UnitRankCountDetailButton   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ProduceCardText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xD8 ProduceCardText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProduceCardSummaryButton                  = GetObject<UIButton>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UIButton.FromPointer); // 0xE0 ProduceCardSummaryButton    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EventListView                             = GetObject<ProfileEventArchiveListView>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ProfileEventArchiveListView.FromPointer); // 0xE8 EventListView               ( ModelClassType ProfileEventArchiveListView ProfileEventArchiveListView ProfileEventArchiveListView Pointer )
            value.SeasonListView                            = GetObject<ProfileSeasonArchiveListView>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ProfileSeasonArchiveListView.FromPointer); // 0xF0 SeasonListView              ( ModelClassType ProfileSeasonArchiveListView ProfileSeasonArchiveListView ProfileSeasonArchiveListView Pointer )

            return value;
        }
    }
}
