using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductList                              ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 018 PopupTitleText                           ModelPrimitiveType string string string String
    public partial class ShopProductListPopupViewModel : DataModel
    {
        public List<IProductWithAmountStatus>?          ProductList                             { get; set; }
        public string                                   PopupTitleText                          { get; set; }

        public static ShopProductListPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopProductListPopupViewModel() { Pointer= p0 };

            value.ProductList                               = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x10 ProductList                 ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )
            value.PopupTitleText                            = GetString(new IntPtr(p + 0x018)); // 0x18 PopupTitleText              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
