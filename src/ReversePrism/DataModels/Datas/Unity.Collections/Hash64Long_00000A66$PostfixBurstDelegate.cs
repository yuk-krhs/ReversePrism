using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class Hash64Long_00000A66$PostfixBurstDelegate : DataModel
    {

        public static Hash64Long_00000A66$PostfixBurstDelegate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Hash64Long_00000A66$PostfixBurstDelegate() { Pointer= p0 };


            return value;
        }
    }
}
