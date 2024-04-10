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
    // 028 HighScore                                0001865F4260 ModelPrimitiveType int int int Int32
    // 02C IsMyself                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 030 ProduceIdolStatusForIcon                 0001865EB580 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer
    // 038 MstAchievementIdList                     000185D11F18 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 040 DivisionType                             0001866EF3F0 ModelEnumType ScoreRankingDivisionType ScoreRankingDivisionType ScoreRankingDivisionType Int32
    // 044 TotalPower                               0001865F4260 ModelPrimitiveType int int int Int32
    // 048 IdolList                                 000185CE5A18 ModelClassListType List`1<ILiveRankingUnitIdolStatus> List`1<ILiveRankingUnitIdolStatus> List<ILiveRankingUnitIdolStatus> Pointer
    // 050 IsExtended                               000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.Rank                                      = GetInt32(new IntPtr(p + 0x010)); // 02466B473D40 0x10 Rank                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 02466B473D60 0x18 UserId                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 02466B473D80 0x20 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.HighScore                                 = GetInt32(new IntPtr(p + 0x028)); // 02466B473DA0 0x28 HighScore                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsMyself                                  = GetBool(new IntPtr(p + 0x02C)); // 02466B473DC0 0x2C IsMyself                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ProduceIdolStatusForIcon                  = GetObject<IProduceIdolStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 02466B473DE0 0x30 ProduceIdolStatusForIcon    ( 0001865EB580 ModelClassType IProduceIdolStatus IProduceIdolStatus IProduceIdolStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x038)); // 02466B473E00 0x38 MstAchievementIdList        ( 000185D11F18 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.DivisionType                              = (ScoreRankingDivisionType)GetInt32(new IntPtr(p + 0x040)); // 02466B473E20 0x40 DivisionType                ( 0001866EF3F0 ModelEnumType ScoreRankingDivisionType ScoreRankingDivisionType ScoreRankingDivisionType Int32 )
            value.TotalPower                                = GetInt32(new IntPtr(p + 0x044)); // 02466B473E40 0x44 TotalPower                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IdolList                                  = GetObjectList<ILiveRankingUnitIdolStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ILiveRankingUnitIdolStatus.FromPointer); // 02466B473E60 0x48 IdolList                    ( 000185CE5A18 ModelClassListType List`1<ILiveRankingUnitIdolStatus> List`1<ILiveRankingUnitIdolStatus> List<ILiveRankingUnitIdolStatus> Pointer )
            value.IsExtended                                = GetBool(new IntPtr(p + 0x050)); // 02466B473E80 0x50 IsExtended                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
