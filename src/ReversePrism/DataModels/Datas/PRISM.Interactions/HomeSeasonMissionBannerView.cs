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
    // 030 TermLabel                                0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 OpenImageObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 LastDayImageObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ResultImageObject                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 BadgeView                                000186738540 ModelClassType BadgeView BadgeView BadgeView Pointer
    // 058 ViewModel                                0001866BBCF0 ModelClassType HomeBannerViewModel HomeBannerViewModel HomeBannerViewModel Pointer
    public partial class HomeSeasonMissionBannerView
    {
        public UIButton?                                BannerButton                            { get; set; }
        public RawImage?                                BannerImage                             { get; set; }
        public TextMeshProUGUI?                         TermLabel                               { get; set; }
        public GameObject?                              OpenImageObject                         { get; set; }
        public GameObject?                              LastDayImageObject                      { get; set; }
        public GameObject?                              ResultImageObject                       { get; set; }
        public BadgeView?                               BadgeView                               { get; set; }
        public HomeBannerViewModel?                     ViewModel                               { get; set; }

        public static HomeSeasonMissionBannerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSeasonMissionBannerView();

            value.BannerButton                              = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 027005AB6E20 0x20 BannerButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BannerImage                               = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 027005AB6E40 0x28 BannerImage                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TermLabel                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 027005AB6E60 0x30 TermLabel                   ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.OpenImageObject                           = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 027005AB6E80 0x38 OpenImageObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LastDayImageObject                        = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 027005AB6EA0 0x40 LastDayImageObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ResultImageObject                         = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 027005AB6EC0 0x48 ResultImageObject           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BadgeView                                 = GetObject<BadgeView>(new IntPtr(p + 0x050), ReversePrism.DataModels.BadgeView.FromPointer); // 027005AB6EE0 0x50 BadgeView                   ( 000186738540 ModelClassType BadgeView BadgeView BadgeView Pointer )
            value.ViewModel                                 = GetObject<HomeBannerViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.HomeBannerViewModel.FromPointer); // 027005AB6F00 0x58 ViewModel                   ( 0001866BBCF0 ModelClassType HomeBannerViewModel HomeBannerViewModel HomeBannerViewModel Pointer )

            return value;
        }
    }
}
