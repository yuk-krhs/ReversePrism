using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CategoryType                             ModelEnumType ShopGoodsItemCategoryType ShopGoodsItemCategoryType ShopGoodsItemCategoryType Int32
    // 018 GoodsProduct                             ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    public partial class ShopGoodsParam : DataModel
    {
        public ShopGoodsItemCategoryType                CategoryType                            { get; set; }
        public IProductWithAmountStatus?                GoodsProduct                            { get; set; }

        public static ShopGoodsParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopGoodsParam() { Pointer= p0 };

            value.CategoryType                              = (ShopGoodsItemCategoryType)GetInt32(new IntPtr(p + 0x010)); // 0x10 CategoryType                ( ModelEnumType ShopGoodsItemCategoryType ShopGoodsItemCategoryType ShopGoodsItemCategoryType Int32 )
            value.GoodsProduct                              = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x18 GoodsProduct                ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )

            return value;
        }
    }
}
