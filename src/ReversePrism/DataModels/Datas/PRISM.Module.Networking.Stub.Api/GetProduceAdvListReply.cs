using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProduceAdvListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AdvListFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_advList_codec                  FieldCodec`1<ProduceAdvStatus> IL2CPP_TYPE_GENERICINST
    // 018 AdvList                                  ModelClassListType RepeatedField`1<ProduceAdvStatus> RepeatedField`1<ProduceAdvStatus> List<ProduceAdvStatus> Pointer
    public partial class GetProduceAdvListReply : DataModel
    {
        public List<ProduceAdvStatus>?                  AdvList                                 { get; set; }

        public static GetProduceAdvListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProduceAdvListReply() { Pointer= p0 };

            value.AdvList                                   = GetObjectList<ProduceAdvStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAdvStatus.FromPointer); // 0x18 AdvList                     ( ModelClassListType RepeatedField`1<ProduceAdvStatus> RepeatedField`1<ProduceAdvStatus> List<ProduceAdvStatus> Pointer )

            return value;
        }
    }
}
