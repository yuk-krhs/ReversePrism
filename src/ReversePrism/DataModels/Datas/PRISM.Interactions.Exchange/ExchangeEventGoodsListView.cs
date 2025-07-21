using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 PurchaseProductAmountPanel               ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 PurchaseProductAmountText                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 PurchaseProductIcon                      ModelClassType RewardItem RewardItem RewardItem Pointer
    // 0C0 Scroller                                 ModelClassType Scroller Scroller Scroller Pointer
    // 0C8 onClickGoodsIndex                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0D0 onClickGoodsSubject                      Subject`1<ExchangeProductViewModel> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeEventGoodsListView : DataModel
    {
        public GameObject?                              PurchaseProductAmountPanel              { get; set; }
        public UITextMeshProUGUI?                       PurchaseProductAmountText               { get; set; }
        public RewardItem?                              PurchaseProductIcon                     { get; set; }
        public Scroller?                                Scroller                                { get; set; }

        public static ExchangeEventGoodsListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeEventGoodsListView() { Pointer= p0 };

            value.PurchaseProductAmountPanel                = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 PurchaseProductAmountPanel  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseProductAmountText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB0 PurchaseProductAmountText   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.RewardItem.FromPointer); // 0xB8 PurchaseProductIcon         ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.Scroller                                  = GetObject<Scroller>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Scroller.FromPointer); // 0xC0 Scroller                    ( ModelClassType Scroller Scroller Scroller Pointer )

            return value;
        }
    }
}
