using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ConnectReleaseAndTokenReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ResultFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Result                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ConnectReleaseAndTokenReply
    {
        public bool                                     Result                                  { get; set; }

        public static ConnectReleaseAndTokenReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConnectReleaseAndTokenReply();

            value.Result                                    = GetBool(new IntPtr(p + 0x018)); // 0270D0B21700 0x18 Result                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
