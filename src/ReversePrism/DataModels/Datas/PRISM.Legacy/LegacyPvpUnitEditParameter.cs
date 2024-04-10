using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 EventStatus                              00018651E870 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    // 020 UnitType                                 000186613660 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32
    // 028 UnitList                                 000185D089A8 ModelClassListType IReadOnlyList`1<IPvpUnitStatus> IReadOnlyList`1<IPvpUnitStatus> List<IPvpUnitStatus> Pointer
    // 030 DefencePvpUnitChangeableDate             000185D00A78 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class LegacyPvpUnitEditParameter : DataModel
    {
        public int                                      EventId                                 { get; set; }
        public IGameEventStatus?                        EventStatus                             { get; set; }
        public PvpUnitType                              UnitType                                { get; set; }
        public List<IPvpUnitStatus>?                    UnitList                                { get; set; }
        public DateTime                                 DefencePvpUnitChangeableDate            { get; set; }

        public static LegacyPvpUnitEditParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyPvpUnitEditParameter() { Pointer= p0 };

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 024665EAECB0 0x10 EventId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EventStatus                               = GetObject<IGameEventStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 024665EAECD0 0x18 EventStatus                 ( 00018651E870 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )
            value.UnitType                                  = (PvpUnitType)GetInt32(new IntPtr(p + 0x020)); // 024665EAECF0 0x20 UnitType                    ( 000186613660 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32 )
            value.UnitList                                  = GetObjectList<IPvpUnitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPvpUnitStatus.FromPointer); // 024665EAED10 0x28 UnitList                    ( 000185D089A8 ModelClassListType IReadOnlyList`1<IPvpUnitStatus> IReadOnlyList`1<IPvpUnitStatus> List<IPvpUnitStatus> Pointer )
            value.DefencePvpUnitChangeableDate              = GetDateTime(new IntPtr(p + 0x030)); // 024665EAED30 0x30 DefencePvpUnitChangeableDate ( 000185D00A78 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
