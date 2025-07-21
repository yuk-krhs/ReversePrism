using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Dimensions                               ModelPrimitiveType int int int Int32
    // 014 Bound                                    ModelPrimitiveType bool bool bool Bool
    public partial class ArraySpec : DataModel
    {
        public int                                      Dimensions                              { get; set; }
        public bool                                     Bound                                   { get; set; }

        public static ArraySpec? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArraySpec() { Pointer= p0 };

            value.Dimensions                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 Dimensions                  ( ModelPrimitiveType int int int Int32 )
            value.Bound                                     = GetBool(new IntPtr(p + 0x014)); // 0x14 Bound                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
