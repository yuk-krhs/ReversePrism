using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Def                                    ModelClassType CinemachineImpulseDefinition CinemachineImpulseDefinition CinemachineImpulseDefinition Pointer
    // 018 M_Velocity                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 M_StartTimeOffset                        ModelPrimitiveType float float float Single
    public partial class LegacySignalSource : DataModel
    {
        public CinemachineImpulseDefinition?            M_Def                                   { get; set; }
        public Vector3                                  M_Velocity                              { get; set; }
        public float                                    M_StartTimeOffset                       { get; set; }

        public static LegacySignalSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacySignalSource() { Pointer= p0 };

            value.M_Def                                     = GetObject<CinemachineImpulseDefinition>(new IntPtr(p + 0x010), ReversePrism.DataModels.CinemachineImpulseDefinition.FromPointer); // 0x10 M_Def                       ( ModelClassType CinemachineImpulseDefinition CinemachineImpulseDefinition CinemachineImpulseDefinition Pointer )
            value.M_Velocity                                = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Velocity                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_StartTimeOffset                         = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_StartTimeOffset           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
