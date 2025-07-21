using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductID                                ModelPrimitiveType string string string String
    // 018 OrderID                                  ModelPrimitiveType string string string String
    // 020 PackageName                              ModelPrimitiveType string string string String
    // 028 PurchaseToken                            ModelPrimitiveType string string string String
    // 030 PurchaseDate                             ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 PurchaseState                            ModelEnumType GooglePurchaseState GooglePurchaseState GooglePurchaseState Int32
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

            value.ProductID                                 = GetString(new IntPtr(p + 0x010)); // 0x10 ProductID                   ( ModelPrimitiveType string string string String )
            value.OrderID                                   = GetString(new IntPtr(p + 0x018)); // 0x18 OrderID                     ( ModelPrimitiveType string string string String )
            value.PackageName                               = GetString(new IntPtr(p + 0x020)); // 0x20 PackageName                 ( ModelPrimitiveType string string string String )
            value.PurchaseToken                             = GetString(new IntPtr(p + 0x028)); // 0x28 PurchaseToken               ( ModelPrimitiveType string string string String )
            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x030)); // 0x30 PurchaseDate                ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.PurchaseState                             = (GooglePurchaseState)GetInt32(new IntPtr(p + 0x038)); // 0x38 PurchaseState               ( ModelEnumType GooglePurchaseState GooglePurchaseState GooglePurchaseState Int32 )

            return value;
        }
    }
}
