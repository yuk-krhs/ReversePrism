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
    // 018 Result                                   ModelPrimitiveType bool bool bool Bool
    public partial class ConnectReleaseAndTokenReply : DataModel
    {
        public bool                                     Result                                  { get; set; }

        public static ConnectReleaseAndTokenReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConnectReleaseAndTokenReply() { Pointer= p0 };

            value.Result                                    = GetBool(new IntPtr(p + 0x018)); // 0x18 Result                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
