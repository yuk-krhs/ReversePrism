using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class BoringX509LookupHandle : DataModel
    {

        public static BoringX509LookupHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoringX509LookupHandle() { Pointer= p0 };


            return value;
        }
    }
}
