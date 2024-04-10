using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<VerifyReceiptForDmmGamesArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 OrderIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 OrderId                                  000186671910 ModelPrimitiveType string string string String
    // 000 ReceiptDataFieldNumber                   int IL2CPP_TYPE_I4
    // 020 ReceiptData                              000186671910 ModelPrimitiveType string string string String
    // 000 DataSignatureFieldNumber                 int IL2CPP_TYPE_I4
    // 028 DataSignature                            000186671910 ModelPrimitiveType string string string String
    public partial class VerifyReceiptForDmmGamesArgs : DataModel
    {
        public string                                   OrderId                                 { get; set; }
        public string                                   ReceiptData                             { get; set; }
        public string                                   DataSignature                           { get; set; }

        public static VerifyReceiptForDmmGamesArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyReceiptForDmmGamesArgs() { Pointer= p0 };

            value.OrderId                                   = GetString(new IntPtr(p + 0x018)); // 024660B52FD0 0x18 OrderId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ReceiptData                               = GetString(new IntPtr(p + 0x020)); // 024660B53010 0x20 ReceiptData                 ( 000186671910 ModelPrimitiveType string string string String )
            value.DataSignature                             = GetString(new IntPtr(p + 0x028)); // 024660B53050 0x28 DataSignature               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
