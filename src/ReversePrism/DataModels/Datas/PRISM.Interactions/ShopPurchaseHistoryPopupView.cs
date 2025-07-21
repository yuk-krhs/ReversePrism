using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CautionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemListContent                          ModelClassType Transform Transform Transform Pointer
    // 030 ItemViewPrefab                           ModelClassType GameObject GameObject GameObject Pointer
    // 038 EmptyViewTextObj                         ModelClassType GameObject GameObject GameObject Pointer
    // 040 ItemList                                 ModelClassListType List`1<ShopPurchaseHistoryItemView> List`1<ShopPurchaseHistoryItemView> List<ShopPurchaseHistoryItemView> Pointer
    // 048 ViewModel                                ModelClassType ShopPurchaseHistoryViewModel ShopPurchaseHistoryViewModel ShopPurchaseHistoryViewModel Pointer
    // 050 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onClickHistoryItem                       Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopPurchaseHistoryPopupView : DataModel
    {
        public UITextMeshProUGUI?                       CautionText                             { get; set; }
        public Transform?                               ItemListContent                         { get; set; }
        public GameObject?                              ItemViewPrefab                          { get; set; }
        public GameObject?                              EmptyViewTextObj                        { get; set; }
        public List<ShopPurchaseHistoryItemView>?       ItemList                                { get; set; }
        public ShopPurchaseHistoryViewModel?            ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ShopPurchaseHistoryPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseHistoryPopupView() { Pointer= p0 };

            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 CautionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemListContent                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ItemListContent             ( ModelClassType Transform Transform Transform Pointer )
            value.ItemViewPrefab                            = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 ItemViewPrefab              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyViewTextObj                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 EmptyViewTextObj            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemList                                  = GetObjectList<ShopPurchaseHistoryItemView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopPurchaseHistoryItemView.FromPointer); // 0x40 ItemList                    ( ModelClassListType List`1<ShopPurchaseHistoryItemView> List`1<ShopPurchaseHistoryItemView> List<ShopPurchaseHistoryItemView> Pointer )
            value.ViewModel                                 = GetObject<ShopPurchaseHistoryViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShopPurchaseHistoryViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType ShopPurchaseHistoryViewModel ShopPurchaseHistoryViewModel ShopPurchaseHistoryViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
