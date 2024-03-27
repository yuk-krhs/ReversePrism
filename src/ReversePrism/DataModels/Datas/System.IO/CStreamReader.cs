using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Driver                                   00018662E6B0 ModelClassType TermInfoDriver TermInfoDriver TermInfoDriver Pointer
    public partial class CStreamReader
    {
        public TermInfoDriver?                          Driver                                  { get; set; }

        public static CStreamReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CStreamReader();

            value.Driver                                    = GetObject<TermInfoDriver>(new IntPtr(p + 0x060), ReversePrism.DataModels.TermInfoDriver.FromPointer); // 0270D6E42998 0x60 Driver                      ( 00018662E6B0 ModelClassType TermInfoDriver TermInfoDriver TermInfoDriver Pointer )

            return value;
        }
    }
}
