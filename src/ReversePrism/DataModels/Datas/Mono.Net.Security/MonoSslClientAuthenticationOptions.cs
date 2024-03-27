using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Options                                  00018655C390 ModelClassType SslClientAuthenticationOptions SslClientAuthenticationOptions SslClientAuthenticationOptions Pointer
    public partial class MonoSslClientAuthenticationOptions
    {
        public SslClientAuthenticationOptions?          Options                                 { get; set; }

        public static MonoSslClientAuthenticationOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoSslClientAuthenticationOptions();

            value.Options                                   = GetObject<SslClientAuthenticationOptions>(new IntPtr(p + 0x018), ReversePrism.DataModels.SslClientAuthenticationOptions.FromPointer); // 0270D79280C0 0x18 Options                     ( 00018655C390 ModelClassType SslClientAuthenticationOptions SslClientAuthenticationOptions SslClientAuthenticationOptions Pointer )

            return value;
        }
    }
}
