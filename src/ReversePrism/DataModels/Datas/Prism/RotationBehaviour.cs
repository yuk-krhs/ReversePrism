using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EulerRotation                            ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class RotationBehaviour : DataModel
    {
        public Vector3                                  EulerRotation                           { get; set; }

        public static RotationBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RotationBehaviour() { Pointer= p0 };

            value.EulerRotation                             = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 EulerRotation               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
