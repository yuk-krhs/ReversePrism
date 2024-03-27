using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Nop                                      Action IL2CPP_TYPE_CLASS
    // 008 Throw                                    Action`1<Exception> IL2CPP_TYPE_GENERICINST
    public partial class Stubs
    {

        public static Stubs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Stubs();


            return value;
        }
    }
}
