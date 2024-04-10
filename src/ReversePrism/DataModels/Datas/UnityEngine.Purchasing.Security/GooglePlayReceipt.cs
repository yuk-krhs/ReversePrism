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
    public partial class GooglePlayReceipt : DataModel
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
            var value   = new GooglePlayReceipt() { Pointer= p0 };

            value.ProductID                                 = GetString(new IntPtr(p + 0x010)); // 0245A6930F60 0x10 ProductID                   ( 000186671910 ModelPrimitiveType string string string String )
            value.OrderID                                   = GetString(new IntPtr(p + 0x018)); // 0245A6930F80 0x18 OrderID                     ( 000186671910 ModelPrimitiveType string string string String )
            value.PackageName                               = GetString(new IntPtr(p + 0x020)); // 0245A6930FA0 0x20 PackageName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.PurchaseToken                             = GetString(new IntPtr(p + 0x028)); // 0245A6930FC0 0x28 PurchaseToken               ( 000186671910 ModelPrimitiveType string string string String )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x030)); // 0245A6930FE0 0x30 PurchaseDate                ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.PurchaseState                             = (GooglePurchaseState)GetInt32(new IntPtr(p + 0x038)); // 0245A6931000 0x38 PurchaseState               ( 00018668B070 ModelEnumType GooglePurchaseState GooglePurchaseState GooglePurchaseState Int32 )

            return value;
        }
    }
}
