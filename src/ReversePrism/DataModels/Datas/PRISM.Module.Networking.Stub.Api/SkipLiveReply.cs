using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SkipLiveReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StartParamFieldNumber                    int IL2CPP_TYPE_I4
    // 018 StartParam                               ModelClassType LiveStartParamStatus LiveStartParamStatus LiveStartParamStatus Pointer
    // 000 SkipLiveFieldNumber                      int IL2CPP_TYPE_I4
    // 020 SkipLive                                 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 LiveBonusFieldNumber                     int IL2CPP_TYPE_I4
    // 028 LiveBonus                                ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 PlayRewardPackFieldNumber                int IL2CPP_TYPE_I4
    // 030 PlayRewardPack                           ModelClassType LivePlayRewardPackStatus LivePlayRewardPackStatus LivePlayRewardPackStatus Pointer
    // 000 BeforeMoneyRewardFieldNumber             int IL2CPP_TYPE_I4
    // 038 BeforeMoneyReward                        ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer
    // 000 AfterMoneyRewardFieldNumber              int IL2CPP_TYPE_I4
    // 040 AfterMoneyReward                         ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer
    // 000 ScoreRankFieldNumber                     int IL2CPP_TYPE_I4
    // 048 ScoreRank                                ModelEnumType ScoreRank ScoreRank ScoreRank Int32
    // 000 AutoLiveFieldNumber                      int IL2CPP_TYPE_I4
    // 050 AutoLive                                 ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer
    // 000 IdolBaseRewardListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_idolBaseRewardList_codec       FieldCodec`1<IdolBaseRewardStatus> IL2CPP_TYPE_GENERICINST
    // 058 IdolBaseRewardList                       ModelClassListType RepeatedField`1<IdolBaseRewardStatus> RepeatedField`1<IdolBaseRewardStatus> List<IdolBaseRewardStatus> Pointer
    // 000 SongFieldNumber                          int IL2CPP_TYPE_I4
    // 060 Song                                     ModelClassType SongStatus SongStatus SongStatus Pointer
    // 000 EventResultFieldNumber                   int IL2CPP_TYPE_I4
    // 068 EventResult                              ModelClassType LiveEventResultStatus LiveEventResultStatus LiveEventResultStatus Pointer
    // 000 ScoreFieldNumber                         int IL2CPP_TYPE_I4
    // 070 Score                                    ModelPrimitiveType int int int Int32
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 078 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class SkipLiveReply : DataModel
    {
        public LiveStartParamStatus?                    StartParam                              { get; set; }
        public StaminaStatus?                           SkipLive                                { get; set; }
        public StaminaStatus?                           LiveBonus                               { get; set; }
        public LivePlayRewardPackStatus?                PlayRewardPack                          { get; set; }
        public HavingProductStatus?                     BeforeMoneyReward                       { get; set; }
        public HavingProductStatus?                     AfterMoneyReward                        { get; set; }
        public ScoreRank                                ScoreRank                               { get; set; }
        public StaminaStatus?                           AutoLive                                { get; set; }
        public List<IdolBaseRewardStatus>?              IdolBaseRewardList                      { get; set; }
        public SongStatus?                              Song                                    { get; set; }
        public LiveEventResultStatus?                   EventResult                             { get; set; }
        public int                                      Score                                   { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static SkipLiveReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipLiveReply() { Pointer= p0 };

            value.StartParam                                = GetObject<LiveStartParamStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveStartParamStatus.FromPointer); // 0x18 StartParam                  ( ModelClassType LiveStartParamStatus LiveStartParamStatus LiveStartParamStatus Pointer )
            value.SkipLive                                  = GetObject<StaminaStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0x20 SkipLive                    ( ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.LiveBonus                                 = GetObject<StaminaStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0x28 LiveBonus                   ( ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.PlayRewardPack                            = GetObject<LivePlayRewardPackStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LivePlayRewardPackStatus.FromPointer); // 0x30 PlayRewardPack              ( ModelClassType LivePlayRewardPackStatus LivePlayRewardPackStatus LivePlayRewardPackStatus Pointer )
            value.BeforeMoneyReward                         = GetObject<HavingProductStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 0x38 BeforeMoneyReward           ( ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer )
            value.AfterMoneyReward                          = GetObject<HavingProductStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.HavingProductStatus.FromPointer); // 0x40 AfterMoneyReward            ( ModelClassType HavingProductStatus HavingProductStatus HavingProductStatus Pointer )
            value.ScoreRank                                 = (ScoreRank)GetInt32(new IntPtr(p + 0x048)); // 0x48 ScoreRank                   ( ModelEnumType ScoreRank ScoreRank ScoreRank Int32 )
            value.AutoLive                                  = GetObject<StaminaStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.StaminaStatus.FromPointer); // 0x50 AutoLive                    ( ModelClassType StaminaStatus StaminaStatus StaminaStatus Pointer )
            value.IdolBaseRewardList                        = GetObjectList<IdolBaseRewardStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IdolBaseRewardStatus.FromPointer); // 0x58 IdolBaseRewardList          ( ModelClassListType RepeatedField`1<IdolBaseRewardStatus> RepeatedField`1<IdolBaseRewardStatus> List<IdolBaseRewardStatus> Pointer )
            value.Song                                      = GetObject<SongStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.SongStatus.FromPointer); // 0x60 Song                        ( ModelClassType SongStatus SongStatus SongStatus Pointer )
            value.EventResult                               = GetObject<LiveEventResultStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveEventResultStatus.FromPointer); // 0x68 EventResult                 ( ModelClassType LiveEventResultStatus LiveEventResultStatus LiveEventResultStatus Pointer )
            value.Score                                     = GetInt32(new IntPtr(p + 0x070)); // 0x70 Score                       ( ModelPrimitiveType int int int Int32 )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x78 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
