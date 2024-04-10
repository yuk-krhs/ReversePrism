using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186567B00 ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer
    // 018 HomeView                                 000186569B50 ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer
    // 020 BannerView                               000186567380 ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer
    // 028 MessageViewModel                         0001866BE2A0 ModelClassType HomeCharacterMessageViewModel HomeCharacterMessageViewModel HomeCharacterMessageViewModel Pointer
    // 030 MobileNotificationPresenter              000186630850 ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer
    // 038 CharaMessageShowDisposable               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 040 CharaMessageCloseDisposable              0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 048 VoicePlayEndDisposable                   0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 050 LeaveCharaMessageShowDisposable          0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 058 CharaTouchDisposable                     0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 060 MobileVisible                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 062 IsFirstMessage                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    // 070 Home3dSceneView                          000186566BC0 ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer
    // 078 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 080 UnitIdols                                000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
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

            value.View                                      = GetObject<IHomeCharacterMessagePanelView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHomeCharacterMessagePanelView.FromPointer); // 0245A708AA10 0x10 View                        ( 000186567B00 ModelClassType IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView IHomeCharacterMessagePanelView Pointer )
            value.HomeView                                  = GetObject<IHomeMainView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHomeMainView.FromPointer); // 0245A708AA30 0x18 HomeView                    ( 000186569B50 ModelClassType IHomeMainView IHomeMainView IHomeMainView Pointer )
            value.BannerView                                = GetObject<IHomeBannerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHomeBannerView.FromPointer); // 0245A708AA50 0x20 BannerView                  ( 000186567380 ModelClassType IHomeBannerView IHomeBannerView IHomeBannerView Pointer )
            value.MessageViewModel                          = GetObject<HomeCharacterMessageViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeCharacterMessageViewModel.FromPointer); // 0245A708AA70 0x28 MessageViewModel            ( 0001866BE2A0 ModelClassType HomeCharacterMessageViewModel HomeCharacterMessageViewModel HomeCharacterMessageViewModel Pointer )
            value.MobileNotificationPresenter               = GetObject<MobileNotificationPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileNotificationPresenter.FromPointer); // 0245A708AA90 0x30 MobileNotificationPresenter ( 000186630850 ModelClassType MobileNotificationPresenter MobileNotificationPresenter MobileNotificationPresenter Pointer )
            value.CharaMessageShowDisposable                = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A708AAB0 0x38 CharaMessageShowDisposable  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.CharaMessageCloseDisposable               = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A708AAD0 0x40 CharaMessageCloseDisposable ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.VoicePlayEndDisposable                    = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A708AAF0 0x48 VoicePlayEndDisposable      ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.LeaveCharaMessageShowDisposable           = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A708AB10 0x50 LeaveCharaMessageShowDisposable ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.CharaTouchDisposable                      = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A708AB30 0x58 CharaTouchDisposable        ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.MobileVisible                             = GetBool(new IntPtr(p + 0x060)); // 0245A708AB50 0x60 MobileVisible               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x061)); // 0245A708AB70 0x61 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFirstMessage                            = GetBool(new IntPtr(p + 0x062)); // 0245A708AB90 0x62 IsFirstMessage              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0245A708ABB0 0x68 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )
            value.Home3dSceneView                           = GetObject<IHome3DSceneView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IHome3DSceneView.FromPointer); // 0245A708ABD0 0x70 Home3dSceneView             ( 000186566BC0 ModelClassType IHome3DSceneView IHome3DSceneView IHome3DSceneView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0245A708ABF0 0x78 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x080), ReversePrism.DataModels.UnitIdol.FromPointer); // 0245A708AC10 0x80 UnitIdols                   ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )

            return value;
        }
    }
}
