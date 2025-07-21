using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 018 View                                     ModelClassType IHomeView IHomeView IHomeView Pointer
    // 020 HomeMainView                             ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer
    // 028 MainBanner                               ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer
    // 030 Scene3DView                              ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer
    // 038 CharacterMessageView                     ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer
    // 040 MainPresenter                            ModelClassType HomeMainPresenter HomeMainPresenter HomeMainPresenter Pointer
    // 048 LoginBonusPresenter                      ModelClassType HomeLoginBonusOverlayPresenter HomeLoginBonusOverlayPresenter HomeLoginBonusOverlayPresenter Pointer
    // 050 Home3DScenePresenter                     ModelClassType Home3DScenePresenter Home3DScenePresenter Home3DScenePresenter Pointer
    // 058 MobileNotificationPresenter              ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer
    // 060 Argument                                 ModelClassType HomeArgument HomeArgument HomeArgument Pointer
    // 068 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 070 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class HomePresenter : DataModel
    {
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

            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0x10 ViewModel                   ( ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.View                                      = GetObject<IHomeView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHomeView.FromPointer); // 0x18 View                        ( ModelClassType IHomeView IHomeView IHomeView Pointer )
            value.HomeMainView                              = GetObject<IHomeMainView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHomeMainView.FromPointer); // 0x20 HomeMainView                ( ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer )
            value.MainBanner                                = GetObject<IHomeBannerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IHomeBannerView.FromPointer); // 0x28 MainBanner                  ( ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer )
            value.Scene3DView                               = GetObject<IHome3DSceneView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IHome3DSceneView.FromPointer); // 0x30 Scene3DView                 ( ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer )
            value.CharacterMessageView                      = GetObject<IHomeCharacterMessagePanelView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IHomeCharacterMessagePanelView.FromPointer); // 0x38 CharacterMessageView        ( ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer )
            value.MainPresenter                             = GetObject<HomeMainPresenter>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeMainPresenter.FromPointer); // 0x40 MainPresenter               ( ModelClassType HomeMainPresenter HomeMainPresenter HomeMainPresenter Pointer )
            value.LoginBonusPresenter                       = GetObject<HomeLoginBonusOverlayPresenter>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeLoginBonusOverlayPresenter.FromPointer); // 0x48 LoginBonusPresenter         ( ModelClassType HomeLoginBonusOverlayPresenter HomeLoginBonusOverlayPresenter HomeLoginBonusOverlayPresenter Pointer )
            value.Home3DScenePresenter                      = GetObject<Home3DScenePresenter>(new IntPtr(p + 0x050), ReversePrism.DataModels.Home3DScenePresenter.FromPointer); // 0x50 Home3DScenePresenter        ( ModelClassType Home3DScenePresenter Home3DScenePresenter Home3DScenePresenter Pointer )
            value.MobileNotificationPresenter               = GetObject<MobileNotificationPresenter>(new IntPtr(p + 0x058), ReversePrism.DataModels.MobileNotificationPresenter.FromPointer); // 0x58 MobileNotificationPresenter ( ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer )
            value.Argument                                  = GetObject<HomeArgument>(new IntPtr(p + 0x060), ReversePrism.DataModels.HomeArgument.FromPointer); // 0x60 Argument                    ( ModelClassType HomeArgument HomeArgument HomeArgument Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x68 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x70 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
