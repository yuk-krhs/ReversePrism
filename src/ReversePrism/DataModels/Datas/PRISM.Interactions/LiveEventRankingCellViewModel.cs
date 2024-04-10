using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rank                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 018 UserId                                   000186672F10 ModelPrimitiveType string string string String
    // 020 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 028 HighScore                                0001865F8300 ModelPrimitiveType long long long Int64
    // 030 IsMyself                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 038 ProduceIdolStatusForIcon                 0001865EB580 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 040 MstAchievementIdList                     000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 048 RankingType                              0001865F1FD0 ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 04C DifficultyLevel                          00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 050 PointProduct                             0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 058 Comment                                  000186672F10 ModelPrimitiveType string string string String
    public partial class LiveEventRankingCellViewModel : DataModel
    {
        public int                                      Rank                                    { get; set; }
        public string                                   UserId                                  { get; set; }
        public string                                   Name                                    { get; set; }
        public long                                     HighScore                               { get; set; }
        public bool                                     IsMyself                                { get; set; }
        public IProduceIdolStatus?                      ProduceIdolStatusForIcon                { get; set; }
        public List<int>?                               MstAchievementIdList                    { get; set; }
        public EventRankingType                         RankingType                             { get; set; }
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public IProductStatus?                          PointProduct                            { get; set; }
        public string                                   Comment                                 { get; set; }

        public static LiveEventRankingCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingCellViewModel() { Pointer= p0 };

            value.Rank                                      = GetInt32(new IntPtr(p + 0x010)); // 02466B993620 0x10 Rank                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 02466B993640 0x18 UserId                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 02466B993660 0x20 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.HighScore                                 = GetInt64(new IntPtr(p + 0x028)); // 02466B993680 0x28 HighScore                   ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.IsMyself                                  = GetBool(new IntPtr(p + 0x030)); // 02466B9936A0 0x30 IsMyself                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ProduceIdolStatusForIcon                  = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 02466B9936C0 0x38 ProduceIdolStatusForIcon    ( 0001865EB580 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x040)); // 02466B9936E0 0x40 MstAchievementIdList        ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x048)); // 02466B993700 0x48 RankingType                 ( 0001865F1FD0 ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x04C)); // 02466B993720 0x4C DifficultyLevel             ( 00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.PointProduct                              = GetObject<IProductStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProductStatus.FromPointer); // 02466B993740 0x50 PointProduct                ( 0001865F9930 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.Comment                                   = GetString(new IntPtr(p + 0x058)); // 02466B993760 0x58 Comment                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
