using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShopLocalSave                            ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer
    // 018 Age                                      ModelPrimitiveType int int int Int32
    // 01C PriceType                                ModelEnumType ProductPriceType ProductPriceType ProductPriceType Int32
    // 020 ShopMstItemID                            ModelPrimitiveType int int int Int32
    // 024 CostumeCategoryID                        ModelPrimitiveType int int int Int32
    // 028 CostumeGroupID                           ModelPrimitiveType int int int Int32
    // 030 ContentProductList                       ModelClassListType List`1<ShopProductParam> List`1<ShopProductParam> List<ShopProductParam> Pointer
    // 038 DisplayOrder                             ModelPrimitiveType int int int Int32
    public partial class ShopCostumeGridViewModel : DataModel
    {
        public ShopLocalSave?                           ShopLocalSave                           { get; set; }
        public int                                      Age                                     { get; set; }
        public ProductPriceType                         PriceType                               { get; set; }
        public int                                      ShopMstItemID                           { get; set; }
        public int                                      CostumeCategoryID                       { get; set; }
        public int                                      CostumeGroupID                          { get; set; }
        public List<ShopProductParam>?                  ContentProductList                      { get; set; }
        public int                                      DisplayOrder                            { get; set; }

        public static ShopCostumeGridViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeGridViewModel() { Pointer= p0 };

            value.ShopLocalSave                             = GetObject<ShopLocalSave>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopLocalSave.FromPointer); // 0x10 ShopLocalSave               ( ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer )
            value.Age                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Age                         ( ModelPrimitiveType int int int Int32 )
            value.PriceType                                 = (ProductPriceType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C PriceType                   ( ModelEnumType ProductPriceType ProductPriceType ProductPriceType Int32 )
            value.ShopMstItemID                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 ShopMstItemID               ( ModelPrimitiveType int int int Int32 )
            value.CostumeCategoryID                         = GetInt32(new IntPtr(p + 0x024)); // 0x24 CostumeCategoryID           ( ModelPrimitiveType int int int Int32 )
            value.CostumeGroupID                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 CostumeGroupID              ( ModelPrimitiveType int int int Int32 )
            value.ContentProductList                        = GetObjectList<ShopProductParam>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopProductParam.FromPointer); // 0x30 ContentProductList          ( ModelClassListType List`1<ShopProductParam> List`1<ShopProductParam> List<ShopProductParam> Pointer )
            value.DisplayOrder                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 DisplayOrder                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
