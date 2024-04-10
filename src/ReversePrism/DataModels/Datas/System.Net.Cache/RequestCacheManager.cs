using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_CacheConfigSettings                    RequestCachingSectionInternal IL2CPP_TYPE_CLASS
    // 008 s_BypassCacheBinding                     RequestCacheBinding IL2CPP_TYPE_CLASS
    // 010 S_DefaultGlobalBinding                   000186664670 ModelClassType RequestCacheBinding RequestCacheBinding RequestCacheBinding Pointer
    // 018 S_DefaultHttpBinding                     000186664670 ModelClassType RequestCacheBinding RequestCacheBinding RequestCacheBinding Pointer
    // 020 S_DefaultFtpBinding                      000186664670 ModelClassType RequestCacheBinding RequestCacheBinding RequestCacheBinding Pointer
    public partial class RequestCacheManager : DataModel
    {
        public RequestCacheBinding?                     S_DefaultGlobalBinding                  { get; set; }
        public RequestCacheBinding?                     S_DefaultHttpBinding                    { get; set; }
        public RequestCacheBinding?                     S_DefaultFtpBinding                     { get; set; }

        public static RequestCacheManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestCacheManager() { Pointer= p0 };

            value.S_DefaultGlobalBinding                    = GetObject<RequestCacheBinding>(new IntPtr(p + 0x010), ReversePrism.DataModels.RequestCacheBinding.FromPointer); // 024667B4C168 0x10 S_DefaultGlobalBinding      ( 000186664670 ModelClassType RequestCacheBinding RequestCacheBinding RequestCacheBinding Pointer )
            value.S_DefaultHttpBinding                      = GetObject<RequestCacheBinding>(new IntPtr(p + 0x018), ReversePrism.DataModels.RequestCacheBinding.FromPointer); // 024667B4C188 0x18 S_DefaultHttpBinding        ( 000186664670 ModelClassType RequestCacheBinding RequestCacheBinding RequestCacheBinding Pointer )
            value.S_DefaultFtpBinding                       = GetObject<RequestCacheBinding>(new IntPtr(p + 0x020), ReversePrism.DataModels.RequestCacheBinding.FromPointer); // 024667B4C1A8 0x20 S_DefaultFtpBinding         ( 000186664670 ModelClassType RequestCacheBinding RequestCacheBinding RequestCacheBinding Pointer )

            return value;
        }
    }
}
