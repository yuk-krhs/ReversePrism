using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Counter                                  0001865F7700 ModelPrimitiveType long long long Int64
    public partial class AtomicCounter : DataModel
    {
        public long                                     Counter                                 { get; set; }

        public static AtomicCounter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AtomicCounter() { Pointer= p0 };

            value.Counter                                   = GetInt64(new IntPtr(p + 0x010)); // 0245A40AD820 0x10 Counter                     ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
