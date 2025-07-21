using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PaymentCountry                           ModelPrimitiveType string string string String
    // 018 EngagementID                             Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 028 IsInitiator                              Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 030 StoreID                                  ModelPrimitiveType string string string String
    // 038 StoreSourceID                            ModelPrimitiveType string string string String
    // 040 TransactionID                            ModelPrimitiveType string string string String
    // 048 StoreItemID                              ModelPrimitiveType string string string String
    // 050 AmazonUserID                             ModelPrimitiveType string string string String
    // 058 StoreItemSkuID                           ModelPrimitiveType string string string String
    // 060 ProductID                                ModelPrimitiveType string string string String
    // 068 GameStoreID                              ModelPrimitiveType string string string String
    // 070 TransactionServer                        Nullable`1<TransactionServer> IL2CPP_TYPE_GENERICINST
    // 078 RevenueValidated                         Nullable`1<long> IL2CPP_TYPE_GENERICINST
    // 088 TransactionName                          ModelPrimitiveType string string string String
    // 090 TransactionType                          ModelEnumType TransactionType TransactionType TransactionType Int32
    // 098 ProductsReceived                         ModelEnumType Product Product Product Int32
    // 0C0 ProductsSpent                            ModelEnumType Product Product Product Int32
    // 0E8 FailureReason                            ModelPrimitiveType string string string String
    public partial class TransactionFailedParameters : DataModel
    {
        public string                                   PaymentCountry                          { get; set; }
        public string                                   StoreID                                 { get; set; }
        public string                                   StoreSourceID                           { get; set; }
        public string                                   TransactionID                           { get; set; }
        public string                                   StoreItemID                             { get; set; }
        public string                                   AmazonUserID                            { get; set; }
        public string                                   StoreItemSkuID                          { get; set; }
        public string                                   ProductID                               { get; set; }
        public string                                   GameStoreID                             { get; set; }
        public string                                   TransactionName                         { get; set; }
        public TransactionType                          TransactionType                         { get; set; }
        public Product                                  ProductsReceived                        { get; set; }
        public Product                                  ProductsSpent                           { get; set; }
        public string                                   FailureReason                           { get; set; }

        public static TransactionFailedParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransactionFailedParameters() { Pointer= p0 };

            value.PaymentCountry                            = GetString(new IntPtr(p + 0x010)); // 0x10 PaymentCountry              ( ModelPrimitiveType string string string String )
            value.StoreID                                   = GetString(new IntPtr(p + 0x030)); // 0x30 StoreID                     ( ModelPrimitiveType string string string String )
            value.StoreSourceID                             = GetString(new IntPtr(p + 0x038)); // 0x38 StoreSourceID               ( ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x040)); // 0x40 TransactionID               ( ModelPrimitiveType string string string String )
            value.StoreItemID                               = GetString(new IntPtr(p + 0x048)); // 0x48 StoreItemID                 ( ModelPrimitiveType string string string String )
            value.AmazonUserID                              = GetString(new IntPtr(p + 0x050)); // 0x50 AmazonUserID                ( ModelPrimitiveType string string string String )
            value.StoreItemSkuID                            = GetString(new IntPtr(p + 0x058)); // 0x58 StoreItemSkuID              ( ModelPrimitiveType string string string String )
            value.ProductID                                 = GetString(new IntPtr(p + 0x060)); // 0x60 ProductID                   ( ModelPrimitiveType string string string String )
            value.GameStoreID                               = GetString(new IntPtr(p + 0x068)); // 0x68 GameStoreID                 ( ModelPrimitiveType string string string String )
            value.TransactionName                           = GetString(new IntPtr(p + 0x088)); // 0x88 TransactionName             ( ModelPrimitiveType string string string String )
            value.TransactionType                           = (TransactionType)GetInt32(new IntPtr(p + 0x090)); // 0x90 TransactionType             ( ModelEnumType TransactionType TransactionType TransactionType Int32 )
            value.ProductsReceived                          = (Product)GetInt32(new IntPtr(p + 0x098)); // 0x98 ProductsReceived            ( ModelEnumType Product Product Product Int32 )
            value.ProductsSpent                             = (Product)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 ProductsSpent               ( ModelEnumType Product Product Product Int32 )
            value.FailureReason                             = GetString(new IntPtr(p + 0x0E8)); // 0xE8 FailureReason               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
