using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class Hash128Long_00000A6D$PostfixBurstDelegate
    {

        public static Hash128Long_00000A6D$PostfixBurstDelegate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Hash128Long_00000A6D$PostfixBurstDelegate();


            return value;
        }
    }
}
