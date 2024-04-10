using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MainBannerView                           0001866BB5A0 ModelClassType HomeBannerView HomeBannerView HomeBannerView Pointer
    // 028 SeasonMissionBannerView                  0001866CA390 ModelClassType HomeSeasonMissionBannerView HomeSeasonMissionBannerView HomeSeasonMissionBannerView Pointer
    // 030 SpecialMissionBannerView                 0001866D1BA0 ModelClassType HomeSpecialMissionBannerView HomeSpecialMissionBannerView HomeSpecialMissionBannerView Pointer
    // 038 OurStreamBannerView                      0001866C6F30 ModelClassType HomeOurStreamBannerView HomeOurStreamBannerView HomeOurStreamBannerView Pointer
    // 040 HeaderView                               0001866C0E80 ModelClassType HomeHeaderPanelView HomeHeaderPanelView HomeHeaderPanelView Pointer
    // 048 MainFooterView                           0001866C0960 ModelClassType HomeFooterPanelView HomeFooterPanelView HomeFooterPanelView Pointer
    // 050 DmButton                                 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 HideUIButton                             000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 HideAreaObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 SettingsButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 SeasonMissionButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 CharacterButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 080 GlobalButton                             000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 088 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 090 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 098 HomeSettingsPopupFactory                 0001866CFE90 ModelClassType HomeSettingsPopupViewFactory HomeSettingsPopupViewFactory HomeSettingsPopupViewFactory Pointer
    // 0A0 IdolSelectPopupFactory                   0001866CE8C0 ModelClassType HomeSettingsIdolSelectPopupViewFactory HomeSettingsIdolSelectPopupViewFactory HomeSettingsIdolSelectPopupViewFactory Pointer
    // 0A8 RemindItemPopupFactory                   0001866C9500 ModelClassType HomeRemindItemPopupViewFactory HomeRemindItemPopupViewFactory HomeRemindItemPopupViewFactory Pointer
    // 0B0 gashaExchangeExpiryDateInfoPopupViewFactory PopupViewFactory`1<IGashaExchangeExpiryDateInfoPopupView> IL2CPP_TYPE_GENERICINST
    // 0B8 mobileOverlayFactory                     OverlayViewFactory`1<IMobileOverlayView> IL2CPP_TYPE_GENERICINST
    // 0C0 seasonMissionOverlayFactory              OverlayViewFactory`1<ISeasonMissionView> IL2CPP_TYPE_GENERICINST
    // 0C8 shopOverlayViewFactory                   OverlayViewFactory`1<IShopView> IL2CPP_TYPE_GENERICINST
    // 0D0 shopLoginBonusPassRewardPopupViewFactory PopupViewFactory`1<IShopLoginBonusPassRewardPopupView> IL2CPP_TYPE_GENERICINST
    // 0D8 presentBoxPopupViewFactory               PopupViewFactory`1<IPresentBoxPopupView> IL2CPP_TYPE_GENERICINST
    // 0E0 specialMissionPopupViewFactory           PopupViewFactory`1<ISpecialMissionPopupView> IL2CPP_TYPE_GENERICINST
    // 0E8 fesDataPossessionLimitPopupViewFactory   PopupViewFactory`1<IFesDataPossessionLimitPopupView> IL2CPP_TYPE_GENERICINST
    // 0F0 exchangeOverlayFactory                   OverlayViewFactory`1<IExchangeTopOverlayView> IL2CPP_TYPE_GENERICINST
    // 0F8 ViewModel                                0001866D38A0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer
    // 100 SubFooterPanelView                       0001866D2570 ModelClassType HomeSubFooterPanelView HomeSubFooterPanelView HomeSubFooterPanelView Pointer
    // 108 DmViewDisposable                         0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 110 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
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
        public HomeSettingsPopupViewFactory?            HomeSettingsPopupFactory                { get; set; }
        public HomeSettingsIdolSelectPopupViewFactory?  IdolSelectPopupFactory                  { get; set; }
        public HomeRemindItemPopupViewFactory?          RemindItemPopupFactory                  { get; set; }
        public HomeViewModel?                           ViewModel                               { get; set; }
        public HomeSubFooterPanelView?                  SubFooterPanelView                      { get; set; }
        public IDisposable?                             DmViewDisposable                        { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static HomeMainView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeMainView() { Pointer= p0 };

            value.MainBannerView                            = GetObject<HomeBannerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeBannerView.FromPointer); // 0245A4FA4E38 0x20 MainBannerView              ( 0001866BB5A0 ModelClassType HomeBannerView HomeBannerView HomeBannerView Pointer )
            value.SeasonMissionBannerView                   = GetObject<HomeSeasonMissionBannerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeSeasonMissionBannerView.FromPointer); // 0245A4FA4E58 0x28 SeasonMissionBannerView     ( 0001866CA390 ModelClassType HomeSeasonMissionBannerView HomeSeasonMissionBannerView HomeSeasonMissionBannerView Pointer )
            value.SpecialMissionBannerView                  = GetObject<HomeSpecialMissionBannerView>(new IntPtr(p + 0x030), ReversePrism.DataModels.HomeSpecialMissionBannerView.FromPointer); // 0245A4FA4E78 0x30 SpecialMissionBannerView    ( 0001866D1BA0 ModelClassType HomeSpecialMissionBannerView HomeSpecialMissionBannerView HomeSpecialMissionBannerView Pointer )
            value.OurStreamBannerView                       = GetObject<HomeOurStreamBannerView>(new IntPtr(p + 0x038), ReversePrism.DataModels.HomeOurStreamBannerView.FromPointer); // 0245A4FA4E98 0x38 OurStreamBannerView         ( 0001866C6F30 ModelClassType HomeOurStreamBannerView HomeOurStreamBannerView HomeOurStreamBannerView Pointer )
            value.HeaderView                                = GetObject<HomeHeaderPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeHeaderPanelView.FromPointer); // 0245A4FA4EB8 0x40 HeaderView                  ( 0001866C0E80 ModelClassType HomeHeaderPanelView HomeHeaderPanelView HomeHeaderPanelView Pointer )
            value.MainFooterView                            = GetObject<HomeFooterPanelView>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeFooterPanelView.FromPointer); // 0245A4FA4ED8 0x48 MainFooterView              ( 0001866C0960 ModelClassType HomeFooterPanelView HomeFooterPanelView HomeFooterPanelView Pointer )
            value.DmButton                                  = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0245A4FA4EF8 0x50 DmButton                    ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HideUIButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0245A4FA4F18 0x58 HideUIButton                ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.HideAreaObject                            = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0245A4FA4F38 0x60 HideAreaObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SettingsButton                            = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0245A4FA4F58 0x68 SettingsButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SeasonMissionButton                       = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0245A4FA4F78 0x70 SeasonMissionButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CharacterButton                           = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0245A4FA4F98 0x78 CharacterButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GlobalButton                              = GetObject<ButtonBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.ButtonBase.FromPointer); // 0245A4FA4FB8 0x80 GlobalButton                ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0245A4FA4FD8 0x88 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.HomeSettingsPopupFactory                  = GetObject<HomeSettingsPopupViewFactory>(new IntPtr(p + 0x098), ReversePrism.DataModels.HomeSettingsPopupViewFactory.FromPointer); // 0245A4FA5018 0x98 HomeSettingsPopupFactory    ( 0001866CFE90 ModelClassType HomeSettingsPopupViewFactory HomeSettingsPopupViewFactory HomeSettingsPopupViewFactory Pointer )
            value.IdolSelectPopupFactory                    = GetObject<HomeSettingsIdolSelectPopupViewFactory>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.HomeSettingsIdolSelectPopupViewFactory.FromPointer); // 0245A4FA5038 0xA0 IdolSelectPopupFactory      ( 0001866CE8C0 ModelClassType HomeSettingsIdolSelectPopupViewFactory HomeSettingsIdolSelectPopupViewFactory HomeSettingsIdolSelectPopupViewFactory Pointer )
            value.RemindItemPopupFactory                    = GetObject<HomeRemindItemPopupViewFactory>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.HomeRemindItemPopupViewFactory.FromPointer); // 0245A4FA5058 0xA8 RemindItemPopupFactory      ( 0001866C9500 ModelClassType HomeRemindItemPopupViewFactory HomeRemindItemPopupViewFactory HomeRemindItemPopupViewFactory Pointer )
            value.ViewModel                                 = GetObject<HomeViewModel>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.HomeViewModel.FromPointer); // 0245A4FA5198 0xF8 ViewModel                   ( 0001866D38A0 ModelClassType HomeViewModel HomeViewModel HomeViewModel Pointer )
            value.SubFooterPanelView                        = GetObject<HomeSubFooterPanelView>(new IntPtr(p + 0x100), ReversePrism.DataModels.HomeSubFooterPanelView.FromPointer); // 0245A4FA51B8 0x100 SubFooterPanelView          ( 0001866D2570 ModelClassType HomeSubFooterPanelView HomeSubFooterPanelView HomeSubFooterPanelView Pointer )
            value.DmViewDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x108), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A4FA51D8 0x108 DmViewDisposable            ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x110), ReversePrism.DataModels.IResourceTag.FromPointer); // 0245A4FA51F8 0x110 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
