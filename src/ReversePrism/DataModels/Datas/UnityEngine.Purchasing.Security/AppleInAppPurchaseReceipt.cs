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
    public partial class AppleInAppPurchaseReceipt
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
            var value   = new AppleInAppPurchaseReceipt();

            value.Quantity                                  = GetInt32(new IntPtr(p + 0x010)); // 02700697D6A0 0x10 Quantity                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProductID                                 = GetString(new IntPtr(p + 0x018)); // 02700697D6C0 0x18 ProductID                   ( 000186671910 ModelPrimitiveType string string string String )
            value.TransactionID                             = GetString(new IntPtr(p + 0x020)); // 02700697D6E0 0x20 TransactionID               ( 000186671910 ModelPrimitiveType string string string String )
            value.OriginalTransactionIdentifier             = GetString(new IntPtr(p + 0x028)); // 02700697D700 0x28 OriginalTransactionIdentifier ( 000186671910 ModelPrimitiveType string string string String )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x030)); // 02700697D720 0x30 PurchaseDate                ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.OriginalPurchaseDate                      = GetDateTime(new IntPtr(p + 0x038)); // 02700697D740 0x38 OriginalPurchaseDate        ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.SubscriptionExpirationDate                = GetDateTime(new IntPtr(p + 0x040)); // 02700697D760 0x40 SubscriptionExpirationDate  ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.CancellationDate                          = GetDateTime(new IntPtr(p + 0x048)); // 02700697D780 0x48 CancellationDate            ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.IsFreeTrial                               = GetInt32(new IntPtr(p + 0x050)); // 02700697D7A0 0x50 IsFreeTrial                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProductType                               = GetInt32(new IntPtr(p + 0x054)); // 02700697D7C0 0x54 ProductType                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsIntroductoryPricePeriod                 = GetInt32(new IntPtr(p + 0x058)); // 02700697D7E0 0x58 IsIntroductoryPricePeriod   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
