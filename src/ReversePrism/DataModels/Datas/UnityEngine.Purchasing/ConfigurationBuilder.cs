using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseCatalogProvider                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 <products>k__BackingField                HashSet`1<ProductDefinition> IL2CPP_TYPE_GENERICINST
    // 020 Factory                                  0001865E1940 ModelClassType PurchasingFactory PurchasingFactory PurchasingFactory Pointer
    public partial class ConfigurationBuilder : DataModel
    {
        public bool                                     UseCatalogProvider                      { get; set; }
        public PurchasingFactory?                       Factory                                 { get; set; }

        public static ConfigurationBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfigurationBuilder() { Pointer= p0 };

            value.UseCatalogProvider                        = GetBool(new IntPtr(p + 0x010)); // 02466302E988 0x10 UseCatalogProvider          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Factory                                   = GetObject<PurchasingFactory>(new IntPtr(p + 0x020), ReversePrism.DataModels.PurchasingFactory.FromPointer); // 02466302E9C8 0x20 Factory                     ( 0001865E1940 ModelClassType PurchasingFactory PurchasingFactory PurchasingFactory Pointer )

            return value;
        }
    }
}
