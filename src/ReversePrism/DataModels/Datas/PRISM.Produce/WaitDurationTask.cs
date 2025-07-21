using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TimeScale                                ModelPrimitiveType float float float Single
    public partial class WaitDurationTask : DataModel
    {
        public float                                    TimeScale                               { get; set; }

        public static WaitDurationTask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitDurationTask() { Pointer= p0 };

            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 TimeScale                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
