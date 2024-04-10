using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReceiveEndDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 040 PremiumRegisteredDate                    000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SeasonMissionStatus> IL2CPP_TYPE_GENERICINST
    // 050 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSeasonMissionIdFieldNumber            int IL2CPP_TYPE_I4
    // 058 MstSeasonMissionId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ReceiveEndDateFieldNumber                int IL2CPP_TYPE_I4
    // 060 _ReceiveEndDate                          000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 068 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 070 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MissionListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_missionList_codec              FieldCodec`1<SeasonMissionMissionStatus> IL2CPP_TYPE_GENERICINST
    // 078 MissionList                              000185CF0198 ModelClassListType RepeatedField`1<SeasonMissionMissionStatus> RepeatedField`1<SeasonMissionMissionStatus> List<SeasonMissionMissionStatus> Pointer
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 080 Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SeasonExpFieldNumber                     int IL2CPP_TYPE_I4
    // 088 SeasonExp                                00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 SeasonRewardListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_seasonRewardList_codec         FieldCodec`1<SeasonRewardStatus> IL2CPP_TYPE_GENERICINST
    // 090 SeasonRewardList                         000185CF0608 ModelClassListType RepeatedField`1<SeasonRewardStatus> RepeatedField`1<SeasonRewardStatus> List<SeasonRewardStatus> Pointer
    // 000 IsPremiumFieldNumber                     int IL2CPP_TYPE_I4
    // 098 IsPremium                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 MissionTabFieldNumber                    int IL2CPP_TYPE_I4
    // 0A0 MissionTab                               000186709060 ModelClassType SeasonMissionTabStatus SeasonMissionTabStatus SeasonMissionTabStatus Pointer
    // 000 RankRewardTabFieldNumber                 int IL2CPP_TYPE_I4
    // 0A8 RankRewardTab                            000186709060 ModelClassType SeasonMissionTabStatus SeasonMissionTabStatus SeasonMissionTabStatus Pointer
    // 000 LastDisplayRankFieldNumber               int IL2CPP_TYPE_I4
    // 0B0 LastDisplayRank                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PremiumRegisteredDateFieldNumber         int IL2CPP_TYPE_I4
    // 0B8 _PremiumRegisteredDate                   000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class SeasonMissionStatus : DataModel
    {
        public DateTime                                 ReceiveEndDate                          { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public DateTime                                 PremiumRegisteredDate                   { get; set; }
        public int                                      MstSeasonMissionId                      { get; set; }
        public Timestamp?                               _ReceiveEndDate                         { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public List<SeasonMissionMissionStatus>?        MissionList                             { get; set; }
        public int                                      Rank                                    { get; set; }
        public LimitedValueStatus?                      SeasonExp                               { get; set; }
        public List<SeasonRewardStatus>?                SeasonRewardList                        { get; set; }
        public bool                                     IsPremium                               { get; set; }
        public SeasonMissionTabStatus?                  MissionTab                              { get; set; }
        public SeasonMissionTabStatus?                  RankRewardTab                           { get; set; }
        public int                                      LastDisplayRank                         { get; set; }
        public Timestamp?                               _PremiumRegisteredDate                  { get; set; }

        public static SeasonMissionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionStatus() { Pointer= p0 };

            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x010)); // 0246626F5008 0x10 ReceiveEndDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 0246626F5028 0x20 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x030)); // 0246626F5048 0x30 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PremiumRegisteredDate                     = GetDateTime(new IntPtr(p + 0x040)); // 0246626F5068 0x40 PremiumRegisteredDate       ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstSeasonMissionId                        = GetInt32(new IntPtr(p + 0x058)); // 0246626F50E8 0x58 MstSeasonMissionId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._ReceiveEndDate                           = GetObject<Timestamp>(new IntPtr(p + 0x060), ReversePrism.DataModels.Timestamp.FromPointer); // 0246626F5128 0x60 _ReceiveEndDate             ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x068), ReversePrism.DataModels.Timestamp.FromPointer); // 0246626F5168 0x68 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x070), ReversePrism.DataModels.Timestamp.FromPointer); // 0246626F51A8 0x70 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MissionList                               = GetObjectList<SeasonMissionMissionStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.SeasonMissionMissionStatus.FromPointer); // 0246626F5208 0x78 MissionList                 ( 000185CF0198 ModelClassListType RepeatedField`1<SeasonMissionMissionStatus> RepeatedField`1<SeasonMissionMissionStatus> List<SeasonMissionMissionStatus> Pointer )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x080)); // 0246626F5248 0x80 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SeasonExp                                 = GetObject<LimitedValueStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0246626F5288 0x88 SeasonExp                   ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.SeasonRewardList                          = GetObjectList<SeasonRewardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.SeasonRewardStatus.FromPointer); // 0246626F52E8 0x90 SeasonRewardList            ( 000185CF0608 ModelClassListType RepeatedField`1<SeasonRewardStatus> RepeatedField`1<SeasonRewardStatus> List<SeasonRewardStatus> Pointer )
            value.IsPremium                                 = GetBool(new IntPtr(p + 0x098)); // 0246626F5328 0x98 IsPremium                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MissionTab                                = GetObject<SeasonMissionTabStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SeasonMissionTabStatus.FromPointer); // 0246626F5368 0xA0 MissionTab                  ( 000186709060 ModelClassType SeasonMissionTabStatus SeasonMissionTabStatus SeasonMissionTabStatus Pointer )
            value.RankRewardTab                             = GetObject<SeasonMissionTabStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SeasonMissionTabStatus.FromPointer); // 0246626F53A8 0xA8 RankRewardTab               ( 000186709060 ModelClassType SeasonMissionTabStatus SeasonMissionTabStatus SeasonMissionTabStatus Pointer )
            value.LastDisplayRank                           = GetInt32(new IntPtr(p + 0x0B0)); // 0246626F53E8 0xB0 LastDisplayRank             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._PremiumRegisteredDate                    = GetObject<Timestamp>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Timestamp.FromPointer); // 0246626F5428 0xB8 _PremiumRegisteredDate      ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ReceiveEndDate                = ToDateTime(value._ReceiveEndDate);
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);
            value.PremiumRegisteredDate         = ToDateTime(value._PremiumRegisteredDate);

            return value;
        }
    }
}
