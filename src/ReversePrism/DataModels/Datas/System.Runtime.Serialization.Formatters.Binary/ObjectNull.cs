using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NullCount                                ModelPrimitiveType int int int Int32
    public partial class ObjectNull : DataModel
    {
        public int                                      NullCount                               { get; set; }

        public static ObjectNull? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectNull() { Pointer= p0 };

            value.NullCount                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 NullCount                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
