using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LoginReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Token                                    000186671910 ModelPrimitiveType string string string String
    // 000 UserFieldNumber                          int IL2CPP_TYPE_I4
    // 020 User                                     000186722AD0 ModelClassType SelfStatus SelfStatus SelfStatus Pointer
    public partial class LoginReply
    {
        public string                                   Token                                   { get; set; }
        public SelfStatus?                              User                                    { get; set; }

        public static LoginReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginReply();

            value.Token                                     = GetString(new IntPtr(p + 0x018)); // 0270015FC600 0x18 Token                       ( 000186671910 ModelPrimitiveType string string string String )
            value.User                                      = GetObject<SelfStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SelfStatus.FromPointer); // 0270015FC640 0x20 User                        ( 000186722AD0 ModelClassType SelfStatus SelfStatus SelfStatus Pointer )

            return value;
        }
    }
}
