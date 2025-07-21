using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0B0 LayoutGroup                              ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer
    // 0B8 PurchaseProductAmountPanel               ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 PurchaseProductAmountText                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 PurchaseProductIcon                      ModelClassType RewardItem RewardItem RewardItem Pointer
    // 0D0 FilterState                              ModelClassType UIButtonGroupUnit UIButtonGroupUnit UIButtonGroupUnit Pointer
    // 0D8 FilterButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 0E0 EmptyResultText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E8 Scroller                                 ModelClassType Scroller Scroller Scroller Pointer
    // 0F0 HorizontalTabGroup                       ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 0F8 ItemFilterPopupContentBase               ModelClassType ExchangeItemFilterPopupContent ExchangeItemFilterPopupContent ExchangeItemFilterPopupContent Pointer
    // 100 PieceFilterPopupContentBase              ModelClassType ExchangePieceFilterPopupContent ExchangePieceFilterPopupContent ExchangePieceFilterPopupContent Pointer
    // 108 ConfirmationPopupContentBase             ModelClassType ExchangeConfirmationPopupContent ExchangeConfirmationPopupContent ExchangeConfirmationPopupContent Pointer
    // 110 curAllItems                              IList`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    // 118 appliedFilterItems                       IList`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    // 120 curSortFilterModel                       SortFilterModel`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    // 128 ItemSortFilterModel                      ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer
    // 130 PieceSortIdolFilterModel                 ModelClassType ExchangePieceSortFilterModel ExchangePieceSortFilterModel ExchangePieceSortFilterModel Pointer
    // 138 StarFragmentFilterDataSortFilterModel    ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer
    // 140 SeasonMedalFilterDataSortFilterModel     ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer
    // 148 NoneDataSortFilterModel                  ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer
    // 150 IsSkipScrollResetOnNextUpdate            ModelPrimitiveType bool bool bool Bool
    // 158 onExchangeCompletedSubject               Subject`1<ValueTuple`2<ExchangeGoodsClientModel, IPurchaseExchangeProductReply>> IL2CPP_TYPE_GENERICINST
    // 160 onGoToOtherViewSubject                   Subject`1<ValueTuple`3<ButtonGoToType, ExchangeGoodsClientModel, IPurchaseExchangeProductReply>> IL2CPP_TYPE_GENERICINST
    // 168 onSelectGoodsSubject                     Subject`1<ExchangeGoodsClientModel> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeGoodsGridView : DataModel
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
        public ExchangeItemFilterPopupContent?          ItemFilterPopupContentBase              { get; set; }
        public ExchangePieceFilterPopupContent?         PieceFilterPopupContentBase             { get; set; }
        public ExchangeConfirmationPopupContent?        ConfirmationPopupContentBase            { get; set; }
        public ExchangeItemSortFilterModel?             ItemSortFilterModel                     { get; set; }
        public ExchangePieceSortFilterModel?            PieceSortIdolFilterModel                { get; set; }
        public ExchangeItemSortFilterModel?             StarFragmentFilterDataSortFilterModel   { get; set; }
        public ExchangeItemSortFilterModel?             SeasonMedalFilterDataSortFilterModel    { get; set; }
        public ExchangeItemSortFilterModel?             NoneDataSortFilterModel                 { get; set; }
        public bool                                     IsSkipScrollResetOnNextUpdate           { get; set; }

        public static ExchangeGoodsGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeGoodsGridView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xA8 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.LayoutGroup                               = GetObject<LayoutGroup>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LayoutGroup.FromPointer); // 0xB0 LayoutGroup                 ( ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer )
            value.PurchaseProductAmountPanel                = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0xB8 PurchaseProductAmountPanel  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseProductAmountText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC0 PurchaseProductAmountText   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.RewardItem.FromPointer); // 0xC8 PurchaseProductIcon         ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.FilterState                               = GetObject<UIButtonGroupUnit>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UIButtonGroupUnit.FromPointer); // 0xD0 FilterState                 ( ModelClassType UIButtonGroupUnit UIButtonGroupUnit UIButtonGroupUnit Pointer )
            value.FilterButton                              = GetObject<UIButton>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UIButton.FromPointer); // 0xD8 FilterButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.EmptyResultText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xE0 EmptyResultText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Scroller                                  = GetObject<Scroller>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Scroller.FromPointer); // 0xE8 Scroller                    ( ModelClassType Scroller Scroller Scroller Pointer )
            value.HorizontalTabGroup                        = GetObject<UITabGroupEx>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0xF0 HorizontalTabGroup          ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.ItemFilterPopupContentBase                = GetObject<ExchangeItemFilterPopupContent>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ExchangeItemFilterPopupContent.FromPointer); // 0xF8 ItemFilterPopupContentBase  ( ModelClassType ExchangeItemFilterPopupContent ExchangeItemFilterPopupContent ExchangeItemFilterPopupContent Pointer )
            value.PieceFilterPopupContentBase               = GetObject<ExchangePieceFilterPopupContent>(new IntPtr(p + 0x100), ReversePrism.DataModels.ExchangePieceFilterPopupContent.FromPointer); // 0x100 PieceFilterPopupContentBase ( ModelClassType ExchangePieceFilterPopupContent ExchangePieceFilterPopupContent ExchangePieceFilterPopupContent Pointer )
            value.ConfirmationPopupContentBase              = GetObject<ExchangeConfirmationPopupContent>(new IntPtr(p + 0x108), ReversePrism.DataModels.ExchangeConfirmationPopupContent.FromPointer); // 0x108 ConfirmationPopupContentBase ( ModelClassType ExchangeConfirmationPopupContent ExchangeConfirmationPopupContent ExchangeConfirmationPopupContent Pointer )
            value.ItemSortFilterModel                       = GetObject<ExchangeItemSortFilterModel>(new IntPtr(p + 0x128), ReversePrism.DataModels.ExchangeItemSortFilterModel.FromPointer); // 0x128 ItemSortFilterModel         ( ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer )
            value.PieceSortIdolFilterModel                  = GetObject<ExchangePieceSortFilterModel>(new IntPtr(p + 0x130), ReversePrism.DataModels.ExchangePieceSortFilterModel.FromPointer); // 0x130 PieceSortIdolFilterModel    ( ModelClassType ExchangePieceSortFilterModel ExchangePieceSortFilterModel ExchangePieceSortFilterModel Pointer )
            value.StarFragmentFilterDataSortFilterModel     = GetObject<ExchangeItemSortFilterModel>(new IntPtr(p + 0x138), ReversePrism.DataModels.ExchangeItemSortFilterModel.FromPointer); // 0x138 StarFragmentFilterDataSortFilterModel ( ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer )
            value.SeasonMedalFilterDataSortFilterModel      = GetObject<ExchangeItemSortFilterModel>(new IntPtr(p + 0x140), ReversePrism.DataModels.ExchangeItemSortFilterModel.FromPointer); // 0x140 SeasonMedalFilterDataSortFilterModel ( ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer )
            value.NoneDataSortFilterModel                   = GetObject<ExchangeItemSortFilterModel>(new IntPtr(p + 0x148), ReversePrism.DataModels.ExchangeItemSortFilterModel.FromPointer); // 0x148 NoneDataSortFilterModel     ( ModelClassType ExchangeItemSortFilterModel ExchangeItemSortFilterModel ExchangeItemSortFilterModel Pointer )
            value.IsSkipScrollResetOnNextUpdate             = GetBool(new IntPtr(p + 0x150)); // 0x150 IsSkipScrollResetOnNextUpdate ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
