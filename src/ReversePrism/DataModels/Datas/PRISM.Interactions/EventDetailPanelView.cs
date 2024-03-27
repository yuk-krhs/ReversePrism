using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EventDateText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 RemainTimeText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 RewardButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 RankingButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 MissionButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 ShopButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 MissionButtonBadge                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 EventPointText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 EventRankingText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 HighScoreRankingText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 EventStoryText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 EventStoryRemainPointText                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 EventBonusRateText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 StoryCompleteObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 HelpButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 098 UserRankingPanel                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 AggregationPanel                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 AggregationDateText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class EventDetailPanelView
    {
        public UITextMeshProUGUI?                       EventDateText                           { get; set; }
        public UITextMeshProUGUI?                       RemainTimeText                          { get; set; }
        public UIButton?                                RewardButton                            { get; set; }
        public UIButton?                                RankingButton                           { get; set; }
        public UIButton?                                MissionButton                           { get; set; }
        public UIButton?                                ShopButton                              { get; set; }
        public GameObject?                              MissionButtonBadge                      { get; set; }
        public UITextMeshProUGUI?                       EventPointText                          { get; set; }
        public UITextMeshProUGUI?                       EventRankingText                        { get; set; }
        public UITextMeshProUGUI?                       HighScoreRankingText                    { get; set; }
        public UITextMeshProUGUI?                       EventStoryText                          { get; set; }
        public UITextMeshProUGUI?                       EventStoryRemainPointText               { get; set; }
        public UITextMeshProUGUI?                       EventBonusRateText                      { get; set; }
        public GameObject?                              StoryCompleteObject                     { get; set; }
        public UIButton?                                HelpButton                              { get; set; }
        public GameObject?                              UserRankingPanel                        { get; set; }
        public GameObject?                              AggregationPanel                        { get; set; }
        public UITextMeshProUGUI?                       AggregationDateText                     { get; set; }

        public static EventDetailPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventDetailPanelView();

            value.EventDateText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB90AF50 0x20 EventDateText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RemainTimeText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB90AF70 0x28 RemainTimeText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardButton                              = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB90AF90 0x30 RewardButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RankingButton                             = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB90AFB0 0x38 RankingButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.MissionButton                             = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB90AFD0 0x40 MissionButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ShopButton                                = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB90AFF0 0x48 ShopButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.MissionButtonBadge                        = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB90B010 0x50 MissionButtonBadge          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EventPointText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB90B030 0x58 EventPointText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventRankingText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB90B050 0x60 EventRankingText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HighScoreRankingText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB90B070 0x68 HighScoreRankingText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventStoryText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB90B090 0x70 EventStoryText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventStoryRemainPointText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB90B0B0 0x78 EventStoryRemainPointText   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventBonusRateText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB90B0D0 0x80 EventBonusRateText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StoryCompleteObject                       = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB90B0F0 0x88 StoryCompleteObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.HelpButton                                = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB90B110 0x90 HelpButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UserRankingPanel                          = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB90B130 0x98 UserRankingPanel            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AggregationPanel                          = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB90B150 0xA0 AggregationPanel            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AggregationDateText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB90B170 0xA8 AggregationDateText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
