using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AngularVelocity                          0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class GyroscopeState
    {
        public Vector3                                  AngularVelocity                         { get; set; }

        public static GyroscopeState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GyroscopeState();

            value.AngularVelocity                           = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0270D77FE900 0x10 AngularVelocity             ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
