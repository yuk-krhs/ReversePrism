using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ClothControllers                         ModelClassListType List`1<MagicaClothController> List`1<MagicaClothController> List<MagicaClothController> Pointer
    // 028 ColliderCategoryDatas                    ModelClassListType List`1<MagicaColliderCategoryData> List`1<MagicaColliderCategoryData> List<MagicaColliderCategoryData> Pointer
    public partial class MagicaClothGroup : DataModel
    {
        public List<MagicaClothController>?             ClothControllers                        { get; set; }
        public List<MagicaColliderCategoryData>?        ColliderCategoryDatas                   { get; set; }

        public static MagicaClothGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaClothGroup() { Pointer= p0 };

            value.ClothControllers                          = GetObjectList<MagicaClothController>(new IntPtr(p + 0x020), ReversePrism.DataModels.MagicaClothController.FromPointer); // 0x20 ClothControllers            ( ModelClassListType List`1<MagicaClothController> List`1<MagicaClothController> List<MagicaClothController> Pointer )
            value.ColliderCategoryDatas                     = GetObjectList<MagicaColliderCategoryData>(new IntPtr(p + 0x028), ReversePrism.DataModels.MagicaColliderCategoryData.FromPointer); // 0x28 ColliderCategoryDatas       ( ModelClassListType List`1<MagicaColliderCategoryData> List`1<MagicaColliderCategoryData> List<MagicaColliderCategoryData> Pointer )

            return value;
        }
    }
}
