using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NullCount                                0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class ObjectNull
    {
        public int                                      NullCount                               { get; set; }

        public static ObjectNull? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectNull();

            value.NullCount                                 = GetInt32(new IntPtr(p + 0x010)); // 0270D6C33248 0x10 NullCount                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
