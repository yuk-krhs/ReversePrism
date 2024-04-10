using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Quantity                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 ProductID                                000186671910 ModelPrimitiveType string string string String
    // 020 TransactionID                            000186671910 ModelPrimitiveType string string string String
    // 028 OriginalTransactionIdentifier            000186671910 ModelPrimitiveType string string string String
    // 030 PurchaseDate                             0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 OriginalPurchaseDate                     0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 SubscriptionExpirationDate               0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 CancellationDate                         0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 IsFreeTrial                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 ProductType                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 IsIntroductoryPricePeriod                0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Quantity                                  = GetInt32(new IntPtr(p + 0x010)); // 0245A692FE38 0x10 Quantity                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProductID                                 = GetString(new IntPtr(p + 0x018)); // 0245A692FE58 0x18 ProductID                   ( 000186671910 ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x020)); // 0245A692FE78 0x20 TransactionID               ( 000186671910 ModelPrimitiveType string string string String )
            value.OriginalTransactionIdentifier             = GetString(new IntPtr(p + 0x028)); // 0245A692FE98 0x28 OriginalTransactionIdentifier ( 000186671910 ModelPrimitiveType string string string String )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x030)); // 0245A692FEB8 0x30 PurchaseDate                ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.OriginalPurchaseDate                      = GetDateTime(new IntPtr(p + 0x038)); // 0245A692FED8 0x38 OriginalPurchaseDate        ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SubscriptionExpirationDate                = GetDateTime(new IntPtr(p + 0x040)); // 0245A692FEF8 0x40 SubscriptionExpirationDate  ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.CancellationDate                          = GetDateTime(new IntPtr(p + 0x048)); // 0245A692FF18 0x48 CancellationDate            ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.IsFreeTrial                               = GetInt32(new IntPtr(p + 0x050)); // 0245A692FF38 0x50 IsFreeTrial                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProductType                               = GetInt32(new IntPtr(p + 0x054)); // 0245A692FF58 0x54 ProductType                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsIntroductoryPricePeriod                 = GetInt32(new IntPtr(p + 0x058)); // 0245A692FF78 0x58 IsIntroductoryPricePeriod   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
