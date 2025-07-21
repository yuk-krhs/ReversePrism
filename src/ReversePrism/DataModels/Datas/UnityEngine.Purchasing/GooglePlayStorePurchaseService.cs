using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GooglePlayStoreService                 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer
    public partial class GooglePlayStorePurchaseService : DataModel
    {
        public IGooglePlayStoreService?                 M_GooglePlayStoreService                { get; set; }

        public static GooglePlayStorePurchaseService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePlayStorePurchaseService() { Pointer= p0 };

            value.M_GooglePlayStoreService                  = GetObject<IGooglePlayStoreService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGooglePlayStoreService.FromPointer); // 0x10 M_GooglePlayStoreService    ( ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer )

            return value;
        }
    }
}
