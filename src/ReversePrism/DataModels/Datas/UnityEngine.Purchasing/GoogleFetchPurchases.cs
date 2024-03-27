using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_GooglePlayStoreService                 00018655F5C0 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer
    // 018 M_StoreCallback                          000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer
    // 020 M_Util                                   0001866900E0 ModelClassType IUtil IUtil IUtil Pointer
    public partial class GoogleFetchPurchases
    {
        public IGooglePlayStoreService?                 M_GooglePlayStoreService                { get; set; }
        public IStoreCallback?                          M_StoreCallback                         { get; set; }
        public IUtil?                                   M_Util                                  { get; set; }

        public static GoogleFetchPurchases? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleFetchPurchases();

            value.M_GooglePlayStoreService                  = GetObject<IGooglePlayStoreService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGooglePlayStoreService.FromPointer); // 02700690CEA0 0x10 M_GooglePlayStoreService    ( 00018655F5C0 ModelClassType IGooglePlayStoreService IGooglePlayStoreService IGooglePlayStoreService Pointer )
            value.M_StoreCallback                           = GetObject<IStoreCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStoreCallback.FromPointer); // 02700690CEC0 0x18 M_StoreCallback             ( 000186658CA0 ModelClassType IStoreCallback IStoreCallback IStoreCallback Pointer )
            value.M_Util                                    = GetObject<IUtil>(new IntPtr(p + 0x020), ReversePrism.DataModels.IUtil.FromPointer); // 02700690CEE0 0x20 M_Util                      ( 0001866900E0 ModelClassType IUtil IUtil IUtil Pointer )

            return value;
        }
    }
}
