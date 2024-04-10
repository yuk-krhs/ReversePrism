using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 useUWPFallback                           bool IL2CPP_TYPE_BOOLEAN
    public partial class Kernel32 : DataModel
    {

        public static Kernel32? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Kernel32() { Pointer= p0 };


            return value;
        }
    }
}
