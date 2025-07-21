using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Quantity                                 ModelPrimitiveType int int int Int32
    // 018 ProductID                                ModelPrimitiveType string string string String
    // 020 TransactionID                            ModelPrimitiveType string string string String
    // 028 OriginalTransactionIdentifier            ModelPrimitiveType string string string String
    // 030 PurchaseDate                             ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 OriginalPurchaseDate                     ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 SubscriptionExpirationDate               ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 CancellationDate                         ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 IsFreeTrial                              ModelPrimitiveType int int int Int32
    // 054 ProductType                              ModelPrimitiveType int int int Int32
    // 058 IsIntroductoryPricePeriod                ModelPrimitiveType int int int Int32
    public partial class AppleInAppPurchaseReceipt : DataModel
    {
        public int                                      Quantity                                { get; set; }
        public string                                   ProductID                               { get; set; }
        public string                                   TransactionID                           { get; set; }
        public string                                   OriginalTransactionIdentifier           { get; set; }
        public DateTime                                 PurchaseDate                            { get; set; }
        public DateTime                                 OriginalPurchaseDate                    { get; set; }
        public DateTime                                 SubscriptionExpirationDate              { get; set; }
        public DateTime                                 CancellationDate                        { get; set; }
        public int                                      IsFreeTrial                             { get; set; }
        public int                                      ProductType                             { get; set; }
        public int                                      IsIntroductoryPricePeriod               { get; set; }

        public static AppleInAppPurchaseReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppleInAppPurchaseReceipt() { Pointer= p0 };

            value.Quantity                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 Quantity                    ( ModelPrimitiveType int int int Int32 )
            value.ProductID                                 = GetString(new IntPtr(p + 0x018)); // 0x18 ProductID                   ( ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x020)); // 0x20 TransactionID               ( ModelPrimitiveType string string string String )
            value.OriginalTransactionIdentifier             = GetString(new IntPtr(p + 0x028)); // 0x28 OriginalTransactionIdentifier ( ModelPrimitiveType string string string String )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x030)); // 0x30 PurchaseDate                ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.OriginalPurchaseDate                      = GetDateTime(new IntPtr(p + 0x038)); // 0x38 OriginalPurchaseDate        ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SubscriptionExpirationDate                = GetDateTime(new IntPtr(p + 0x040)); // 0x40 SubscriptionExpirationDate  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.CancellationDate                          = GetDateTime(new IntPtr(p + 0x048)); // 0x48 CancellationDate            ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.IsFreeTrial                               = GetInt32(new IntPtr(p + 0x050)); // 0x50 IsFreeTrial                 ( ModelPrimitiveType int int int Int32 )
            value.ProductType                               = GetInt32(new IntPtr(p + 0x054)); // 0x54 ProductType                 ( ModelPrimitiveType int int int Int32 )
            value.IsIntroductoryPricePeriod                 = GetInt32(new IntPtr(p + 0x058)); // 0x58 IsIntroductoryPricePeriod   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
