using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductID                                000186671910 ModelPrimitiveType string string string String
    // 018 OrderID                                  000186671910 ModelPrimitiveType string string string String
    // 020 PackageName                              000186671910 ModelPrimitiveType string string string String
    // 028 PurchaseToken                            000186671910 ModelPrimitiveType string string string String
    // 030 PurchaseDate                             0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 PurchaseState                            00018668B070 ModelEnumType GooglePurchaseState GooglePurchaseState GooglePurchaseState Int32
    public partial class GooglePlayReceipt
    {
        public string                                   ProductID                               { get; set; }
        public string                                   OrderID                                 { get; set; }
        public string                                   PackageName                             { get; set; }
        public string                                   PurchaseToken                           { get; set; }
        public DateTime                                 PurchaseDate                            { get; set; }
        public GooglePurchaseState                      PurchaseState                           { get; set; }

        public static GooglePlayReceipt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayReceipt();

            value.ProductID                                 = GetString(new IntPtr(p + 0x010)); // 02700697E7C8 0x10 ProductID                   ( 000186671910 ModelPrimitiveType string string string String )
            value.OrderID                                   = GetString(new IntPtr(p + 0x018)); // 02700697E7E8 0x18 OrderID                     ( 000186671910 ModelPrimitiveType string string string String )
            value.PackageName                               = GetString(new IntPtr(p + 0x020)); // 02700697E808 0x20 PackageName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.PurchaseToken                             = GetString(new IntPtr(p + 0x028)); // 02700697E828 0x28 PurchaseToken               ( 000186671910 ModelPrimitiveType string string string String )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x030)); // 02700697E848 0x30 PurchaseDate                ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.PurchaseState                             = (GooglePurchaseState)GetInt32(new IntPtr(p + 0x038)); // 02700697E868 0x38 PurchaseState               ( 00018668B070 ModelEnumType GooglePurchaseState GooglePurchaseState GooglePurchaseState Int32 )

            return value;
        }
    }
}
