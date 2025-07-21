using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleLabelText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 CloseButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 038 HistoryButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 040 TabPrefab                                ModelClassType ExchangeTabItemView ExchangeTabItemView ExchangeTabItemView Pointer
    // 048 TabGroup                                 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 050 PurchaseProductObj                       ModelClassType GameObject GameObject GameObject Pointer
    // 058 GoodsGridView                            ModelClassType ExchangeGoodsGridView ExchangeGoodsGridView ExchangeGoodsGridView Pointer
    // 060 LargeGridView                            ModelClassType ExchangeLargeSpaceGridView ExchangeLargeSpaceGridView ExchangeLargeSpaceGridView Pointer
    // 068 EventGridView                            ModelClassType ExchangeEventGridView ExchangeEventGridView ExchangeEventGridView Pointer
    // 070 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 078 ViewModel                                ModelClassType ExchangeTopViewModel ExchangeTopViewModel ExchangeTopViewModel Pointer
    // 080 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 onExchangeCompleted                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 onGoodsSelect                            Subject`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    // 098 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ExchangeTopOverlayView : DataModel
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
        public ScrollRect?                              ScrollRect                              { get; set; }
        public ExchangeTopViewModel?                    ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static ExchangeTopOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeTopOverlayView() { Pointer= p0 };

            value.TitleLabelText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TitleLabelText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 CloseButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HistoryButton                             = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 HistoryButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TabPrefab                                 = GetObject<ExchangeTabItemView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExchangeTabItemView.FromPointer); // 0x40 TabPrefab                   ( ModelClassType ExchangeTabItemView ExchangeTabItemView ExchangeTabItemView Pointer )
            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x48 TabGroup                    ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.PurchaseProductObj                        = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 PurchaseProductObj          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoodsGridView                             = GetObject<ExchangeGoodsGridView>(new IntPtr(p + 0x058), ReversePrism.DataModels.ExchangeGoodsGridView.FromPointer); // 0x58 GoodsGridView               ( ModelClassType ExchangeGoodsGridView ExchangeGoodsGridView ExchangeGoodsGridView Pointer )
            value.LargeGridView                             = GetObject<ExchangeLargeSpaceGridView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ExchangeLargeSpaceGridView.FromPointer); // 0x60 LargeGridView               ( ModelClassType ExchangeLargeSpaceGridView ExchangeLargeSpaceGridView ExchangeLargeSpaceGridView Pointer )
            value.EventGridView                             = GetObject<ExchangeEventGridView>(new IntPtr(p + 0x068), ReversePrism.DataModels.ExchangeEventGridView.FromPointer); // 0x68 EventGridView               ( ModelClassType ExchangeEventGridView ExchangeEventGridView ExchangeEventGridView Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x70 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ViewModel                                 = GetObject<ExchangeTopViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.ExchangeTopViewModel.FromPointer); // 0x78 ViewModel                   ( ModelClassType ExchangeTopViewModel ExchangeTopViewModel ExchangeTopViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x098), ReversePrism.DataModels.IDisposable.FromPointer); // 0x98 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
