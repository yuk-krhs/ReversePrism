using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_CachedQuerySkuDetailsService           00018655B990 ModelClassType IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService Pointer
    // 018 M_Logger                                 0001865A19E0 ModelClassType ILogger ILogger ILogger Pointer
    public partial class GooglePurchaseBuilder
    {
        public IGoogleCachedQuerySkuDetailsService?     M_CachedQuerySkuDetailsService          { get; set; }
        public ILogger?                                 M_Logger                                { get; set; }

        public static GooglePurchaseBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePurchaseBuilder();

            value.M_CachedQuerySkuDetailsService            = GetObject<IGoogleCachedQuerySkuDetailsService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGoogleCachedQuerySkuDetailsService.FromPointer); // 0270069236C0 0x10 M_CachedQuerySkuDetailsService ( 00018655B990 ModelClassType IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService Pointer )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILogger.FromPointer); // 0270069236E0 0x18 M_Logger                    ( 0001865A19E0 ModelClassType ILogger ILogger ILogger Pointer )

            return value;
        }
    }
}
