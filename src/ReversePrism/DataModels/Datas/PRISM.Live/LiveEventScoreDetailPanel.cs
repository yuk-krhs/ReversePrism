using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScoreRankIcon                            0001866EE570 ModelClassType ScoreRankIcon ScoreRankIcon ScoreRankIcon Pointer
    // 028 ScoreText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 EventPointBaseText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 MedalScoreText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 EventBonusText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 LbRateText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 RewardEventPointText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TotalEventPointText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 RewardMedalText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TotalMedalText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 PointIcon                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 078 MedalIcon                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 080 Data                                     000186553C60 ModelClassType LiveEventScoreDetailData LiveEventScoreDetailData LiveEventScoreDetailData Pointer
    // 088 Sprites                                  000185D0B748 ModelClassListType List`1<Sprite> List`1<Sprite> List<Sprite> Pointer
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
        public LiveEventScoreDetailData?                Data                                    { get; set; }
        public List<Sprite>?                            Sprites                                 { get; set; }

        public static LiveEventScoreDetailPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventScoreDetailPanel() { Pointer= p0 };

            value.ScoreRankIcon                             = GetObject<ScoreRankIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScoreRankIcon.FromPointer); // 024665153408 0x20 ScoreRankIcon               ( 0001866EE570 ModelClassType ScoreRankIcon ScoreRankIcon ScoreRankIcon Pointer )
            value.ScoreText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665153428 0x28 ScoreText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventPointBaseText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665153448 0x30 EventPointBaseText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MedalScoreText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665153468 0x38 MedalScoreText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventBonusText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665153488 0x40 EventBonusText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LbRateText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651534A8 0x48 LbRateText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardEventPointText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651534C8 0x50 RewardEventPointText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalEventPointText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246651534E8 0x58 TotalEventPointText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardMedalText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665153508 0x60 RewardMedalText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TotalMedalText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665153528 0x68 TotalMedalText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PointIcon                                 = GetObject<Image>(new IntPtr(p + 0x070), ReversePrism.DataModels.Image.FromPointer); // 024665153548 0x70 PointIcon                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.MedalIcon                                 = GetObject<Image>(new IntPtr(p + 0x078), ReversePrism.DataModels.Image.FromPointer); // 024665153568 0x78 MedalIcon                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Data                                      = GetObject<LiveEventScoreDetailData>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveEventScoreDetailData.FromPointer); // 024665153588 0x80 Data                        ( 000186553C60 ModelClassType LiveEventScoreDetailData LiveEventScoreDetailData LiveEventScoreDetailData Pointer )
            value.Sprites                                   = GetObjectList<Sprite>(new IntPtr(p + 0x088), ReversePrism.DataModels.Sprite.FromPointer); // 0246651535A8 0x88 Sprites                     ( 000185D0B748 ModelClassListType List`1<Sprite> List`1<Sprite> List<Sprite> Pointer )

            return value;
        }
    }
}
