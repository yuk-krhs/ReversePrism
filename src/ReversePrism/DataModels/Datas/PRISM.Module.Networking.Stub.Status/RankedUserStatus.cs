using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RankedUserStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Point                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Comment                                  000186671910 ModelPrimitiveType string string string String
    // 000 FavoriteProduceIdolFieldNumber           int IL2CPP_TYPE_I4
    // 038 FavoriteProduceIdol                      000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 040 MstAchievementIdList                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 048 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RankingTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 04C RankingType                              000186762F80 ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 050 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 058 DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    public partial class RankedUserStatus
    {
        public int                                      Rank                                    { get; set; }
        public long                                     Point                                   { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   Comment                                 { get; set; }
        public ProduceIdolStatus?                       FavoriteProduceIdol                     { get; set; }
        public List<int>?                               MstAchievementIdList                    { get; set; }
        public int                                      MstEventId                              { get; set; }
        public EventRankingType                         RankingType                             { get; set; }
        public string                                   UserId                                  { get; set; }
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }

        public static RankedUserStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankedUserStatus();

            value.Rank                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D101DB68 0x18 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Point                                     = GetInt64(new IntPtr(p + 0x020)); // 0270D101DBA8 0x20 Point                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270D101DBE8 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Comment                                   = GetString(new IntPtr(p + 0x030)); // 0270D101DC28 0x30 Comment                     ( 000186671910 ModelPrimitiveType string string string String )
            value.FavoriteProduceIdol                       = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0270D101DC68 0x38 FavoriteProduceIdol         ( 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x040)); // 0270D101DCC8 0x40 MstAchievementIdList        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x048)); // 0270D101DD08 0x48 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x04C)); // 0270D101DD48 0x4C RankingType                 ( 000186762F80 ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.UserId                                    = GetString(new IntPtr(p + 0x050)); // 0270D101DD88 0x50 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x058)); // 0270D101DDC8 0x58 DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )

            return value;
        }
    }
}
