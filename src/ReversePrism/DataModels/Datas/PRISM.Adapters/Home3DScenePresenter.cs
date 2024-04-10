using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                0001866D38A0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 018 View                                     000186567B00 ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer
    // 020 HomeMainView                             000186569B50 ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer
    // 028 BannerView                               000186567380 ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer
    // 030 Home3dSceneView                          000186566BC0 ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer
    // 038 CharaMessagePresenter                    0001866BDB80 ModelClassType HomeCharacterMessagePresenter HomeCharacterMessagePresenter HomeCharacterMessagePresenter Pointer
    // 040 LoginBonusCharaMessagePresenter          0001866C26F0 ModelClassType HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter Pointer
    // 048 MobileNotificationPresenter              000186630850 ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer
    public partial class Home3DScenePresenter : DataModel
    {
        public HomeViewModel?                           ViewModel                               { get; set; }
        public IHomeCharacterMessagePanelView?          View                                    { get; set; }
        public IHomeMainView?                           HomeMainView                            { get; set; }
        public IHomeBannerView?                         BannerView                              { get; set; }
        public IHome3DSceneView?                        Home3dSceneView                         { get; set; }
        public HomeCharacterMessagePresenter?           CharaMessagePresenter                   { get; set; }
        public HomeLoginBonusCharacterMessagePresenter? LoginBonusCharaMessagePresenter         { get; set; }
        public MobileNotificationPresenter?             MobileNotificationPresenter             { get; set; }

        public static Home3DScenePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Home3DScenePresenter() { Pointer= p0 };

            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0245A5B60EA8 0x10 ViewModel                   ( 0001866D38A0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.View                                      = GetObject<IHomeCharacterMessagePanelView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHomeCharacterMessagePanelView.FromPointer); // 0245A5B60EC8 0x18 View                        ( 000186567B00 ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer )
            value.HomeMainView                              = GetObject<IHomeMainView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHomeMainView.FromPointer); // 0245A5B60EE8 0x20 HomeMainView                ( 000186569B50 ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer )
            value.BannerView                                = GetObject<IHomeBannerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IHomeBannerView.FromPointer); // 0245A5B60F08 0x28 BannerView                  ( 000186567380 ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer )
            value.Home3dSceneView                           = GetObject<IHome3DSceneView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IHome3DSceneView.FromPointer); // 0245A5B60F28 0x30 Home3dSceneView             ( 000186566BC0 ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer )
            value.CharaMessagePresenter                     = GetObject<HomeCharacterMessagePresenter>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeCharacterMessagePresenter.FromPointer); // 0245A5B60F48 0x38 CharaMessagePresenter       ( 0001866BDB80 ModelClassType HomeCharacterMessagePresenter HomeCharacterMessagePresenter HomeCharacterMessagePresenter Pointer )
            value.LoginBonusCharaMessagePresenter           = GetObject<HomeLoginBonusCharacterMessagePresenter>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeLoginBonusCharacterMessagePresenter.FromPointer); // 0245A5B60F68 0x40 LoginBonusCharaMessagePresenter ( 0001866C26F0 ModelClassType HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter HomeLoginBonusCharacterMessagePresenter Pointer )
            value.MobileNotificationPresenter               = GetObject<MobileNotificationPresenter>(new IntPtr(p + 0x048), ReversePrism.DataModels.MobileNotificationPresenter.FromPointer); // 0245A5B60F88 0x48 MobileNotificationPresenter ( 000186630850 ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer )

            return value;
        }
    }
}
