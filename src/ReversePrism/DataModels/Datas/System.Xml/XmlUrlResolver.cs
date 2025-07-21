using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_DownloadManager                        <object> IL2CPP_TYPE_OBJECT
    // 010 Credentials                              ModelClassType ICredentials ICredentials ICredentials Pointer
    // 018 Proxy                                    ModelClassType IWebProxy IWebProxy IWebProxy Pointer
    // 020 CachePolicy                              ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer
    public partial class XmlUrlResolver : DataModel
    {
        public ICredentials?                            Credentials                             { get; set; }
        public IWebProxy?                               Proxy                                   { get; set; }
        public RequestCachePolicy?                      CachePolicy                             { get; set; }

        public static XmlUrlResolver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlUrlResolver() { Pointer= p0 };

            value.Credentials                               = GetObject<ICredentials>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICredentials.FromPointer); // 0x10 Credentials                 ( ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.Proxy                                     = GetObject<IWebProxy>(new IntPtr(p + 0x018), ReversePrism.DataModels.IWebProxy.FromPointer); // 0x18 Proxy                       ( ModelClassType IWebProxy IWebProxy IWebProxy Pointer )
            value.CachePolicy                               = GetObject<RequestCachePolicy>(new IntPtr(p + 0x020), ReversePrism.DataModels.RequestCachePolicy.FromPointer); // 0x20 CachePolicy                 ( ModelClassType RequestCachePolicy RequestCachePolicy RequestCachePolicy Pointer )

            return value;
        }
    }
}
