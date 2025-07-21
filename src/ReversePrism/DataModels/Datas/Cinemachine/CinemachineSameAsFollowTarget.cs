using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_Damping                                ModelPrimitiveType float float float Single
    // 02C M_PreviousReferenceOrientation           ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class CinemachineSameAsFollowTarget : DataModel
    {
        public float                                    M_Damping                               { get; set; }
        public Quaternion                               M_PreviousReferenceOrientation          { get; set; }

        public static CinemachineSameAsFollowTarget? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineSameAsFollowTarget() { Pointer= p0 };

            value.M_Damping                                 = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_Damping                   ( ModelPrimitiveType float float float Single )
            value.M_PreviousReferenceOrientation            = (Quaternion)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_PreviousReferenceOrientation ( ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
