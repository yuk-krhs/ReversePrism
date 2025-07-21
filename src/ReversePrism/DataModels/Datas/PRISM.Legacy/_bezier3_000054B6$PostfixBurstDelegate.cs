using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class _bezier3_000054B6$PostfixBurstDelegate : DataModel
    {

        public static _bezier3_000054B6$PostfixBurstDelegate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _bezier3_000054B6$PostfixBurstDelegate() { Pointer= p0 };


            return value;
        }
    }
}
