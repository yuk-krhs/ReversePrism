using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 Index                                    0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ArrayPropertyDescriptor
    {
        public int                                      Index                                   { get; set; }

        public static ArrayPropertyDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArrayPropertyDescriptor();

            value.Index                                     = GetInt32(new IntPtr(p + 0x098)); // 0270D7B150F8 0x98 Index                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
