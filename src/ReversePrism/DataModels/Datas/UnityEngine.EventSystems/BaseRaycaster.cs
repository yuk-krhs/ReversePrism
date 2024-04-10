using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_RootRaycaster                          0001867416D0 ModelClassType BaseRaycaster BaseRaycaster BaseRaycaster Pointer
    public partial class BaseRaycaster : DataModel
    {
        public BaseRaycaster?                           M_RootRaycaster                         { get; set; }

        public static BaseRaycaster? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseRaycaster() { Pointer= p0 };

            value.M_RootRaycaster                           = GetObject<BaseRaycaster>(new IntPtr(p + 0x020), ReversePrism.DataModels.BaseRaycaster.FromPointer); // 0245A35E7730 0x20 M_RootRaycaster             ( 0001867416D0 ModelClassType BaseRaycaster BaseRaycaster BaseRaycaster Pointer )

            return value;
        }
    }
}
