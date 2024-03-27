using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemPrefab                               00018675D150 ModelClassType ShopGoodsSetItem ShopGoodsSetItem ShopGoodsSetItem Pointer
    // 028 ItemParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 ViewModel                                00018676A030 ModelClassType ShopProductListPopupViewModel ShopProductListPopupViewModel ShopProductListPopupViewModel Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopProductListPopupView
    {
        public ShopGoodsSetItem?                        ItemPrefab                              { get; set; }
        public Transform?                               ItemParent                              { get; set; }
        public ShopProductListPopupViewModel?           ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ShopProductListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopProductListPopupView();

            value.ItemPrefab                                = GetObject<ShopGoodsSetItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopGoodsSetItem.FromPointer); // 0270DB7BDDA0 0x20 ItemPrefab                  ( 00018675D150 ModelClassType ShopGoodsSetItem ShopGoodsSetItem ShopGoodsSetItem Pointer )
            value.ItemParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB7BDDC0 0x28 ItemParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ViewModel                                 = GetObject<ShopProductListPopupViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopProductListPopupViewModel.FromPointer); // 0270DB7BDDE0 0x30 ViewModel                   ( 00018676A030 ModelClassType ShopProductListPopupViewModel ShopProductListPopupViewModel ShopProductListPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB7BDE20 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
