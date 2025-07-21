using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_CurrentPointerId                       ModelPrimitiveType int int int Int32
    public partial class PointerManipulator : DataModel
    {
        public int                                      M_CurrentPointerId                      { get; set; }

        public static PointerManipulator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerManipulator() { Pointer= p0 };

            value.M_CurrentPointerId                        = GetInt32(new IntPtr(p + 0x030)); // 0x30 M_CurrentPointerId          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
