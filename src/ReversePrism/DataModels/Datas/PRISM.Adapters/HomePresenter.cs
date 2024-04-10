using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001866C5F40 ModelClassType HomeModel HomeModel HomeModel Pointer
    // 018 ViewModel                                0001866D38A0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 020 View                                     00018656CB60 ModelClassType IHomeView IHomeView IHomeView Pointer
    // 028 HomeMainView                             000186569B50 ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer
    // 030 MainBanner                               000186567380 ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer
    // 038 Scene3DView                              000186566BC0 ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer
    // 040 CharacterMessageView                     000186567B00 ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer
    // 048 MainPresenter                            0001866C50C0 ModelClassType HomeMainPresenter HomeMainPresenter HomeMainPresenter Pointer
    // 050 LoginBonusPresenter                      0001866C2E00 ModelClassType HomeLoginBonusOverlayPresenter HomeLoginBonusOverlayPresenter HomeLoginBonusOverlayPresenter Pointer
    // 058 Home3DScenePresenter                     0001866B89C0 ModelClassType Home3DScenePresenter Home3DScenePresenter Home3DScenePresenter Pointer
    // 060 MobileNotificationPresenter              000186630850 ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer
    // 068 Argument                                 0001866B9B50 ModelClassType HomeArgument HomeArgument HomeArgument Pointer
    // 070 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 078 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class HomePresenter : DataModel
    {
        public HomeModel?                               Model                                   { get; set; }
        public HomeViewModel?                           ViewModel                               { get; set; }
        public IHomeView?                               View                                    { get; set; }
        public IHomeMainView?                           HomeMainView                            { get; set; }
        public IHomeBannerView?                         MainBanner                              { get; set; }
        public IHome3DSceneView?                        Scene3DView                             { get; set; }
        public IHomeCharacterMessagePanelView?          CharacterMessageView                    { get; set; }
        public HomeMainPresenter?                       MainPresenter                           { get; set; }
        public HomeLoginBonusOverlayPresenter?          LoginBonusPresenter                     { get; set; }
        public Home3DScenePresenter?                    Home3DScenePresenter                    { get; set; }
        public MobileNotificationPresenter?             MobileNotificationPresenter             { get; set; }
        public HomeArgument?                            Argument                                { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static HomePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomePresenter() { Pointer= p0 };

            value.Model                                     = GetObject<HomeModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeModel.FromPointer); // 0245A5B3CE60 0x10 Model                       ( 0001866C5F40 ModelClassType HomeModel HomeModel HomeModel Pointer )
            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0245A5B3CE80 0x18 ViewModel                   ( 0001866D38A0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.View                                      = GetObject<IHomeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHomeView.FromPointer); // 0245A5B3CEA0 0x20 View                        ( 00018656CB60 ModelClassType IHomeView IHomeView IHomeView Pointer )
            value.HomeMainView                              = GetObject<IHomeMainView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IHomeMainView.FromPointer); // 0245A5B3CEC0 0x28 HomeMainView                ( 000186569B50 ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer )
            value.MainBanner                                = GetObject<IHomeBannerView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IHomeBannerView.FromPointer); // 0245A5B3CEE0 0x30 MainBanner                  ( 000186567380 ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer )
            value.Scene3DView                               = GetObject<IHome3DSceneView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IHome3DSceneView.FromPointer); // 0245A5B3CF00 0x38 Scene3DView                 ( 000186566BC0 ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer )
            value.CharacterMessageView                      = GetObject<IHomeCharacterMessagePanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IHomeCharacterMessagePanelView.FromPointer); // 0245A5B3CF20 0x40 CharacterMessageView        ( 000186567B00 ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer )
            value.MainPresenter                             = GetObject<HomeMainPresenter>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeMainPresenter.FromPointer); // 0245A5B3CF40 0x48 MainPresenter               ( 0001866C50C0 ModelClassType HomeMainPresenter HomeMainPresenter HomeMainPresenter Pointer )
            value.LoginBonusPresenter                       = GetObject<HomeLoginBonusOverlayPresenter>(new IntPtr(p + 0x050), ReversePrism.DataModels.HomeLoginBonusOverlayPresenter.FromPointer); // 0245A5B3CF60 0x50 LoginBonusPresenter         ( 0001866C2E00 ModelClassType HomeLoginBonusOverlayPresenter HomeLoginBonusOverlayPresenter HomeLoginBonusOverlayPresenter Pointer )
            value.Home3DScenePresenter                      = GetObject<Home3DScenePresenter>(new IntPtr(p + 0x058), ReversePrism.DataModels.Home3DScenePresenter.FromPointer); // 0245A5B3CF80 0x58 Home3DScenePresenter        ( 0001866B89C0 ModelClassType Home3DScenePresenter Home3DScenePresenter Home3DScenePresenter Pointer )
            value.MobileNotificationPresenter               = GetObject<MobileNotificationPresenter>(new IntPtr(p + 0x060), ReversePrism.DataModels.MobileNotificationPresenter.FromPointer); // 0245A5B3CFA0 0x60 MobileNotificationPresenter ( 000186630850 ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer )
            value.Argument                                  = GetObject<HomeArgument>(new IntPtr(p + 0x068), ReversePrism.DataModels.HomeArgument.FromPointer); // 0245A5B3CFC0 0x68 Argument                    ( 0001866B9B50 ModelClassType HomeArgument HomeArgument HomeArgument Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0245A5B3CFE0 0x70 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0245A5B3D000 0x78 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
