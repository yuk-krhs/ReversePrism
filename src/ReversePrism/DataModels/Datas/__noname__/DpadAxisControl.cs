using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 130 Component                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class DpadAxisControl
    {
        public int                                      Component                               { get; set; }

        public static DpadAxisControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DpadAxisControl();

            value.Component                                 = GetInt32(new IntPtr(p + 0x130)); // 027003395718 0x130 Component                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
