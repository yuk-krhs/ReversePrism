using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstMissionGroupId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 LastDisplayDate                          000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 ReceiveEndDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 MissionList                              000185D03738 ModelClassListType IReadOnlyList`1<IMissionStatus> IReadOnlyList`1<IMissionStatus> List<IMissionStatus> Pointer
    // 040 Gauge                                    0001865B47F0 ModelClassType IMissionGaugeStatus IMissionGaugeStatus IMissionGaugeStatus Pointer
    // 048 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C ReceivableCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 MissionGroupType                         000186605E40 ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32
    // 058 GameEvent                                00018651E870 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    public partial class MissionGroup
    {
        public int                                      MstMissionGroupId                       { get; set; }
        public DateTime                                 LastDisplayDate                         { get; set; }
        public DateTime                                 ReceiveEndDate                          { get; set; }
        public List<IMissionStatus>?                    MissionList                             { get; set; }
        public IMissionGaugeStatus?                     Gauge                                   { get; set; }
        public int                                      SortId                                  { get; set; }
        public int                                      ReceivableCount                         { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public MissionGroupType                         MissionGroupType                        { get; set; }
        public IGameEventStatus?                        GameEvent                               { get; set; }

        public static MissionGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionGroup();

            value.MstMissionGroupId                         = GetInt32(new IntPtr(p + 0x010)); // 0270D5555698 0x10 MstMissionGroupId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x018)); // 0270D55556B8 0x18 LastDisplayDate             ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x028)); // 0270D55556D8 0x28 ReceiveEndDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MissionList                               = GetObjectList<IMissionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IMissionStatus.FromPointer); // 0270D55556F8 0x38 MissionList                 ( 000185D03738 ModelClassListType IReadOnlyList`1<IMissionStatus> IReadOnlyList`1<IMissionStatus> List<IMissionStatus> Pointer )
            value.Gauge                                     = GetObject<IMissionGaugeStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IMissionGaugeStatus.FromPointer); // 0270D5555718 0x40 Gauge                       ( 0001865B47F0 ModelClassType IMissionGaugeStatus IMissionGaugeStatus IMissionGaugeStatus Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x048)); // 0270D5555738 0x48 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x04C)); // 0270D5555758 0x4C ReceivableCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x050)); // 0270D5555778 0x50 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MissionGroupType                          = (MissionGroupType)GetInt32(new IntPtr(p + 0x054)); // 0270D5555798 0x54 MissionGroupType            ( 000186605E40 ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32 )
            value.GameEvent                                 = GetObject<IGameEventStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 0270D55557B8 0x58 GameEvent                   ( 00018651E870 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )

            return value;
        }
    }
}
