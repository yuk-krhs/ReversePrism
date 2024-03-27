using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     00018669FE20 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32
    // 018 Value                                    <int> IL2CPP_TYPE_I
    // 020 Type                                     <int> IL2CPP_TYPE_I
    public partial class TypedReference
    {
        public RuntimeTypeHandle                        Type                                    { get; set; }

        public static TypedReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypedReference();

            value.Type                                      = (RuntimeTypeHandle)GetInt32(new IntPtr(p + 0x010)); // 0270D6A62DC8 0x10 Type                        ( 00018669FE20 ModelEnumType RuntimeTypeHandle RuntimeTypeHandle RuntimeTypeHandle Int32 )

            return value;
        }
    }
}
