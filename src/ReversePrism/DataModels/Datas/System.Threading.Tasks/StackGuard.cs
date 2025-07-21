using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_inliningDepth                          ModelPrimitiveType int int int Int32
    // 000 MAX_UNCHECKED_INLINING_DEPTH             int IL2CPP_TYPE_I4
    public partial class StackGuard : DataModel
    {
        public int                                      M_inliningDepth                         { get; set; }

        public static StackGuard? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackGuard() { Pointer= p0 };

            value.M_inliningDepth                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_inliningDepth             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
