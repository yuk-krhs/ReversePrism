using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ItemView                                 000186754E60 ModelClassType ShopCostumeGridItemView ShopCostumeGridItemView ShopCostumeGridItemView Pointer
    public partial class ShopCostumeGridViewCell
    {
        public ShopCostumeGridItemView?                 ItemView                                { get; set; }

        public static ShopCostumeGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeGridViewCell();

            value.ItemView                                  = GetObject<ShopCostumeGridItemView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopCostumeGridItemView.FromPointer); // 0270DB80E240 0x30 ItemView                    ( 000186754E60 ModelClassType ShopCostumeGridItemView ShopCostumeGridItemView ShopCostumeGridItemView Pointer )

            return value;
        }
    }
}
