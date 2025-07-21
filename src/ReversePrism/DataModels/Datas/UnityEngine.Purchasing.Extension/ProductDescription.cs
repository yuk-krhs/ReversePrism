using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StoreSpecificId                          ModelPrimitiveType string string string String
    // 018 Type                                     ModelEnumType ProductType ProductType ProductType Int32
    // 020 Metadata                                 ModelClassType ProductMetadata ProductMetadata ProductMetadata Pointer
    // 028 Receipt                                  ModelPrimitiveType string string string String
    // 030 TransactionId                            ModelPrimitiveType string string string String
    public partial class ProductDescription : DataModel
    {
        public string                                   StoreSpecificId                         { get; set; }
        public ProductType                              Type                                    { get; set; }
        public ProductMetadata?                         Metadata                                { get; set; }
        public string                                   Receipt                                 { get; set; }
        public string                                   TransactionId                           { get; set; }

        public static ProductDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductDescription() { Pointer= p0 };

            value.StoreSpecificId                           = GetString(new IntPtr(p + 0x010)); // 0x10 StoreSpecificId             ( ModelPrimitiveType string string string String )
            value.Type                                      = (ProductType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelEnumType ProductType ProductType ProductType Int32 )
            value.Metadata                                  = GetObject<ProductMetadata>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductMetadata.FromPointer); // 0x20 Metadata                    ( ModelClassType ProductMetadata ProductMetadata ProductMetadata Pointer )
            value.Receipt                                   = GetString(new IntPtr(p + 0x028)); // 0x28 Receipt                     ( ModelPrimitiveType string string string String )
            value.TransactionId                             = GetString(new IntPtr(p + 0x030)); // 0x30 TransactionId               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
