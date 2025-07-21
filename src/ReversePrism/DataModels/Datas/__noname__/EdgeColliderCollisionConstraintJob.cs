using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 stepEdgeCollisionIndexArray              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 030 parameterArray                           NativeArray`1<ClothParameters> IL2CPP_TYPE_GENERICINST
    // 040 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 050 vertexDepths                             NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 060 edgeTeamIdArray                          NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 070 edges                                    NativeArray`1<int2> IL2CPP_TYPE_GENERICINST
    // 080 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 090 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 0A0 collisionNormalArray                     NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B0 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0C0 colliderFlagArray                        NativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 0D0 colliderWorkDataArray                    NativeArray`1<WorkData> IL2CPP_TYPE_GENERICINST
    // 0E0 countArray                               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 0F0 sumArray                                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 100 tempFrictionArray                        NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 110 tempNormalArray                          NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class EdgeColliderCollisionConstraintJob : DataModel
    {

        public static EdgeColliderCollisionConstraintJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EdgeColliderCollisionConstraintJob() { Pointer= p0 };


            return value;
        }
    }
}
