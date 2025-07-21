using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Dropdown                                 ModelClassType Dropdown Dropdown Dropdown Pointer
    // 028 dropdownIndex                            ReactiveProperty`1<int> IL2CPP_TYPE_GENERICINST
    // 030 Items                                    ModelClassListType List`1<Item> List`1<Item> List<Item> Pointer
    public partial class UIPullDown : DataModel
    {
        public Dropdown?                                Dropdown                                { get; set; }
        public List<Item>?                              Items                                   { get; set; }

        public static UIPullDown? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIPullDown() { Pointer= p0 };

            value.Dropdown                                  = GetObject<Dropdown>(new IntPtr(p + 0x020), ReversePrism.DataModels.Dropdown.FromPointer); // 0x20 Dropdown                    ( ModelClassType Dropdown Dropdown Dropdown Pointer )
            value.Items                                     = GetObjectList<Item>(new IntPtr(p + 0x030), ReversePrism.DataModels.Item.FromPointer); // 0x30 Items                       ( ModelClassListType List`1<Item> List`1<Item> List<Item> Pointer )

            return value;
        }
    }
}
