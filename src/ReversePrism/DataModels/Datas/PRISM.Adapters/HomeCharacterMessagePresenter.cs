using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer
    // 018 HomeView                                 ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer
    // 020 BannerView                               ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer
    // 028 MessageViewModel                         ModelClassType HomeCharacterMessageViewModel HomeCharacterMessageViewModel HomeCharacterMessageViewModel Pointer
    // 030 MobileNotificationPresenter              ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer
    // 038 CharaMessageShowDisposable               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 040 CharaMessageCloseDisposable              ModelClassType IDisposable IDisposable IDisposable Pointer
    // 048 VoicePlayEndDisposable                   ModelClassType IDisposable IDisposable IDisposable Pointer
    // 050 LeaveCharaMessageShowDisposable          ModelClassType IDisposable IDisposable IDisposable Pointer
    // 058 CharaTouchDisposable                     ModelClassType IDisposable IDisposable IDisposable Pointer
    // 060 MobileVisible                            ModelPrimitiveType bool bool bool Bool
    // 061 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 062 IsFirstMessage                           ModelPrimitiveType bool bool bool Bool
    // 068 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 070 Home3dSceneView                          ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer
    // 078 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 080 UnitIdols                                ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    public partial class HomeCharacterMessagePresenter : DataModel
    {
        public IHomeCharacterMessagePanelView?          View                                    { get; set; }
        public IHomeMainView?                           HomeView                                { get; set; }
        public IHomeBannerView?                         BannerView                              { get; set; }
        public HomeCharacterMessageViewModel?           MessageViewModel                        { get; set; }
        public MobileNotificationPresenter?             MobileNotificationPresenter             { get; set; }
        public IDisposable?                             CharaMessageShowDisposable              { get; set; }
        public IDisposable?                             CharaMessageCloseDisposable             { get; set; }
        public IDisposable?                             VoicePlayEndDisposable                  { get; set; }
        public IDisposable?                             LeaveCharaMessageShowDisposable         { get; set; }
        public IDisposable?                             CharaTouchDisposable                    { get; set; }
        public bool                                     MobileVisible                           { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public bool                                     IsFirstMessage                          { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }
        public IHome3DSceneView?                        Home3dSceneView                         { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }

        public static HomeCharacterMessagePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeCharacterMessagePresenter() { Pointer= p0 };

            value.View                                      = GetObject<IHomeCharacterMessagePanelView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHomeCharacterMessagePanelView.FromPointer); // 0x10 View                        ( ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer )
            value.HomeView                                  = GetObject<IHomeMainView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHomeMainView.FromPointer); // 0x18 HomeView                    ( ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer )
            value.BannerView                                = GetObject<IHomeBannerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHomeBannerView.FromPointer); // 0x20 BannerView                  ( ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer )
            value.MessageViewModel                          = GetObject<HomeCharacterMessageViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeCharacterMessageViewModel.FromPointer); // 0x28 MessageViewModel            ( ModelClassType HomeCharacterMessageViewModel HomeCharacterMessageViewModel HomeCharacterMessageViewModel Pointer )
            value.MobileNotificationPresenter               = GetObject<MobileNotificationPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileNotificationPresenter.FromPointer); // 0x30 MobileNotificationPresenter ( ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer )
            value.CharaMessageShowDisposable                = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 0x38 CharaMessageShowDisposable  ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.CharaMessageCloseDisposable               = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 0x40 CharaMessageCloseDisposable ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.VoicePlayEndDisposable                    = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0x48 VoicePlayEndDisposable      ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.LeaveCharaMessageShowDisposable           = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0x50 LeaveCharaMessageShowDisposable ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.CharaTouchDisposable                      = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 CharaTouchDisposable        ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.MobileVisible                             = GetBool(new IntPtr(p + 0x060)); // 0x60 MobileVisible               ( ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x061)); // 0x61 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.IsFirstMessage                            = GetBool(new IntPtr(p + 0x062)); // 0x62 IsFirstMessage              ( ModelPrimitiveType bool bool bool Bool )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x68 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.Home3dSceneView                           = GetObject<IHome3DSceneView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IHome3DSceneView.FromPointer); // 0x70 Home3dSceneView             ( ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x78 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x080), ReversePrism.DataModels.UnitIdol.FromPointer); // 0x80 UnitIdols                   ( ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
