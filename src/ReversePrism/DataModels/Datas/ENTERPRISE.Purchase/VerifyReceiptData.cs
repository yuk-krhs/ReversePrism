using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OrderId                                  0001866722E0 ModelPrimitiveType string string string String
    // 018 ReceiptData                              0001866722E0 ModelPrimitiveType string string string String
    // 020 TransactionId                            0001866722E0 ModelPrimitiveType string string string String
    // 028 DataSignature                            0001866722E0 ModelPrimitiveType string string string String
    // 030 PurchaseState                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 Currency                                 0001866722E0 ModelPrimitiveType string string string String
    // 040 UnitPrice                                000186666050 ModelPrimitiveType float float float Single
    // 048 ProductId                                0001866722E0 ModelPrimitiveType string string string String
    // 050 Product                                  00018659E900 ModelClassType Product Product Product Pointer
    public partial class VerifyReceiptData : DataModel
    {
        public string                                   OrderId                                 { get; set; }
        public string                                   ReceiptData                             { get; set; }
        public string                                   TransactionId                           { get; set; }
        public string                                   DataSignature                           { get; set; }
        public int                                      PurchaseState                           { get; set; }
        public string                                   Currency                                { get; set; }
        public float                                    UnitPrice                               { get; set; }
        public string                                   ProductId                               { get; set; }
        public Product?                                 Product                                 { get; set; }

        public static VerifyReceiptData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyReceiptData() { Pointer= p0 };

            value.OrderId                                   = GetString(new IntPtr(p + 0x010)); // 024663029800 0x10 OrderId                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ReceiptData                               = GetString(new IntPtr(p + 0x018)); // 024663029820 0x18 ReceiptData                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TransactionId                             = GetString(new IntPtr(p + 0x020)); // 024663029840 0x20 TransactionId               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DataSignature                             = GetString(new IntPtr(p + 0x028)); // 024663029860 0x28 DataSignature               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PurchaseState                             = GetInt32(new IntPtr(p + 0x030)); // 024663029880 0x30 PurchaseState               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Currency                                  = GetString(new IntPtr(p + 0x038)); // 0246630298A0 0x38 Currency                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UnitPrice                                 = GetSingle(new IntPtr(p + 0x040)); // 0246630298C0 0x40 UnitPrice                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.ProductId                                 = GetString(new IntPtr(p + 0x048)); // 0246630298E0 0x48 ProductId                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Product                                   = GetObject<Product>(new IntPtr(p + 0x050), ReversePrism.DataModels.Product.FromPointer); // 024663029900 0x50 Product                     ( 00018659E900 ModelClassType Product Product Product Pointer )

            return value;
        }
    }
}
