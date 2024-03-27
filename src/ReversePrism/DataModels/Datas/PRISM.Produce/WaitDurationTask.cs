using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TimeScale                                0001866656B0 ModelPrimitiveType float float float Single
    public partial class WaitDurationTask
    {
        public float                                    TimeScale                               { get; set; }

        public static WaitDurationTask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitDurationTask();

            value.TimeScale                                 = GetSingle(new IntPtr(p + 0x010)); // 0270D5B07DD0 0x10 TimeScale                   ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
