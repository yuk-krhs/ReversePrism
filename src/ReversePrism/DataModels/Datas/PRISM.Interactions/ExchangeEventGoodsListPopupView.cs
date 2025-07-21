using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewModel                                ModelClassType ExchangeEventGoodsListPopupViewModel ExchangeEventGoodsListPopupViewModel ExchangeEventGoodsListPopupViewModel Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ExchangeProductObj                       ModelClassType GameObject GameObject GameObject Pointer
    // 038 ExchangeProductIcon                      ModelClassType RewardItem RewardItem RewardItem Pointer
    // 040 ExchangeProductAmountText                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 ListView                                 ModelClassType ExchangeEventGoodsListView ExchangeEventGoodsListView ExchangeEventGoodsListView Pointer
    // 050 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.ViewModel                                 = GetObject<ExchangeEventGoodsListPopupViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExchangeEventGoodsListPopupViewModel.FromPointer); // 0x20 ViewModel                   ( ModelClassType ExchangeEventGoodsListPopupViewModel ExchangeEventGoodsListPopupViewModel ExchangeEventGoodsListPopupViewModel Pointer )
            value.ExchangeProductObj                        = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 ExchangeProductObj          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardItem.FromPointer); // 0x38 ExchangeProductIcon         ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ExchangeProductAmountText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 ExchangeProductAmountText   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ListView                                  = GetObject<ExchangeEventGoodsListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExchangeEventGoodsListView.FromPointer); // 0x48 ListView                    ( ModelClassType ExchangeEventGoodsListView ExchangeEventGoodsListView ExchangeEventGoodsListView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x50 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
