using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PaymentCountry                           0001866722E0 ModelPrimitiveType string string string String
    // 018 ProductID                                0001866722E0 ModelPrimitiveType string string string String
    // 020 RevenueValidated                         Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 030 TransactionID                            0001866722E0 ModelPrimitiveType string string string String
    // 038 TransactionReceipt                       0001866722E0 ModelPrimitiveType string string string String
    // 040 TransactionReceiptSignature              0001866722E0 ModelPrimitiveType string string string String
    // 048 TransactionServer                        Nullable`1<TransactionServer> IL2CPP_TYPE_GENERICINST
    // 050 TransactorID                             0001866722E0 ModelPrimitiveType string string string String
    // 058 StoreItemSkuID                           0001866722E0 ModelPrimitiveType string string string String
    // 060 StoreItemID                              0001866722E0 ModelPrimitiveType string string string String
    // 068 StoreID                                  0001866722E0 ModelPrimitiveType string string string String
    // 070 StoreSourceID                            0001866722E0 ModelPrimitiveType string string string String
    // 078 TransactionName                          0001866722E0 ModelPrimitiveType string string string String
    // 080 TransactionType                          0001866A1DF0 ModelEnumType TransactionType TransactionType TransactionType Int32
    // 088 ProductsReceived                         00018659E2C0 ModelEnumType Product Product Product Int32
    // 0B0 ProductsSpent                            00018659E2C0 ModelEnumType Product Product Product Int32
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

            value.PaymentCountry                            = GetString(new IntPtr(p + 0x010)); // 02466B8351C0 0x10 PaymentCountry              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ProductID                                 = GetString(new IntPtr(p + 0x018)); // 02466B8351E0 0x18 ProductID                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x030)); // 02466B835220 0x30 TransactionID               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TransactionReceipt                        = GetString(new IntPtr(p + 0x038)); // 02466B835240 0x38 TransactionReceipt          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TransactionReceiptSignature               = GetString(new IntPtr(p + 0x040)); // 02466B835260 0x40 TransactionReceiptSignature ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TransactorID                              = GetString(new IntPtr(p + 0x050)); // 02466B8352A0 0x50 TransactorID                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StoreItemSkuID                            = GetString(new IntPtr(p + 0x058)); // 02466B8352C0 0x58 StoreItemSkuID              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StoreItemID                               = GetString(new IntPtr(p + 0x060)); // 02466B8352E0 0x60 StoreItemID                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StoreID                                   = GetString(new IntPtr(p + 0x068)); // 02466B835300 0x68 StoreID                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StoreSourceID                             = GetString(new IntPtr(p + 0x070)); // 02466B835320 0x70 StoreSourceID               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TransactionName                           = GetString(new IntPtr(p + 0x078)); // 02466B835340 0x78 TransactionName             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TransactionType                           = (TransactionType)GetInt32(new IntPtr(p + 0x080)); // 02466B835360 0x80 TransactionType             ( 0001866A1DF0 ModelEnumType TransactionType TransactionType TransactionType Int32 )
            value.ProductsReceived                          = (Product)GetInt32(new IntPtr(p + 0x088)); // 02466B835380 0x88 ProductsReceived            ( 00018659E2C0 ModelEnumType Product Product Product Int32 )
            value.ProductsSpent                             = (Product)GetInt32(new IntPtr(p + 0x0B0)); // 02466B8353A0 0xB0 ProductsSpent               ( 00018659E2C0 ModelEnumType Product Product Product Int32 )

            return value;
        }
    }
}
