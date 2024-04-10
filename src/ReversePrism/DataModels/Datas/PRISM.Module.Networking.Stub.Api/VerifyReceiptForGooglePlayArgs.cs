using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<VerifyReceiptForGooglePlayArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 OrderIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 OrderId                                  000186671910 ModelPrimitiveType string string string String
    // 000 ReceiptDataFieldNumber                   int IL2CPP_TYPE_I4
    // 020 ReceiptData                              000186671910 ModelPrimitiveType string string string String
    // 000 CurrencyCodeFieldNumber                  int IL2CPP_TYPE_I4
    // 028 CurrencyCode                             000186671910 ModelPrimitiveType string string string String
    // 000 UnitPriceFieldNumber                     int IL2CPP_TYPE_I4
    // 030 UnitPrice                                0001865C2950 ModelPrimitiveType double double double Double
    // 000 DataSignatureFieldNumber                 int IL2CPP_TYPE_I4
    // 038 DataSignature                            000186671910 ModelPrimitiveType string string string String
    public partial class VerifyReceiptForGooglePlayArgs : DataModel
    {
        public string                                   OrderId                                 { get; set; }
        public string                                   ReceiptData                             { get; set; }
        public string                                   CurrencyCode                            { get; set; }
        public double                                   UnitPrice                               { get; set; }
        public string                                   DataSignature                           { get; set; }

        public static VerifyReceiptForGooglePlayArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyReceiptForGooglePlayArgs() { Pointer= p0 };

            value.OrderId                                   = GetString(new IntPtr(p + 0x018)); // 024660B588F8 0x18 OrderId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ReceiptData                               = GetString(new IntPtr(p + 0x020)); // 024660B58938 0x20 ReceiptData                 ( 000186671910 ModelPrimitiveType string string string String )
            value.CurrencyCode                              = GetString(new IntPtr(p + 0x028)); // 024660B58978 0x28 CurrencyCode                ( 000186671910 ModelPrimitiveType string string string String )
            value.UnitPrice                                 = GetDouble(new IntPtr(p + 0x030)); // 024660B589B8 0x30 UnitPrice                   ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.DataSignature                             = GetString(new IntPtr(p + 0x038)); // 024660B589F8 0x38 DataSignature               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
