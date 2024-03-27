using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetExchangeGroupListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ExchangeGroupListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_exchangeGroupList_codec        FieldCodec`1<ExchangeGroupStatus> IL2CPP_TYPE_GENERICINST
    // 018 ExchangeGroupList                        000185CD6408 ModelClassListType RepeatedField`1<ExchangeGroupStatus> RepeatedField`1<ExchangeGroupStatus> List<ExchangeGroupStatus> Pointer
    public partial class GetExchangeGroupListReply
    {
        public List<ExchangeGroupStatus>?               ExchangeGroupList                       { get; set; }

        public static GetExchangeGroupListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetExchangeGroupListReply();

            value.ExchangeGroupList                         = GetObjectList<ExchangeGroupStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExchangeGroupStatus.FromPointer); // 0270D121F140 0x18 ExchangeGroupList           ( 000185CD6408 ModelClassListType RepeatedField`1<ExchangeGroupStatus> RepeatedField`1<ExchangeGroupStatus> List<ExchangeGroupStatus> Pointer )

            return value;
        }
    }
}
