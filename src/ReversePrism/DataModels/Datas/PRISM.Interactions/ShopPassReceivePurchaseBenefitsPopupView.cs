using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemPrefab                               ModelClassType ShopGoodsSetItem ShopGoodsSetItem ShopGoodsSetItem Pointer
    // 028 ItemParent                               ModelClassType Transform Transform Transform Pointer
    // 030 ViewModel                                ModelClassType ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 terminateTask                            UniTaskCompletionSource`1<int> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopPassReceivePurchaseBenefitsPopupView : DataModel
    {
        public ShopGoodsSetItem?                        ItemPrefab                              { get; set; }
        public Transform?                               ItemParent                              { get; set; }
        public ShopReceivePurchaseBenefitsViewModel?    ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ShopPassReceivePurchaseBenefitsPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassReceivePurchaseBenefitsPopupView() { Pointer= p0 };

            value.ItemPrefab                                = GetObject<ShopGoodsSetItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopGoodsSetItem.FromPointer); // 0x20 ItemPrefab                  ( ModelClassType ShopGoodsSetItem ShopGoodsSetItem ShopGoodsSetItem Pointer )
            value.ItemParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ItemParent                  ( ModelClassType Transform Transform Transform Pointer )
            value.ViewModel                                 = GetObject<ShopReceivePurchaseBenefitsViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopReceivePurchaseBenefitsViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
