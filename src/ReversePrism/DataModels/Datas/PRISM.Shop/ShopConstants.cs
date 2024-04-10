using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ChargeLimitUnder16                       int IL2CPP_TYPE_I4
    // 000 ChargeLimitUnder18                       int IL2CPP_TYPE_I4
    // 000 AgeLimit16                               int IL2CPP_TYPE_I4
    // 000 AgeLimit18                               int IL2CPP_TYPE_I4
    // 000 MonthlyChargeAlert                       int IL2CPP_TYPE_I4
    // 000 MaxPurchaseCount                         int IL2CPP_TYPE_I4
    // 000 ProductNameLengthPerLine                 int IL2CPP_TYPE_I4
    // 000 MaxBirthDayStringLength                  int IL2CPP_TYPE_I4
    public partial class ShopConstants : DataModel
    {

        public static ShopConstants? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopConstants() { Pointer= p0 };


            return value;
        }
    }
}
