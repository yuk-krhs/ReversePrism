using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 BeginDate                                000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 EndDate                                  000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 ResultBeginDate                          000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 048 EventPoint                               0001865F8300 ModelPrimitiveType long long long Int64
    // 050 PointRank                                0001865F4260 ModelPrimitiveType int int int Int32
    // 054 HighScoreRank                            0001865F4260 ModelPrimitiveType int int int Int32
    // 058 EventBonusRate                           0001865F4260 ModelPrimitiveType int int int Int32
    // 060 NextStoryTitle                           000186672F10 ModelPrimitiveType string string string String
    // 068 NextStoryChapterPoint                    0001865F8300 ModelPrimitiveType long long long Int64
    // 070 HasMission                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 074 MissionGroupId                           0001865F4260 ModelPrimitiveType int int int Int32
    // 078 SongId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 07C EventState                               0001865F6600 ModelEnumType GameEventState GameEventState GameEventState Int32
    // 080 EventBonusIdolList                       000185CF5408 ModelClassListType IReadOnlyList`1<IEventBonusProduceIdolStatus> IReadOnlyList`1<IEventBonusProduceIdolStatus> List<IEventBonusProduceIdolStatus> Pointer
    // 088 MedalGashaStatus                         0001865AC7D0 ModelClassType IMedalGashaStatus IMedalGashaStatus IMedalGashaStatus Pointer
    public partial class LiveEventViewModel : DataModel
    {
        public int                                      Id                                      { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public DateTime                                 ResultBeginDate                         { get; set; }
        public long                                     EventPoint                              { get; set; }
        public int                                      PointRank                               { get; set; }
        public int                                      HighScoreRank                           { get; set; }
        public int                                      EventBonusRate                          { get; set; }
        public string                                   NextStoryTitle                          { get; set; }
        public long                                     NextStoryChapterPoint                   { get; set; }
        public bool                                     HasMission                              { get; set; }
        public int                                      MissionGroupId                          { get; set; }
        public int                                      SongId                                  { get; set; }
        public GameEventState                           EventState                              { get; set; }
        public List<IEventBonusProduceIdolStatus>?      EventBonusIdolList                      { get; set; }
        public IMedalGashaStatus?                       MedalGashaStatus                        { get; set; }

        public static LiveEventViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventViewModel() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0246662D8250 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x018)); // 0246662D8270 0x18 BeginDate                   ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x028)); // 0246662D8290 0x28 EndDate                     ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ResultBeginDate                           = GetDateTime(new IntPtr(p + 0x038)); // 0246662D82B0 0x38 ResultBeginDate             ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EventPoint                                = GetInt64(new IntPtr(p + 0x048)); // 0246662D82D0 0x48 EventPoint                  ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.PointRank                                 = GetInt32(new IntPtr(p + 0x050)); // 0246662D82F0 0x50 PointRank                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.HighScoreRank                             = GetInt32(new IntPtr(p + 0x054)); // 0246662D8310 0x54 HighScoreRank               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EventBonusRate                            = GetInt32(new IntPtr(p + 0x058)); // 0246662D8330 0x58 EventBonusRate              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.NextStoryTitle                            = GetString(new IntPtr(p + 0x060)); // 0246662D8350 0x60 NextStoryTitle              ( 000186672F10 ModelPrimitiveType string string string String )
            value.NextStoryChapterPoint                     = GetInt64(new IntPtr(p + 0x068)); // 0246662D8370 0x68 NextStoryChapterPoint       ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.HasMission                                = GetBool(new IntPtr(p + 0x070)); // 0246662D8390 0x70 HasMission                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.MissionGroupId                            = GetInt32(new IntPtr(p + 0x074)); // 0246662D83B0 0x74 MissionGroupId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SongId                                    = GetInt32(new IntPtr(p + 0x078)); // 0246662D83D0 0x78 SongId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EventState                                = (GameEventState)GetInt32(new IntPtr(p + 0x07C)); // 0246662D83F0 0x7C EventState                  ( 0001865F6600 ModelEnumType GameEventState GameEventState GameEventState Int32 )
            value.EventBonusIdolList                        = GetObjectList<IEventBonusProduceIdolStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IEventBonusProduceIdolStatus.FromPointer); // 0246662D8410 0x80 EventBonusIdolList          ( 000185CF5408 ModelClassListType IReadOnlyList`1<IEventBonusProduceIdolStatus> IReadOnlyList`1<IEventBonusProduceIdolStatus> List<IEventBonusProduceIdolStatus> Pointer )
            value.MedalGashaStatus                          = GetObject<IMedalGashaStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IMedalGashaStatus.FromPointer); // 0246662D8430 0x88 MedalGashaStatus            ( 0001865AC7D0 ModelClassType IMedalGashaStatus IMedalGashaStatus IMedalGashaStatus Pointer )

            return value;
        }
    }
}
