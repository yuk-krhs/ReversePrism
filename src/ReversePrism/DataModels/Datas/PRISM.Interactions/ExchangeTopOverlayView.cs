using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleLabelText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 CloseButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 HistoryButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 048 TabPrefab                                00018651D830 ModelClassType ExchangeTabItemView ExchangeTabItemView ExchangeTabItemView Pointer
    // 050 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 058 PurchaseProductObj                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 GoodsGridView                            000186509BA0 ModelClassType ExchangeGoodsGridView ExchangeGoodsGridView ExchangeGoodsGridView Pointer
    // 068 LargeGridView                            00018650F2C0 ModelClassType ExchangeLargeSpaceGridView ExchangeLargeSpaceGridView ExchangeLargeSpaceGridView Pointer
    // 070 EventGridView                            000186778970 ModelClassType ExchangeEventGridView ExchangeEventGridView ExchangeEventGridView Pointer
    // 078 exchangeSelectionListPopupViewFactory    PopupViewFactory`1<IExchangeSelectionListPopupView> IL2CPP_TYPE_GENERICINST
    // 080 exchangeSelectionConfirmPopupViewFactory PopupViewFactory`1<IExchangeSelectionConfirmPopupView> IL2CPP_TYPE_GENERICINST
    // 088 exchangeSelectionCompletePopupViewFactory PopupViewFactory`1<IExchangeSelectionCompletePopupView> IL2CPP_TYPE_GENERICINST
    // 090 exchangeCostumeListPopupViewFactory      PopupViewFactory`1<IExchangeCostumeListPopupView> IL2CPP_TYPE_GENERICINST
    // 098 exchangeProductDetailPopupViewFactory    PopupViewFactory`1<IExchangeProductDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 0A0 exchangeHistoryPopupViewFactory          PopupViewFactory`1<IExchangeHistoryPopupView> IL2CPP_TYPE_GENERICINST
    // 0A8 exchangeHistoryDetailPopupViewFactory    PopupViewFactory`1<IExchangeHistoryDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 0B0 exchangeEventGoodsListPopupViewFactory   PopupViewFactory`1<IExchangeEventGoodsListPopupView> IL2CPP_TYPE_GENERICINST
    // 0B8 exchangeSimpleConfirmPopupViewFactory    PopupViewFactory`1<IExchangeSimpleConfirmPopupView> IL2CPP_TYPE_GENERICINST
    // 0C0 resultPopupViewFactory                   PopupViewFactory`1<IExchangeResultPopupView> IL2CPP_TYPE_GENERICINST
    // 0C8 characterGetEffectOverlayFactory         OverlayViewFactory`1<ICharacterGetEffectOverlayView> IL2CPP_TYPE_GENERICINST
    // 0D0 ViewModel                                00018651E9F0 ModelClassType ExchangeTopViewModel ExchangeTopViewModel ExchangeTopViewModel Pointer
    // 0D8 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0E0 onExchangeCompleted                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0E8 onGoodsSelect                            Subject`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    // 0F0 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0F8 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ExchangeTopOverlayView
    {
        public UITextMeshProUGUI?                       TitleLabelText                          { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UIButton?                                CloseButton                             { get; set; }
        public UIButton?                                HistoryButton                           { get; set; }
        public ExchangeTabItemView?                     TabPrefab                               { get; set; }
        public UITabGroup?                              TabGroup                                { get; set; }
        public GameObject?                              PurchaseProductObj                      { get; set; }
        public ExchangeGoodsGridView?                   GoodsGridView                           { get; set; }
        public ExchangeLargeSpaceGridView?              LargeGridView                           { get; set; }
        public ExchangeEventGridView?                   EventGridView                           { get; set; }
        public ExchangeTopViewModel?                    ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ExchangeTopOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeTopOverlayView();

            value.TitleLabelText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8C6ED0 0x20 TitleLabelText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DB8C6EF0 0x28 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB8C6F10 0x30 CloseButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HistoryButton                             = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB8C6F30 0x38 HistoryButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TabPrefab                                 = GetObject<ExchangeTabItemView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExchangeTabItemView.FromPointer); // 0270DB8C6F70 0x48 TabPrefab                   ( 00018651D830 ModelClassType ExchangeTabItemView ExchangeTabItemView ExchangeTabItemView Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DB8C6F90 0x50 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.PurchaseProductObj                        = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8C6FB0 0x58 PurchaseProductObj          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoodsGridView                             = GetObject<ExchangeGoodsGridView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ExchangeGoodsGridView.FromPointer); // 0270DB8C6FD0 0x60 GoodsGridView               ( 000186509BA0 ModelClassType ExchangeGoodsGridView ExchangeGoodsGridView ExchangeGoodsGridView Pointer )
            value.LargeGridView                             = GetObject<ExchangeLargeSpaceGridView>(new IntPtr(p + 0x068), ReversePrism.DataModels.ExchangeLargeSpaceGridView.FromPointer); // 0270DB8C6FF0 0x68 LargeGridView               ( 00018650F2C0 ModelClassType ExchangeLargeSpaceGridView ExchangeLargeSpaceGridView ExchangeLargeSpaceGridView Pointer )
            value.EventGridView                             = GetObject<ExchangeEventGridView>(new IntPtr(p + 0x070), ReversePrism.DataModels.ExchangeEventGridView.FromPointer); // 0270DB8C7010 0x70 EventGridView               ( 000186778970 ModelClassType ExchangeEventGridView ExchangeEventGridView ExchangeEventGridView Pointer )
            value.ViewModel                                 = GetObject<ExchangeTopViewModel>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ExchangeTopViewModel.FromPointer); // 0270DB8C7190 0xD0 ViewModel                   ( 00018651E9F0 ModelClassType ExchangeTopViewModel ExchangeTopViewModel ExchangeTopViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB8C7210 0xF0 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB8C7230 0xF8 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
