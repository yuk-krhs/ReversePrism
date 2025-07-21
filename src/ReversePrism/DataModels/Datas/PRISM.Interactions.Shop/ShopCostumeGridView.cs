using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CellPrefab                               ModelClassType ShopCostumeGridViewCell ShopCostumeGridViewCell ShopCostumeGridViewCell Pointer
    // 098 EmptyViewText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ShopCostumeGridView : DataModel
    {
        public ShopCostumeGridViewCell?                 CellPrefab                              { get; set; }
        public UITextMeshProUGUI?                       EmptyViewText                           { get; set; }

        public static ShopCostumeGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeGridView() { Pointer= p0 };

            value.CellPrefab                                = GetObject<ShopCostumeGridViewCell>(new IntPtr(p + 0x090), ReversePrism.DataModels.ShopCostumeGridViewCell.FromPointer); // 0x90 CellPrefab                  ( ModelClassType ShopCostumeGridViewCell ShopCostumeGridViewCell ShopCostumeGridViewCell Pointer )
            value.EmptyViewText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 EmptyViewText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
