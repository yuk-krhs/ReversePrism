using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dimensions                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Bound                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ArraySpec
    {
        public int                                      Dimensions                              { get; set; }
        public bool                                     Bound                                   { get; set; }

        public static ArraySpec? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArraySpec();

            value.Dimensions                                = GetInt32(new IntPtr(p + 0x010)); // 0270D6AA1438 0x10 Dimensions                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Bound                                     = GetBool(new IntPtr(p + 0x014)); // 0270D6AA1458 0x14 Bound                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
