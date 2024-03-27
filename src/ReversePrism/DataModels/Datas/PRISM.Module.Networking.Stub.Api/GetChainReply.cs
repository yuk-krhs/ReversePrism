using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetChainReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ChainInfoListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_chainInfoList_codec            FieldCodec`1<ChainInfoStatus> IL2CPP_TYPE_GENERICINST
    // 018 ChainInfoList                            000185CD08A8 ModelClassListType RepeatedField`1<ChainInfoStatus> RepeatedField`1<ChainInfoStatus> List<ChainInfoStatus> Pointer
    public partial class GetChainReply
    {
        public List<ChainInfoStatus>?                   ChainInfoList                           { get; set; }

        public static GetChainReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetChainReply();

            value.ChainInfoList                             = GetObjectList<ChainInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChainInfoStatus.FromPointer); // 0270D22E8730 0x18 ChainInfoList               ( 000185CD08A8 ModelClassListType RepeatedField`1<ChainInfoStatus> RepeatedField`1<ChainInfoStatus> List<ChainInfoStatus> Pointer )

            return value;
        }
    }
}
