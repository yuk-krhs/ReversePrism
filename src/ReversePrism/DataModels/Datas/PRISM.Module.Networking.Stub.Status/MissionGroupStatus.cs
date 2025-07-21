using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastDisplayDate                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 ReceiveEndDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<MissionGroupStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstMissionGroupIdFieldNumber             int IL2CPP_TYPE_I4
    // 038 MstMissionGroupId                        ModelPrimitiveType int int int Int32
    // 000 LastDisplayDateFieldNumber               int IL2CPP_TYPE_I4
    // 040 _LastDisplayDate                         ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ReceiveEndDateFieldNumber                int IL2CPP_TYPE_I4
    // 048 _ReceiveEndDate                          ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MissionListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_missionList_codec              FieldCodec`1<MissionStatus> IL2CPP_TYPE_GENERICINST
    // 050 MissionList                              ModelClassListType RepeatedField`1<MissionStatus> RepeatedField`1<MissionStatus> List<MissionStatus> Pointer
    // 000 GaugeFieldNumber                         int IL2CPP_TYPE_I4
    // 058 Gauge                                    ModelClassType MissionGaugeStatus MissionGaugeStatus MissionGaugeStatus Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 060 SortId                                   ModelPrimitiveType int int int Int32
    // 000 ReceivableCountFieldNumber               int IL2CPP_TYPE_I4
    // 064 ReceivableCount                          ModelPrimitiveType int int int Int32
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 068 IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 000 MissionGroupTypeFieldNumber              int IL2CPP_TYPE_I4
    // 06C MissionGroupType                         ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32
    // 000 GameEventFieldNumber                     int IL2CPP_TYPE_I4
    // 070 GameEvent                                ModelClassType GameEventStatus GameEventStatus GameEventStatus Pointer
    public partial class MissionGroupStatus : DataModel
    {
        public DateTime                                 LastDisplayDate                         { get; set; }
        public DateTime                                 ReceiveEndDate                          { get; set; }
        public int                                      MstMissionGroupId                       { get; set; }
        public Timestamp?                               _LastDisplayDate                        { get; set; }
        public Timestamp?                               _ReceiveEndDate                         { get; set; }
        public List<MissionStatus>?                     MissionList                             { get; set; }
        public MissionGaugeStatus?                      Gauge                                   { get; set; }
        public int                                      SortId                                  { get; set; }
        public int                                      ReceivableCount                         { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public MissionGroupType                         MissionGroupType                        { get; set; }
        public GameEventStatus?                         GameEvent                               { get; set; }

        public static MissionGroupStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionGroupStatus() { Pointer= p0 };

            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x010)); // 0x10 LastDisplayDate             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x020)); // 0x20 ReceiveEndDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstMissionGroupId                         = GetInt32(new IntPtr(p + 0x038)); // 0x38 MstMissionGroupId           ( ModelPrimitiveType int int int Int32 )
            value._LastDisplayDate                          = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0x40 _LastDisplayDate            ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._ReceiveEndDate                           = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0x48 _ReceiveEndDate             ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MissionList                               = GetObjectList<MissionStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.MissionStatus.FromPointer); // 0x50 MissionList                 ( ModelClassListType RepeatedField`1<MissionStatus> RepeatedField`1<MissionStatus> List<MissionStatus> Pointer )
            value.Gauge                                     = GetObject<MissionGaugeStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.MissionGaugeStatus.FromPointer); // 0x58 Gauge                       ( ModelClassType MissionGaugeStatus MissionGaugeStatus MissionGaugeStatus Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x060)); // 0x60 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x064)); // 0x64 ReceivableCount             ( ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x068)); // 0x68 IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.MissionGroupType                          = (MissionGroupType)GetInt32(new IntPtr(p + 0x06C)); // 0x6C MissionGroupType            ( ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32 )
            value.GameEvent                                 = GetObject<GameEventStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameEventStatus.FromPointer); // 0x70 GameEvent                   ( ModelClassType GameEventStatus GameEventStatus GameEventStatus Pointer )
            value.LastDisplayDate               = ToDateTime(value._LastDisplayDate);
            value.ReceiveEndDate                = ToDateTime(value._ReceiveEndDate);

            return value;
        }
    }
}
