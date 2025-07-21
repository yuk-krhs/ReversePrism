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
    // 018 Rank                                     ModelPrimitiveType int int int Int32
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Point                                    ModelPrimitiveType long long long Int64
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Name                                     ModelPrimitiveType string string string String
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Comment                                  ModelPrimitiveType string string string String
    // 000 FavoriteProduceIdolFieldNumber           int IL2CPP_TYPE_I4
    // 038 FavoriteProduceIdol                      ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 040 MstAchievementIdList                     ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 048 MstEventId                               ModelPrimitiveType int int int Int32
    // 000 RankingTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 04C RankingType                              ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 050 UserId                                   ModelPrimitiveType string string string String
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 058 DifficultyLevel                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 MstEventRankingIdFieldNumber             int IL2CPP_TYPE_I4
    // 05C MstEventRankingId                        ModelPrimitiveType int int int Int32
    // 000 RankGradeFieldNumber                     int IL2CPP_TYPE_I4
    // 060 RankGrade                                ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32
    public partial class RankedUserStatus : DataModel
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
        public int                                      MstEventRankingId                       { get; set; }
        public EventRankGrade                           RankGrade                               { get; set; }

        public static RankedUserStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankedUserStatus() { Pointer= p0 };

            value.Rank                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.Point                                     = GetInt64(new IntPtr(p + 0x020)); // 0x20 Point                       ( ModelPrimitiveType long long long Int64 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.Comment                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Comment                     ( ModelPrimitiveType string string string String )
            value.FavoriteProduceIdol                       = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0x38 FavoriteProduceIdol         ( ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x040)); // 0x40 MstAchievementIdList        ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x048)); // 0x48 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x04C)); // 0x4C RankingType                 ( ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.UserId                                    = GetString(new IntPtr(p + 0x050)); // 0x50 UserId                      ( ModelPrimitiveType string string string String )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x058)); // 0x58 DifficultyLevel             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.MstEventRankingId                         = GetInt32(new IntPtr(p + 0x05C)); // 0x5C MstEventRankingId           ( ModelPrimitiveType int int int Int32 )
            value.RankGrade                                 = (EventRankGrade)GetInt32(new IntPtr(p + 0x060)); // 0x60 RankGrade                   ( ModelEnumType EventRankGrade EventRankGrade EventRankGrade Int32 )

            return value;
        }
    }
}
