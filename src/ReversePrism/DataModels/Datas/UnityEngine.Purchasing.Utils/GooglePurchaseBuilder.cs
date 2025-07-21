using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_CachedQuerySkuDetailsService           ModelClassType IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService Pointer
    // 018 M_Logger                                 ModelClassType ILogger ILogger ILogger Pointer
    public partial class GooglePurchaseBuilder : DataModel
    {
        public IGoogleCachedQuerySkuDetailsService?     M_CachedQuerySkuDetailsService          { get; set; }
        public ILogger?                                 M_Logger                                { get; set; }

        public static GooglePurchaseBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GooglePurchaseBuilder() { Pointer= p0 };

            value.M_CachedQuerySkuDetailsService            = GetObject<IGoogleCachedQuerySkuDetailsService>(new IntPtr(p + 0x010), ReversePrism.DataModels.IGoogleCachedQuerySkuDetailsService.FromPointer); // 0x10 M_CachedQuerySkuDetailsService ( ModelClassType IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService IGoogleCachedQuerySkuDetailsService Pointer )
            value.M_Logger                                  = GetObject<ILogger>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILogger.FromPointer); // 0x18 M_Logger                    ( ModelClassType ILogger ILogger ILogger Pointer )

            return value;
        }
    }
}
