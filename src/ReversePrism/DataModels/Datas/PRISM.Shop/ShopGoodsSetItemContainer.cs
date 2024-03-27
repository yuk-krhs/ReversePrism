using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemPrefab                               00018675D150 ModelClassType ShopGoodsSetItem ShopGoodsSetItem ShopGoodsSetItem Pointer
    // 030 ItemParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 NoItemLabel                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ShopGoodsSetItemContainer
    {
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public ShopGoodsSetItem?                        ItemPrefab                              { get; set; }
        public Transform?                               ItemParent                              { get; set; }
        public GameObject?                              NoItemLabel                             { get; set; }

        public static ShopGoodsSetItemContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopGoodsSetItemContainer();

            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D551A010 0x20 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemPrefab                                = GetObject<ShopGoodsSetItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopGoodsSetItem.FromPointer); // 0270D551A030 0x28 ItemPrefab                  ( 00018675D150 ModelClassType ShopGoodsSetItem ShopGoodsSetItem ShopGoodsSetItem Pointer )
            value.ItemParent                                = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270D551A050 0x30 ItemParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.NoItemLabel                               = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D551A070 0x38 NoItemLabel                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
