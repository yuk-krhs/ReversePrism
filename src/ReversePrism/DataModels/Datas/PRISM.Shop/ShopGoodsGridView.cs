using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               ModelClassType ShopGoodsGridViewCell ShopGoodsGridViewCell ShopGoodsGridViewCell Pointer
    // 098 EmptyViewText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ShopGoodsGridView : DataModel
    {
        public ShopGoodsGridViewCell?                   CellPrefab                              { get; set; }
        public UITextMeshProUGUI?                       EmptyViewText                           { get; set; }

        public static ShopGoodsGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopGoodsGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<ShopGoodsGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ShopGoodsGridViewCell.FromPointer); // 0x90 CellPrefab                  ( ModelClassType ShopGoodsGridViewCell ShopGoodsGridViewCell ShopGoodsGridViewCell Pointer )
            value.EmptyViewText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 EmptyViewText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
