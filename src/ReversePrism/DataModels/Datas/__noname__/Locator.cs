using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OverlayManager                           0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 018 SaveData                                 0001866BE3F0 ModelClassType SaveDataContainer SaveDataContainer SaveDataContainer Pointer
    // 020 PermanentData                            000186735140 ModelClassType PermanentDataContainer PermanentDataContainer PermanentDataContainer Pointer
    // 028 ResettableServiceContainer               00018666CD60 ModelClassType ResettableServiceContainer ResettableServiceContainer ResettableServiceContainer Pointer
    // 030 ButtonGotoTypeProcessor                  000186714650 ModelClassType IButtonGotoTypeProcessor IButtonGotoTypeProcessor IButtonGotoTypeProcessor Pointer
    // 038 OverlayInstantiator                      0001865CC990 ModelClassType IOverlayInstantiator IOverlayInstantiator IOverlayInstantiator Pointer
    // 040 ResourceLoader                           00018666F930 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 048 ResourceDownloader                       00018666E3A0 ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer
    // 050 BackKeyObservable                        00018670D5B0 ModelClassType IBackKeyObservable IBackKeyObservable IBackKeyObservable Pointer
    // 058 CommonSequencerContainer                 0001867347C0 ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer
    // 060 NotificationManager                      0001866B3400 ModelClassType NotificationManager NotificationManager NotificationManager Pointer
    // 068 AppReviewManager                         0001866C9840 ModelClassType AppReviewManager AppReviewManager AppReviewManager Pointer
    // 070 ResourceLoaderFactory                    00018661B1C0 ModelClassType IResourceLoaderFactory IResourceLoaderFactory IResourceLoaderFactory Pointer
    // 078 SystemCall                               00018666C2B0 ModelClassType ISystemCall ISystemCall ISystemCall Pointer
    // 080 Crashlytics                              000186744360 ModelClassType ICrashlytics ICrashlytics ICrashlytics Pointer
    // 088 Analytics                                0001866F16F0 ModelClassType IAnalytics IAnalytics IAnalytics Pointer
    // 090 LoadingPresenter                         00018659E8E0 ModelClassType ILoadingPresenter ILoadingPresenter ILoadingPresenter Pointer
    // 098 ConnectingView                           000186739440 ModelClassType IConnectingView IConnectingView IConnectingView Pointer
    // 0A0 TutorialBuilder                          00018667F5E0 ModelClassType ITutorialBuilder ITutorialBuilder ITutorialBuilder Pointer
    public partial class Locator : DataModel
    {
        public OverlayManager?                          OverlayManager                          { get; set; }
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

        public static Locator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Locator() { Pointer= p0 };

            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.OverlayManager.FromPointer); // 0245A3A3E8C0 0x10 OverlayManager              ( 0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.SaveData                                  = GetObject<SaveDataContainer>(new IntPtr(p + 0x018), ReversePrism.DataModels.SaveDataContainer.FromPointer); // 0245A3A3E8E0 0x18 SaveData                    ( 0001866BE3F0 ModelClassType SaveDataContainer SaveDataContainer SaveDataContainer Pointer )
            value.PermanentData                             = GetObject<PermanentDataContainer>(new IntPtr(p + 0x020), ReversePrism.DataModels.PermanentDataContainer.FromPointer); // 0245A3A3E900 0x20 PermanentData               ( 000186735140 ModelClassType PermanentDataContainer PermanentDataContainer PermanentDataContainer Pointer )
            value.ResettableServiceContainer                = GetObject<ResettableServiceContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.ResettableServiceContainer.FromPointer); // 0245A3A3E920 0x28 ResettableServiceContainer  ( 00018666CD60 ModelClassType ResettableServiceContainer ResettableServiceContainer ResettableServiceContainer Pointer )
            value.ButtonGotoTypeProcessor                   = GetObject<IButtonGotoTypeProcessor>(new IntPtr(p + 0x030), ReversePrism.DataModels.IButtonGotoTypeProcessor.FromPointer); // 0245A3A3E940 0x30 ButtonGotoTypeProcessor     ( 000186714650 ModelClassType IButtonGotoTypeProcessor IButtonGotoTypeProcessor IButtonGotoTypeProcessor Pointer )
            value.OverlayInstantiator                       = GetObject<IOverlayInstantiator>(new IntPtr(p + 0x038), ReversePrism.DataModels.IOverlayInstantiator.FromPointer); // 0245A3A3E960 0x38 OverlayInstantiator         ( 0001865CC990 ModelClassType IOverlayInstantiator IOverlayInstantiator IOverlayInstantiator Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x040), ReversePrism.DataModels.ResourceLoader.FromPointer); // 0245A3A3E980 0x40 ResourceLoader              ( 00018666F930 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceDownloader                        = GetObject<ResourceDownloader>(new IntPtr(p + 0x048), ReversePrism.DataModels.ResourceDownloader.FromPointer); // 0245A3A3E9A0 0x48 ResourceDownloader          ( 00018666E3A0 ModelClassType ResourceDownloader ResourceDownloader ResourceDownloader Pointer )
            value.BackKeyObservable                         = GetObject<IBackKeyObservable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IBackKeyObservable.FromPointer); // 0245A3A3E9C0 0x50 BackKeyObservable           ( 00018670D5B0 ModelClassType IBackKeyObservable IBackKeyObservable IBackKeyObservable Pointer )
            value.CommonSequencerContainer                  = GetObject<ICommonSequencerContainer>(new IntPtr(p + 0x058), ReversePrism.DataModels.ICommonSequencerContainer.FromPointer); // 0245A3A3E9E0 0x58 CommonSequencerContainer    ( 0001867347C0 ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer )
            value.NotificationManager                       = GetObject<NotificationManager>(new IntPtr(p + 0x060), ReversePrism.DataModels.NotificationManager.FromPointer); // 0245A3A3EA00 0x60 NotificationManager         ( 0001866B3400 ModelClassType NotificationManager NotificationManager NotificationManager Pointer )
            value.AppReviewManager                          = GetObject<AppReviewManager>(new IntPtr(p + 0x068), ReversePrism.DataModels.AppReviewManager.FromPointer); // 0245A3A3EA20 0x68 AppReviewManager            ( 0001866C9840 ModelClassType AppReviewManager AppReviewManager AppReviewManager Pointer )
            value.ResourceLoaderFactory                     = GetObject<IResourceLoaderFactory>(new IntPtr(p + 0x070), ReversePrism.DataModels.IResourceLoaderFactory.FromPointer); // 0245A3A3EA40 0x70 ResourceLoaderFactory       ( 00018661B1C0 ModelClassType IResourceLoaderFactory IResourceLoaderFactory IResourceLoaderFactory Pointer )
            value.SystemCall                                = GetObject<ISystemCall>(new IntPtr(p + 0x078), ReversePrism.DataModels.ISystemCall.FromPointer); // 0245A3A3EA60 0x78 SystemCall                  ( 00018666C2B0 ModelClassType ISystemCall ISystemCall ISystemCall Pointer )
            value.Crashlytics                               = GetObject<ICrashlytics>(new IntPtr(p + 0x080), ReversePrism.DataModels.ICrashlytics.FromPointer); // 0245A3A3EA80 0x80 Crashlytics                 ( 000186744360 ModelClassType ICrashlytics ICrashlytics ICrashlytics Pointer )
            value.Analytics                                 = GetObject<IAnalytics>(new IntPtr(p + 0x088), ReversePrism.DataModels.IAnalytics.FromPointer); // 0245A3A3EAA0 0x88 Analytics                   ( 0001866F16F0 ModelClassType IAnalytics IAnalytics IAnalytics Pointer )
            value.LoadingPresenter                          = GetObject<ILoadingPresenter>(new IntPtr(p + 0x090), ReversePrism.DataModels.ILoadingPresenter.FromPointer); // 0245A3A3EAC0 0x90 LoadingPresenter            ( 00018659E8E0 ModelClassType ILoadingPresenter ILoadingPresenter ILoadingPresenter Pointer )
            value.ConnectingView                            = GetObject<IConnectingView>(new IntPtr(p + 0x098), ReversePrism.DataModels.IConnectingView.FromPointer); // 0245A3A3EAE0 0x98 ConnectingView              ( 000186739440 ModelClassType IConnectingView IConnectingView IConnectingView Pointer )
            value.TutorialBuilder                           = GetObject<ITutorialBuilder>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ITutorialBuilder.FromPointer); // 0245A3A3EB00 0xA0 TutorialBuilder             ( 00018667F5E0 ModelClassType ITutorialBuilder ITutorialBuilder ITutorialBuilder Pointer )

            return value;
        }
    }
}
