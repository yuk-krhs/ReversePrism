using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGashaHistoryListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HistoryListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_historyList_codec              FieldCodec`1<GashaHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 018 HistoryList                              000185CDBB28 ModelClassListType RepeatedField`1<GashaHistoryStatus> RepeatedField`1<GashaHistoryStatus> List<GashaHistoryStatus> Pointer
    public partial class GetGashaHistoryListReply
    {
        public List<GashaHistoryStatus>?                HistoryList                             { get; set; }

        public static GetGashaHistoryListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGashaHistoryListReply();

            value.HistoryList                               = GetObjectList<GashaHistoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaHistoryStatus.FromPointer); // 0270D1A134D0 0x18 HistoryList                 ( 000185CDBB28 ModelClassListType RepeatedField`1<GashaHistoryStatus> RepeatedField`1<GashaHistoryStatus> List<GashaHistoryStatus> Pointer )

            return value;
        }
    }
}
