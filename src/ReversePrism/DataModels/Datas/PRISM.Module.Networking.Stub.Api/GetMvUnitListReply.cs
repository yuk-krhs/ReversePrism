using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetMvUnitListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_unitList_codec                 FieldCodec`1<MvUnitStatus> IL2CPP_TYPE_GENERICINST
    // 018 UnitList                                 000185CE7C98 ModelClassListType RepeatedField`1<MvUnitStatus> RepeatedField`1<MvUnitStatus> List<MvUnitStatus> Pointer
    public partial class GetMvUnitListReply : DataModel
    {
        public List<MvUnitStatus>?                      UnitList                                { get; set; }

        public static GetMvUnitListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetMvUnitListReply() { Pointer= p0 };

            value.UnitList                                  = GetObjectList<MvUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MvUnitStatus.FromPointer); // 024662182138 0x18 UnitList                    ( 000185CE7C98 ModelClassListType RepeatedField`1<MvUnitStatus> RepeatedField`1<MvUnitStatus> List<MvUnitStatus> Pointer )

            return value;
        }
    }
}
