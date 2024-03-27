using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               00018675B970 ModelClassType ShopGoodsGridViewCell ShopGoodsGridViewCell ShopGoodsGridViewCell Pointer
    // 098 EmptyViewText                            0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ShopGoodsGridView
    {
        public ShopGoodsGridViewCell?                   CellPrefab                              { get; set; }
        public UITextMeshProUGUI?                       EmptyViewText                           { get; set; }

        public static ShopGoodsGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopGoodsGridView();

            value.CellPrefab                                = GetObject<ShopGoodsGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ShopGoodsGridViewCell.FromPointer); // 0270D551A438 0x90 CellPrefab                  ( 00018675B970 ModelClassType ShopGoodsGridViewCell ShopGoodsGridViewCell ShopGoodsGridViewCell Pointer )
            value.EmptyViewText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D551A458 0x98 EmptyViewText               ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
