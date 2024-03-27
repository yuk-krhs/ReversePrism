using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_ConfigMap                              Dictionary`2<Type, IStoreConfiguration> IL2CPP_TYPE_GENERICINST
    // 018 m_ExtensionMap                           Dictionary`2<Type, IStoreExtension> IL2CPP_TYPE_GENERICINST
    // 020 M_Store                                  000186658560 ModelClassType IStore IStore IStore Pointer
    // 028 M_CatalogProvider                        00018671A8E0 ModelClassType ICatalogProvider ICatalogProvider ICatalogProvider Pointer
    // 030 StoreName                                000186671910 ModelPrimitiveType string string string String
    public partial class PurchasingFactory
    {
        public IStore?                                  M_Store                                 { get; set; }
        public ICatalogProvider?                        M_CatalogProvider                       { get; set; }
        public string                                   StoreName                               { get; set; }

        public static PurchasingFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PurchasingFactory();

            value.M_Store                                   = GetObject<IStore>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStore.FromPointer); // 027004BA9D28 0x20 M_Store                     ( 000186658560 ModelClassType IStore IStore IStore Pointer )
            value.M_CatalogProvider                         = GetObject<ICatalogProvider>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICatalogProvider.FromPointer); // 027004BA9D48 0x28 M_CatalogProvider           ( 00018671A8E0 ModelClassType ICatalogProvider ICatalogProvider ICatalogProvider Pointer )
            value.StoreName                                 = GetString(new IntPtr(p + 0x030)); // 027004BA9D68 0x30 StoreName                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
