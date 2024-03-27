using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 Delta                                    0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class WheelEvent
    {
        public Vector3                                  Delta                                   { get; set; }

        public static WheelEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WheelEvent();

            value.Delta                                     = (Vector3)GetInt32(new IntPtr(p + 0x0C0)); // 02700677FEC0 0xC0 Delta                       ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
