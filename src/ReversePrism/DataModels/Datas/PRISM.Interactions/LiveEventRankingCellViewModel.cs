using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rank                                     ModelPrimitiveType int int int Int32
    // 018 UserId                                   ModelPrimitiveType string string string String
    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 HighScore                                ModelPrimitiveType long long long Int64
    // 030 IsMyself                                 ModelPrimitiveType bool bool bool Bool
    // 038 ProduceIdolStatusForIcon                 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 040 MstAchievementIdList                     ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 048 RankingType                              ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 04C DifficultyLevel                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 050 Point                                    ModelPrimitiveType long long long Int64
    // 058 PointProduct                             ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 060 Comment                                  ModelPrimitiveType string string string String
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
        public long                                     Point                                   { get; set; }
        public IProductStatus?                          PointProduct                            { get; set; }
        public string                                   Comment                                 { get; set; }

        public static LiveEventRankingCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingCellViewModel() { Pointer= p0 };

            value.Rank                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 0x18 UserId                      ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.HighScore                                 = GetInt64(new IntPtr(p + 0x028)); // 0x28 HighScore                   ( ModelPrimitiveType long long long Int64 )
            value.IsMyself                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 IsMyself                    ( ModelPrimitiveType bool bool bool Bool )
            value.ProduceIdolStatusForIcon                  = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0x38 ProduceIdolStatusForIcon    ( ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x040)); // 0x40 MstAchievementIdList        ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x048)); // 0x48 RankingType                 ( ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x04C)); // 0x4C DifficultyLevel             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.Point                                     = GetInt64(new IntPtr(p + 0x050)); // 0x50 Point                       ( ModelPrimitiveType long long long Int64 )
            value.PointProduct                              = GetObject<IProductStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x58 PointProduct                ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.Comment                                   = GetString(new IntPtr(p + 0x060)); // 0x60 Comment                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
