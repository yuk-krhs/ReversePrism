using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Impl                                     000186567EF0 ModelClassType X509ChainImpl X509ChainImpl X509ChainImpl Pointer
    public partial class X509Chain
    {
        public X509ChainImpl?                           Impl                                    { get; set; }

        public static X509Chain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Chain();

            value.Impl                                      = GetObject<X509ChainImpl>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509ChainImpl.FromPointer); // 0270D78F5710 0x10 Impl                        ( 000186567EF0 ModelClassType X509ChainImpl X509ChainImpl X509ChainImpl Pointer )

            return value;
        }
    }
}
