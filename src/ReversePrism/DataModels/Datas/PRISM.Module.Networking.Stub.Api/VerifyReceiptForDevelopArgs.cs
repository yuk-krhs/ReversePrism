using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<VerifyReceiptForDevelopArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 OrderIdFieldNumber                       int IL2CPP_TYPE_I4
    // 018 OrderId                                  ModelPrimitiveType string string string String
    // 000 CurrencyCodeFieldNumber                  int IL2CPP_TYPE_I4
    // 020 CurrencyCode                             ModelPrimitiveType string string string String
    // 000 UnitPriceFieldNumber                     int IL2CPP_TYPE_I4
    // 028 UnitPrice                                ModelPrimitiveType double double double Double
    public partial class VerifyReceiptForDevelopArgs : DataModel
    {
        public string                                   OrderId                                 { get; set; }
        public string                                   CurrencyCode                            { get; set; }
        public double                                   UnitPrice                               { get; set; }

        public static VerifyReceiptForDevelopArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyReceiptForDevelopArgs() { Pointer= p0 };

            value.OrderId                                   = GetString(new IntPtr(p + 0x018)); // 0x18 OrderId                     ( ModelPrimitiveType string string string String )
            value.CurrencyCode                              = GetString(new IntPtr(p + 0x020)); // 0x20 CurrencyCode                ( ModelPrimitiveType string string string String )
            value.UnitPrice                                 = GetDouble(new IntPtr(p + 0x028)); // 0x28 UnitPrice                   ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
