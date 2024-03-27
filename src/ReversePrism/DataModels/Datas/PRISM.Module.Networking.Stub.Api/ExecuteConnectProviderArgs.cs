using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExecuteConnectProviderArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProviderTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ProviderType                             0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Token                                    000186671910 ModelPrimitiveType string string string String
    // 000 AuthenticationTypeFieldNumber            int IL2CPP_TYPE_I4
    // 028 AuthenticationType                       0001866A2CB0 ModelEnumType TransferAuthenticationType TransferAuthenticationType TransferAuthenticationType Int32
    public partial class ExecuteConnectProviderArgs
    {
        public TransferProviderType                     ProviderType                            { get; set; }
        public string                                   Token                                   { get; set; }
        public TransferAuthenticationType               AuthenticationType                      { get; set; }

        public static ExecuteConnectProviderArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteConnectProviderArgs();

            value.ProviderType                              = (TransferProviderType)GetInt32(new IntPtr(p + 0x018)); // 0270D2C3DA58 0x18 ProviderType                ( 0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.Token                                     = GetString(new IntPtr(p + 0x020)); // 0270D2C3DA98 0x20 Token                       ( 000186671910 ModelPrimitiveType string string string String )
            value.AuthenticationType                        = (TransferAuthenticationType)GetInt32(new IntPtr(p + 0x028)); // 0270D2C3DAD8 0x28 AuthenticationType          ( 0001866A2CB0 ModelEnumType TransferAuthenticationType TransferAuthenticationType TransferAuthenticationType Int32 )

            return value;
        }
    }
}
