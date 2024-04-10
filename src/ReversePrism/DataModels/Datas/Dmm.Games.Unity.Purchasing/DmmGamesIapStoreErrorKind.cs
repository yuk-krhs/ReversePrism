using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Init                                     string IL2CPP_TYPE_STRING
    // 000 GetPurchasedItems                        string IL2CPP_TYPE_STRING
    // 000 GetDetailItems                           string IL2CPP_TYPE_STRING
    // 000 DeletePurchasedItem                      string IL2CPP_TYPE_STRING
    // 000 PurchasedProcess                         string IL2CPP_TYPE_STRING
    public partial class DmmGamesIapStoreErrorKind : DataModel
    {

        public static DmmGamesIapStoreErrorKind? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DmmGamesIapStoreErrorKind() { Pointer= p0 };


            return value;
        }
    }
}
