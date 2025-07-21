using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IHomeFixedBannerView IHomeFixedBannerView IHomeFixedBannerView Pointer
    public partial class HomeFixedBannerPresenter : DataModel
    {
        public IHomeFixedBannerView?                    View                                    { get; set; }

        public static HomeFixedBannerPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeFixedBannerPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IHomeFixedBannerView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHomeFixedBannerView.FromPointer); // 0x10 View                        ( ModelClassType IHomeFixedBannerView IHomeFixedBannerView IHomeFixedBannerView Pointer )

            return value;
        }
    }
}
