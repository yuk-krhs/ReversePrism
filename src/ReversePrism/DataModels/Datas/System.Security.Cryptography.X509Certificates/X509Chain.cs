using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Impl                                     ModelClassType X509ChainImpl X509ChainImpl X509ChainImpl Pointer
    public partial class X509Chain : DataModel
    {
        public X509ChainImpl?                           Impl                                    { get; set; }

        public static X509Chain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Chain() { Pointer= p0 };

            value.Impl                                      = GetObject<X509ChainImpl>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509ChainImpl.FromPointer); // 0x10 Impl                        ( ModelClassType X509ChainImpl X509ChainImpl X509ChainImpl Pointer )

            return value;
        }
    }
}
