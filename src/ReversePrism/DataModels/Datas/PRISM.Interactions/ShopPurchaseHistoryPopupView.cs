using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CautionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemListContent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 ItemViewPrefab                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 EmptyViewTextObj                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 ItemList                                 000185D09568 ModelClassListType List`1<ShopPurchaseHistoryItemView> List`1<ShopPurchaseHistoryItemView> List<ShopPurchaseHistoryItemView> Pointer
    // 048 ViewModel                                00018676EB10 ModelClassType ShopPurchaseHistoryViewModel ShopPurchaseHistoryViewModel ShopPurchaseHistoryViewModel Pointer
    // 050 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onClickHistoryItem                       Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopPurchaseHistoryPopupView
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
            var value   = new ShopPurchaseHistoryPopupView();

            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8016E0 0x20 CautionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemListContent                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB801700 0x28 ItemListContent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ItemViewPrefab                            = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB801720 0x30 ItemViewPrefab              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyViewTextObj                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB801740 0x38 EmptyViewTextObj            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemList                                  = GetObjectList<ShopPurchaseHistoryItemView>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopPurchaseHistoryItemView.FromPointer); // 0270DB801760 0x40 ItemList                    ( 000185D09568 ModelClassListType List`1<ShopPurchaseHistoryItemView> List`1<ShopPurchaseHistoryItemView> List<ShopPurchaseHistoryItemView> Pointer )
            value.ViewModel                                 = GetObject<ShopPurchaseHistoryViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShopPurchaseHistoryViewModel.FromPointer); // 0270DB801780 0x48 ViewModel                   ( 00018676EB10 ModelClassType ShopPurchaseHistoryViewModel ShopPurchaseHistoryViewModel ShopPurchaseHistoryViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB8017E0 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
