using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StoreSpecificId                          000186671910 ModelPrimitiveType string string string String
    // 018 Type                                     0001865A6600 ModelEnumType ProductType ProductType ProductType Int32
    // 020 Metadata                                 0001865A3510 ModelClassType ProductMetadata ProductMetadata ProductMetadata Pointer
    // 028 Receipt                                  000186671910 ModelPrimitiveType string string string String
    // 030 TransactionId                            000186671910 ModelPrimitiveType string string string String
    public partial class ProductDescription
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
            var value   = new ProductDescription();

            value.StoreSpecificId                           = GetString(new IntPtr(p + 0x010)); // 027004DAEB50 0x10 StoreSpecificId             ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = (ProductType)GetInt32(new IntPtr(p + 0x018)); // 027004DAEB70 0x18 Type                        ( 0001865A6600 ModelEnumType ProductType ProductType ProductType Int32 )
            value.Metadata                                  = GetObject<ProductMetadata>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductMetadata.FromPointer); // 027004DAEB90 0x20 Metadata                    ( 0001865A3510 ModelClassType ProductMetadata ProductMetadata ProductMetadata Pointer )
            value.Receipt                                   = GetString(new IntPtr(p + 0x028)); // 027004DAEBB0 0x28 Receipt                     ( 000186671910 ModelPrimitiveType string string string String )
            value.TransactionId                             = GetString(new IntPtr(p + 0x030)); // 027004DAEBD0 0x30 TransactionId               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
