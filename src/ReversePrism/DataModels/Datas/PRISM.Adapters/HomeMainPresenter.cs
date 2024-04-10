using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MainBannerMax                            int IL2CPP_TYPE_I4
    // 010 Argument                                 0001866B9B50 ModelClassType HomeArgument HomeArgument HomeArgument Pointer
    // 018 Model                                    0001866C6410 ModelClassType HomeModel HomeModel HomeModel Pointer
    // 020 ViewModel                                0001866D3DB0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 028 HomeView                                 00018656CDB0 ModelClassType IHomeView IHomeView IHomeView Pointer
    // 030 View                                     000186569DB0 ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer
    // 038 ResumeLiveView                           00018661D9D0 ModelClassType IResumeLiveView IResumeLiveView IResumeLiveView Pointer
    // 040 DisposeLiveView                          000186754120 ModelClassType IDisposeLiveView IDisposeLiveView IDisposeLiveView Pointer
    // 048 MainBanner                               0001865675E0 ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer
    // 050 SeasonMissionBanner                      0001866C0480 ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer
    // 058 SpecialMissionBanner                     0001866C0480 ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer
    // 060 OurStreamBanner                          0001866C0480 ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer
    // 068 EventListButton                          00018675BE10 ModelClassType EventListButtonPresenter EventListButtonPresenter EventListButtonPresenter Pointer
    // 070 MobileNotificationPresenter              000186630850 ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer
    // 078 TokenSource                              0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 080 OverlayManager                           0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 088 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 090 onRequestBadge                           Func`2<CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 098 onReload3dScene                          Func`2<CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 0A0 IsFadeInEnd                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A1 IsActiveUI                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 <OnBeforeResumeLiveAsync>k__BackingField Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class HomeMainPresenter : DataModel
    {
        public HomeArgument?                            Argument                                { get; set; }
        public HomeModel?                               Model                                   { get; set; }
        public HomeViewModel?                           ViewModel                               { get; set; }
        public IHomeView?                               HomeView                                { get; set; }
        public IHomeMainView?                           View                                    { get; set; }
        public IResumeLiveView?                         ResumeLiveView                          { get; set; }
        public IDisposeLiveView?                        DisposeLiveView                         { get; set; }
        public IHomeBannerView?                         MainBanner                              { get; set; }
        public HomeFixedBannerPresenter?                SeasonMissionBanner                     { get; set; }
        public HomeFixedBannerPresenter?                SpecialMissionBanner                    { get; set; }
        public HomeFixedBannerPresenter?                OurStreamBanner                         { get; set; }
        public EventListButtonPresenter?                EventListButton                         { get; set; }
        public MobileNotificationPresenter?             MobileNotificationPresenter             { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public OverlayManager?                          OverlayManager                          { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     IsFadeInEnd                             { get; set; }
        public bool                                     IsActiveUI                              { get; set; }

        public static HomeMainPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeMainPresenter() { Pointer= p0 };

            value.Argument                                  = GetObject<HomeArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeArgument.FromPointer); // 0245A5B3C3C8 0x10 Argument                    ( 0001866B9B50 ModelClassType HomeArgument HomeArgument HomeArgument Pointer )
            value.Model                                     = GetObject<HomeModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.HomeModel.FromPointer); // 0245A5B3C3E8 0x18 Model                       ( 0001866C6410 ModelClassType HomeModel HomeModel HomeModel Pointer )
            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0245A5B3C408 0x20 ViewModel                   ( 0001866D3DB0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.HomeView                                  = GetObject<IHomeView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IHomeView.FromPointer); // 0245A5B3C428 0x28 HomeView                    ( 00018656CDB0 ModelClassType IHomeView IHomeView IHomeView Pointer )
            value.View                                      = GetObject<IHomeMainView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IHomeMainView.FromPointer); // 0245A5B3C448 0x30 View                        ( 000186569DB0 ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer )
            value.ResumeLiveView                            = GetObject<IResumeLiveView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResumeLiveView.FromPointer); // 0245A5B3C468 0x38 ResumeLiveView              ( 00018661D9D0 ModelClassType IResumeLiveView IResumeLiveView IResumeLiveView Pointer )
            value.DisposeLiveView                           = GetObject<IDisposeLiveView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposeLiveView.FromPointer); // 0245A5B3C488 0x40 DisposeLiveView             ( 000186754120 ModelClassType IDisposeLiveView IDisposeLiveView IDisposeLiveView Pointer )
            value.MainBanner                                = GetObject<IHomeBannerView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IHomeBannerView.FromPointer); // 0245A5B3C4A8 0x48 MainBanner                  ( 0001865675E0 ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer )
            value.SeasonMissionBanner                       = GetObject<HomeFixedBannerPresenter>(new IntPtr(p + 0x050), ReversePrism.DataModels.HomeFixedBannerPresenter.FromPointer); // 0245A5B3C4C8 0x50 SeasonMissionBanner         ( 0001866C0480 ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer )
            value.SpecialMissionBanner                      = GetObject<HomeFixedBannerPresenter>(new IntPtr(p + 0x058), ReversePrism.DataModels.HomeFixedBannerPresenter.FromPointer); // 0245A5B3C4E8 0x58 SpecialMissionBanner        ( 0001866C0480 ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer )
            value.OurStreamBanner                           = GetObject<HomeFixedBannerPresenter>(new IntPtr(p + 0x060), ReversePrism.DataModels.HomeFixedBannerPresenter.FromPointer); // 0245A5B3C508 0x60 OurStreamBanner             ( 0001866C0480 ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer )
            value.EventListButton                           = GetObject<EventListButtonPresenter>(new IntPtr(p + 0x068), ReversePrism.DataModels.EventListButtonPresenter.FromPointer); // 0245A5B3C528 0x68 EventListButton             ( 00018675BE10 ModelClassType EventListButtonPresenter EventListButtonPresenter EventListButtonPresenter Pointer )
            value.MobileNotificationPresenter               = GetObject<MobileNotificationPresenter>(new IntPtr(p + 0x070), ReversePrism.DataModels.MobileNotificationPresenter.FromPointer); // 0245A5B3C548 0x70 MobileNotificationPresenter ( 000186630850 ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x078), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0245A5B3C568 0x78 TokenSource                 ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x080), ReversePrism.DataModels.OverlayManager.FromPointer); // 0245A5B3C588 0x80 OverlayManager              ( 0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0245A5B3C5A8 0x88 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsFadeInEnd                               = GetBool(new IntPtr(p + 0x0A0)); // 0245A5B3C608 0xA0 IsFadeInEnd                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsActiveUI                                = GetBool(new IntPtr(p + 0x0A1)); // 0245A5B3C628 0xA1 IsActiveUI                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
