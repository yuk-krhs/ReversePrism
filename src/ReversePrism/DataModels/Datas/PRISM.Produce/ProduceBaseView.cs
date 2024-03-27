using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ProduceCardPath                          string IL2CPP_TYPE_STRING
    // 020 GaugeAnimationTime                       000186665B50 ModelPrimitiveType float float float Single
    // 028 CancelBackGround                         0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer
    // 030 BuffDebuffDetailDetail                   000186779A00 ModelClassType BuffDebuffDetail BuffDebuffDetail BuffDebuffDetail Pointer
    // 038 CountdownContent                         0001866390B0 ModelClassType CountdownContent CountdownContent CountdownContent Pointer
    // 040 TimePanelContent                         000186668180 ModelClassType TimePanelContent TimePanelContent TimePanelContent Pointer
    // 048 BaseIngameSkillDetailKeywordContent      00018673EBE0 ModelClassType BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent Pointer
    // 050 ProduceCardAndCharaSkillDetailPanel      000186534E70 ModelClassType ProduceCardAndCharaSkillDetailPanel ProduceCardAndCharaSkillDetailPanel ProduceCardAndCharaSkillDetailPanel Pointer
    // 058 InGameFinishPanel                        0001866D5250 ModelClassType InGameFinishPanel InGameFinishPanel InGameFinishPanel Pointer
    // 060 onChangeVisibleDetailUI                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 068 onShowBuffDebuffDetailUI                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 OnHidePrediction                         0001866797B0 ModelClassType Action Action Action Pointer
    // 078 AssetTag                                 000186671910 ModelPrimitiveType string string string String
    // 080 PauseContent                             000186558570 ModelClassType ProduceInGamePauseContent ProduceInGamePauseContent ProduceInGamePauseContent Pointer
    // 088 FramePerSec                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 090 onChangeFocus                            Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 098 IsShowPrediction                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A0 FastForwardButton                        000186558290 ModelClassType FastForwardButton FastForwardButton FastForwardButton Pointer
    // 0A8 onClickEndInGameButton                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B0 PlayerView                               0001866D73F0 ModelClassType InGamePlayerView InGamePlayerView InGamePlayerView Pointer
    // 0B8 EnemyView                                0001866D4650 ModelClassType InGameEnemyView InGameEnemyView InGameEnemyView Pointer
    // 0C0 OnClickRestartButtonActionAsync          Func`2<CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 0C8 OnClickCancelButtonAction                000186679A00 ModelClassType Action Action Action Pointer
    public partial class ProduceBaseView
    {
        public float                                    GaugeAnimationTime                      { get; set; }
        public UIButton?                                CancelBackGround                        { get; set; }
        public BuffDebuffDetail?                        BuffDebuffDetailDetail                  { get; set; }
        public CountdownContent?                        CountdownContent                        { get; set; }
        public TimePanelContent?                        TimePanelContent                        { get; set; }
        public BaseIngameSkillDetailKeywordContent?     BaseIngameSkillDetailKeywordContent     { get; set; }
        public ProduceCardAndCharaSkillDetailPanel?     ProduceCardAndCharaSkillDetailPanel     { get; set; }
        public InGameFinishPanel?                       InGameFinishPanel                       { get; set; }
        public Action?                                  OnHidePrediction                        { get; set; }
        public string                                   AssetTag                                { get; set; }
        public ProduceInGamePauseContent?               PauseContent                            { get; set; }
        public int                                      FramePerSec                             { get; set; }
        public bool                                     IsShowPrediction                        { get; set; }
        public FastForwardButton?                       FastForwardButton                       { get; set; }
        public InGamePlayerView?                        PlayerView                              { get; set; }
        public InGameEnemyView?                         EnemyView                               { get; set; }
        public Action?                                  OnClickCancelButtonAction               { get; set; }

        public static ProduceBaseView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceBaseView();

            value.GaugeAnimationTime                        = GetSingle(new IntPtr(p + 0x020)); // 0270D507C7A0 0x20 GaugeAnimationTime          ( 000186665B50 ModelPrimitiveType float float float Single )
            value.CancelBackGround                          = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270D507C7C0 0x28 CancelBackGround            ( 0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer )
            value.BuffDebuffDetailDetail                    = GetObject<BuffDebuffDetail>(new IntPtr(p + 0x030), ReversePrism.DataModels.BuffDebuffDetail.FromPointer); // 0270D507C7E0 0x30 BuffDebuffDetailDetail      ( 000186779A00 ModelClassType BuffDebuffDetail BuffDebuffDetail BuffDebuffDetail Pointer )
            value.CountdownContent                          = GetObject<CountdownContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.CountdownContent.FromPointer); // 0270D507C800 0x38 CountdownContent            ( 0001866390B0 ModelClassType CountdownContent CountdownContent CountdownContent Pointer )
            value.TimePanelContent                          = GetObject<TimePanelContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.TimePanelContent.FromPointer); // 0270D507C820 0x40 TimePanelContent            ( 000186668180 ModelClassType TimePanelContent TimePanelContent TimePanelContent Pointer )
            value.BaseIngameSkillDetailKeywordContent       = GetObject<BaseIngameSkillDetailKeywordContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.BaseIngameSkillDetailKeywordContent.FromPointer); // 0270D507C840 0x48 BaseIngameSkillDetailKeywordContent ( 00018673EBE0 ModelClassType BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent Pointer )
            value.ProduceCardAndCharaSkillDetailPanel       = GetObject<ProduceCardAndCharaSkillDetailPanel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceCardAndCharaSkillDetailPanel.FromPointer); // 0270D507C860 0x50 ProduceCardAndCharaSkillDetailPanel ( 000186534E70 ModelClassType ProduceCardAndCharaSkillDetailPanel ProduceCardAndCharaSkillDetailPanel ProduceCardAndCharaSkillDetailPanel Pointer )
            value.InGameFinishPanel                         = GetObject<InGameFinishPanel>(new IntPtr(p + 0x058), ReversePrism.DataModels.InGameFinishPanel.FromPointer); // 0270D507C880 0x58 InGameFinishPanel           ( 0001866D5250 ModelClassType InGameFinishPanel InGameFinishPanel InGameFinishPanel Pointer )
            value.OnHidePrediction                          = GetObject<Action>(new IntPtr(p + 0x070), ReversePrism.DataModels.Action.FromPointer); // 0270D507C8E0 0x70 OnHidePrediction            ( 0001866797B0 ModelClassType Action Action Action Pointer )
            value.AssetTag                                  = GetString(new IntPtr(p + 0x078)); // 0270D507C900 0x78 AssetTag                    ( 000186671910 ModelPrimitiveType string string string String )
            value.PauseContent                              = GetObject<ProduceInGamePauseContent>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceInGamePauseContent.FromPointer); // 0270D507C920 0x80 PauseContent                ( 000186558570 ModelClassType ProduceInGamePauseContent ProduceInGamePauseContent ProduceInGamePauseContent Pointer )
            value.FramePerSec                               = GetInt32(new IntPtr(p + 0x088)); // 0270D507C940 0x88 FramePerSec                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsShowPrediction                          = GetBool(new IntPtr(p + 0x098)); // 0270D507C980 0x98 IsShowPrediction            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FastForwardButton                         = GetObject<FastForwardButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.FastForwardButton.FromPointer); // 0270D507C9A0 0xA0 FastForwardButton           ( 000186558290 ModelClassType FastForwardButton FastForwardButton FastForwardButton Pointer )
            value.PlayerView                                = GetObject<InGamePlayerView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.InGamePlayerView.FromPointer); // 0270D507C9E0 0xB0 PlayerView                  ( 0001866D73F0 ModelClassType InGamePlayerView InGamePlayerView InGamePlayerView Pointer )
            value.EnemyView                                 = GetObject<InGameEnemyView>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.InGameEnemyView.FromPointer); // 0270D507CA00 0xB8 EnemyView                   ( 0001866D4650 ModelClassType InGameEnemyView InGameEnemyView InGameEnemyView Pointer )
            value.OnClickCancelButtonAction                 = GetObject<Action>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Action.FromPointer); // 0270D507CA40 0xC8 OnClickCancelButtonAction   ( 000186679A00 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
