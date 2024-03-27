using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetTransferURLReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UrlFieldNumber                           int IL2CPP_TYPE_I4
    // 018 Url                                      000186671910 ModelPrimitiveType string string string String
    public partial class GetTransferURLReply
    {
        public string                                   Url                                     { get; set; }

        public static GetTransferURLReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetTransferURLReply();

            value.Url                                       = GetString(new IntPtr(p + 0x018)); // 0270D0B68838 0x18 Url                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
