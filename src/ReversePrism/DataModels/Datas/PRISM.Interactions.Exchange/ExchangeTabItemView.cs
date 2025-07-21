using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabButton                                ModelClassType UITabButton UITabButton UITabButton Pointer
    // 028 NewBadge                                 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ExchangeTabItemView : DataModel
    {
        public UITabButton?                             TabButton                               { get; set; }
        public GameObject?                              NewBadge                                { get; set; }

        public static ExchangeTabItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeTabItemView() { Pointer= p0 };

            value.TabButton                                 = GetObject<UITabButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabButton.FromPointer); // 0x20 TabButton                   ( ModelClassType UITabButton UITabButton UITabButton Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 NewBadge                    ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
