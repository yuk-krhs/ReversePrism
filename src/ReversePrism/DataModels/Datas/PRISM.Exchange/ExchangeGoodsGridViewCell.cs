using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 GoodsData                                00018677A520 ModelClassType ExchangeGoodsClientModel ExchangeGoodsClientModel ExchangeGoodsClientModel Pointer
    // 048 NewBtgObj                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 ItemIcon                                 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 058 DescriptionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 PeriodText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 CountText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ButtonInActiveObj                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 PurchaseProductIcon                      00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 080 PriceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 CellInActiveObj                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 PIdolDetail                              000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 098 SCharaDetail                             0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 0A0 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0A8 ShowPeriodTextDisposable                 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ExchangeGoodsGridViewCell
    {
        public ExchangeGoodsClientModel?                GoodsData                               { get; set; }
        public GameObject?                              NewBtgObj                               { get; set; }
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public UITextMeshProUGUI?                       PeriodText                              { get; set; }
        public UITextMeshProUGUI?                       CountText                               { get; set; }
        public GameObject?                              ButtonInActiveObj                       { get; set; }
        public RewardItem?                              PurchaseProductIcon                     { get; set; }
        public UITextMeshProUGUI?                       PriceText                               { get; set; }
        public GameObject?                              CellInActiveObj                         { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetail                             { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetail                            { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public IDisposable?                             ShowPeriodTextDisposable                { get; set; }

        public static ExchangeGoodsGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeGoodsGridViewCell();

            value.GoodsData                                 = GetObject<ExchangeGoodsClientModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExchangeGoodsClientModel.FromPointer); // 0270D5501E20 0x40 GoodsData                   ( 00018677A520 ModelClassType ExchangeGoodsClientModel ExchangeGoodsClientModel ExchangeGoodsClientModel Pointer )
            value.NewBtgObj                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5501E40 0x48 NewBtgObj                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x050), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0270D5501E60 0x50 ItemIcon                    ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5501E80 0x58 DescriptionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PeriodText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5501EA0 0x60 PeriodText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CountText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5501EC0 0x68 CountText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ButtonInActiveObj                         = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5501EE0 0x70 ButtonInActiveObj           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x078), ReversePrism.DataModels.RewardItem.FromPointer); // 0270D5501F00 0x78 PurchaseProductIcon         ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5501F20 0x80 PriceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CellInActiveObj                           = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5501F40 0x88 CellInActiveObj             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolDetail                               = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x090), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270D5501F60 0x90 PIdolDetail                 ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetail                              = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x098), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270D5501F80 0x98 SCharaDetail                ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D5501FA0 0xA0 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ShowPeriodTextDisposable                  = GetObject<IDisposable>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D5501FC0 0xA8 ShowPeriodTextDisposable    ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
