using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExecuteTransferArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProviderTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ProviderType                             0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Token                                    000186671910 ModelPrimitiveType string string string String
    // 000 PlatformFieldNumber                      int IL2CPP_TYPE_I4
    // 028 Platform                                 000186671910 ModelPrimitiveType string string string String
    // 000 PlatformUserIdFieldNumber                int IL2CPP_TYPE_I4
    // 030 PlatformUserId                           000186671910 ModelPrimitiveType string string string String
    // 000 AuthenticationTypeFieldNumber            int IL2CPP_TYPE_I4
    // 038 AuthenticationType                       0001866A2CB0 ModelEnumType TransferAuthenticationType TransferAuthenticationType TransferAuthenticationType Int32
    // 000 ViewerIdFieldNumber                      int IL2CPP_TYPE_I4
    // 040 ViewerId                                 0001865F7700 ModelPrimitiveType long long long Int64
    // 000 ViewerIdSignatureFieldNumber             int IL2CPP_TYPE_I4
    // 048 ViewerIdSignature                        000186671910 ModelPrimitiveType string string string String
    // 000 PassPhraseFieldNumber                    int IL2CPP_TYPE_I4
    // 050 PassPhrase                               000186671910 ModelPrimitiveType string string string String
    public partial class ExecuteTransferArgs : DataModel
    {
        public TransferProviderType                     ProviderType                            { get; set; }
        public string                                   Token                                   { get; set; }
        public string                                   Platform                                { get; set; }
        public string                                   PlatformUserId                          { get; set; }
        public TransferAuthenticationType               AuthenticationType                      { get; set; }
        public long                                     ViewerId                                { get; set; }
        public string                                   ViewerIdSignature                       { get; set; }
        public string                                   PassPhrase                              { get; set; }

        public static ExecuteTransferArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteTransferArgs() { Pointer= p0 };

            value.ProviderType                              = (TransferProviderType)GetInt32(new IntPtr(p + 0x018)); // 024660B29118 0x18 ProviderType                ( 0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.Token                                     = GetString(new IntPtr(p + 0x020)); // 024660B29158 0x20 Token                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Platform                                  = GetString(new IntPtr(p + 0x028)); // 024660B29198 0x28 Platform                    ( 000186671910 ModelPrimitiveType string string string String )
            value.PlatformUserId                            = GetString(new IntPtr(p + 0x030)); // 024660B291D8 0x30 PlatformUserId              ( 000186671910 ModelPrimitiveType string string string String )
            value.AuthenticationType                        = (TransferAuthenticationType)GetInt32(new IntPtr(p + 0x038)); // 024660B29218 0x38 AuthenticationType          ( 0001866A2CB0 ModelEnumType TransferAuthenticationType TransferAuthenticationType TransferAuthenticationType Int32 )
            value.ViewerId                                  = GetInt64(new IntPtr(p + 0x040)); // 024660B29258 0x40 ViewerId                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ViewerIdSignature                         = GetString(new IntPtr(p + 0x048)); // 024660B29298 0x48 ViewerIdSignature           ( 000186671910 ModelPrimitiveType string string string String )
            value.PassPhrase                                = GetString(new IntPtr(p + 0x050)); // 024660B292D8 0x50 PassPhrase                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
