using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 onClickPurchase                          Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    // 048 onClickDetail                            Subject`1<ShopProductParam> IL2CPP_TYPE_GENERICINST
    // 050 ShopLocalSave                            0001867622A0 ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer
    public partial class ShopGoodsGridViewContext
    {
        public ShopLocalSave?                           ShopLocalSave                           { get; set; }

        public static ShopGoodsGridViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopGoodsGridViewContext();

            value.ShopLocalSave                             = GetObject<ShopLocalSave>(new IntPtr(p + 0x050), ReversePrism.DataModels.ShopLocalSave.FromPointer); // 0270D5519858 0x50 ShopLocalSave               ( 0001867622A0 ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer )

            return value;
        }
    }
}
