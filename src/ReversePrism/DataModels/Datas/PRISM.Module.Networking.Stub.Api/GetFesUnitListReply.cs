using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetFesUnitListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesUnitListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_fesUnitList_codec              FieldCodec`1<FesUnitStatus> IL2CPP_TYPE_GENERICINST
    // 018 FesUnitList                              000185CD8458 ModelClassListType RepeatedField`1<FesUnitStatus> RepeatedField`1<FesUnitStatus> List<FesUnitStatus> Pointer
    public partial class GetFesUnitListReply
    {
        public List<FesUnitStatus>?                     FesUnitList                             { get; set; }

        public static GetFesUnitListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetFesUnitListReply();

            value.FesUnitList                               = GetObjectList<FesUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.FesUnitStatus.FromPointer); // 0270D13228C0 0x18 FesUnitList                 ( 000185CD8458 ModelClassListType RepeatedField`1<FesUnitStatus> RepeatedField`1<FesUnitStatus> List<FesUnitStatus> Pointer )

            return value;
        }
    }
}
