using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Attitude                                 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class AttitudeState : DataModel
    {
        public Quaternion                               Attitude                                { get; set; }

        public static AttitudeState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttitudeState() { Pointer= p0 };

            value.Attitude                                  = (Quaternion)GetInt32(new IntPtr(p + 0x010)); // 024667856B60 0x10 Attitude                    ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
