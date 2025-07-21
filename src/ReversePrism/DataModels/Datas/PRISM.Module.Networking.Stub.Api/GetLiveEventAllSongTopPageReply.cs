using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLiveEventAllSongTopPageReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GameEventStatusFieldNumber               int IL2CPP_TYPE_I4
    // 018 GameEventStatus                          ModelClassType GameEventStatus GameEventStatus GameEventStatus Pointer
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 MstSongId                                ModelPrimitiveType int int int Int32
    // 000 BreakTimeFieldNumber                     int IL2CPP_TYPE_I4
    // 028 BreakTime                                ModelClassType EventBreakTimeStatus EventBreakTimeStatus EventBreakTimeStatus Pointer
    // 000 EventBonusFieldNumber                    int IL2CPP_TYPE_I4
    // 030 EventBonus                               ModelClassType EventBonusStatus EventBonusStatus EventBonusStatus Pointer
    // 000 AlbumListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_albumList_codec                FieldCodec`1<EventAlbumStatus> IL2CPP_TYPE_GENERICINST
    // 038 AlbumList                                ModelClassListType RepeatedField`1<EventAlbumStatus> RepeatedField`1<EventAlbumStatus> List<EventAlbumStatus> Pointer
    // 000 EventRankingListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_eventRankingList_codec         FieldCodec`1<LiveEventRankingStatus> IL2CPP_TYPE_GENERICINST
    // 040 EventRankingList                         ModelClassListType RepeatedField`1<LiveEventRankingStatus> RepeatedField`1<LiveEventRankingStatus> List<LiveEventRankingStatus> Pointer
    // 000 NotificationListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_notificationList_codec         FieldCodec`1<HomeNotificationStatus> IL2CPP_TYPE_GENERICINST
    // 048 NotificationList                         ModelClassListType RepeatedField`1<HomeNotificationStatus> RepeatedField`1<HomeNotificationStatus> List<HomeNotificationStatus> Pointer
    // 000 MstMissionGroupIdFieldNumber             int IL2CPP_TYPE_I4
    // 050 MstMissionGroupId                        ModelPrimitiveType int int int Int32
    public partial class GetLiveEventAllSongTopPageReply : DataModel
    {
        public GameEventStatus?                         GameEventStatus                         { get; set; }
        public int                                      MstSongId                               { get; set; }
        public EventBreakTimeStatus?                    BreakTime                               { get; set; }
        public EventBonusStatus?                        EventBonus                              { get; set; }
        public List<EventAlbumStatus>?                  AlbumList                               { get; set; }
        public List<LiveEventRankingStatus>?            EventRankingList                        { get; set; }
        public List<HomeNotificationStatus>?            NotificationList                        { get; set; }
        public int                                      MstMissionGroupId                       { get; set; }

        public static GetLiveEventAllSongTopPageReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveEventAllSongTopPageReply() { Pointer= p0 };

            value.GameEventStatus                           = GetObject<GameEventStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameEventStatus.FromPointer); // 0x18 GameEventStatus             ( ModelClassType GameEventStatus GameEventStatus GameEventStatus Pointer )
            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstSongId                   ( ModelPrimitiveType int int int Int32 )
            value.BreakTime                                 = GetObject<EventBreakTimeStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventBreakTimeStatus.FromPointer); // 0x28 BreakTime                   ( ModelClassType EventBreakTimeStatus EventBreakTimeStatus EventBreakTimeStatus Pointer )
            value.EventBonus                                = GetObject<EventBonusStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventBonusStatus.FromPointer); // 0x30 EventBonus                  ( ModelClassType EventBonusStatus EventBonusStatus EventBonusStatus Pointer )
            value.AlbumList                                 = GetObjectList<EventAlbumStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventAlbumStatus.FromPointer); // 0x38 AlbumList                   ( ModelClassListType RepeatedField`1<EventAlbumStatus> RepeatedField`1<EventAlbumStatus> List<EventAlbumStatus> Pointer )
            value.EventRankingList                          = GetObjectList<LiveEventRankingStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveEventRankingStatus.FromPointer); // 0x40 EventRankingList            ( ModelClassListType RepeatedField`1<LiveEventRankingStatus> RepeatedField`1<LiveEventRankingStatus> List<LiveEventRankingStatus> Pointer )
            value.NotificationList                          = GetObjectList<HomeNotificationStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeNotificationStatus.FromPointer); // 0x48 NotificationList            ( ModelClassListType RepeatedField`1<HomeNotificationStatus> RepeatedField`1<HomeNotificationStatus> List<HomeNotificationStatus> Pointer )
            value.MstMissionGroupId                         = GetInt32(new IntPtr(p + 0x050)); // 0x50 MstMissionGroupId           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
