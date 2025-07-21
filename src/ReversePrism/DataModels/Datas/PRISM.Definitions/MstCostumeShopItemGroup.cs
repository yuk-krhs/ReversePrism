using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstCostumeShopItemCategoryId             ModelPrimitiveType int int int Int32
    // 018 DisplayOrder                             ModelPrimitiveType int int int Int32
    public partial class MstCostumeShopItemGroup : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstCostumeShopItemCategoryId            { get; set; }
        public int                                      DisplayOrder                            { get; set; }

        public static MstCostumeShopItemGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstCostumeShopItemGroup() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstCostumeShopItemCategoryId              = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCostumeShopItemCategoryId ( ModelPrimitiveType int int int Int32 )
            value.DisplayOrder                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 DisplayOrder                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
