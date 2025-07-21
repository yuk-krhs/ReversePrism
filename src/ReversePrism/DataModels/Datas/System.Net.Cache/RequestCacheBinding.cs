using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_RequestCache                           ModelClassType RequestCache RequestCache RequestCache Pointer
    // 018 M_CacheValidator                         ModelClassType RequestCacheValidator RequestCacheValidator RequestCacheValidator Pointer
    // 020 M_Policy                                 ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer
    public partial class RequestCacheBinding : DataModel
    {
        public RequestCache?                            M_RequestCache                          { get; set; }
        public RequestCacheValidator?                   M_CacheValidator                        { get; set; }
        public RequestCachePolicy?                      M_Policy                                { get; set; }

        public static RequestCacheBinding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestCacheBinding() { Pointer= p0 };

            value.M_RequestCache                            = GetObject<RequestCache>(new IntPtr(p + 0x010), ReversePrism.DataModels.RequestCache.FromPointer); // 0x10 M_RequestCache              ( ModelClassType RequestCache RequestCache RequestCache Pointer )
            value.M_CacheValidator                          = GetObject<RequestCacheValidator>(new IntPtr(p + 0x018), ReversePrism.DataModels.RequestCacheValidator.FromPointer); // 0x18 M_CacheValidator            ( ModelClassType RequestCacheValidator RequestCacheValidator RequestCacheValidator Pointer )
            value.M_Policy                                  = GetObject<RequestCachePolicy>(new IntPtr(p + 0x020), ReversePrism.DataModels.RequestCachePolicy.FromPointer); // 0x20 M_Policy                    ( ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer )

            return value;
        }
    }
}
