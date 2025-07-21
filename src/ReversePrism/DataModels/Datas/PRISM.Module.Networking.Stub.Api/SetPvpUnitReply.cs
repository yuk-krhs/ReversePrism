using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DefensePvpUnitChangeableDate             ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SetPvpUnitReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_unitList_codec                 FieldCodec`1<PvpUnitStatus> IL2CPP_TYPE_GENERICINST
    // 028 UnitList                                 ModelClassListType RepeatedField`1<PvpUnitStatus> RepeatedField`1<PvpUnitStatus> List<PvpUnitStatus> Pointer
    // 000 DefensePvpUnitChangeableDateFieldNumber  int IL2CPP_TYPE_I4
    // 030 _DefensePvpUnitChangeableDate            ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class SetPvpUnitReply : DataModel
    {
        public DateTime                                 DefensePvpUnitChangeableDate            { get; set; }
        public List<PvpUnitStatus>?                     UnitList                                { get; set; }
        public Timestamp?                               _DefensePvpUnitChangeableDate           { get; set; }

        public static SetPvpUnitReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetPvpUnitReply() { Pointer= p0 };

            value.DefensePvpUnitChangeableDate              = GetDateTime(new IntPtr(p + 0x010)); // 0x10 DefensePvpUnitChangeableDate ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.UnitList                                  = GetObjectList<PvpUnitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpUnitStatus.FromPointer); // 0x28 UnitList                    ( ModelClassListType RepeatedField`1<PvpUnitStatus> RepeatedField`1<PvpUnitStatus> List<PvpUnitStatus> Pointer )
            value._DefensePvpUnitChangeableDate             = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0x30 _DefensePvpUnitChangeableDate ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.DefensePvpUnitChangeableDate  = ToDateTime(value._DefensePvpUnitChangeableDate);

            return value;
        }
    }
}
