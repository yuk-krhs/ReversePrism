using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handle                                   00018665CA00 ModelEnumType RuntimeGPtrArrayHandle RuntimeGPtrArrayHandle RuntimeGPtrArrayHandle Int32
    public partial class SafeGPtrArrayHandle
    {
        public RuntimeGPtrArrayHandle                   Handle                                  { get; set; }

        public static SafeGPtrArrayHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SafeGPtrArrayHandle();

            value.Handle                                    = (RuntimeGPtrArrayHandle)GetInt32(new IntPtr(p + 0x010)); // 0270D6930728 0x10 Handle                      ( 00018665CA00 ModelEnumType RuntimeGPtrArrayHandle RuntimeGPtrArrayHandle RuntimeGPtrArrayHandle Int32 )

            return value;
        }
    }
}
