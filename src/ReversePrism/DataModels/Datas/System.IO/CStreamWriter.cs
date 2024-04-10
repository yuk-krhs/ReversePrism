using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 Driver                                   00018662E6B0 ModelClassType TermInfoDriver TermInfoDriver TermInfoDriver Pointer
    public partial class CStreamWriter : DataModel
    {
        public TermInfoDriver?                          Driver                                  { get; set; }

        public static CStreamWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CStreamWriter() { Pointer= p0 };

            value.Driver                                    = GetObject<TermInfoDriver>(new IntPtr(p + 0x070), ReversePrism.DataModels.TermInfoDriver.FromPointer); // 024666ACBC30 0x70 Driver                      ( 00018662E6B0 ModelClassType TermInfoDriver TermInfoDriver TermInfoDriver Pointer )

            return value;
        }
    }
}
