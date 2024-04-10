using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastDisplayDate                          000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 ReceiveEndDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<MissionGroupStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstMissionGroupIdFieldNumber             int IL2CPP_TYPE_I4
    // 038 MstMissionGroupId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LastDisplayDateFieldNumber               int IL2CPP_TYPE_I4
    // 040 _LastDisplayDate                         000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ReceiveEndDateFieldNumber                int IL2CPP_TYPE_I4
    // 048 _ReceiveEndDate                          000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MissionListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_missionList_codec              FieldCodec`1<MissionStatus> IL2CPP_TYPE_GENERICINST
    // 050 MissionList                              000185CE70D8 ModelClassListType RepeatedField`1<MissionStatus> RepeatedField`1<MissionStatus> List<MissionStatus> Pointer
    // 000 GaugeFieldNumber                         int IL2CPP_TYPE_I4
    // 058 Gauge                                    000186622DD0 ModelClassType MissionGaugeStatus MissionGaugeStatus MissionGaugeStatus Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 060 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ReceivableCountFieldNumber               int IL2CPP_TYPE_I4
    // 064 ReceivableCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 068 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 MissionGroupTypeFieldNumber              int IL2CPP_TYPE_I4
    // 06C MissionGroupType                         0001866240E0 ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32
    // 000 GameEventFieldNumber                     int IL2CPP_TYPE_I4
    // 070 GameEvent                                0001865E7E60 ModelClassType GameEventStatus GameEventStatus GameEventStatus Pointer
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

            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x010)); // 024662262990 0x10 LastDisplayDate             ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x020)); // 0246622629B0 0x20 ReceiveEndDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstMissionGroupId                         = GetInt32(new IntPtr(p + 0x038)); // 024662262A30 0x38 MstMissionGroupId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._LastDisplayDate                          = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 024662262A70 0x40 _LastDisplayDate            ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._ReceiveEndDate                           = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 024662262AB0 0x48 _ReceiveEndDate             ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MissionList                               = GetObjectList<MissionStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.MissionStatus.FromPointer); // 024662262B10 0x50 MissionList                 ( 000185CE70D8 ModelClassListType RepeatedField`1<MissionStatus> RepeatedField`1<MissionStatus> List<MissionStatus> Pointer )
            value.Gauge                                     = GetObject<MissionGaugeStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.MissionGaugeStatus.FromPointer); // 024662262B50 0x58 Gauge                       ( 000186622DD0 ModelClassType MissionGaugeStatus MissionGaugeStatus MissionGaugeStatus Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x060)); // 024662262B90 0x60 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x064)); // 024662262BD0 0x64 ReceivableCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x068)); // 024662262C10 0x68 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MissionGroupType                          = (MissionGroupType)GetInt32(new IntPtr(p + 0x06C)); // 024662262C50 0x6C MissionGroupType            ( 0001866240E0 ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32 )
            value.GameEvent                                 = GetObject<GameEventStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameEventStatus.FromPointer); // 024662262C90 0x70 GameEvent                   ( 0001865E7E60 ModelClassType GameEventStatus GameEventStatus GameEventStatus Pointer )
            value.LastDisplayDate               = ToDateTime(value._LastDisplayDate);
            value.ReceiveEndDate                = ToDateTime(value._ReceiveEndDate);

            return value;
        }
    }
}
