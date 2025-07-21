using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 teamIdArray                              ExNativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 000 Flag_Valid                               sbyte IL2CPP_TYPE_U1
    // 000 Flag_Enable                              sbyte IL2CPP_TYPE_U1
    // 000 Flag_Reset                               sbyte IL2CPP_TYPE_U1
    // 018 flagArray                                ExNativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 020 centerArray                              ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 sizeArray                                ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 framePositions                           ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 038 frameRotations                           ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 040 frameScales                              ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 048 oldFramePositions                        ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 oldFrameRotations                        ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 058 nowPositions                             ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 nowRotations                             ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 068 oldPositions                             ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 070 oldRotations                             ExNativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 078 colliderSet                              HashSet`1<ColliderComponent> IL2CPP_TYPE_GENERICINST
    // 080 IsValid                                  ModelPrimitiveType bool bool bool Bool
    // 088 workDataArray                            ExNativeArray`1<WorkData> IL2CPP_TYPE_GENERICINST
    public partial class ColliderManager : DataModel
    {
        public bool                                     IsValid                                 { get; set; }

        public static ColliderManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColliderManager() { Pointer= p0 };

            value.IsValid                                   = GetBool(new IntPtr(p + 0x080)); // 0x80 IsValid                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
