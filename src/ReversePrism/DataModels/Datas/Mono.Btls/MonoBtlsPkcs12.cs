using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PrivateKey                               00018663F7F0 ModelClassType MonoBtlsKey MonoBtlsKey MonoBtlsKey Pointer
    public partial class MonoBtlsPkcs12
    {
        public MonoBtlsKey?                             PrivateKey                              { get; set; }

        public static MonoBtlsPkcs12? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsPkcs12();

            value.PrivateKey                                = GetObject<MonoBtlsKey>(new IntPtr(p + 0x020), ReversePrism.DataModels.MonoBtlsKey.FromPointer); // 0270D7944890 0x20 PrivateKey                  ( 00018663F7F0 ModelClassType MonoBtlsKey MonoBtlsKey MonoBtlsKey Pointer )

            return value;
        }
    }
}
