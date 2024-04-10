using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSeasonMissionId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 ReceiveEndDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 048 MissionList                              000185D0A1B8 ModelClassListType IReadOnlyList`1<ISeasonMissionMissionStatus> IReadOnlyList`1<ISeasonMissionMissionStatus> List<ISeasonMissionMissionStatus> Pointer
    // 050 Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 SeasonExp                                0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 060 SeasonRewardList                         000185D15FC8 ModelClassListType IReadOnlyList`1<SeasonReward> IReadOnlyList`1<SeasonReward> List<SeasonReward> Pointer
    // 068 IsPremium                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 MissionTab                               00018662E180 ModelClassType ISeasonMissionTabStatus ISeasonMissionTabStatus ISeasonMissionTabStatus Pointer
    // 078 RankRewardTab                            00018662E180 ModelClassType ISeasonMissionTabStatus ISeasonMissionTabStatus ISeasonMissionTabStatus Pointer
    // 080 LastDisplayRank                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 PremiumRegisteredDate                    000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class SeasonMission : DataModel
    {
        public int                                      MstSeasonMissionId                      { get; set; }
        public DateTime                                 ReceiveEndDate                          { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public List<ISeasonMissionMissionStatus>?       MissionList                             { get; set; }
        public int                                      Rank                                    { get; set; }
        public ILimitedValueStatus?                     SeasonExp                               { get; set; }
        public List<SeasonReward>?                      SeasonRewardList                        { get; set; }
        public bool                                     IsPremium                               { get; set; }
        public ISeasonMissionTabStatus?                 MissionTab                              { get; set; }
        public ISeasonMissionTabStatus?                 RankRewardTab                           { get; set; }
        public int                                      LastDisplayRank                         { get; set; }
        public DateTime                                 PremiumRegisteredDate                   { get; set; }

        public static SeasonMission? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMission() { Pointer= p0 };

            value.MstSeasonMissionId                        = GetInt32(new IntPtr(p + 0x010)); // 02466568E0A0 0x10 MstSeasonMissionId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x018)); // 02466568E0C0 0x18 ReceiveEndDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x028)); // 02466568E0E0 0x28 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x038)); // 02466568E100 0x38 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MissionList                               = GetObjectList<ISeasonMissionMissionStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ISeasonMissionMissionStatus.FromPointer); // 02466568E120 0x48 MissionList                 ( 000185D0A1B8 ModelClassListType IReadOnlyList`1<ISeasonMissionMissionStatus> IReadOnlyList`1<ISeasonMissionMissionStatus> List<ISeasonMissionMissionStatus> Pointer )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x050)); // 02466568E140 0x50 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SeasonExp                                 = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 02466568E160 0x58 SeasonExp                   ( 0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.SeasonRewardList                          = GetObjectList<SeasonReward>(new IntPtr(p + 0x060), ReversePrism.DataModels.SeasonReward.FromPointer); // 02466568E180 0x60 SeasonRewardList            ( 000185D15FC8 ModelClassListType IReadOnlyList`1<SeasonReward> IReadOnlyList`1<SeasonReward> List<SeasonReward> Pointer )
            value.IsPremium                                 = GetBool(new IntPtr(p + 0x068)); // 02466568E1A0 0x68 IsPremium                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MissionTab                                = GetObject<ISeasonMissionTabStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.ISeasonMissionTabStatus.FromPointer); // 02466568E1C0 0x70 MissionTab                  ( 00018662E180 ModelClassType ISeasonMissionTabStatus ISeasonMissionTabStatus ISeasonMissionTabStatus Pointer )
            value.RankRewardTab                             = GetObject<ISeasonMissionTabStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.ISeasonMissionTabStatus.FromPointer); // 02466568E1E0 0x78 RankRewardTab               ( 00018662E180 ModelClassType ISeasonMissionTabStatus ISeasonMissionTabStatus ISeasonMissionTabStatus Pointer )
            value.LastDisplayRank                           = GetInt32(new IntPtr(p + 0x080)); // 02466568E200 0x80 LastDisplayRank             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PremiumRegisteredDate                     = GetDateTime(new IntPtr(p + 0x088)); // 02466568E220 0x88 PremiumRegisteredDate       ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
