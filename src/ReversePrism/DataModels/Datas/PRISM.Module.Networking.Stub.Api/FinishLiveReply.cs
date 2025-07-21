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
    // 018 StartParam                               ModelClassType LiveStartParamStatus LiveStartParamStatus LiveStartParamStatus Pointer
    // 000 IsLiveSuccessFieldNumber                 int IL2CPP_TYPE_I4
    // 020 IsLiveSuccess                            ModelPrimitiveType bool bool bool Bool
    // 000 ScoreInfoFieldNumber                     int IL2CPP_TYPE_I4
    // 028 ScoreInfo                                ModelClassType LiveScoreInfoStatus LiveScoreInfoStatus LiveScoreInfoStatus Pointer
    // 000 ComboInfoFieldNumber                     int IL2CPP_TYPE_I4
    // 030 ComboInfo                                ModelClassType LiveComboInfoStatus LiveComboInfoStatus LiveComboInfoStatus Pointer
    // 000 TechnicalScoreInfoFieldNumber            int IL2CPP_TYPE_I4
    // 038 TechnicalScoreInfo                       ModelClassType LiveTechnicalScoreInfoStatus LiveTechnicalScoreInfoStatus LiveTechnicalScoreInfoStatus Pointer
    // 000 BeforeClearInfoListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_beforeClearInfoList_codec      FieldCodec`1<LiveClearInfoStatus> IL2CPP_TYPE_GENERICINST
    // 040 BeforeClearInfoList                      ModelClassListType RepeatedField`1<LiveClearInfoStatus> RepeatedField`1<LiveClearInfoStatus> List<LiveClearInfoStatus> Pointer
    // 000 AfterClearInfoFieldNumber                int IL2CPP_TYPE_I4
    // 048 AfterClearInfo                           ModelClassType LiveClearInfoStatus LiveClearInfoStatus LiveClearInfoStatus Pointer
    // 000 TimingJudgementFieldNumber               int IL2CPP_TYPE_I4
    // 050 TimingJudgement                          ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer
    // 000 BeforeRatingInfoFieldNumber              int IL2CPP_TYPE_I4
    // 058 BeforeRatingInfo                         ModelClassType LiveRatingInfoStatus LiveRatingInfoStatus LiveRatingInfoStatus Pointer
    // 000 AfterRatingInfoFieldNumber               int IL2CPP_TYPE_I4
    // 060 AfterRatingInfo                          ModelClassType LiveRatingInfoStatus LiveRatingInfoStatus LiveRatingInfoStatus Pointer
    // 000 PlayRewardPackFieldNumber                int IL2CPP_TYPE_I4
    // 068 PlayRewardPack                           ModelClassType LivePlayRewardPackStatus LivePlayRewardPackStatus LivePlayRewardPackStatus Pointer
    // 000 RankRewardPackFieldNumber                int IL2CPP_TYPE_I4
    // 070 RankRewardPack                           ModelClassType LiveRankRewardPackStatus LiveRankRewardPackStatus LiveRankRewardPackStatus Pointer
    // 000 RateRewardPackFieldNumber                int IL2CPP_TYPE_I4
    // 078 RateRewardPack                           ModelClassType LiveRateRewardPackStatus LiveRateRewardPackStatus LiveRateRewardPackStatus Pointer
    // 000 BeforeMoneyRewardFieldNumber             int IL2CPP_TYPE_I4
    // 080 BeforeMoneyReward                        ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer
    // 000 AfterMoneyRewardFieldNumber              int IL2CPP_TYPE_I4
    // 088 AfterMoneyReward                         ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer
    // 000 IdolBaseRewardListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_idolBaseRewardList_codec       FieldCodec`1<IdolBaseRewardStatus> IL2CPP_TYPE_GENERICINST
    // 090 IdolBaseRewardList                       ModelClassListType RepeatedField`1<IdolBaseRewardStatus> RepeatedField`1<IdolBaseRewardStatus> List<IdolBaseRewardStatus> Pointer
    // 000 SongFieldNumber                          int IL2CPP_TYPE_I4
    // 098 Song                                     ModelClassType SongStatus SongStatus SongStatus Pointer
    // 000 TotalHighScoreRatingFieldNumber          int IL2CPP_TYPE_I4
    // 0A0 TotalHighScoreRating                     ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer
    // 000 TotalTechnicalRatingFieldNumber          int IL2CPP_TYPE_I4
    // 0A8 TotalTechnicalRating                     ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer
    // 000 EventResultFieldNumber                   int IL2CPP_TYPE_I4
    // 0B0 EventResult                              ModelClassType LiveEventResultStatus LiveEventResultStatus LiveEventResultStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 0B8 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
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

            value.StartParam                                = GetObject<LiveStartParamStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveStartParamStatus.FromPointer); // 0x18 StartParam                  ( ModelClassType LiveStartParamStatus LiveStartParamStatus LiveStartParamStatus Pointer )
            value.IsLiveSuccess                             = GetBool(new IntPtr(p + 0x020)); // 0x20 IsLiveSuccess               ( ModelPrimitiveType bool bool bool Bool )
            value.ScoreInfo                                 = GetObject<LiveScoreInfoStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveScoreInfoStatus.FromPointer); // 0x28 ScoreInfo                   ( ModelClassType LiveScoreInfoStatus LiveScoreInfoStatus LiveScoreInfoStatus Pointer )
            value.ComboInfo                                 = GetObject<LiveComboInfoStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveComboInfoStatus.FromPointer); // 0x30 ComboInfo                   ( ModelClassType LiveComboInfoStatus LiveComboInfoStatus LiveComboInfoStatus Pointer )
            value.TechnicalScoreInfo                        = GetObject<LiveTechnicalScoreInfoStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveTechnicalScoreInfoStatus.FromPointer); // 0x38 TechnicalScoreInfo          ( ModelClassType LiveTechnicalScoreInfoStatus LiveTechnicalScoreInfoStatus LiveTechnicalScoreInfoStatus Pointer )
            value.BeforeClearInfoList                       = GetObjectList<LiveClearInfoStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveClearInfoStatus.FromPointer); // 0x40 BeforeClearInfoList         ( ModelClassListType RepeatedField`1<LiveClearInfoStatus> RepeatedField`1<LiveClearInfoStatus> List<LiveClearInfoStatus> Pointer )
            value.AfterClearInfo                            = GetObject<LiveClearInfoStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveClearInfoStatus.FromPointer); // 0x48 AfterClearInfo              ( ModelClassType LiveClearInfoStatus LiveClearInfoStatus LiveClearInfoStatus Pointer )
            value.TimingJudgement                           = GetObject<LiveTimingJudgementStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveTimingJudgementStatus.FromPointer); // 0x50 TimingJudgement             ( ModelClassType LiveTimingJudgementStatus LiveTimingJudgementStatus LiveTimingJudgementStatus Pointer )
            value.BeforeRatingInfo                          = GetObject<LiveRatingInfoStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveRatingInfoStatus.FromPointer); // 0x58 BeforeRatingInfo            ( ModelClassType LiveRatingInfoStatus LiveRatingInfoStatus LiveRatingInfoStatus Pointer )
            value.AfterRatingInfo                           = GetObject<LiveRatingInfoStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveRatingInfoStatus.FromPointer); // 0x60 AfterRatingInfo             ( ModelClassType LiveRatingInfoStatus LiveRatingInfoStatus LiveRatingInfoStatus Pointer )
            value.PlayRewardPack                            = GetObject<LivePlayRewardPackStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.LivePlayRewardPackStatus.FromPointer); // 0x68 PlayRewardPack              ( ModelClassType LivePlayRewardPackStatus LivePlayRewardPackStatus LivePlayRewardPackStatus Pointer )
            value.RankRewardPack                            = GetObject<LiveRankRewardPackStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveRankRewardPackStatus.FromPointer); // 0x70 RankRewardPack              ( ModelClassType LiveRankRewardPackStatus LiveRankRewardPackStatus LiveRankRewardPackStatus Pointer )
            value.RateRewardPack                            = GetObject<LiveRateRewardPackStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveRateRewardPackStatus.FromPointer); // 0x78 RateRewardPack              ( ModelClassType LiveRateRewardPackStatus LiveRateRewardPackStatus LiveRateRewardPackStatus Pointer )
            value.BeforeMoneyReward                         = GetObject<HavingProductStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 0x80 BeforeMoneyReward           ( ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer )
            value.AfterMoneyReward                          = GetObject<HavingProductStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 0x88 AfterMoneyReward            ( ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer )
            value.IdolBaseRewardList                        = GetObjectList<IdolBaseRewardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IdolBaseRewardStatus.FromPointer); // 0x90 IdolBaseRewardList          ( ModelClassListType RepeatedField`1<IdolBaseRewardStatus> RepeatedField`1<IdolBaseRewardStatus> List<IdolBaseRewardStatus> Pointer )
            value.Song                                      = GetObject<SongStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.SongStatus.FromPointer); // 0x98 Song                        ( ModelClassType SongStatus SongStatus SongStatus Pointer )
            value.TotalHighScoreRating                      = GetObject<TotalHighScoreRatingStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.TotalHighScoreRatingStatus.FromPointer); // 0xA0 TotalHighScoreRating        ( ModelClassType TotalHighScoreRatingStatus TotalHighScoreRatingStatus TotalHighScoreRatingStatus Pointer )
            value.TotalTechnicalRating                      = GetObject<TotalTechnicalRatingStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.TotalTechnicalRatingStatus.FromPointer); // 0xA8 TotalTechnicalRating        ( ModelClassType TotalTechnicalRatingStatus TotalTechnicalRatingStatus TotalTechnicalRatingStatus Pointer )
            value.EventResult                               = GetObject<LiveEventResultStatus>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LiveEventResultStatus.FromPointer); // 0xB0 EventResult                 ( ModelClassType LiveEventResultStatus LiveEventResultStatus LiveEventResultStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0xB8 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
