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
    public partial class SeasonMission
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
            var value   = new SeasonMission();

            value.MstSeasonMissionId                        = GetInt32(new IntPtr(p + 0x010)); // 0270D562CF28 0x10 MstSeasonMissionId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x018)); // 0270D562CF48 0x18 ReceiveEndDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x028)); // 0270D562CF68 0x28 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x038)); // 0270D562CF88 0x38 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MissionList                               = GetObjectList<ISeasonMissionMissionStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ISeasonMissionMissionStatus.FromPointer); // 0270D562CFA8 0x48 MissionList                 ( 000185D0A1B8 ModelClassListType IReadOnlyList`1<ISeasonMissionMissionStatus> IReadOnlyList`1<ISeasonMissionMissionStatus> List<ISeasonMissionMissionStatus> Pointer )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x050)); // 0270D562CFC8 0x50 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SeasonExp                                 = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0270D562CFE8 0x58 SeasonExp                   ( 0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.SeasonRewardList                          = GetObjectList<SeasonReward>(new IntPtr(p + 0x060), ReversePrism.DataModels.SeasonReward.FromPointer); // 0270D562D008 0x60 SeasonRewardList            ( 000185D15FC8 ModelClassListType IReadOnlyList`1<SeasonReward> IReadOnlyList`1<SeasonReward> List<SeasonReward> Pointer )
            value.IsPremium                                 = GetBool(new IntPtr(p + 0x068)); // 0270D562D028 0x68 IsPremium                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MissionTab                                = GetObject<ISeasonMissionTabStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.ISeasonMissionTabStatus.FromPointer); // 0270D562D048 0x70 MissionTab                  ( 00018662E180 ModelClassType ISeasonMissionTabStatus ISeasonMissionTabStatus ISeasonMissionTabStatus Pointer )
            value.RankRewardTab                             = GetObject<ISeasonMissionTabStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.ISeasonMissionTabStatus.FromPointer); // 0270D562D068 0x78 RankRewardTab               ( 00018662E180 ModelClassType ISeasonMissionTabStatus ISeasonMissionTabStatus ISeasonMissionTabStatus Pointer )
            value.LastDisplayRank                           = GetInt32(new IntPtr(p + 0x080)); // 0270D562D088 0x80 LastDisplayRank             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PremiumRegisteredDate                     = GetDateTime(new IntPtr(p + 0x088)); // 0270D562D0A8 0x88 PremiumRegisteredDate       ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
