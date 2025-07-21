using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IShopLoginBonusPassView IShopLoginBonusPassView IShopLoginBonusPassView Pointer
    public partial class ShopLoginBonusPassPresenter : DataModel
    {
        public IShopLoginBonusPassView?                 View                                    { get; set; }

        public static ShopLoginBonusPassPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopLoginBonusPassPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IShopLoginBonusPassView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IShopLoginBonusPassView.FromPointer); // 0x10 View                        ( ModelClassType IShopLoginBonusPassView IShopLoginBonusPassView IShopLoginBonusPassView Pointer )

            return value;
        }
    }
}
