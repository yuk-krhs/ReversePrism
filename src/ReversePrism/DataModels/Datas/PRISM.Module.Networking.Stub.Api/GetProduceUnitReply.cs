using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProduceUnitReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceUnitListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceUnitList_codec          FieldCodec`1<ProduceIdolUnitStatus> IL2CPP_TYPE_GENERICINST
    // 018 ProduceUnitList                          000185CEBFD8 ModelClassListType RepeatedField`1<ProduceIdolUnitStatus> RepeatedField`1<ProduceIdolUnitStatus> List<ProduceIdolUnitStatus> Pointer
    public partial class GetProduceUnitReply
    {
        public List<ProduceIdolUnitStatus>?             ProduceUnitList                         { get; set; }

        public static GetProduceUnitReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProduceUnitReply();

            value.ProduceUnitList                           = GetObjectList<ProduceIdolUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolUnitStatus.FromPointer); // 0270D2587D98 0x18 ProduceUnitList             ( 000185CEBFD8 ModelClassListType RepeatedField`1<ProduceIdolUnitStatus> RepeatedField`1<ProduceIdolUnitStatus> List<ProduceIdolUnitStatus> Pointer )

            return value;
        }
    }
}
