using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ItemPrefab                               ModelClassType ShopGoodsSetItem ShopGoodsSetItem ShopGoodsSetItem Pointer
    // 068 ItemParent                               ModelClassType Transform Transform Transform Pointer
    public partial class ShopReceiveBonusContent : DataModel
    {
        public ShopGoodsSetItem?                        ItemPrefab                              { get; set; }
        public Transform?                               ItemParent                              { get; set; }

        public static ShopReceiveBonusContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopReceiveBonusContent() { Pointer= p0 };

            value.ItemPrefab                                = GetObject<ShopGoodsSetItem>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShopGoodsSetItem.FromPointer); // 0x60 ItemPrefab                  ( ModelClassType ShopGoodsSetItem ShopGoodsSetItem ShopGoodsSetItem Pointer )
            value.ItemParent                                = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0x68 ItemParent                  ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
