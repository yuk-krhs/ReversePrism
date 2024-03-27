using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 shopOverlayViewFactory                   IOverlayViewFactory`1<IShopView> IL2CPP_TYPE_GENERICINST
    // 018 ViewModel                                000186774F10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    public partial class ShopOverlaySequencer
    {
        public ShopViewModel?                           ViewModel                               { get; set; }

        public static ShopOverlaySequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopOverlaySequencer();

            value.ViewModel                                 = GetObject<ShopViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0270D6819AC8 0x18 ViewModel                   ( 000186774F10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )

            return value;
        }
    }
}
