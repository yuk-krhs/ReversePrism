using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FinishLiveReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StartParamFieldNumber                    int IL2CPP_TYPE_I4
    // 018 StartParam                               000186582820 ModelClassType LiveStartParamStatus LiveStartParamStatus LiveStartParamStatus Pointer
    // 000 IsLiveSuccessFieldNumber                 int IL2CPP_TYPE_I4
    // 020 IsLiveSuccess                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ScoreInfoFieldNumber                     int IL2CPP_TYPE_I4
    // 028 ScoreInfo                                0001865776F0 ModelClassType LiveScoreInfoStatus LiveScoreInfoStatus LiveScoreInfoStatus Pointer
    // 000 ComboInfoFieldNumber                     int IL2CPP_TYPE_I4
    // 030 ComboInfo                                000186545FC0 ModelClassType LiveComboInfoStatus LiveComboInfoStatus LiveComboInfoStatus Pointer
    // 000 TechnicalScoreInfoFieldNumber            int IL2CPP_TYPE_I4
    // 038 TechnicalScoreInfo                       000186586510 ModelClassType LiveTechnicalScoreInfoStatus LiveTechnicalScoreInfoStatus LiveTechnicalScoreInfoStatus Pointer
    // 000 BeforeClearInfoListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_beforeClearInfoList_codec      FieldCodec`1<LiveClearInfoStatus> IL2CPP_TYPE_GENERICINST
    // 040 BeforeClearInfoList                      000185CE2E68 ModelClassListType RepeatedField`1<LiveClearInfoStatus> RepeatedField`1<LiveClearInfoStatus> List<LiveClearInfoStatus> Pointer
    // 000 AfterClearInfoFieldNumber                int IL2CPP_TYPE_I4
    // 048 AfterClearInfo                           000186545830 ModelClassType LiveClearInfoStatus LiveClearInfoStatus LiveClearInfoStatus Pointer
    // 000 TimingJudgementFieldNumber               int IL2CPP_TYPE_I4
    // 050 TimingJudgement                          000186586D00 ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer
    // 000 BeforeRatingInfoFieldNumber              int IL2CPP_TYPE_I4
    // 058 BeforeRatingInfo                         00018656C3D0 ModelClassType LiveRatingInfoStatus LiveRatingInfoStatus LiveRatingInfoStatus Pointer
    // 000 AfterRatingInfoFieldNumber               int IL2CPP_TYPE_I4
    // 060 AfterRatingInfo                          00018656C3D0 ModelClassType LiveRatingInfoStatus LiveRatingInfoStatus LiveRatingInfoStatus Pointer
    // 000 PlayRewardPackFieldNumber                int IL2CPP_TYPE_I4
    // 068 PlayRewardPack                           000186567D50 ModelClassType LivePlayRewardPackStatus LivePlayRewardPackStatus LivePlayRewardPackStatus Pointer
    // 000 RankRewardPackFieldNumber                int IL2CPP_TYPE_I4
    // 070 RankRewardPack                           00018656A7E0 ModelClassType LiveRankRewardPackStatus LiveRankRewardPackStatus LiveRankRewardPackStatus Pointer
    // 000 RateRewardPackFieldNumber                int IL2CPP_TYPE_I4
    // 078 RateRewardPack                           00018656BC20 ModelClassType LiveRateRewardPackStatus LiveRateRewardPackStatus LiveRateRewardPackStatus Pointer
    // 000 BeforeMoneyRewardFieldNumber             int IL2CPP_TYPE_I4
    // 080 BeforeMoneyReward                        0001866AD720 ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer
    // 000 AfterMoneyRewardFieldNumber              int IL2CPP_TYPE_I4
    // 088 AfterMoneyReward                         0001866AD720 ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer
    // 000 IdolBaseRewardListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_idolBaseRewardList_codec       FieldCodec`1<IdolBaseRewardStatus> IL2CPP_TYPE_GENERICINST
    // 090 IdolBaseRewardList                       000185CDF438 ModelClassListType RepeatedField`1<IdolBaseRewardStatus> RepeatedField`1<IdolBaseRewardStatus> List<IdolBaseRewardStatus> Pointer
    // 000 SongFieldNumber                          int IL2CPP_TYPE_I4
    // 098 Song                                     00018652B0A0 ModelClassType SongStatus SongStatus SongStatus Pointer
    // 000 TotalHighScoreRatingFieldNumber          int IL2CPP_TYPE_I4
    // 0A0 TotalHighScoreRating                     00018668CAE0 ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer
    // 000 TotalTechnicalRatingFieldNumber          int IL2CPP_TYPE_I4
    // 0A8 TotalTechnicalRating                     00018668D290 ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer
    // 000 EventResultFieldNumber                   int IL2CPP_TYPE_I4
    // 0B0 EventResult                              000186553260 ModelClassType LiveEventResultStatus LiveEventResultStatus LiveEventResultStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 0B8 HavingGroup                              0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class FinishLiveReply : DataModel
    {
        public LiveStartParamStatus?                    StartParam                              { get; set; }
        public bool                                     IsLiveSuccess                           { get; set; }
        public LiveScoreInfoStatus?                     ScoreInfo                               { get; set; }
        public LiveComboInfoStatus?                     ComboInfo                               { get; set; }
        public LiveTechnicalScoreInfoStatus?            TechnicalScoreInfo                      { get; set; }
        public List<LiveClearInfoStatus>?               BeforeClearInfoList                     { get; set; }
        public LiveClearInfoStatus?                     AfterClearInfo                          { get; set; }
        public LiveTimingJudgementStatus?               TimingJudgement                         { get; set; }
        public LiveRatingInfoStatus?                    BeforeRatingInfo                        { get; set; }
        public LiveRatingInfoStatus?                    AfterRatingInfo                         { get; set; }
        public LivePlayRewardPackStatus?                PlayRewardPack                          { get; set; }
        public LiveRankRewardPackStatus?                RankRewardPack                          { get; set; }
        public LiveRateRewardPackStatus?                RateRewardPack                          { get; set; }
        public HavingProductStatus?                     BeforeMoneyReward                       { get; set; }
        public HavingProductStatus?                     AfterMoneyReward                        { get; set; }
        public List<IdolBaseRewardStatus>?              IdolBaseRewardList                      { get; set; }
        public SongStatus?                              Song                                    { get; set; }
        public TotalHighScoreRatingStatus?              TotalHighScoreRating                    { get; set; }
        public TotalTechnicalRatingStatus?              TotalTechnicalRating                    { get; set; }
        public LiveEventResultStatus?                   EventResult                             { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static FinishLiveReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishLiveReply() { Pointer= p0 };

            value.StartParam                                = GetObject<LiveStartParamStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveStartParamStatus.FromPointer); // 0246621744A8 0x18 StartParam                  ( 000186582820 ModelClassType LiveStartParamStatus LiveStartParamStatus LiveStartParamStatus Pointer )
            value.IsLiveSuccess                             = GetBool(new IntPtr(p + 0x020)); // 0246621744E8 0x20 IsLiveSuccess               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScoreInfo                                 = GetObject<LiveScoreInfoStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveScoreInfoStatus.FromPointer); // 024662174528 0x28 ScoreInfo                   ( 0001865776F0 ModelClassType LiveScoreInfoStatus LiveScoreInfoStatus LiveScoreInfoStatus Pointer )
            value.ComboInfo                                 = GetObject<LiveComboInfoStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveComboInfoStatus.FromPointer); // 024662174568 0x30 ComboInfo                   ( 000186545FC0 ModelClassType LiveComboInfoStatus LiveComboInfoStatus LiveComboInfoStatus Pointer )
            value.TechnicalScoreInfo                        = GetObject<LiveTechnicalScoreInfoStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveTechnicalScoreInfoStatus.FromPointer); // 0246621745A8 0x38 TechnicalScoreInfo          ( 000186586510 ModelClassType LiveTechnicalScoreInfoStatus LiveTechnicalScoreInfoStatus LiveTechnicalScoreInfoStatus Pointer )
            value.BeforeClearInfoList                       = GetObjectList<LiveClearInfoStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveClearInfoStatus.FromPointer); // 024662174608 0x40 BeforeClearInfoList         ( 000185CE2E68 ModelClassListType RepeatedField`1<LiveClearInfoStatus> RepeatedField`1<LiveClearInfoStatus> List<LiveClearInfoStatus> Pointer )
            value.AfterClearInfo                            = GetObject<LiveClearInfoStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveClearInfoStatus.FromPointer); // 024662174648 0x48 AfterClearInfo              ( 000186545830 ModelClassType LiveClearInfoStatus LiveClearInfoStatus LiveClearInfoStatus Pointer )
            value.TimingJudgement                           = GetObject<LiveTimingJudgementStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveTimingJudgementStatus.FromPointer); // 024662174688 0x50 TimingJudgement             ( 000186586D00 ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer )
            value.BeforeRatingInfo                          = GetObject<LiveRatingInfoStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveRatingInfoStatus.FromPointer); // 0246621746C8 0x58 BeforeRatingInfo            ( 00018656C3D0 ModelClassType LiveRatingInfoStatus LiveRatingInfoStatus LiveRatingInfoStatus Pointer )
            value.AfterRatingInfo                           = GetObject<LiveRatingInfoStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveRatingInfoStatus.FromPointer); // 024662174708 0x60 AfterRatingInfo             ( 00018656C3D0 ModelClassType LiveRatingInfoStatus LiveRatingInfoStatus LiveRatingInfoStatus Pointer )
            value.PlayRewardPack                            = GetObject<LivePlayRewardPackStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.LivePlayRewardPackStatus.FromPointer); // 024662174748 0x68 PlayRewardPack              ( 000186567D50 ModelClassType LivePlayRewardPackStatus LivePlayRewardPackStatus LivePlayRewardPackStatus Pointer )
            value.RankRewardPack                            = GetObject<LiveRankRewardPackStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveRankRewardPackStatus.FromPointer); // 024662174788 0x70 RankRewardPack              ( 00018656A7E0 ModelClassType LiveRankRewardPackStatus LiveRankRewardPackStatus LiveRankRewardPackStatus Pointer )
            value.RateRewardPack                            = GetObject<LiveRateRewardPackStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveRateRewardPackStatus.FromPointer); // 0246621747C8 0x78 RateRewardPack              ( 00018656BC20 ModelClassType LiveRateRewardPackStatus LiveRateRewardPackStatus LiveRateRewardPackStatus Pointer )
            value.BeforeMoneyReward                         = GetObject<HavingProductStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 024662174808 0x80 BeforeMoneyReward           ( 0001866AD720 ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer )
            value.AfterMoneyReward                          = GetObject<HavingProductStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 024662174848 0x88 AfterMoneyReward            ( 0001866AD720 ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer )
            value.IdolBaseRewardList                        = GetObjectList<IdolBaseRewardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IdolBaseRewardStatus.FromPointer); // 0246621748A8 0x90 IdolBaseRewardList          ( 000185CDF438 ModelClassListType RepeatedField`1<IdolBaseRewardStatus> RepeatedField`1<IdolBaseRewardStatus> List<IdolBaseRewardStatus> Pointer )
            value.Song                                      = GetObject<SongStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.SongStatus.FromPointer); // 0246621748E8 0x98 Song                        ( 00018652B0A0 ModelClassType SongStatus SongStatus SongStatus Pointer )
            value.TotalHighScoreRating                      = GetObject<TotalHighScoreRatingStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.TotalHighScoreRatingStatus.FromPointer); // 024662174928 0xA0 TotalHighScoreRating        ( 00018668CAE0 ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<TotalTechnicalRatingStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.TotalTechnicalRatingStatus.FromPointer); // 024662174968 0xA8 TotalTechnicalRating        ( 00018668D290 ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer )
            value.EventResult                               = GetObject<LiveEventResultStatus>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LiveEventResultStatus.FromPointer); // 0246621749A8 0xB0 EventResult                 ( 000186553260 ModelClassType LiveEventResultStatus LiveEventResultStatus LiveEventResultStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0246621749E8 0xB8 HavingGroup                 ( 0001866ACFE0 ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
