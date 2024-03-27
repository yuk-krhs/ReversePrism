using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Unit                                     0001865A49E0 ModelEnumType Unit Unit Unit Int32
    // 014 Value                                    000186666050 ModelPrimitiveType float float float Single
    public partial class Dimension
    {
        public Unit                                     Unit                                    { get; set; }
        public float                                    Value                                   { get; set; }

        public static Dimension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Dimension();

            value.Unit                                      = (Unit)GetInt32(new IntPtr(p + 0x010)); // 027006884810 0x10 Unit                        ( 0001865A49E0 ModelEnumType Unit Unit Unit Int32 )
            value.Value                                     = GetSingle(new IntPtr(p + 0x014)); // 027006884830 0x14 Value                       ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
