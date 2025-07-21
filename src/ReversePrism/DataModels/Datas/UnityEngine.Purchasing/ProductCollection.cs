using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_IdToProduct                            Dictionary`2<string, Product> IL2CPP_TYPE_GENERICINST
    // 018 m_StoreSpecificIdToProduct               Dictionary`2<string, Product> IL2CPP_TYPE_GENERICINST
    // 020 <set>k__BackingField                     HashSet`1<Product> IL2CPP_TYPE_GENERICINST
    // 028 All                                      ModelClassListType Product[] Product[] List<Product> Pointer
    public partial class ProductCollection : DataModel
    {
        public List<Product>?                           All                                     { get; set; }

        public static ProductCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProductCollection() { Pointer= p0 };

            value.All                                       = GetObjectList<Product>(new IntPtr(p + 0x028), ReversePrism.DataModels.Product.FromPointer); // 0x28 All                         ( ModelClassListType Product[] Product[] List<Product> Pointer )

            return value;
        }
    }
}
