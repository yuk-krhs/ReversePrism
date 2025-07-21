using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      ModelPrimitiveType int int int Int32
    // 014 Max                                      ModelPrimitiveType int int int Int32
    // 018 IsNotNull                                ModelPrimitiveType bool bool bool Bool
    public partial class Range : DataModel
    {
        public int                                      Min                                     { get; set; }
        public int                                      Max                                     { get; set; }
        public bool                                     IsNotNull                               { get; set; }

        public static Range? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Range() { Pointer= p0 };

            value.Min                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 Min                         ( ModelPrimitiveType int int int Int32 )
            value.Max                                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 Max                         ( ModelPrimitiveType int int int Int32 )
            value.IsNotNull                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 IsNotNull                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
