using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 GoodsData                                00018650E110 ModelClassType ExchangeLargeSpaceGoodsGridViewModel ExchangeLargeSpaceGoodsGridViewModel ExchangeLargeSpaceGoodsGridViewModel Pointer
    // 038 NewBtgObj                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 ItemIcon                                 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 048 DescriptionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 PeriodText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 CountText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 ButtonInActiveObj                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 PurchaseProductIcon                      00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 070 PriceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CellInActiveObj                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 ExchangeBtn                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 088 ShowPeriodTextDisposable                 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
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

            value.GoodsData                                 = GetObject<ExchangeLargeSpaceGoodsGridViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExchangeLargeSpaceGoodsGridViewModel.FromPointer); // 02466B98F8C8 0x30 GoodsData                   ( 00018650E110 ModelClassType ExchangeLargeSpaceGoodsGridViewModel ExchangeLargeSpaceGoodsGridViewModel ExchangeLargeSpaceGoodsGridViewModel Pointer )
            value.NewBtgObj                                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466B98F8E8 0x38 NewBtgObj                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemIcon                                  = GetObject<RewardItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B98F908 0x40 ItemIcon                    ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B98F928 0x48 DescriptionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PeriodText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B98F948 0x50 PeriodText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CountText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B98F968 0x58 CountText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ButtonInActiveObj                         = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466B98F988 0x60 ButtonInActiveObj           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x068), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B98F9A8 0x68 PurchaseProductIcon         ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B98F9C8 0x70 PriceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CellInActiveObj                           = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 02466B98F9E8 0x78 CellInActiveObj             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeBtn                               = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 02466B98FA08 0x80 ExchangeBtn                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ShowPeriodTextDisposable                  = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B98FA28 0x88 ShowPeriodTextDisposable    ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
