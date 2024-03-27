using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Origin                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_Direction                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class Ray
    {
        public Vector3                                  M_Origin                                { get; set; }
        public Vector3                                  M_Direction                             { get; set; }

        public static Ray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Ray();

            value.M_Origin                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0270068A9378 0x10 M_Origin                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Direction                               = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 0270068A9398 0x1C M_Direction                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
