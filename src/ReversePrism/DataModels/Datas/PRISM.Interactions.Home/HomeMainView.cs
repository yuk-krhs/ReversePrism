using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MainBannerView                           ModelClassType HomeBannerView HomeBannerView HomeBannerView Pointer
    // 028 SeasonMissionBannerView                  ModelClassType HomeSeasonMissionBannerView HomeSeasonMissionBannerView HomeSeasonMissionBannerView Pointer
    // 030 SpecialMissionBannerView                 ModelClassType HomeSpecialMissionBannerView HomeSpecialMissionBannerView HomeSpecialMissionBannerView Pointer
    // 038 OurStreamBannerView                      ModelClassType HomeOurStreamBannerView HomeOurStreamBannerView HomeOurStreamBannerView Pointer
    // 040 HeaderView                               ModelClassType HomeHeaderPanelView HomeHeaderPanelView HomeHeaderPanelView Pointer
    // 048 MainFooterView                           ModelClassType HomeFooterPanelView HomeFooterPanelView HomeFooterPanelView Pointer
    // 050 DmButton                                 ModelClassType UIButton UIButton UIButton Pointer
    // 058 HideUIButton                             ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 HideAreaObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 068 SettingsButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 070 SeasonMissionButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 078 CharacterButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 080 GlobalButton                             ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 088 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 090 ProduceResumeConfirmPopupPrefab          ModelClassType ProduceResumeConfirmPopupContent ProduceResumeConfirmPopupContent ProduceResumeConfirmPopupContent Pointer
    // 098 ViewModel                                ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 0A0 SubFooterPanelView                       ModelClassType HomeSubFooterPanelView HomeSubFooterPanelView HomeSubFooterPanelView Pointer
    // 0A8 DmViewDisposable                         ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class HomeMainView : DataModel
    {
        public HomeBannerView?                          MainBannerView                          { get; set; }
        public HomeSeasonMissionBannerView?             SeasonMissionBannerView                 { get; set; }
        public HomeSpecialMissionBannerView?            SpecialMissionBannerView                { get; set; }
        public HomeOurStreamBannerView?                 OurStreamBannerView                     { get; set; }
        public HomeHeaderPanelView?                     HeaderView                              { get; set; }
        public HomeFooterPanelView?                     MainFooterView                          { get; set; }
        public UIButton?                                DmButton                                { get; set; }
        public ButtonBase?                              HideUIButton                            { get; set; }
        public GameObject?                              HideAreaObject                          { get; set; }
        public UIButton?                                SettingsButton                          { get; set; }
        public UIButton?                                SeasonMissionButton                     { get; set; }
        public UIButton?                                CharacterButton                         { get; set; }
        public ButtonBase?                              GlobalButton                            { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ProduceResumeConfirmPopupContent?        ProduceResumeConfirmPopupPrefab         { get; set; }
        public HomeViewModel?                           ViewModel                               { get; set; }
        public HomeSubFooterPanelView?                  SubFooterPanelView                      { get; set; }
        public IDisposable?                             DmViewDisposable                        { get; set; }

        public static HomeMainView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeMainView() { Pointer= p0 };

            value.MainBannerView                            = GetObject<HomeBannerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeBannerView.FromPointer); // 0x20 MainBannerView              ( ModelClassType HomeBannerView HomeBannerView HomeBannerView Pointer )
            value.SeasonMissionBannerView                   = GetObject<HomeSeasonMissionBannerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeSeasonMissionBannerView.FromPointer); // 0x28 SeasonMissionBannerView     ( ModelClassType HomeSeasonMissionBannerView HomeSeasonMissionBannerView HomeSeasonMissionBannerView Pointer )
            value.SpecialMissionBannerView                  = GetObject<HomeSpecialMissionBannerView>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeSpecialMissionBannerView.FromPointer); // 0x30 SpecialMissionBannerView    ( ModelClassType HomeSpecialMissionBannerView HomeSpecialMissionBannerView HomeSpecialMissionBannerView Pointer )
            value.OurStreamBannerView                       = GetObject<HomeOurStreamBannerView>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeOurStreamBannerView.FromPointer); // 0x38 OurStreamBannerView         ( ModelClassType HomeOurStreamBannerView HomeOurStreamBannerView HomeOurStreamBannerView Pointer )
            value.HeaderView                                = GetObject<HomeHeaderPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeHeaderPanelView.FromPointer); // 0x40 HeaderView                  ( ModelClassType HomeHeaderPanelView HomeHeaderPanelView HomeHeaderPanelView Pointer )
            value.MainFooterView                            = GetObject<HomeFooterPanelView>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeFooterPanelView.FromPointer); // 0x48 MainFooterView              ( ModelClassType HomeFooterPanelView HomeFooterPanelView HomeFooterPanelView Pointer )
            value.DmButton                                  = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 DmButton                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HideUIButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x58 HideUIButton                ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.HideAreaObject                            = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 HideAreaObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SettingsButton                            = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 SettingsButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SeasonMissionButton                       = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 SeasonMissionButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CharacterButton                           = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 CharacterButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GlobalButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x80 GlobalButton                ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x88 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ProduceResumeConfirmPopupPrefab           = GetObject<ProduceResumeConfirmPopupContent>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceResumeConfirmPopupContent.FromPointer); // 0x90 ProduceResumeConfirmPopupPrefab ( ModelClassType ProduceResumeConfirmPopupContent ProduceResumeConfirmPopupContent ProduceResumeConfirmPopupContent Pointer )
            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0x98 ViewModel                   ( ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.SubFooterPanelView                        = GetObject<HomeSubFooterPanelView>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.HomeSubFooterPanelView.FromPointer); // 0xA0 SubFooterPanelView          ( ModelClassType HomeSubFooterPanelView HomeSubFooterPanelView HomeSubFooterPanelView Pointer )
            value.DmViewDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IDisposable.FromPointer); // 0xA8 DmViewDisposable            ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
