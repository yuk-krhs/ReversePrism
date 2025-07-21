using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 GoodsData                                ModelClassType ExchangeLargeSpaceGoodsGridViewModel ExchangeLargeSpaceGoodsGridViewModel ExchangeLargeSpaceGoodsGridViewModel Pointer
    // 038 NewBtgObj                                ModelClassType GameObject GameObject GameObject Pointer
    // 040 ItemIcon                                 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 048 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 PeriodText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 CountText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ButtonInActiveObj                        ModelClassType GameObject GameObject GameObject Pointer
    // 068 PurchaseProductIcon                      ModelClassType RewardItem RewardItem RewardItem Pointer
    // 070 PriceText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CellInActiveObj                          ModelClassType GameObject GameObject GameObject Pointer
    // 080 ExchangeBtn                              ModelClassType UIButton UIButton UIButton Pointer
    // 088 ShowPeriodTextDisposable                 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ExchangeLargeSpaceGoodsViewCell : DataModel
    {
        public ExchangeLargeSpaceGoodsGridViewModel?    GoodsData                               { get; set; }
        public GameObject?                              NewBtgObj                               { get; set; }
        public RewardItem?                              ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public UITextMeshProUGUI?                       PeriodText                              { get; set; }
        public UITextMeshProUGUI?                       CountText                               { get; set; }
        public GameObject?                              ButtonInActiveObj                       { get; set; }
        public RewardItem?                              PurchaseProductIcon                     { get; set; }
        public UITextMeshProUGUI?                       PriceText                               { get; set; }
        public GameObject?                              CellInActiveObj                         { get; set; }
        public UIButton?                                ExchangeBtn                             { get; set; }
        public IDisposable?                             ShowPeriodTextDisposable                { get; set; }

        public static ExchangeLargeSpaceGoodsViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeLargeSpaceGoodsViewCell() { Pointer= p0 };

            value.GoodsData                                 = GetObject<ExchangeLargeSpaceGoodsGridViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExchangeLargeSpaceGoodsGridViewModel.FromPointer); // 0x30 GoodsData                   ( ModelClassType ExchangeLargeSpaceGoodsGridViewModel ExchangeLargeSpaceGoodsGridViewModel ExchangeLargeSpaceGoodsGridViewModel Pointer )
            value.NewBtgObj                                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 NewBtgObj                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemIcon                                  = GetObject<RewardItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItem.FromPointer); // 0x40 ItemIcon                    ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PeriodText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 PeriodText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CountText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 CountText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ButtonInActiveObj                         = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 ButtonInActiveObj           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x068), ReversePrism.DataModels.RewardItem.FromPointer); // 0x68 PurchaseProductIcon         ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 PriceText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CellInActiveObj                           = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 CellInActiveObj             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeBtn                               = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 ExchangeBtn                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ShowPeriodTextDisposable                  = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0x88 ShowPeriodTextDisposable    ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
