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
    public partial class ShopTabItem
    {
        public UITabButton?                             TabButton                               { get; set; }
        public GameObject?                              NewBadge                                { get; set; }

        public static ShopTabItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopTabItem();

            value.TabButton                                 = GetObject<UITabButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabButton.FromPointer); // 0270D553AEA0 0x20 TabButton                   ( 0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D553AEC0 0x28 NewBadge                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
