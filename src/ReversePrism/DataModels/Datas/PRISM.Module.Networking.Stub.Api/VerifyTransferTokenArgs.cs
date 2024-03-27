using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<VerifyTransferTokenArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProviderTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ProviderType                             0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Token                                    000186671910 ModelPrimitiveType string string string String
    // 000 AuthorizationCodeFieldNumber             int IL2CPP_TYPE_I4
    // 028 AuthorizationCode                        000186671910 ModelPrimitiveType string string string String
    public partial class VerifyTransferTokenArgs
    {
        public TransferProviderType                     ProviderType                            { get; set; }
        public string                                   Token                                   { get; set; }
        public string                                   AuthorizationCode                       { get; set; }

        public static VerifyTransferTokenArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyTransferTokenArgs();

            value.ProviderType                              = (TransferProviderType)GetInt32(new IntPtr(p + 0x018)); // 0270D0B84A40 0x18 ProviderType                ( 0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.Token                                     = GetString(new IntPtr(p + 0x020)); // 0270D0B84A80 0x20 Token                       ( 000186671910 ModelPrimitiveType string string string String )
            value.AuthorizationCode                         = GetString(new IntPtr(p + 0x028)); // 0270D0B84AC0 0x28 AuthorizationCode           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
