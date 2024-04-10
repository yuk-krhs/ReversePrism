using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BannerButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 BannerImage                              0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 ViewModel                                0001866BBCF0 ModelClassType HomeBannerViewModel HomeBannerViewModel HomeBannerViewModel Pointer
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

            value.BannerButton                              = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0245A4FA70D0 0x20 BannerButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BannerImage                               = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0245A4FA70F0 0x28 BannerImage                 ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ViewModel                                 = GetObject<HomeBannerViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeBannerViewModel.FromPointer); // 0245A4FA7110 0x30 ViewModel                   ( 0001866BBCF0 ModelClassType HomeBannerViewModel HomeBannerViewModel HomeBannerViewModel Pointer )

            return value;
        }
    }
}
