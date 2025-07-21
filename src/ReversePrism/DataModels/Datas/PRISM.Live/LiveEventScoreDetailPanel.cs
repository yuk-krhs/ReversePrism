using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScoreRankIcon                            ModelClassType ScoreRankIcon ScoreRankIcon ScoreRankIcon Pointer
    // 028 ScoreText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 EventPointBaseText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 MedalScoreText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 EventBonusText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 LbRateText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 RewardEventPointText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TotalEventPointText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 RewardMedalText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TotalMedalText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 PointIcon                                ModelClassType Image Image Image Pointer
    // 078 MedalIcon                                ModelClassType Image Image Image Pointer
    // 080 PointNameBaseText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 PointNameText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 PointUnitTexts                           ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 098 Data                                     ModelClassType LiveEventScoreDetailData LiveEventScoreDetailData LiveEventScoreDetailData Pointer
    // 0A0 Sprites                                  ModelClassListType List`1<Sprite> List`1<Sprite> List<Sprite> Pointer
    public partial class LiveEventScoreDetailPanel : DataModel
    {
        public ScoreRankIcon?                           ScoreRankIcon                           { get; set; }
        public UITextMeshProUGUI?                       ScoreText                               { get; set; }
        public UITextMeshProUGUI?                       EventPointBaseText                      { get; set; }
        public UITextMeshProUGUI?                       MedalScoreText                          { get; set; }
        public UITextMeshProUGUI?                       EventBonusText                          { get; set; }
        public UITextMeshProUGUI?                       LbRateText                              { get; set; }
        public UITextMeshProUGUI?                       RewardEventPointText                    { get; set; }
        public UITextMeshProUGUI?                       TotalEventPointText                     { get; set; }
        public UITextMeshProUGUI?                       RewardMedalText                         { get; set; }
        public UITextMeshProUGUI?                       TotalMedalText                          { get; set; }
        public Image?                                   PointIcon                               { get; set; }
        public Image?                                   MedalIcon                               { get; set; }
        public UITextMeshProUGUI?                       PointNameBaseText                       { get; set; }
        public UITextMeshProUGUI?                       PointNameText                           { get; set; }
        public List<UITextMeshProUGUI>?                 PointUnitTexts                          { get; set; }
        public LiveEventScoreDetailData?                Data                                    { get; set; }
        public List<Sprite>?                            Sprites                                 { get; set; }

        public static LiveEventScoreDetailPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventScoreDetailPanel() { Pointer= p0 };

            value.ScoreRankIcon                             = GetObject<ScoreRankIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScoreRankIcon.FromPointer); // 0x20 ScoreRankIcon               ( ModelClassType ScoreRankIcon ScoreRankIcon ScoreRankIcon Pointer )
            value.ScoreText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ScoreText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventPointBaseText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 EventPointBaseText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MedalScoreText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 MedalScoreText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventBonusText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 EventBonusText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LbRateText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 LbRateText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardEventPointText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 RewardEventPointText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalEventPointText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TotalEventPointText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardMedalText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 RewardMedalText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalMedalText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TotalMedalText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PointIcon                                 = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 0x70 PointIcon                   ( ModelClassType Image Image Image Pointer )
            value.MedalIcon                                 = GetObject<Image>(new IntPtr(p + 0x078), ReversePrism.DataModels.Image.FromPointer); // 0x78 MedalIcon                   ( ModelClassType Image Image Image Pointer )
            value.PointNameBaseText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 PointNameBaseText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PointNameText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 PointNameText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PointUnitTexts                            = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 PointUnitTexts              ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.Data                                      = GetObject<LiveEventScoreDetailData>(new IntPtr(p + 0x098), ReversePrism.DataModels.LiveEventScoreDetailData.FromPointer); // 0x98 Data                        ( ModelClassType LiveEventScoreDetailData LiveEventScoreDetailData LiveEventScoreDetailData Pointer )
            value.Sprites                                   = GetObjectList<Sprite>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Sprite.FromPointer); // 0xA0 Sprites                     ( ModelClassListType List`1<Sprite> List`1<Sprite> List<Sprite> Pointer )

            return value;
        }
    }
}
