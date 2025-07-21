using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventStatus                              ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    // 018 EventPoint                               ModelPrimitiveType long long long Int64
    // 020 PointRank                                ModelPrimitiveType int int int Int32
    // 024 HighScoreRank                            ModelPrimitiveType int int int Int32
    // 028 EventBonusRate                           ModelPrimitiveType int int int Int32
    // 030 NextStoryTitle                           ModelPrimitiveType string string string String
    // 038 NextStoryChapterPoint                    ModelPrimitiveType long long long Int64
    // 040 MissionGroupId                           ModelPrimitiveType int int int Int32
    // 044 SongId                                   ModelPrimitiveType int int int Int32
    // 048 EventBonusIdolList                       ModelClassListType IReadOnlyList`1<IEventBonusProduceIdolStatus> IReadOnlyList`1<IEventBonusProduceIdolStatus> List<IEventBonusProduceIdolStatus> Pointer
    // 050 MedalGashaStatus                         ModelClassType IMedalGashaStatus IMedalGashaStatus IMedalGashaStatus Pointer
    // 058 Notification                             ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer
    // 060 AlbumList                                ModelClassListType IReadOnlyList`1<IEventAlbumStatus> IReadOnlyList`1<IEventAlbumStatus> List<IEventAlbumStatus> Pointer
    // 068 BreakTime                                ModelClassType IEventBreakTimeStatus IEventBreakTimeStatus IEventBreakTimeStatus Pointer
    // 070 AllSongEventResultViewModel              ModelClassType LiveAllSongEventResultViewModel LiveAllSongEventResultViewModel LiveAllSongEventResultViewModel Pointer
    public partial class LiveEventViewModel : DataModel
    {
        public IGameEventStatus?                        EventStatus                             { get; set; }
        public long                                     EventPoint                              { get; set; }
        public int                                      PointRank                               { get; set; }
        public int                                      HighScoreRank                           { get; set; }
        public int                                      EventBonusRate                          { get; set; }
        public string                                   NextStoryTitle                          { get; set; }
        public long                                     NextStoryChapterPoint                   { get; set; }
        public int                                      MissionGroupId                          { get; set; }
        public int                                      SongId                                  { get; set; }
        public List<IEventBonusProduceIdolStatus>?      EventBonusIdolList                      { get; set; }
        public IMedalGashaStatus?                       MedalGashaStatus                        { get; set; }
        public NotificationManageViewModel?             Notification                            { get; set; }
        public List<IEventAlbumStatus>?                 AlbumList                               { get; set; }
        public IEventBreakTimeStatus?                   BreakTime                               { get; set; }
        public LiveAllSongEventResultViewModel?         AllSongEventResultViewModel             { get; set; }

        public static LiveEventViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventViewModel() { Pointer= p0 };

            value.EventStatus                               = GetObject<IGameEventStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 0x10 EventStatus                 ( ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )
            value.EventPoint                                = GetInt64(new IntPtr(p + 0x018)); // 0x18 EventPoint                  ( ModelPrimitiveType long long long Int64 )
            value.PointRank                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 PointRank                   ( ModelPrimitiveType int int int Int32 )
            value.HighScoreRank                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 HighScoreRank               ( ModelPrimitiveType int int int Int32 )
            value.EventBonusRate                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 EventBonusRate              ( ModelPrimitiveType int int int Int32 )
            value.NextStoryTitle                            = GetString(new IntPtr(p + 0x030)); // 0x30 NextStoryTitle              ( ModelPrimitiveType string string string String )
            value.NextStoryChapterPoint                     = GetInt64(new IntPtr(p + 0x038)); // 0x38 NextStoryChapterPoint       ( ModelPrimitiveType long long long Int64 )
            value.MissionGroupId                            = GetInt32(new IntPtr(p + 0x040)); // 0x40 MissionGroupId              ( ModelPrimitiveType int int int Int32 )
            value.SongId                                    = GetInt32(new IntPtr(p + 0x044)); // 0x44 SongId                      ( ModelPrimitiveType int int int Int32 )
            value.EventBonusIdolList                        = GetObjectList<IEventBonusProduceIdolStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IEventBonusProduceIdolStatus.FromPointer); // 0x48 EventBonusIdolList          ( ModelClassListType IReadOnlyList`1<IEventBonusProduceIdolStatus> IReadOnlyList`1<IEventBonusProduceIdolStatus> List<IEventBonusProduceIdolStatus> Pointer )
            value.MedalGashaStatus                          = GetObject<IMedalGashaStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IMedalGashaStatus.FromPointer); // 0x50 MedalGashaStatus            ( ModelClassType IMedalGashaStatus IMedalGashaStatus IMedalGashaStatus Pointer )
            value.Notification                              = GetObject<NotificationManageViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.NotificationManageViewModel.FromPointer); // 0x58 Notification                ( ModelClassType NotificationManageViewModel NotificationManageViewModel NotificationManageViewModel Pointer )
            value.AlbumList                                 = GetObjectList<IEventAlbumStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IEventAlbumStatus.FromPointer); // 0x60 AlbumList                   ( ModelClassListType IReadOnlyList`1<IEventAlbumStatus> IReadOnlyList`1<IEventAlbumStatus> List<IEventAlbumStatus> Pointer )
            value.BreakTime                                 = GetObject<IEventBreakTimeStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IEventBreakTimeStatus.FromPointer); // 0x68 BreakTime                   ( ModelClassType IEventBreakTimeStatus IEventBreakTimeStatus IEventBreakTimeStatus Pointer )
            value.AllSongEventResultViewModel               = GetObject<LiveAllSongEventResultViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveAllSongEventResultViewModel.FromPointer); // 0x70 AllSongEventResultViewModel ( ModelClassType LiveAllSongEventResultViewModel LiveAllSongEventResultViewModel LiveAllSongEventResultViewModel Pointer )

            return value;
        }
    }
}
