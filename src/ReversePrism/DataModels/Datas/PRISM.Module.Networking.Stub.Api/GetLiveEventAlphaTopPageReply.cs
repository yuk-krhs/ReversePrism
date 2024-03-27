using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLiveEventAlphaTopPageReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GameEventStatusFieldNumber               int IL2CPP_TYPE_I4
    // 018 GameEventStatus                          0001865E7E60 ModelClassType GameEventStatus GameEventStatus GameEventStatus Pointer
    // 000 EventPointFieldNumber                    int IL2CPP_TYPE_I4
    // 020 EventPoint                               0001865F7700 ModelPrimitiveType long long long Int64
    // 000 NextRewardFieldNumber                    int IL2CPP_TYPE_I4
    // 028 NextReward                               000186760490 ModelClassType EventPointRewardStatus EventPointRewardStatus EventPointRewardStatus Pointer
    // 000 NotificationListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_notificationList_codec         FieldCodec`1<HomeNotificationStatus> IL2CPP_TYPE_GENERICINST
    // 030 NotificationList                         000185CDE8A8 ModelClassListType RepeatedField`1<HomeNotificationStatus> RepeatedField`1<HomeNotificationStatus> List<HomeNotificationStatus> Pointer
    // 000 EventBonusFieldNumber                    int IL2CPP_TYPE_I4
    // 038 EventBonus                               00018674F9C0 ModelClassType EventBonusStatus EventBonusStatus EventBonusStatus Pointer
    // 000 MedalGashaStatusFieldNumber              int IL2CPP_TYPE_I4
    // 040 MedalGashaStatus                         0001865EEDD0 ModelClassType MedalGashaStatus MedalGashaStatus MedalGashaStatus Pointer
    // 000 MedalFieldNumber                         int IL2CPP_TYPE_I4
    // 048 Medal                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 000 EventRankingListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_eventRankingList_codec         FieldCodec`1<LiveEventRankingStatus> IL2CPP_TYPE_GENERICINST
    // 050 EventRankingList                         000185CE3088 ModelClassListType RepeatedField`1<LiveEventRankingStatus> RepeatedField`1<LiveEventRankingStatus> List<LiveEventRankingStatus> Pointer
    // 000 MstMissionGroupIdFieldNumber             int IL2CPP_TYPE_I4
    // 058 MstMissionGroupId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 05C MstSongId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetLiveEventAlphaTopPageReply
    {
        public GameEventStatus?                         GameEventStatus                         { get; set; }
        public long                                     EventPoint                              { get; set; }
        public EventPointRewardStatus?                  NextReward                              { get; set; }
        public List<HomeNotificationStatus>?            NotificationList                        { get; set; }
        public EventBonusStatus?                        EventBonus                              { get; set; }
        public MedalGashaStatus?                        MedalGashaStatus                        { get; set; }
        public long                                     Medal                                   { get; set; }
        public List<LiveEventRankingStatus>?            EventRankingList                        { get; set; }
        public int                                      MstMissionGroupId                       { get; set; }
        public int                                      MstSongId                               { get; set; }

        public static GetLiveEventAlphaTopPageReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveEventAlphaTopPageReply();

            value.GameEventStatus                           = GetObject<GameEventStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameEventStatus.FromPointer); // 0270D21A9510 0x18 GameEventStatus             ( 0001865E7E60 ModelClassType GameEventStatus GameEventStatus GameEventStatus Pointer )
            value.EventPoint                                = GetInt64(new IntPtr(p + 0x020)); // 0270D21A9550 0x20 EventPoint                  ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.NextReward                                = GetObject<EventPointRewardStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventPointRewardStatus.FromPointer); // 0270D21A9590 0x28 NextReward                  ( 000186760490 ModelClassType EventPointRewardStatus EventPointRewardStatus EventPointRewardStatus Pointer )
            value.NotificationList                          = GetObjectList<HomeNotificationStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeNotificationStatus.FromPointer); // 0270D21A95F0 0x30 NotificationList            ( 000185CDE8A8 ModelClassListType RepeatedField`1<HomeNotificationStatus> RepeatedField`1<HomeNotificationStatus> List<HomeNotificationStatus> Pointer )
            value.EventBonus                                = GetObject<EventBonusStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventBonusStatus.FromPointer); // 0270D21A9630 0x38 EventBonus                  ( 00018674F9C0 ModelClassType EventBonusStatus EventBonusStatus EventBonusStatus Pointer )
            value.MedalGashaStatus                          = GetObject<MedalGashaStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.MedalGashaStatus.FromPointer); // 0270D21A9670 0x40 MedalGashaStatus            ( 0001865EEDD0 ModelClassType MedalGashaStatus MedalGashaStatus MedalGashaStatus Pointer )
            value.Medal                                     = GetInt64(new IntPtr(p + 0x048)); // 0270D21A96B0 0x48 Medal                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.EventRankingList                          = GetObjectList<LiveEventRankingStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveEventRankingStatus.FromPointer); // 0270D21A9710 0x50 EventRankingList            ( 000185CE3088 ModelClassListType RepeatedField`1<LiveEventRankingStatus> RepeatedField`1<LiveEventRankingStatus> List<LiveEventRankingStatus> Pointer )
            value.MstMissionGroupId                         = GetInt32(new IntPtr(p + 0x058)); // 0270D21A9750 0x58 MstMissionGroupId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x05C)); // 0270D21A9790 0x5C MstSongId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
