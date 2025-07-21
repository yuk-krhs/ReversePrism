using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RegisterReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 018 UserId                                   ModelPrimitiveType string string string String
    // 000 SecretFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Secret                                   ModelPrimitiveType string string string String
    // 000 SearchIdFieldNumber                      int IL2CPP_TYPE_I4
    // 028 SearchId                                 ModelPrimitiveType string string string String
    public partial class RegisterReply : DataModel
    {
        public string                                   UserId                                  { get; set; }
        public string                                   Secret                                  { get; set; }
        public string                                   SearchId                                { get; set; }

        public static RegisterReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterReply() { Pointer= p0 };

            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 0x18 UserId                      ( ModelPrimitiveType string string string String )
            value.Secret                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Secret                      ( ModelPrimitiveType string string string String )
            value.SearchId                                  = GetString(new IntPtr(p + 0x028)); // 0x28 SearchId                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
