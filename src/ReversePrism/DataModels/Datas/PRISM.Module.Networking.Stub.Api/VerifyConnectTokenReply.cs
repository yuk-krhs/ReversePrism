using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReleasableDate                           000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<VerifyConnectTokenReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ResultFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Result                                   000186604590 ModelEnumType ConnectionResultType ConnectionResultType ConnectionResultType Int32
    // 000 SearchIdFieldNumber                      int IL2CPP_TYPE_I4
    // 030 SearchId                                 000186671910 ModelPrimitiveType string string string String
    // 000 UserNameFieldNumber                      int IL2CPP_TYPE_I4
    // 038 UserName                                 000186671910 ModelPrimitiveType string string string String
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 040 Type                                     0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 048 Token                                    000186671910 ModelPrimitiveType string string string String
    // 000 ReleasableDateFieldNumber                int IL2CPP_TYPE_I4
    // 050 _ReleasableDate                          000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class VerifyConnectTokenReply
    {
        public DateTime                                 ReleasableDate                          { get; set; }
        public ConnectionResultType                     Result                                  { get; set; }
        public string                                   SearchId                                { get; set; }
        public string                                   UserName                                { get; set; }
        public TransferProviderType                     Type                                    { get; set; }
        public string                                   Token                                   { get; set; }
        public Timestamp?                               _ReleasableDate                         { get; set; }

        public static VerifyConnectTokenReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyConnectTokenReply();

            value.ReleasableDate                            = GetDateTime(new IntPtr(p + 0x010)); // 0270D2C44528 0x10 ReleasableDate              ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Result                                    = (ConnectionResultType)GetInt32(new IntPtr(p + 0x028)); // 0270D2C445A8 0x28 Result                      ( 000186604590 ModelEnumType ConnectionResultType ConnectionResultType ConnectionResultType Int32 )
            value.SearchId                                  = GetString(new IntPtr(p + 0x030)); // 0270D2C445E8 0x30 SearchId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.UserName                                  = GetString(new IntPtr(p + 0x038)); // 0270D2C44628 0x38 UserName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = (TransferProviderType)GetInt32(new IntPtr(p + 0x040)); // 0270D2C44668 0x40 Type                        ( 0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.Token                                     = GetString(new IntPtr(p + 0x048)); // 0270D2C446A8 0x48 Token                       ( 000186671910 ModelPrimitiveType string string string String )
            value._ReleasableDate                           = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D2C446E8 0x50 _ReleasableDate             ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ReleasableDate                = ToDateTime(value._ReleasableDate);

            return value;
        }
    }
}
