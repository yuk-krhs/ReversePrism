using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LeftMenu                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 MenuPanelView                            00018667CEC0 ModelClassType GlobalMenuPanelView GlobalMenuPanelView GlobalMenuPanelView Pointer
    // 030 FooterPanelView                          00018667C9E0 ModelClassType GlobalMenuFooterPanelView GlobalMenuFooterPanelView GlobalMenuFooterPanelView Pointer
    // 038 CloseButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 profileOverlayFactory                    OverlayViewFactory`1<IProfileUserSelfOverlayView> IL2CPP_TYPE_GENERICINST
    // 050 friendOverlayFactory                     OverlayViewFactory`1<IFriendOverlayView> IL2CPP_TYPE_GENERICINST
    // 058 shopOverlayFactory                       OverlayViewFactory`1<IShopView> IL2CPP_TYPE_GENERICINST
    // 060 supportPopupFactory                      PopupViewFactory`1<ISupportPopupView> IL2CPP_TYPE_GENERICINST
    // 068 transferContactPopupFactory              PopupViewFactory`1<ITransferContactPopupView> IL2CPP_TYPE_GENERICINST
    // 070 fesDataPossessionLimitPopupFactory       PopupViewFactory`1<IFesDataPossessionLimitPopupView> IL2CPP_TYPE_GENERICINST
    // 078 produceOptionPopupViewFactory            PopupViewFactory`1<IProduceOptionPopupView> IL2CPP_TYPE_GENERICINST
    // 080 gameHelpListPopupViewFactory             PopupViewFactory`1<IGameHelpListPopupView> IL2CPP_TYPE_GENERICINST
    // 088 liveSettingPopupViewFactory              PopupViewFactory`1<ILiveSettingPopupView> IL2CPP_TYPE_GENERICINST
    // 090 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 098 TransferAccount                          0001866A2500 ModelClassType TransferAccount TransferAccount TransferAccount Pointer
    // 0A0 EventListButtonView                      00018675C2C0 ModelClassType EventListButtonView EventListButtonView EventListButtonView Pointer
    // 0A8 ViewModel                                00018667E9E0 ModelClassType GlobalMenuViewModel GlobalMenuViewModel GlobalMenuViewModel Pointer
    // 0B0 onMenuClicked                            Subject`1<MenuType> IL2CPP_TYPE_GENERICINST
    // 0B8 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0C0 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 0C8 <UseJumpObservable>k__BackingField       IObservable`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class GlobalMenuView : DataModel
    {
        public RectTransform?                           LeftMenu                                { get; set; }
        public GlobalMenuPanelView?                     MenuPanelView                           { get; set; }
        public GlobalMenuFooterPanelView?               FooterPanelView                         { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public TransferAccount?                         TransferAccount                         { get; set; }
        public EventListButtonView?                     EventListButtonView                     { get; set; }
        public GlobalMenuViewModel?                     ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static GlobalMenuView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalMenuView() { Pointer= p0 };

            value.LeftMenu                                  = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 02466BF30E20 0x20 LeftMenu                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.MenuPanelView                             = GetObject<GlobalMenuPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.GlobalMenuPanelView.FromPointer); // 02466BF30E40 0x28 MenuPanelView               ( 00018667CEC0 ModelClassType GlobalMenuPanelView GlobalMenuPanelView GlobalMenuPanelView Pointer )
            value.FooterPanelView                           = GetObject<GlobalMenuFooterPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.GlobalMenuFooterPanelView.FromPointer); // 02466BF30E60 0x30 FooterPanelView             ( 00018667C9E0 ModelClassType GlobalMenuFooterPanelView GlobalMenuFooterPanelView GlobalMenuFooterPanelView Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466BF30E80 0x38 CloseButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466BF30EA0 0x40 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TransferAccount                           = GetObject<TransferAccount>(new IntPtr(p + 0x098), ReversePrism.DataModels.TransferAccount.FromPointer); // 02466BF31000 0x98 TransferAccount             ( 0001866A2500 ModelClassType TransferAccount TransferAccount TransferAccount Pointer )
            value.EventListButtonView                       = GetObject<EventListButtonView>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.EventListButtonView.FromPointer); // 02466BF31020 0xA0 EventListButtonView         ( 00018675C2C0 ModelClassType EventListButtonView EventListButtonView EventListButtonView Pointer )
            value.ViewModel                                 = GetObject<GlobalMenuViewModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GlobalMenuViewModel.FromPointer); // 02466BF31040 0xA8 ViewModel                   ( 00018667E9E0 ModelClassType GlobalMenuViewModel GlobalMenuViewModel GlobalMenuViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IDisposable.FromPointer); // 02466BF31080 0xB8 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466BF310A0 0xC0 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
