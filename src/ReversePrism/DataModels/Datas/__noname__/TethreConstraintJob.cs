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
    // 040 centerDataArray                          NativeArray`1<CenterData> IL2CPP_TYPE_GENERICINST
    // 050 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 060 vertexDepths                             NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 070 vertexRootIndices                        NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 080 teamIdArray                              NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 090 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0A0 velocityPosArray                         NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 0B0 frictionArray                            NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 0C0 stepBasicPositionBuffer                  NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class TethreConstraintJob : DataModel
    {

        public static TethreConstraintJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TethreConstraintJob() { Pointer= p0 };


            return value;
        }
    }
}
