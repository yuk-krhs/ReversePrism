using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewModel                                000186777CF0 ModelClassType ExchangeEventGoodsListPopupViewModel ExchangeEventGoodsListPopupViewModel ExchangeEventGoodsListPopupViewModel Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ExchangeProductObj                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ExchangeProductIcon                      00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 040 ExchangeProductAmountText                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ListView                                 000186778490 ModelClassType ExchangeEventGoodsListView ExchangeEventGoodsListView ExchangeEventGoodsListView Pointer
    // 050 confirmationPopupFactory                 PopupViewFactory`1<IExchangeConfirmationPopupView> IL2CPP_TYPE_GENERICINST
    // 058 resultPopupViewFactory                   PopupViewFactory`1<IExchangeResultPopupView> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeEventGoodsListPopupView : DataModel
    {
        public ExchangeEventGoodsListPopupViewModel?    ViewModel                               { get; set; }
        public GameObject?                              ExchangeProductObj                      { get; set; }
        public RewardItem?                              ExchangeProductIcon                     { get; set; }
        public UITextMeshProUGUI?                       ExchangeProductAmountText               { get; set; }
        public ExchangeEventGoodsListView?              ListView                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeEventGoodsListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeEventGoodsListPopupView() { Pointer= p0 };

            value.ViewModel                                 = GetObject<ExchangeEventGoodsListPopupViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExchangeEventGoodsListPopupViewModel.FromPointer); // 02466B96B800 0x20 ViewModel                   ( 000186777CF0 ModelClassType ExchangeEventGoodsListPopupViewModel ExchangeEventGoodsListPopupViewModel ExchangeEventGoodsListPopupViewModel Pointer )
            value.ExchangeProductObj                        = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B96B840 0x30 ExchangeProductObj          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B96B860 0x38 ExchangeProductIcon         ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ExchangeProductAmountText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B96B880 0x40 ExchangeProductAmountText   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ListView                                  = GetObject<ExchangeEventGoodsListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExchangeEventGoodsListView.FromPointer); // 02466B96B8A0 0x48 ListView                    ( 000186778490 ModelClassType ExchangeEventGoodsListView ExchangeEventGoodsListView ExchangeEventGoodsListView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B96B900 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
