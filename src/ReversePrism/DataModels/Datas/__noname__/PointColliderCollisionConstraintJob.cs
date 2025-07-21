using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 stepParticleIndexArray                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 030 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 040 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 050 vertexDepths                             NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 060 teamIdArray                              NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 070 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 080 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 090 collisionNormalArray                     NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A0 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B0 basePosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0C0 colliderFlagArray                        NativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 0D0 colliderWorkDataArray                    NativeArray`1<WorkData> IL2CPP_TYPE_GENERICINST
    public partial class PointColliderCollisionConstraintJob : DataModel
    {

        public static PointColliderCollisionConstraintJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointColliderCollisionConstraintJob() { Pointer= p0 };


            return value;
        }
    }
}
