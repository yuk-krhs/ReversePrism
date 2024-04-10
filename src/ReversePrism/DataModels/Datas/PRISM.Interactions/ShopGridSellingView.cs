using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 00018675B4B0 ModelClassType ShopGoodsGridView ShopGoodsGridView ShopGoodsGridView Pointer
    // 028 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    public partial class ShopGridSellingView : DataModel
    {
        public ShopGoodsGridView?                       GridView                                { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }

        public static ShopGridSellingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopGridSellingView() { Pointer= p0 };

            value.GridView                                  = GetObject<ShopGoodsGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopGoodsGridView.FromPointer); // 02466B871BB0 0x20 GridView                    ( 00018675B4B0 ModelClassType ShopGoodsGridView ShopGoodsGridView ShopGoodsGridView Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B871BD0 0x28 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )

            return value;
        }
    }
}
