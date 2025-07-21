using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OrderId                                  ModelPrimitiveType string string string String
    // 018 ReceiptData                              ModelPrimitiveType string string string String
    // 020 TransactionId                            ModelPrimitiveType string string string String
    // 028 DataSignature                            ModelPrimitiveType string string string String
    // 030 PurchaseState                            ModelPrimitiveType int int int Int32
    // 038 Currency                                 ModelPrimitiveType string string string String
    // 040 UnitPrice                                ModelPrimitiveType float float float Single
    // 048 ProductId                                ModelPrimitiveType string string string String
    // 050 Product                                  ModelClassType Product Product Product Pointer
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

            value.OrderId                                   = GetString(new IntPtr(p + 0x010)); // 0x10 OrderId                     ( ModelPrimitiveType string string string String )
            value.ReceiptData                               = GetString(new IntPtr(p + 0x018)); // 0x18 ReceiptData                 ( ModelPrimitiveType string string string String )
            value.TransactionId                             = GetString(new IntPtr(p + 0x020)); // 0x20 TransactionId               ( ModelPrimitiveType string string string String )
            value.DataSignature                             = GetString(new IntPtr(p + 0x028)); // 0x28 DataSignature               ( ModelPrimitiveType string string string String )
            value.PurchaseState                             = GetInt32(new IntPtr(p + 0x030)); // 0x30 PurchaseState               ( ModelPrimitiveType int int int Int32 )
            value.Currency                                  = GetString(new IntPtr(p + 0x038)); // 0x38 Currency                    ( ModelPrimitiveType string string string String )
            value.UnitPrice                                 = GetSingle(new IntPtr(p + 0x040)); // 0x40 UnitPrice                   ( ModelPrimitiveType float float float Single )
            value.ProductId                                 = GetString(new IntPtr(p + 0x048)); // 0x48 ProductId                   ( ModelPrimitiveType string string string String )
            value.Product                                   = GetObject<Product>(new IntPtr(p + 0x050), ReversePrism.DataModels.Product.FromPointer); // 0x50 Product                     ( ModelClassType Product Product Product Pointer )

            return value;
        }
    }
}
