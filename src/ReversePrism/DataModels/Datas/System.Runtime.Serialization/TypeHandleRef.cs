using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    00018669FE20 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    public partial class TypeHandleRef
    {
        public RuntimeTypeHandle                        Value                                   { get; set; }

        public static TypeHandleRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeHandleRef();

            value.Value                                     = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x010)); // 027004C79058 0x10 Value                       ( 00018669FE20 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )

            return value;
        }
    }
}
