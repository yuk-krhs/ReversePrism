using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class ShopCostumeListPopupViewFactory : DataModel
    {

        public static ShopCostumeListPopupViewFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopCostumeListPopupViewFactory() { Pointer= p0 };


            return value;
        }
    }
}
