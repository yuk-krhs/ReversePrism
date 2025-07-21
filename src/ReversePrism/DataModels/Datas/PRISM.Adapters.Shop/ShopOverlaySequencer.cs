using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    public partial class ShopOverlaySequencer : DataModel
    {
        public ShopViewModel?                           ViewModel                               { get; set; }

        public static ShopOverlaySequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopOverlaySequencer() { Pointer= p0 };

            value.ViewModel                                 = GetObject<ShopViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0x10 ViewModel                   ( ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )

            return value;
        }
    }
}
