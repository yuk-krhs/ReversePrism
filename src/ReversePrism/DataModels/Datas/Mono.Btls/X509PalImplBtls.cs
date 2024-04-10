using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Provider                                 0001866401C0 ModelClassType MonoBtlsProvider MonoBtlsProvider MonoBtlsProvider Pointer
    public partial class X509PalImplBtls : DataModel
    {
        public MonoBtlsProvider?                        Provider                                { get; set; }

        public static X509PalImplBtls? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509PalImplBtls() { Pointer= p0 };

            value.Provider                                  = GetObject<MonoBtlsProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.MonoBtlsProvider.FromPointer); // 0246679CD050 0x10 Provider                    ( 0001866401C0 ModelClassType MonoBtlsProvider MonoBtlsProvider MonoBtlsProvider Pointer )

            return value;
        }
    }
}
