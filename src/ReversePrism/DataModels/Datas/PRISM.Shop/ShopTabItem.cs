using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabButton                                0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer
    // 028 NewBadge                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ShopTabItem : DataModel
    {
        public UITabButton?                             TabButton                               { get; set; }
        public GameObject?                              NewBadge                                { get; set; }

        public static ShopTabItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopTabItem() { Pointer= p0 };

            value.TabButton                                 = GetObject<UITabButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabButton.FromPointer); // 0246655ACD28 0x20 TabButton                   ( 0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0246655ACD48 0x28 NewBadge                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
