using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetExchangePurchaseHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HistoryListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_historyList_codec              FieldCodec`1<ExchangePurchaseHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 018 HistoryList                              000185CD6AE8 ModelClassListType RepeatedField`1<ExchangePurchaseHistoryStatus> RepeatedField`1<ExchangePurchaseHistoryStatus> List<ExchangePurchaseHistoryStatus> Pointer
    public partial class GetExchangePurchaseHistoryListReply
    {
        public List<ExchangePurchaseHistoryStatus>?     HistoryList                             { get; set; }

        public static GetExchangePurchaseHistoryListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetExchangePurchaseHistoryListReply();

            value.HistoryList                               = GetObjectList<ExchangePurchaseHistoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExchangePurchaseHistoryStatus.FromPointer); // 0270D12203A0 0x18 HistoryList                 ( 000185CD6AE8 ModelClassListType RepeatedField`1<ExchangePurchaseHistoryStatus> RepeatedField`1<ExchangePurchaseHistoryStatus> List<ExchangePurchaseHistoryStatus> Pointer )

            return value;
        }
    }
}
