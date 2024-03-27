using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ItemPrefab                               00018675D150 ModelClassType ShopGoodsSetItem ShopGoodsSetItem ShopGoodsSetItem Pointer
    // 068 ItemParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class ShopReceiveBonusContent
    {
        public ShopGoodsSetItem?                        ItemPrefab                              { get; set; }
        public Transform?                               ItemParent                              { get; set; }

        public static ShopReceiveBonusContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopReceiveBonusContent();

            value.ItemPrefab                                = GetObject<ShopGoodsSetItem>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShopGoodsSetItem.FromPointer); // 0270D553A900 0x60 ItemPrefab                  ( 00018675D150 ModelClassType ShopGoodsSetItem ShopGoodsSetItem ShopGoodsSetItem Pointer )
            value.ItemParent                                = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0270D553A920 0x68 ItemParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
