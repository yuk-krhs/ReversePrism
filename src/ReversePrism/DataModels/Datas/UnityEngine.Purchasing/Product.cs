using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Definition                               0001865A0170 ModelClassType ProductDefinition ProductDefinition ProductDefinition Pointer
    // 018 Metadata                                 0001865A3510 ModelClassType ProductMetadata ProductMetadata ProductMetadata Pointer
    // 020 AvailableToPurchase                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 TransactionID                            000186671910 ModelPrimitiveType string string string String
    // 030 AppleOriginalTransactionID               000186671910 ModelPrimitiveType string string string String
    // 038 AppleProductIsRestored                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 Receipt                                  000186671910 ModelPrimitiveType string string string String
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

            value.Definition                                = GetObject<ProductDefinition>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProductDefinition.FromPointer); // 0245A4C229E0 0x10 Definition                  ( 0001865A0170 ModelClassType ProductDefinition ProductDefinition ProductDefinition Pointer )
            value.Metadata                                  = GetObject<ProductMetadata>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProductMetadata.FromPointer); // 0245A4C22A00 0x18 Metadata                    ( 0001865A3510 ModelClassType ProductMetadata ProductMetadata ProductMetadata Pointer )
            value.AvailableToPurchase                       = GetBool(new IntPtr(p + 0x020)); // 0245A4C22A20 0x20 AvailableToPurchase         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TransactionID                             = GetString(new IntPtr(p + 0x028)); // 0245A4C22A40 0x28 TransactionID               ( 000186671910 ModelPrimitiveType string string string String )
            value.AppleOriginalTransactionID                = GetString(new IntPtr(p + 0x030)); // 0245A4C22A60 0x30 AppleOriginalTransactionID  ( 000186671910 ModelPrimitiveType string string string String )
            value.AppleProductIsRestored                    = GetBool(new IntPtr(p + 0x038)); // 0245A4C22A80 0x38 AppleProductIsRestored      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Receipt                                   = GetString(new IntPtr(p + 0x040)); // 0245A4C22AA0 0x40 Receipt                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
