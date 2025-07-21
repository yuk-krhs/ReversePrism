using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstMissionGroupId                        ModelPrimitiveType int int int Int32
    // 018 LastDisplayDate                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 ReceiveEndDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 MissionList                              ModelClassListType IReadOnlyList`1<IMissionStatus> IReadOnlyList`1<IMissionStatus> List<IMissionStatus> Pointer
    // 040 Gauge                                    ModelClassType IMissionGaugeStatus IMissionGaugeStatus IMissionGaugeStatus Pointer
    // 048 SortId                                   ModelPrimitiveType int int int Int32
    // 04C ReceivableCount                          ModelPrimitiveType int int int Int32
    // 050 IsNew                                    ModelPrimitiveType bool bool bool Bool
    // 054 MissionGroupType                         ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32
    // 058 GameEvent                                ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    public partial class MissionGroup : DataModel
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
            var value   = new MissionGroup() { Pointer= p0 };

            value.MstMissionGroupId                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstMissionGroupId           ( ModelPrimitiveType int int int Int32 )
            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x018)); // 0x18 LastDisplayDate             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ReceiveEndDate                            = GetDateTime(new IntPtr(p + 0x028)); // 0x28 ReceiveEndDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MissionList                               = GetObjectList<IMissionStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IMissionStatus.FromPointer); // 0x38 MissionList                 ( ModelClassListType IReadOnlyList`1<IMissionStatus> IReadOnlyList`1<IMissionStatus> List<IMissionStatus> Pointer )
            value.Gauge                                     = GetObject<IMissionGaugeStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IMissionGaugeStatus.FromPointer); // 0x40 Gauge                       ( ModelClassType IMissionGaugeStatus IMissionGaugeStatus IMissionGaugeStatus Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x048)); // 0x48 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x04C)); // 0x4C ReceivableCount             ( ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x050)); // 0x50 IsNew                       ( ModelPrimitiveType bool bool bool Bool )
            value.MissionGroupType                          = (MissionGroupType)GetInt32(new IntPtr(p + 0x054)); // 0x54 MissionGroupType            ( ModelEnumType MissionGroupType MissionGroupType MissionGroupType Int32 )
            value.GameEvent                                 = GetObject<IGameEventStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 0x58 GameEvent                   ( ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )

            return value;
        }
    }
}
