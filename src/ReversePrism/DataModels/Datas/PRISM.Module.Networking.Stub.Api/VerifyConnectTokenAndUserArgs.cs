using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<VerifyConnectTokenAndUserArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 018 UserId                                   ModelPrimitiveType string string string String
    // 000 SecretFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Secret                                   ModelPrimitiveType string string string String
    // 000 ProviderTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 028 ProviderType                             ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Token                                    ModelPrimitiveType string string string String
    // 000 AuthorizationCodeFieldNumber             int IL2CPP_TYPE_I4
    // 038 AuthorizationCode                        ModelPrimitiveType string string string String
    public partial class VerifyConnectTokenAndUserArgs : DataModel
    {
        public string                                   UserId                                  { get; set; }
        public string                                   Secret                                  { get; set; }
        public TransferProviderType                     ProviderType                            { get; set; }
        public string                                   Token                                   { get; set; }
        public string                                   AuthorizationCode                       { get; set; }

        public static VerifyConnectTokenAndUserArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyConnectTokenAndUserArgs() { Pointer= p0 };

            value.UserId                                    = GetString(new IntPtr(p + 0x018)); // 0x18 UserId                      ( ModelPrimitiveType string string string String )
            value.Secret                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Secret                      ( ModelPrimitiveType string string string String )
            value.ProviderType                              = (TransferProviderType)GetInt32(new IntPtr(p + 0x028)); // 0x28 ProviderType                ( ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.Token                                     = GetString(new IntPtr(p + 0x030)); // 0x30 Token                       ( ModelPrimitiveType string string string String )
            value.AuthorizationCode                         = GetString(new IntPtr(p + 0x038)); // 0x38 AuthorizationCode           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
