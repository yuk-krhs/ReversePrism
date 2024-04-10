using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLiveUnitReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_unitList_codec                 FieldCodec`1<LiveUnitDetailStatus> IL2CPP_TYPE_GENERICINST
    // 018 UnitList                                 000185CE40A8 ModelClassListType RepeatedField`1<LiveUnitDetailStatus> RepeatedField`1<LiveUnitDetailStatus> List<LiveUnitDetailStatus> Pointer
    public partial class GetLiveUnitReply : DataModel
    {
        public List<LiveUnitDetailStatus>?              UnitList                                { get; set; }

        public static GetLiveUnitReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveUnitReply() { Pointer= p0 };

            value.UnitList                                  = GetObjectList<LiveUnitDetailStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveUnitDetailStatus.FromPointer); // 02466217F150 0x18 UnitList                    ( 000185CE40A8 ModelClassListType RepeatedField`1<LiveUnitDetailStatus> RepeatedField`1<LiveUnitDetailStatus> List<LiveUnitDetailStatus> Pointer )

            return value;
        }
    }
}
