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
    // 028 HighScore                                ModelPrimitiveType int int int Int32
    // 02C IsMyself                                 ModelPrimitiveType bool bool bool Bool
    // 030 ProduceIdolStatusForIcon                 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 038 MstAchievementIdList                     ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 040 DivisionType                             ModelEnumType ScoreRankingDivisionType ScoreRankingDivisionType ScoreRankingDivisionType Int32
    // 044 TotalPower                               ModelPrimitiveType int int int Int32
    // 048 IdolList                                 ModelClassListType List`1<ILiveRankingUnitIdolStatus> List`1<ILiveRankingUnitIdolStatus> List<ILiveRankingUnitIdolStatus> Pointer
    // 050 IsExtended                               ModelPrimitiveType bool bool bool Bool
    public partial class MusicScoreRankingViewModel : DataModel
    {
        public int                                      Rank                                    { get; set; }
        public string                                   UserId                                  { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      HighScore                               { get; set; }
        public bool                                     IsMyself                                { get; set; }
        public IProduceIdolStatus?                      ProduceIdolStatusForIcon                { get; set; }
        public List<int>?                               MstAchievementIdList                    { get; set; }
        public ScoreRankingDivisionType                 DivisionType                            { get; set; }
        public int                                      TotalPower                              { get; set; }
        public List<ILiveRankingUnitIdolStatus>?        IdolList                                { get; set; }
        public bool                                     IsExtended                              { get; set; }

        public static MusicScoreRankingViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicScoreRankingViewModel() { Pointer= p0 };

            value.Rank                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 0x18 UserId                      ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.HighScore                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 HighScore                   ( ModelPrimitiveType int int int Int32 )
            value.IsMyself                                  = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsMyself                    ( ModelPrimitiveType bool bool bool Bool )
            value.ProduceIdolStatusForIcon                  = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0x30 ProduceIdolStatusForIcon    ( ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x038)); // 0x38 MstAchievementIdList        ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.DivisionType                              = (ScoreRankingDivisionType)GetInt32(new IntPtr(p + 0x040)); // 0x40 DivisionType                ( ModelEnumType ScoreRankingDivisionType ScoreRankingDivisionType ScoreRankingDivisionType Int32 )
            value.TotalPower                                = GetInt32(new IntPtr(p + 0x044)); // 0x44 TotalPower                  ( ModelPrimitiveType int int int Int32 )
            value.IdolList                                  = GetObjectList<ILiveRankingUnitIdolStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ILiveRankingUnitIdolStatus.FromPointer); // 0x48 IdolList                    ( ModelClassListType List`1<ILiveRankingUnitIdolStatus> List`1<ILiveRankingUnitIdolStatus> List<ILiveRankingUnitIdolStatus> Pointer )
            value.IsExtended                                = GetBool(new IntPtr(p + 0x050)); // 0x50 IsExtended                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
