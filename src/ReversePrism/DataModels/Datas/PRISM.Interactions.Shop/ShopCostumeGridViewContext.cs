using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 onClickPurchase                          Subject`1<ShopCostumeGridViewModel> IL2CPP_TYPE_GENERICINST
    // 048 onClickDetail                            Subject`1<ShopCostumeGridViewModel> IL2CPP_TYPE_GENERICINST
    // 050 ShopLocalSave                            ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer
    public partial class ShopCostumeGridViewContext : DataModel
    {
        public ShopLocalSave?                           ShopLocalSave                           { get; set; }

        public static ShopCostumeGridViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeGridViewContext() { Pointer= p0 };

            value.ShopLocalSave                             = GetObject<ShopLocalSave>(new IntPtr(p + 0x050), ReversePrism.DataModels.ShopLocalSave.FromPointer); // 0x50 ShopLocalSave               ( ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer )

            return value;
        }
    }
}
