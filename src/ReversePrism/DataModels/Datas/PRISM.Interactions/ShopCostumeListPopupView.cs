using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellPrefab                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 Content                                  ModelClassType Transform Transform Transform Pointer
    // 030 ShopPurchasePopupView                    ModelClassType ShopPurchasePopupView ShopPurchasePopupView ShopPurchasePopupView Pointer
    // 038 ViewModel                                ModelClassType ShopCostumeGridViewModel ShopCostumeGridViewModel ShopCostumeGridViewModel Pointer
    // 040 onPurchase                               Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    // 048 onDetail                                 Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    // 050 onTry                                    Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    // 058 onClosed                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopCostumeListPopupView : DataModel
    {
        public GameObject?                              CellPrefab                              { get; set; }
        public Transform?                               Content                                 { get; set; }
        public ShopPurchasePopupView?                   ShopPurchasePopupView                   { get; set; }
        public ShopCostumeGridViewModel?                ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ShopCostumeListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeListPopupView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 CellPrefab                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Content                                   = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 Content                     ( ModelClassType Transform Transform Transform Pointer )
            value.ShopPurchasePopupView                     = GetObject<ShopPurchasePopupView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopPurchasePopupView.FromPointer); // 0x30 ShopPurchasePopupView       ( ModelClassType ShopPurchasePopupView ShopPurchasePopupView ShopPurchasePopupView Pointer )
            value.ViewModel                                 = GetObject<ShopCostumeGridViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShopCostumeGridViewModel.FromPointer); // 0x38 ViewModel                   ( ModelClassType ShopCostumeGridViewModel ShopCostumeGridViewModel ShopCostumeGridViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
