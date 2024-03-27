using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0B0 LayoutGroup                              00018650CD20 ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer
    // 0B8 PurchaseProductAmountPanel               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 PurchaseProductAmountText                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 PurchaseProductIcon                      00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 0D0 FilterState                              0001866E1930 ModelClassType UIButtonGroupUnit UIButtonGroupUnit UIButtonGroupUnit Pointer
    // 0D8 FilterButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0E0 EmptyResultText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E8 Scroller                                 0001866FAE60 ModelClassType Scroller Scroller Scroller Pointer
    // 0F0 HorizontalTabGroup                       0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 0F8 curAllItems                              IList`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    // 100 appliedFilterItems                       IList`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    // 108 curSortFilterModel                       SortFilterModel`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    // 110 ItemSortFilterModel                      00018650DAF0 ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer
    // 118 PieceSortIdolFilterModel                 000186510C10 ModelClassType ExchangePieceSortFilterModel ExchangePieceSortFilterModel ExchangePieceSortFilterModel Pointer
    // 120 StarFragmentFilterDataSortFilterModel    00018650DAF0 ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer
    // 128 SeasonMedalFilterDataSortFilterModel     00018650DAF0 ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer
    // 130 NoneDataSortFilterModel                  00018650DAF0 ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer
    // 138 ItemFilterPopupContentBase               000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 140 PieceFilterPopupContentBase              000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 148 ConfirmationPopupContentBase             000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 150 onExchangeCompletedSubject               Subject`1<ValueTuple`2<ExchangeGoodsClientModel, IPurchaseExchangeProductReply>> IL2CPP_TYPE_GENERICINST
    // 158 onGoToOtherViewSubject                   Subject`1<ValueTuple`3<ButtonGoToType, ExchangeGoodsClientModel, IPurchaseExchangeProductReply>> IL2CPP_TYPE_GENERICINST
    // 160 onSelectGoodsSubject                     Subject`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeGoodsGridView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public LayoutGroup?                             LayoutGroup                             { get; set; }
        public GameObject?                              PurchaseProductAmountPanel              { get; set; }
        public UITextMeshProUGUI?                       PurchaseProductAmountText               { get; set; }
        public RewardItem?                              PurchaseProductIcon                     { get; set; }
        public UIButtonGroupUnit?                       FilterState                             { get; set; }
        public UIButton?                                FilterButton                            { get; set; }
        public UITextMeshProUGUI?                       EmptyResultText                         { get; set; }
        public Scroller?                                Scroller                                { get; set; }
        public UITabGroupEx?                            HorizontalTabGroup                      { get; set; }
        public ExchangeItemSortFilterModel?             ItemSortFilterModel                     { get; set; }
        public ExchangePieceSortFilterModel?            PieceSortIdolFilterModel                { get; set; }
        public ExchangeItemSortFilterModel?             StarFragmentFilterDataSortFilterModel   { get; set; }
        public ExchangeItemSortFilterModel?             SeasonMedalFilterDataSortFilterModel    { get; set; }
        public ExchangeItemSortFilterModel?             NoneDataSortFilterModel                 { get; set; }
        public PopupContentBase?                        ItemFilterPopupContentBase              { get; set; }
        public PopupContentBase?                        PieceFilterPopupContentBase             { get; set; }
        public PopupContentBase?                        ConfirmationPopupContentBase            { get; set; }

        public static ExchangeGoodsGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeGoodsGridView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D54CDCF0 0xA8 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.LayoutGroup                               = GetObject<LayoutGroup>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LayoutGroup.FromPointer); // 0270D54CDD10 0xB0 LayoutGroup                 ( 00018650CD20 ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer )
            value.PurchaseProductAmountPanel                = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0270D54CDD30 0xB8 PurchaseProductAmountPanel  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseProductAmountText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D54CDD50 0xC0 PurchaseProductAmountText   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.RewardItem.FromPointer); // 0270D54CDD70 0xC8 PurchaseProductIcon         ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.FilterState                               = GetObject<UIButtonGroupUnit>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UIButtonGroupUnit.FromPointer); // 0270D54CDD90 0xD0 FilterState                 ( 0001866E1930 ModelClassType UIButtonGroupUnit UIButtonGroupUnit UIButtonGroupUnit Pointer )
            value.FilterButton                              = GetObject<UIButton>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIButton.FromPointer); // 0270D54CDDB0 0xD8 FilterButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.EmptyResultText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D54CDDD0 0xE0 EmptyResultText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Scroller                                  = GetObject<Scroller>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Scroller.FromPointer); // 0270D54CDDF0 0xE8 Scroller                    ( 0001866FAE60 ModelClassType Scroller Scroller Scroller Pointer )
            value.HorizontalTabGroup                        = GetObject<UITabGroupEx>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0270D54CDE10 0xF0 HorizontalTabGroup          ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.ItemSortFilterModel                       = GetObject<ExchangeItemSortFilterModel>(new IntPtr(p + 0x110), ReversePrism.DataModels.ExchangeItemSortFilterModel.FromPointer); // 0270D54CDE90 0x110 ItemSortFilterModel         ( 00018650DAF0 ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer )
            value.PieceSortIdolFilterModel                  = GetObject<ExchangePieceSortFilterModel>(new IntPtr(p + 0x118), ReversePrism.DataModels.ExchangePieceSortFilterModel.FromPointer); // 0270D54CDEB0 0x118 PieceSortIdolFilterModel    ( 000186510C10 ModelClassType ExchangePieceSortFilterModel ExchangePieceSortFilterModel ExchangePieceSortFilterModel Pointer )
            value.StarFragmentFilterDataSortFilterModel     = GetObject<ExchangeItemSortFilterModel>(new IntPtr(p + 0x120), ReversePrism.DataModels.ExchangeItemSortFilterModel.FromPointer); // 0270D54CDED0 0x120 StarFragmentFilterDataSortFilterModel ( 00018650DAF0 ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer )
            value.SeasonMedalFilterDataSortFilterModel      = GetObject<ExchangeItemSortFilterModel>(new IntPtr(p + 0x128), ReversePrism.DataModels.ExchangeItemSortFilterModel.FromPointer); // 0270D54CDEF0 0x128 SeasonMedalFilterDataSortFilterModel ( 00018650DAF0 ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer )
            value.NoneDataSortFilterModel                   = GetObject<ExchangeItemSortFilterModel>(new IntPtr(p + 0x130), ReversePrism.DataModels.ExchangeItemSortFilterModel.FromPointer); // 0270D54CDF10 0x130 NoneDataSortFilterModel     ( 00018650DAF0 ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer )
            value.ItemFilterPopupContentBase                = GetObject<PopupContentBase>(new IntPtr(p + 0x138), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270D54CDF30 0x138 ItemFilterPopupContentBase  ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.PieceFilterPopupContentBase               = GetObject<PopupContentBase>(new IntPtr(p + 0x140), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270D54CDF50 0x140 PieceFilterPopupContentBase ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.ConfirmationPopupContentBase              = GetObject<PopupContentBase>(new IntPtr(p + 0x148), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270D54CDF70 0x148 ConfirmationPopupContentBase ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )

            return value;
        }
    }
}
