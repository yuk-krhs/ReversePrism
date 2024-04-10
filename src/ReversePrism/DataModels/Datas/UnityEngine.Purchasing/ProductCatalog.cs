using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 IProductCatalogImpl IL2CPP_TYPE_CLASS
    // 010 AppleSKU                                 0001866722E0 ModelPrimitiveType string string string String
    // 018 AppleTeamID                              0001866722E0 ModelPrimitiveType string string string String
    // 020 EnableCodelessAutoInitialization         000186595960 ModelPrimitiveType bool bool bool Bool
    // 021 EnableUnityGamingServicesAutoInitialization 000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 Products                                 000185CFD998 ModelClassListType List`1<ProductCatalogItem> List`1<ProductCatalogItem> List<ProductCatalogItem> Pointer
    // 000 kCatalogPath                             string IL2CPP_TYPE_STRING
    // 000 kPrevCatalogPath                         string IL2CPP_TYPE_STRING
    public partial class ProductCatalog : DataModel
    {
        public string                                   AppleSKU                                { get; set; }
        public string                                   AppleTeamID                             { get; set; }
        public bool                                     EnableCodelessAutoInitialization        { get; set; }
        public bool                                     EnableUnityGamingServicesAutoInitialization { get; set; }
        public List<ProductCatalogItem>?                Products                                { get; set; }

        public static ProductCatalog? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductCatalog() { Pointer= p0 };

            value.AppleSKU                                  = GetString(new IntPtr(p + 0x010)); // 0245A68DEC80 0x10 AppleSKU                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AppleTeamID                               = GetString(new IntPtr(p + 0x018)); // 0245A68DECA0 0x18 AppleTeamID                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.EnableCodelessAutoInitialization          = GetBool(new IntPtr(p + 0x020)); // 0245A68DECC0 0x20 EnableCodelessAutoInitialization ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.EnableUnityGamingServicesAutoInitialization = GetBool(new IntPtr(p + 0x021)); // 0245A68DECE0 0x21 EnableUnityGamingServicesAutoInitialization ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Products                                  = GetObjectList<ProductCatalogItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductCatalogItem.FromPointer); // 0245A68DED00 0x28 Products                    ( 000185CFD998 ModelClassListType List`1<ProductCatalogItem> List`1<ProductCatalogItem> List<ProductCatalogItem> Pointer )

            return value;
        }
    }
}
