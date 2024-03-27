using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReadDirectMessageArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DirectMessageIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 DirectMessageId                          000186671910 ModelPrimitiveType string string string String
    public partial class ReadDirectMessageArgs
    {
        public string                                   DirectMessageId                         { get; set; }

        public static ReadDirectMessageArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadDirectMessageArgs();

            value.DirectMessageId                           = GetString(new IntPtr(p + 0x018)); // 0270D0E5C340 0x18 DirectMessageId             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
