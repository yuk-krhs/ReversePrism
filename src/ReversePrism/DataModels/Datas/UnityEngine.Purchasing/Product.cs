using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Definition                               ModelClassType ProductDefinition ProductDefinition ProductDefinition Pointer
    // 018 Metadata                                 ModelClassType ProductMetadata ProductMetadata ProductMetadata Pointer
    // 020 AvailableToPurchase                      ModelPrimitiveType bool bool bool Bool
    // 028 TransactionID                            ModelPrimitiveType string string string String
    // 030 AppleOriginalTransactionID               ModelPrimitiveType string string string String
    // 038 AppleProductIsRestored                   ModelPrimitiveType bool bool bool Bool
    // 040 Receipt                                  ModelPrimitiveType string string string String
    public partial class Product : DataModel
    {
        public ProductDefinition?                       Definition                              { get; set; }
        public ProductMetadata?                         Metadata                                { get; set; }
        public bool                                     AvailableToPurchase                     { get; set; }
        public string                                   TransactionID                           { get; set; }
        public string                                   AppleOriginalTransactionID              { get; set; }
        public bool                                     AppleProductIsRestored                  { get; set; }
        public string                                   Receipt                                 { get; set; }

        public static Product? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Product() { Pointer= p0 };

            value.Definition                                = GetObject<ProductDefinition>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProductDefinition.FromPointer); // 0x10 Definition                  ( ModelClassType ProductDefinition ProductDefinition ProductDefinition Pointer )
            value.Metadata                                  = GetObject<ProductMetadata>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductMetadata.FromPointer); // 0x18 Metadata                    ( ModelClassType ProductMetadata ProductMetadata ProductMetadata Pointer )
            value.AvailableToPurchase                       = GetBool(new IntPtr(p + 0x020)); // 0x20 AvailableToPurchase         ( ModelPrimitiveType bool bool bool Bool )
            value.TransactionID                             = GetString(new IntPtr(p + 0x028)); // 0x28 TransactionID               ( ModelPrimitiveType string string string String )
            value.AppleOriginalTransactionID                = GetString(new IntPtr(p + 0x030)); // 0x30 AppleOriginalTransactionID  ( ModelPrimitiveType string string string String )
            value.AppleProductIsRestored                    = GetBool(new IntPtr(p + 0x038)); // 0x38 AppleProductIsRestored      ( ModelPrimitiveType bool bool bool Bool )
            value.Receipt                                   = GetString(new IntPtr(p + 0x040)); // 0x40 Receipt                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
