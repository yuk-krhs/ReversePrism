using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ProductData                              ModelClassType ExchangeProductViewModel ExchangeProductViewModel ExchangeProductViewModel Pointer
    // 048 NewBtgObj                                ModelClassType GameObject GameObject GameObject Pointer
    // 050 ItemIcon                                 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 058 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 PeriodText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 CountText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ButtonInActiveObj                        ModelClassType GameObject GameObject GameObject Pointer
    // 078 PurchaseProductIcon                      ModelClassType RewardItem RewardItem RewardItem Pointer
    // 080 PriceText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 CellInActiveObj                          ModelClassType GameObject GameObject GameObject Pointer
    // 090 LabelAreaObj                             ModelClassType GameObject GameObject GameObject Pointer
    // 098 AlreadyAcquiredLabelObj                  ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 AlreadyAcquiredText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0B0 ShowPeriodTextDisposable                 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ExchangeEventGoodsListItemViewCell : DataModel
    {
        public ExchangeProductViewModel?                ProductData                             { get; set; }
        public GameObject?                              NewBtgObj                               { get; set; }
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public UITextMeshProUGUI?                       PeriodText                              { get; set; }
        public UITextMeshProUGUI?                       CountText                               { get; set; }
        public GameObject?                              ButtonInActiveObj                       { get; set; }
        public RewardItem?                              PurchaseProductIcon                     { get; set; }
        public UITextMeshProUGUI?                       PriceText                               { get; set; }
        public GameObject?                              CellInActiveObj                         { get; set; }
        public GameObject?                              LabelAreaObj                            { get; set; }
        public GameObject?                              AlreadyAcquiredLabelObj                 { get; set; }
        public UITextMeshProUGUI?                       AlreadyAcquiredText                     { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public IDisposable?                             ShowPeriodTextDisposable                { get; set; }

        public static ExchangeEventGoodsListItemViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeEventGoodsListItemViewCell() { Pointer= p0 };

            value.ProductData                               = GetObject<ExchangeProductViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExchangeProductViewModel.FromPointer); // 0x40 ProductData                 ( ModelClassType ExchangeProductViewModel ExchangeProductViewModel ExchangeProductViewModel Pointer )
            value.NewBtgObj                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 NewBtgObj                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x050), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x50 ItemIcon                    ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PeriodText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 PeriodText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CountText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 CountText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ButtonInActiveObj                         = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 ButtonInActiveObj           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x078), ReversePrism.DataModels.RewardItem.FromPointer); // 0x78 PurchaseProductIcon         ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 PriceText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CellInActiveObj                           = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 CellInActiveObj             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LabelAreaObj                              = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 LabelAreaObj                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AlreadyAcquiredLabelObj                   = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 AlreadyAcquiredLabelObj     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AlreadyAcquiredText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA0 AlreadyAcquiredText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xA8 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ShowPeriodTextDisposable                  = GetObject<IDisposable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xB0 ShowPeriodTextDisposable    ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
