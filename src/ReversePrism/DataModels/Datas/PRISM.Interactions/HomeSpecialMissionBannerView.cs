using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BannerButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 BannerImage                              000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 BadgeView                                000186738540 ModelClassType BadgeView BadgeView BadgeView Pointer
    // 038 ViewModel                                0001866BBCF0 ModelClassType HomeBannerViewModel HomeBannerViewModel HomeBannerViewModel Pointer
    public partial class HomeSpecialMissionBannerView
    {
        public UIButton?                                BannerButton                            { get; set; }
        public RawImage?                                BannerImage                             { get; set; }
        public BadgeView?                               BadgeView                               { get; set; }
        public HomeBannerViewModel?                     ViewModel                               { get; set; }

        public static HomeSpecialMissionBannerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSpecialMissionBannerView();

            value.BannerButton                              = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 027005ABE960 0x20 BannerButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BannerImage                               = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 027005ABE980 0x28 BannerImage                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.BadgeView                                 = GetObject<BadgeView>(new IntPtr(p + 0x030), ReversePrism.DataModels.BadgeView.FromPointer); // 027005ABE9A0 0x30 BadgeView                   ( 000186738540 ModelClassType BadgeView BadgeView BadgeView Pointer )
            value.ViewModel                                 = GetObject<HomeBannerViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeBannerViewModel.FromPointer); // 027005ABE9C0 0x38 ViewModel                   ( 0001866BBCF0 ModelClassType HomeBannerViewModel HomeBannerViewModel HomeBannerViewModel Pointer )

            return value;
        }
    }
}
