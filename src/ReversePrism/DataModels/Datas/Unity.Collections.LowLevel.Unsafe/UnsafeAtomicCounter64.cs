using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Counter                                  IntPtr IL2CPP_TYPE_PTR
    public partial class UnsafeAtomicCounter64
    {

        public static UnsafeAtomicCounter64? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeAtomicCounter64();


            return value;
        }
    }
}
