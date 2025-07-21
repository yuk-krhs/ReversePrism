using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    public partial class TypeHandleRef : DataModel
    {
        public RuntimeTypeHandle                        Value                                   { get; set; }

        public static TypeHandleRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeHandleRef() { Pointer= p0 };

            value.Value                                     = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )

            return value;
        }
    }
}
