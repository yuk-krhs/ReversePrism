using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ConnectReleaseOtherAndTokenArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 018 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 000 SecretFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Secret                                   000186671910 ModelPrimitiveType string string string String
    // 000 ProviderTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 028 ProviderType                             0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Token                                    000186671910 ModelPrimitiveType string string string String
    // 000 AuthenticationTypeFieldNumber            int IL2CPP_TYPE_I4
    // 038 AuthenticationType                       0001866A2CB0 ModelEnumType TransferAuthenticationType TransferAuthenticationType TransferAuthenticationType Int32
    public partial class ConnectReleaseOtherAndTokenArgs
    {
        public string                                   UserId                                  { get; set; }
        public string                                   Secret                                  { get; set; }
        public TransferProviderType                     ProviderType                            { get; set; }
        public string                                   Token                                   { get; set; }
        public TransferAuthenticationType               AuthenticationType                      { get; set; }

        public static ConnectReleaseOtherAndTokenArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConnectReleaseOtherAndTokenArgs();

            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 0270D0B25108 0x18 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Secret                                    = GetString(new IntPtr(p + 0x020)); // 0270D0B25148 0x20 Secret                      ( 000186671910 ModelPrimitiveType string string string String )
            value.ProviderType                              = (TransferProviderType)GetInt32(new IntPtr(p + 0x028)); // 0270D0B25188 0x28 ProviderType                ( 0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.Token                                     = GetString(new IntPtr(p + 0x030)); // 0270D0B251C8 0x30 Token                       ( 000186671910 ModelPrimitiveType string string string String )
            value.AuthenticationType                        = (TransferAuthenticationType)GetInt32(new IntPtr(p + 0x038)); // 0270D0B25208 0x38 AuthenticationType          ( 0001866A2CB0 ModelEnumType TransferAuthenticationType TransferAuthenticationType TransferAuthenticationType Int32 )

            return value;
        }
    }
}
