using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BannerButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 028 BannerImage                              ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 ViewModel                                ModelClassType HomeBannerViewModel HomeBannerViewModel HomeBannerViewModel Pointer
    public partial class HomeOurStreamBannerView : DataModel
    {
        public UIButton?                                BannerButton                            { get; set; }
        public UIRawImage?                              BannerImage                             { get; set; }
        public HomeBannerViewModel?                     ViewModel                               { get; set; }

        public static HomeOurStreamBannerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeOurStreamBannerView() { Pointer= p0 };

            value.BannerButton                              = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 BannerButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BannerImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 BannerImage                 ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ViewModel                                 = GetObject<HomeBannerViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeBannerViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType HomeBannerViewModel HomeBannerViewModel HomeBannerViewModel Pointer )

            return value;
        }
    }
}
