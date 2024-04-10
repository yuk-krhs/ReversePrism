using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<VerifyTransferTokenReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ResultFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Result                                   000186604590 ModelEnumType ConnectionResultType ConnectionResultType ConnectionResultType Int32
    // 000 SearchIdFieldNumber                      int IL2CPP_TYPE_I4
    // 020 SearchId                                 000186671910 ModelPrimitiveType string string string String
    // 000 UserNameFieldNumber                      int IL2CPP_TYPE_I4
    // 028 UserName                                 000186671910 ModelPrimitiveType string string string String
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Type                                     0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32
    // 000 TokenFieldNumber                         int IL2CPP_TYPE_I4
    // 038 Token                                    000186671910 ModelPrimitiveType string string string String
    // 000 InTermMonthlyTicketFieldNumber           int IL2CPP_TYPE_I4
    // 040 InTermMonthlyTicket                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class VerifyTransferTokenReply : DataModel
    {
        public ConnectionResultType                     Result                                  { get; set; }
        public string                                   SearchId                                { get; set; }
        public string                                   UserName                                { get; set; }
        public TransferProviderType                     Type                                    { get; set; }
        public string                                   Token                                   { get; set; }
        public bool                                     InTermMonthlyTicket                     { get; set; }

        public static VerifyTransferTokenReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyTransferTokenReply() { Pointer= p0 };

            value.Result                                    = (ConnectionResultType)GetInt32(new IntPtr(p + 0x018)); // 024660B73C30 0x18 Result                      ( 000186604590 ModelEnumType ConnectionResultType ConnectionResultType ConnectionResultType Int32 )
            value.SearchId                                  = GetString(new IntPtr(p + 0x020)); // 024660B73C70 0x20 SearchId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.UserName                                  = GetString(new IntPtr(p + 0x028)); // 024660B73CB0 0x28 UserName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = (TransferProviderType)GetInt32(new IntPtr(p + 0x030)); // 024660B73CF0 0x30 Type                        ( 0001866A6ED0 ModelEnumType TransferProviderType TransferProviderType TransferProviderType Int32 )
            value.Token                                     = GetString(new IntPtr(p + 0x038)); // 024660B73D30 0x38 Token                       ( 000186671910 ModelPrimitiveType string string string String )
            value.InTermMonthlyTicket                       = GetBool(new IntPtr(p + 0x040)); // 024660B73D70 0x40 InTermMonthlyTicket         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
