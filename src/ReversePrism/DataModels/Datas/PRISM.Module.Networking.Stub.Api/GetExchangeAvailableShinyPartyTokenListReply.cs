using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetExchangeAvailableShinyPartyTokenListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ShinyPartyTokenListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_shinyPartyTokenList_codec      FieldCodec`1<ShinyPartyTokenStatus> IL2CPP_TYPE_GENERICINST
    // 018 ShinyPartyTokenList                      ModelClassListType RepeatedField`1<ShinyPartyTokenStatus> RepeatedField`1<ShinyPartyTokenStatus> List<ShinyPartyTokenStatus> Pointer
    public partial class GetExchangeAvailableShinyPartyTokenListReply : DataModel
    {
        public List<ShinyPartyTokenStatus>?             ShinyPartyTokenList                     { get; set; }

        public static GetExchangeAvailableShinyPartyTokenListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetExchangeAvailableShinyPartyTokenListReply() { Pointer= p0 };

            value.ShinyPartyTokenList                       = GetObjectList<ShinyPartyTokenStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShinyPartyTokenStatus.FromPointer); // 0x18 ShinyPartyTokenList         ( ModelClassListType RepeatedField`1<ShinyPartyTokenStatus> RepeatedField`1<ShinyPartyTokenStatus> List<ShinyPartyTokenStatus> Pointer )

            return value;
        }
    }
}
