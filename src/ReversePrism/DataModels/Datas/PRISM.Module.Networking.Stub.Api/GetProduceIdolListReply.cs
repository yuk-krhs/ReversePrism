using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetProduceIdolListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceIdolListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_produceIdolList_codec          FieldCodec`1<ProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 018 ProduceIdolList                          000185CEBD88 ModelClassListType RepeatedField`1<ProduceIdolStatus> RepeatedField`1<ProduceIdolStatus> List<ProduceIdolStatus> Pointer
    public partial class GetProduceIdolListReply
    {
        public List<ProduceIdolStatus>?                 ProduceIdolList                         { get; set; }

        public static GetProduceIdolListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProduceIdolListReply();

            value.ProduceIdolList                           = GetObjectList<ProduceIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 0270D25F6788 0x18 ProduceIdolList             ( 000185CEBD88 ModelClassListType RepeatedField`1<ProduceIdolStatus> RepeatedField`1<ProduceIdolStatus> List<ProduceIdolStatus> Pointer )

            return value;
        }
    }
}
