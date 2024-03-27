using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    0001865F4260 ModelPrimitiveType int int int Int32
    public partial class Index
    {
        public int                                      Value                                   { get; set; }

        public static Index? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Index();

            value.Value                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D6996268 0x10 Value                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
