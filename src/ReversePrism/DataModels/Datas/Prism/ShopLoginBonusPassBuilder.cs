using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186764160 ModelClassType ShopLoginBonusPassView ShopLoginBonusPassView ShopLoginBonusPassView Pointer
    public partial class ShopLoginBonusPassBuilder : DataModel
    {
        public ShopLoginBonusPassView?                  View                                    { get; set; }

        public static ShopLoginBonusPassBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopLoginBonusPassBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ShopLoginBonusPassView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopLoginBonusPassView.FromPointer); // 02466B6B2FB8 0x20 View                        ( 000186764160 ModelClassType ShopLoginBonusPassView ShopLoginBonusPassView ShopLoginBonusPassView Pointer )

            return value;
        }
    }
}
