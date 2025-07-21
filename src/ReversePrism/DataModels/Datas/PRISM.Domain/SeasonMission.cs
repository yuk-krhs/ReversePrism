using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstSeasonMissionId                       ModelPrimitiveType int int int Int32
    // 018 ReceiveEndDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 048 MissionList                              ModelClassListType IReadOnlyList`1<ISeasonMissionMissionStatus> IReadOnlyList`1<ISeasonMissionMissionStatus> List<ISeasonMissionMissionStatus> Pointer
    // 050 Rank                                     ModelPrimitiveType int int int Int32
    // 058 SeasonExp                                ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 060 SeasonRewardList                         ModelClassListType IReadOnlyList`1<SeasonReward> IReadOnlyList`1<SeasonReward> List<SeasonReward> Pointer
    // 068 IsPremium                                ModelPrimitiveType bool bool bool Bool
    // 070 MissionTab                               ModelClassType ISeasonMissionTabStatus ISeasonMissionTabStatus ISeasonMissionTabStatus Pointer
    // 078 RankRewardTab                            ModelClassType ISeasonMissionTabStatus ISeasonMissionTabStatus ISeasonMissionTabStatus Pointer
    // 080 LastDisplayRank                          ModelPrimitiveType int int int Int32
    // 088 PremiumRegisteredDate                    ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
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

            value.MstSeasonMissionId                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstSeasonMissionId          ( ModelPrimitiveType int int int Int32 )
            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x018)); // 0x18 ReceiveEndDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x028)); // 0x28 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x038)); // 0x38 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MissionList                               = GetObjectList<ISeasonMissionMissionStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ISeasonMissionMissionStatus.FromPointer); // 0x48 MissionList                 ( ModelClassListType IReadOnlyList`1<ISeasonMissionMissionStatus> IReadOnlyList`1<ISeasonMissionMissionStatus> List<ISeasonMissionMissionStatus> Pointer )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x050)); // 0x50 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.SeasonExp                                 = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0x58 SeasonExp                   ( ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.SeasonRewardList                          = GetObjectList<SeasonReward>(new IntPtr(p + 0x060), ReversePrism.DataModels.SeasonReward.FromPointer); // 0x60 SeasonRewardList            ( ModelClassListType IReadOnlyList`1<SeasonReward> IReadOnlyList`1<SeasonReward> List<SeasonReward> Pointer )
            value.IsPremium                                 = GetBool(new IntPtr(p + 0x068)); // 0x68 IsPremium                   ( ModelPrimitiveType bool bool bool Bool )
            value.MissionTab                                = GetObject<ISeasonMissionTabStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.ISeasonMissionTabStatus.FromPointer); // 0x70 MissionTab                  ( ModelClassType ISeasonMissionTabStatus ISeasonMissionTabStatus ISeasonMissionTabStatus Pointer )
            value.RankRewardTab                             = GetObject<ISeasonMissionTabStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.ISeasonMissionTabStatus.FromPointer); // 0x78 RankRewardTab               ( ModelClassType ISeasonMissionTabStatus ISeasonMissionTabStatus ISeasonMissionTabStatus Pointer )
            value.LastDisplayRank                           = GetInt32(new IntPtr(p + 0x080)); // 0x80 LastDisplayRank             ( ModelPrimitiveType int int int Int32 )
            value.PremiumRegisteredDate                     = GetDateTime(new IntPtr(p + 0x088)); // 0x88 PremiumRegisteredDate       ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
