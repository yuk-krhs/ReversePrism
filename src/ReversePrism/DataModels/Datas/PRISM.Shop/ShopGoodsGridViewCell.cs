using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ShopGoods                                00018675A870 ModelClassType ShopGoods ShopGoods ShopGoods Pointer
    public partial class ShopGoodsGridViewCell : DataModel
    {
        public ShopGoods?                               ShopGoods                               { get; set; }

        public static ShopGoodsGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopGoodsGridViewCell() { Pointer= p0 };

            value.ShopGoods                                 = GetObject<ShopGoods>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopGoods.FromPointer); // 02466557C4C8 0x30 ShopGoods                   ( 00018675A870 ModelClassType ShopGoods ShopGoods ShopGoods Pointer )

            return value;
        }
    }
}
