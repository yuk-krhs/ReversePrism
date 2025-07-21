using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PaymentCountry                           ModelPrimitiveType string string string String
    // 018 ProductID                                ModelPrimitiveType string string string String
    // 020 RevenueValidated                         Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 030 TransactionID                            ModelPrimitiveType string string string String
    // 038 TransactionReceipt                       ModelPrimitiveType string string string String
    // 040 TransactionReceiptSignature              ModelPrimitiveType string string string String
    // 048 TransactionServer                        Nullable`1<TransactionServer> IL2CPP_TYPE_GENERICINST
    // 050 TransactorID                             ModelPrimitiveType string string string String
    // 058 StoreItemSkuID                           ModelPrimitiveType string string string String
    // 060 StoreItemID                              ModelPrimitiveType string string string String
    // 068 StoreID                                  ModelPrimitiveType string string string String
    // 070 StoreSourceID                            ModelPrimitiveType string string string String
    // 078 TransactionName                          ModelPrimitiveType string string string String
    // 080 TransactionType                          ModelEnumType TransactionType TransactionType TransactionType Int32
    // 088 ProductsReceived                         ModelEnumType Product Product Product Int32
    // 0B0 ProductsSpent                            ModelEnumType Product Product Product Int32
    public partial class TransactionParameters : DataModel
    {
        public string                                   PaymentCountry                          { get; set; }
        public string                                   ProductID                               { get; set; }
        public string                                   TransactionID                           { get; set; }
        public string                                   TransactionReceipt                      { get; set; }
        public string                                   TransactionReceiptSignature             { get; set; }
        public string                                   TransactorID                            { get; set; }
        public string                                   StoreItemSkuID                          { get; set; }
        public string                                   StoreItemID                             { get; set; }
        public string                                   StoreID                                 { get; set; }
        public string                                   StoreSourceID                           { get; set; }
        public string                                   TransactionName                         { get; set; }
        public TransactionType                          TransactionType                         { get; set; }
        public Product                                  ProductsReceived                        { get; set; }
        public Product                                  ProductsSpent                           { get; set; }

        public static TransactionParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransactionParameters() { Pointer= p0 };

            value.PaymentCountry                            = GetString(new IntPtr(p + 0x010)); // 0x10 PaymentCountry              ( ModelPrimitiveType string string string String )
            value.ProductID                                 = GetString(new IntPtr(p + 0x018)); // 0x18 ProductID                   ( ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x030)); // 0x30 TransactionID               ( ModelPrimitiveType string string string String )
            value.TransactionReceipt                        = GetString(new IntPtr(p + 0x038)); // 0x38 TransactionReceipt          ( ModelPrimitiveType string string string String )
            value.TransactionReceiptSignature               = GetString(new IntPtr(p + 0x040)); // 0x40 TransactionReceiptSignature ( ModelPrimitiveType string string string String )
            value.TransactorID                              = GetString(new IntPtr(p + 0x050)); // 0x50 TransactorID                ( ModelPrimitiveType string string string String )
            value.StoreItemSkuID                            = GetString(new IntPtr(p + 0x058)); // 0x58 StoreItemSkuID              ( ModelPrimitiveType string string string String )
            value.StoreItemID                               = GetString(new IntPtr(p + 0x060)); // 0x60 StoreItemID                 ( ModelPrimitiveType string string string String )
            value.StoreID                                   = GetString(new IntPtr(p + 0x068)); // 0x68 StoreID                     ( ModelPrimitiveType string string string String )
            value.StoreSourceID                             = GetString(new IntPtr(p + 0x070)); // 0x70 StoreSourceID               ( ModelPrimitiveType string string string String )
            value.TransactionName                           = GetString(new IntPtr(p + 0x078)); // 0x78 TransactionName             ( ModelPrimitiveType string string string String )
            value.TransactionType                           = (TransactionType)GetInt32(new IntPtr(p + 0x080)); // 0x80 TransactionType             ( ModelEnumType TransactionType TransactionType TransactionType Int32 )
            value.ProductsReceived                          = (Product)GetInt32(new IntPtr(p + 0x088)); // 0x88 ProductsReceived            ( ModelEnumType Product Product Product Int32 )
            value.ProductsSpent                             = (Product)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 ProductsSpent               ( ModelEnumType Product Product Product Int32 )

            return value;
        }
    }
}
