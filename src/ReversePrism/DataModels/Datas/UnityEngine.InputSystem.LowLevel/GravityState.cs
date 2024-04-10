using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Gravity                                  0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class GravityState : DataModel
    {
        public Vector3                                  Gravity                                 { get; set; }

        public static GravityState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GravityState() { Pointer= p0 };

            value.Gravity                                   = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 024667856A30 0x10 Gravity                     ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
