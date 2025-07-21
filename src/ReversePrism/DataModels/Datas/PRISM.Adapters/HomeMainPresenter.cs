using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MainBannerMax                            int IL2CPP_TYPE_I4
    // 010 Argument                                 ModelClassType HomeArgument HomeArgument HomeArgument Pointer
    // 018 ViewModel                                ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 020 HomeView                                 ModelClassType IHomeView IHomeView IHomeView Pointer
    // 028 View                                     ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer
    // 030 ResumeLiveView                           ModelClassType IResumeLiveView IResumeLiveView IResumeLiveView Pointer
    // 038 DisposeLiveView                          ModelClassType IDisposeLiveView IDisposeLiveView IDisposeLiveView Pointer
    // 040 MainBanner                               ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer
    // 048 SeasonMissionBanner                      ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer
    // 050 SpecialMissionBanner                     ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer
    // 058 OurStreamBanner                          ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer
    // 060 EventListButton                          ModelClassType EventListButtonPresenter EventListButtonPresenter EventListButtonPresenter Pointer
    // 068 MobileNotificationPresenter              ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer
    // 070 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 078 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 080 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 088 onRequestBadge                           Func`2<CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 090 onReload3dScene                          Func`2<CancellationToken, UniTask> IL2CPP_TYPE_GENERICINST
    // 098 IsFadeInEnd                              ModelPrimitiveType bool bool bool Bool
    // 099 IsActiveUI                               ModelPrimitiveType bool bool bool Bool
    // 0A0 DirectMessage                            ModelClassType DirectMessageViewModel DirectMessageViewModel DirectMessageViewModel Pointer
    // 0A8 <OnBeforeResumeLiveAsync>k__BackingField Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class HomeMainPresenter : DataModel
    {
        public HomeArgument?                            Argument                                { get; set; }
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
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     IsFadeInEnd                             { get; set; }
        public bool                                     IsActiveUI                              { get; set; }
        public DirectMessageViewModel?                  DirectMessage                           { get; set; }

        public static HomeMainPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeMainPresenter() { Pointer= p0 };

            value.Argument                                  = GetObject<HomeArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.HomeArgument.FromPointer); // 0x10 Argument                    ( ModelClassType HomeArgument HomeArgument HomeArgument Pointer )
            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0x18 ViewModel                   ( ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.HomeView                                  = GetObject<IHomeView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHomeView.FromPointer); // 0x20 HomeView                    ( ModelClassType IHomeView IHomeView IHomeView Pointer )
            value.View                                      = GetObject<IHomeMainView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IHomeMainView.FromPointer); // 0x28 View                        ( ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer )
            value.ResumeLiveView                            = GetObject<IResumeLiveView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResumeLiveView.FromPointer); // 0x30 ResumeLiveView              ( ModelClassType IResumeLiveView IResumeLiveView IResumeLiveView Pointer )
            value.DisposeLiveView                           = GetObject<IDisposeLiveView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposeLiveView.FromPointer); // 0x38 DisposeLiveView             ( ModelClassType IDisposeLiveView IDisposeLiveView IDisposeLiveView Pointer )
            value.MainBanner                                = GetObject<IHomeBannerView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IHomeBannerView.FromPointer); // 0x40 MainBanner                  ( ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer )
            value.SeasonMissionBanner                       = GetObject<HomeFixedBannerPresenter>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeFixedBannerPresenter.FromPointer); // 0x48 SeasonMissionBanner         ( ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer )
            value.SpecialMissionBanner                      = GetObject<HomeFixedBannerPresenter>(new IntPtr(p + 0x050), ReversePrism.DataModels.HomeFixedBannerPresenter.FromPointer); // 0x50 SpecialMissionBanner        ( ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer )
            value.OurStreamBanner                           = GetObject<HomeFixedBannerPresenter>(new IntPtr(p + 0x058), ReversePrism.DataModels.HomeFixedBannerPresenter.FromPointer); // 0x58 OurStreamBanner             ( ModelClassType HomeFixedBannerPresenter HomeFixedBannerPresenter HomeFixedBannerPresenter Pointer )
            value.EventListButton                           = GetObject<EventListButtonPresenter>(new IntPtr(p + 0x060), ReversePrism.DataModels.EventListButtonPresenter.FromPointer); // 0x60 EventListButton             ( ModelClassType EventListButtonPresenter EventListButtonPresenter EventListButtonPresenter Pointer )
            value.MobileNotificationPresenter               = GetObject<MobileNotificationPresenter>(new IntPtr(p + 0x068), ReversePrism.DataModels.MobileNotificationPresenter.FromPointer); // 0x68 MobileNotificationPresenter ( ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x70 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x078), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x78 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x80 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsFadeInEnd                               = GetBool(new IntPtr(p + 0x098)); // 0x98 IsFadeInEnd                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsActiveUI                                = GetBool(new IntPtr(p + 0x099)); // 0x99 IsActiveUI                  ( ModelPrimitiveType bool bool bool Bool )
            value.DirectMessage                             = GetObject<DirectMessageViewModel>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.DirectMessageViewModel.FromPointer); // 0xA0 DirectMessage               ( ModelClassType DirectMessageViewModel DirectMessageViewModel DirectMessageViewModel Pointer )

            return value;
        }
    }
}
