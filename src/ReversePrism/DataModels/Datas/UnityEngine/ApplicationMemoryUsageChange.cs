using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemoryUsage                              0001866D0360 ModelEnumType ApplicationMemoryUsage ApplicationMemoryUsage ApplicationMemoryUsage Int32
    public partial class ApplicationMemoryUsageChange : DataModel
    {
        public ApplicationMemoryUsage                   MemoryUsage                             { get; set; }

        public static ApplicationMemoryUsageChange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ApplicationMemoryUsageChange() { Pointer= p0 };

            value.MemoryUsage                               = (ApplicationMemoryUsage)GetInt32(new IntPtr(p + 0x010)); // 0245A6868CB0 0x10 MemoryUsage                 ( 0001866D0360 ModelEnumType ApplicationMemoryUsage ApplicationMemoryUsage ApplicationMemoryUsage Int32 )

            return value;
        }
    }
}
