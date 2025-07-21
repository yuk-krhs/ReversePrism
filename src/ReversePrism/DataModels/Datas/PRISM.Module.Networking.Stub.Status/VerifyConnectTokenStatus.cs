using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReleasableDate                           ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<VerifyConnectTokenStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ResultFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Result                                   ModelEnumType ConnectionResultType ConnectionResultType ConnectionResultType Int32
    // 000 SearchIdFieldNumber                      int IL2CPP_TYPE_I4
    // 030 SearchId                                 ModelPrimitiveType string string string String
    // 000 UserNameFieldNumber                      int IL2CPP_TYPE_I4
    // 038 UserName                                 ModelPrimitiveType string string string String
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 040 Type                                     ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 048 Token                                    ModelPrimitiveType string string string String
    // 000 ReleasableDateFieldNumber                int IL2CPP_TYPE_I4
    // 050 _ReleasableDate                          ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class VerifyConnectTokenStatus : DataModel
    {
        public DateTime                                 ReleasableDate                          { get; set; }
        public ConnectionResultType                     Result                                  { get; set; }
        public string                                   SearchId                                { get; set; }
        public string                                   UserName                                { get; set; }
        public TransferProviderType                     Type                                    { get; set; }
        public string                                   Token                                   { get; set; }
        public Timestamp?                               _ReleasableDate                         { get; set; }

        public static VerifyConnectTokenStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyConnectTokenStatus() { Pointer= p0 };

            value.ReleasableDate                            = GetDateTime(new IntPtr(p + 0x010)); // 0x10 ReleasableDate              ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Result                                    = (ConnectionResultType)GetInt32(new IntPtr(p + 0x028)); // 0x28 Result                      ( ModelEnumType ConnectionResultType ConnectionResultType ConnectionResultType Int32 )
            value.SearchId                                  = GetString(new IntPtr(p + 0x030)); // 0x30 SearchId                    ( ModelPrimitiveType string string string String )
            value.UserName                                  = GetString(new IntPtr(p + 0x038)); // 0x38 UserName                    ( ModelPrimitiveType string string string String )
            value.Type                                      = (TransferProviderType)GetInt32(new IntPtr(p + 0x040)); // 0x40 Type                        ( ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.Token                                     = GetString(new IntPtr(p + 0x048)); // 0x48 Token                       ( ModelPrimitiveType string string string String )
            value._ReleasableDate                           = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0x50 _ReleasableDate             ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ReleasableDate                = ToDateTime(value._ReleasableDate);

            return value;
        }
    }
}
