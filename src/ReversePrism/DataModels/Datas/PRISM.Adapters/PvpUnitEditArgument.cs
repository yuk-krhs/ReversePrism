using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 EventStatus                              00018651EB30 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer
    // 020 UnitType                                 000186613920 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32
    // 028 UnitList                                 000185D089A8 ModelClassListType IReadOnlyList`1<IPvpUnitStatus> IReadOnlyList`1<IPvpUnitStatus> List<IPvpUnitStatus> Pointer
    // 030 DefencePvpUnitChangeableDate             000185D00A78 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    public partial class PvpUnitEditArgument
    {
        public int                                      EventId                                 { get; set; }
        public IGameEventStatus?                        EventStatus                             { get; set; }
        public PvpUnitType                              UnitType                                { get; set; }
        public List<IPvpUnitStatus>?                    UnitList                                { get; set; }
        public DateTime                                 DefencePvpUnitChangeableDate            { get; set; }

        public static PvpUnitEditArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUnitEditArgument();

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D661D9C8 0x10 EventId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.EventStatus                               = GetObject<IGameEventStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGameEventStatus.FromPointer); // 0270D661D9E8 0x18 EventStatus                 ( 00018651EB30 ModelClassType IGameEventStatus IGameEventStatus IGameEventStatus Pointer )
            value.UnitType                                  = (PvpUnitType)GetInt32(new IntPtr(p + 0x020)); // 0270D661DA08 0x20 UnitType                    ( 000186613920 ModelEnumType PvpUnitType PvpUnitType PvpUnitType Int32 )
            value.UnitList                                  = GetObjectList<IPvpUnitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPvpUnitStatus.FromPointer); // 0270D661DA28 0x28 UnitList                    ( 000185D089A8 ModelClassListType IReadOnlyList`1<IPvpUnitStatus> IReadOnlyList`1<IPvpUnitStatus> List<IPvpUnitStatus> Pointer )
            value.DefencePvpUnitChangeableDate              = GetDateTime(new IntPtr(p + 0x030)); // 0270D661DA48 0x30 DefencePvpUnitChangeableDate ( 000185D00A78 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )

            return value;
        }
    }
}
