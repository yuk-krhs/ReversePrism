using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_ImpulseDefinition                      ModelClassType CinemachineImpulseDefinition CinemachineImpulseDefinition CinemachineImpulseDefinition Pointer
    // 028 M_DefaultVelocity                        ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class CinemachineImpulseSource : DataModel
    {
        public CinemachineImpulseDefinition?            M_ImpulseDefinition                     { get; set; }
        public Vector3                                  M_DefaultVelocity                       { get; set; }

        public static CinemachineImpulseSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineImpulseSource() { Pointer= p0 };

            value.M_ImpulseDefinition                       = GetObject<CinemachineImpulseDefinition>(new IntPtr(p + 0x020), ReversePrism.DataModels.CinemachineImpulseDefinition.FromPointer); // 0x20 M_ImpulseDefinition         ( ModelClassType CinemachineImpulseDefinition CinemachineImpulseDefinition CinemachineImpulseDefinition Pointer )
            value.M_DefaultVelocity                         = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_DefaultVelocity           ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
