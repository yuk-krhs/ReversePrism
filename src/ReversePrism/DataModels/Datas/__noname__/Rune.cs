using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveType int int int Int32
    public partial class Rune : DataModel
    {
        public int                                      Value                                   { get; set; }

        public static Rune? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Rune() { Pointer= p0 };

            value.Value                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
