using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RealCurrency                             Nullable`1<RealCurrency> IL2CPP_TYPE_GENERICINST
    // 028 VirtualCurrencies                        ModelEnumListType List`1<VirtualCurrency> List`1<VirtualCurrency> List<VirtualCurrency> Pointer
    // 030 Items                                    ModelEnumListType List`1<Item> List`1<Item> List<Item> Pointer
    public partial class Product : DataModel
    {
        public List<VirtualCurrency>?                   VirtualCurrencies                       { get; set; }
        public List<Item>?                              Items                                   { get; set; }

        public static Product? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Product() { Pointer= p0 };

            value.VirtualCurrencies                         = GetEnumList<VirtualCurrency>(new IntPtr(p + 0x028)); // 0x28 VirtualCurrencies           ( ModelEnumListType List`1<VirtualCurrency> List`1<VirtualCurrency> List<VirtualCurrency> Pointer )
            value.Items                                     = GetEnumList<Item>(new IntPtr(p + 0x030)); // 0x30 Items                       ( ModelEnumListType List`1<Item> List`1<Item> List<Item> Pointer )

            return value;
        }
    }
}
