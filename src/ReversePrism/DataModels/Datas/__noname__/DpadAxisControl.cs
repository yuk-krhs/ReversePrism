using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 130 Component                                ModelPrimitiveType int int int Int32
    public partial class DpadAxisControl : DataModel
    {
        public int                                      Component                               { get; set; }

        public static DpadAxisControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DpadAxisControl() { Pointer= p0 };

            value.Component                                 = GetInt32(new IntPtr(p + 0x130)); // 0x130 Component                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
