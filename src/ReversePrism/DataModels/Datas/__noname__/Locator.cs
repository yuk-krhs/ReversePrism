using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OverlayManager                           ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 018 OverlayViewFactory                       ModelClassType IOverlayViewFactory IOverlayViewFactory IOverlayViewFactory Pointer
    // 020 PopupViewFactory                         ModelClassType IPopupViewFactory IPopupViewFactory IPopupViewFactory Pointer
    // 028 SaveData                                 ModelClassType SaveDataContainer SaveDataContainer SaveDataContainer Pointer
    // 030 PermanentData                            ModelClassType PermanentDataContainer PermanentDataContainer PermanentDataContainer Pointer
    // 038 ResettableServiceContainer               ModelClassType ResettableServiceContainer ResettableServiceContainer ResettableServiceContainer Pointer
    // 040 ButtonGotoTypeProcessor                  ModelClassType IButtonGotoTypeProcessor IButtonGotoTypeProcessor IButtonGotoTypeProcessor Pointer
    // 048 OverlayInstantiator                      ModelClassType IOverlayInstantiator IOverlayInstantiator IOverlayInstantiator Pointer
    // 050 ResourceLoader                           ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 058 ResourceDownloader                       ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer
    // 060 BackKeyObservable                        ModelClassType IBackKeyObservable IBackKeyObservable IBackKeyObservable Pointer
    // 068 CommonSequencerContainer                 ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer
    // 070 NotificationManager                      ModelClassType NotificationManager NotificationManager NotificationManager Pointer
    // 078 AppReviewManager                         ModelClassType AppReviewManager AppReviewManager AppReviewManager Pointer
    // 080 ResourceLoaderFactory                    ModelClassType IResourceLoaderFactory IResourceLoaderFactory IResourceLoaderFactory Pointer
    // 088 SystemCall                               ModelClassType ISystemCall ISystemCall ISystemCall Pointer
    // 090 Crashlytics                              ModelClassType ICrashlytics ICrashlytics ICrashlytics Pointer
    // 098 Analytics                                ModelClassType IAnalytics IAnalytics IAnalytics Pointer
    // 0A0 LoadingPresenter                         ModelClassType ILoadingPresenter ILoadingPresenter ILoadingPresenter Pointer
    // 0A8 ConnectingView                           ModelClassType IConnectingView IConnectingView IConnectingView Pointer
    // 0B0 TutorialBuilder                          ModelClassType ITutorialBuilder ITutorialBuilder ITutorialBuilder Pointer
    // 0B8 TutorialContext                          ModelClassType ITutorialSequenceContext ITutorialSequenceContext ITutorialSequenceContext Pointer
    // 0C0 LegacyCallerResolver                     ModelClassType ILegacyCallerResolver ILegacyCallerResolver ILegacyCallerResolver Pointer
    public partial class Locator : DataModel
    {
        public OverlayManager?                          OverlayManager                          { get; set; }
        public IOverlayViewFactory?                     OverlayViewFactory                      { get; set; }
        public IPopupViewFactory?                       PopupViewFactory                        { get; set; }
        public SaveDataContainer?                       SaveData                                { get; set; }
        public PermanentDataContainer?                  PermanentData                           { get; set; }
        public ResettableServiceContainer?              ResettableServiceContainer              { get; set; }
        public IButtonGotoTypeProcessor?                ButtonGotoTypeProcessor                 { get; set; }
        public IOverlayInstantiator?                    OverlayInstantiator                     { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public ResourceDownloader?                      ResourceDownloader                      { get; set; }
        public IBackKeyObservable?                      BackKeyObservable                       { get; set; }
        public ICommonSequencerContainer?               CommonSequencerContainer                { get; set; }
        public NotificationManager?                     NotificationManager                     { get; set; }
        public AppReviewManager?                        AppReviewManager                        { get; set; }
        public IResourceLoaderFactory?                  ResourceLoaderFactory                   { get; set; }
        public ISystemCall?                             SystemCall                              { get; set; }
        public ICrashlytics?                            Crashlytics                             { get; set; }
        public IAnalytics?                              Analytics                               { get; set; }
        public ILoadingPresenter?                       LoadingPresenter                        { get; set; }
        public IConnectingView?                         ConnectingView                          { get; set; }
        public ITutorialBuilder?                        TutorialBuilder                         { get; set; }
        public ITutorialSequenceContext?                TutorialContext                         { get; set; }
        public ILegacyCallerResolver?                   LegacyCallerResolver                    { get; set; }

        public static Locator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Locator() { Pointer= p0 };

            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.OverlayManager.FromPointer); // 0x10 OverlayManager              ( ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.OverlayViewFactory                        = GetObject<IOverlayViewFactory>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOverlayViewFactory.FromPointer); // 0x18 OverlayViewFactory          ( ModelClassType IOverlayViewFactory IOverlayViewFactory IOverlayViewFactory Pointer )
            value.PopupViewFactory                          = GetObject<IPopupViewFactory>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPopupViewFactory.FromPointer); // 0x20 PopupViewFactory            ( ModelClassType IPopupViewFactory IPopupViewFactory IPopupViewFactory Pointer )
            value.SaveData                                  = GetObject<SaveDataContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.SaveDataContainer.FromPointer); // 0x28 SaveData                    ( ModelClassType SaveDataContainer SaveDataContainer SaveDataContainer Pointer )
            value.PermanentData                             = GetObject<PermanentDataContainer>(new IntPtr(p + 0x030), ReversePrism.DataModels.PermanentDataContainer.FromPointer); // 0x30 PermanentData               ( ModelClassType PermanentDataContainer PermanentDataContainer PermanentDataContainer Pointer )
            value.ResettableServiceContainer                = GetObject<ResettableServiceContainer>(new IntPtr(p + 0x038), ReversePrism.DataModels.ResettableServiceContainer.FromPointer); // 0x38 ResettableServiceContainer  ( ModelClassType ResettableServiceContainer ResettableServiceContainer ResettableServiceContainer Pointer )
            value.ButtonGotoTypeProcessor                   = GetObject<IButtonGotoTypeProcessor>(new IntPtr(p + 0x040), ReversePrism.DataModels.IButtonGotoTypeProcessor.FromPointer); // 0x40 ButtonGotoTypeProcessor     ( ModelClassType IButtonGotoTypeProcessor IButtonGotoTypeProcessor IButtonGotoTypeProcessor Pointer )
            value.OverlayInstantiator                       = GetObject<IOverlayInstantiator>(new IntPtr(p + 0x048), ReversePrism.DataModels.IOverlayInstantiator.FromPointer); // 0x48 OverlayInstantiator         ( ModelClassType IOverlayInstantiator IOverlayInstantiator IOverlayInstantiator Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.ResourceLoader.FromPointer); // 0x50 ResourceLoader              ( ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceDownloader                        = GetObject<ResourceDownloader>(new IntPtr(p + 0x058), ReversePrism.DataModels.ResourceDownloader.FromPointer); // 0x58 ResourceDownloader          ( ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer )
            value.BackKeyObservable                         = GetObject<IBackKeyObservable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IBackKeyObservable.FromPointer); // 0x60 BackKeyObservable           ( ModelClassType IBackKeyObservable IBackKeyObservable IBackKeyObservable Pointer )
            value.CommonSequencerContainer                  = GetObject<ICommonSequencerContainer>(new IntPtr(p + 0x068), ReversePrism.DataModels.ICommonSequencerContainer.FromPointer); // 0x68 CommonSequencerContainer    ( ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer )
            value.NotificationManager                       = GetObject<NotificationManager>(new IntPtr(p + 0x070), ReversePrism.DataModels.NotificationManager.FromPointer); // 0x70 NotificationManager         ( ModelClassType NotificationManager NotificationManager NotificationManager Pointer )
            value.AppReviewManager                          = GetObject<AppReviewManager>(new IntPtr(p + 0x078), ReversePrism.DataModels.AppReviewManager.FromPointer); // 0x78 AppReviewManager            ( ModelClassType AppReviewManager AppReviewManager AppReviewManager Pointer )
            value.ResourceLoaderFactory                     = GetObject<IResourceLoaderFactory>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceLoaderFactory.FromPointer); // 0x80 ResourceLoaderFactory       ( ModelClassType IResourceLoaderFactory IResourceLoaderFactory IResourceLoaderFactory Pointer )
            value.SystemCall                                = GetObject<ISystemCall>(new IntPtr(p + 0x088), ReversePrism.DataModels.ISystemCall.FromPointer); // 0x88 SystemCall                  ( ModelClassType ISystemCall ISystemCall ISystemCall Pointer )
            value.Crashlytics                               = GetObject<ICrashlytics>(new IntPtr(p + 0x090), ReversePrism.DataModels.ICrashlytics.FromPointer); // 0x90 Crashlytics                 ( ModelClassType ICrashlytics ICrashlytics ICrashlytics Pointer )
            value.Analytics                                 = GetObject<IAnalytics>(new IntPtr(p + 0x098), ReversePrism.DataModels.IAnalytics.FromPointer); // 0x98 Analytics                   ( ModelClassType IAnalytics IAnalytics IAnalytics Pointer )
            value.LoadingPresenter                          = GetObject<ILoadingPresenter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ILoadingPresenter.FromPointer); // 0xA0 LoadingPresenter            ( ModelClassType ILoadingPresenter ILoadingPresenter ILoadingPresenter Pointer )
            value.ConnectingView                            = GetObject<IConnectingView>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IConnectingView.FromPointer); // 0xA8 ConnectingView              ( ModelClassType IConnectingView IConnectingView IConnectingView Pointer )
            value.TutorialBuilder                           = GetObject<ITutorialBuilder>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ITutorialBuilder.FromPointer); // 0xB0 TutorialBuilder             ( ModelClassType ITutorialBuilder ITutorialBuilder ITutorialBuilder Pointer )
            value.TutorialContext                           = GetObject<ITutorialSequenceContext>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ITutorialSequenceContext.FromPointer); // 0xB8 TutorialContext             ( ModelClassType ITutorialSequenceContext ITutorialSequenceContext ITutorialSequenceContext Pointer )
            value.LegacyCallerResolver                      = GetObject<ILegacyCallerResolver>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ILegacyCallerResolver.FromPointer); // 0xC0 LegacyCallerResolver        ( ModelClassType ILegacyCallerResolver ILegacyCallerResolver ILegacyCallerResolver Pointer )

            return value;
        }
    }
}
