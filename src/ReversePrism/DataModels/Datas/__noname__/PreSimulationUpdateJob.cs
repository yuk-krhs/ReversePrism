using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 020 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 030 centerDataArray                          NativeArray`1<CenterData> IL2CPP_TYPE_GENERICINST
    // 040 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 rotations                                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 060 vertexDepths                             NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 070 teamIdArray                              NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 080 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 090 oldPosArray                              NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A0 oldRotArray                              NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 0B0 basePosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0C0 baseRotArray                             NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 0D0 oldPositionArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0E0 oldRotationArray                         NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 0F0 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 100 dispPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 110 velocityArray                            NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 120 realVelocityArray                        NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 130 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 140 staticFrictionArray                      NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 150 collisionNormalArray                     NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class PreSimulationUpdateJob : DataModel
    {

        public static PreSimulationUpdateJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PreSimulationUpdateJob() { Pointer= p0 };


            return value;
        }
    }
}
