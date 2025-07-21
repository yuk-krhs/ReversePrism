using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Val                                      ModelPrimitiveType int int int Int32
    public partial class FieldOffsetAttribute : DataModel
    {
        public int                                      Val                                     { get; set; }

        public static FieldOffsetAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldOffsetAttribute() { Pointer= p0 };

            value.Val                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 Val                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
