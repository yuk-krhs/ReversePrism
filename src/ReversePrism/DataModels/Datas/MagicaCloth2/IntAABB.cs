using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      ModelEnumType int3 int3 int3 Int32
    // 01C Max                                      ModelEnumType int3 int3 int3 Int32
    public partial class IntAABB : DataModel
    {
        public int3                                     Min                                     { get; set; }
        public int3                                     Max                                     { get; set; }

        public static IntAABB? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntAABB() { Pointer= p0 };

            value.Min                                       = (int3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Min                         ( ModelEnumType int3 int3 int3 Int32 )
            value.Max                                       = (int3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Max                         ( ModelEnumType int3 int3 int3 Int32 )

            return value;
        }
    }
}
