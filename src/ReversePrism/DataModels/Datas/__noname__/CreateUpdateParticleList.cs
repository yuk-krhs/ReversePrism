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
    // 030 stepParticleIndexCounter                 NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 040 stepParticleIndexArray                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 050 stepBaseLineIndexCounter                 NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 060 stepBaseLineIndexArray                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 070 stepTriangleBendIndexCounter             NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 080 stepTriangleBendIndexArray               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 090 stepEdgeCollisionIndexCounter            NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 0A0 stepEdgeCollisionIndexArray              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 0B0 motionParticleIndexCounter               NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 0C0 motionParticleIndexArray                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 0D0 selfParticleCounter                      NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 0E0 selfParticleIndexArray                   NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 0F0 selfPointTriangleCounter                 NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 100 selfPointTriangleIndexArray              NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 110 selfEdgeEdgeCounter                      NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 120 selfEdgeEdgeIndexArray                   NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 130 selfTrianglePointCounter                 NativeReference`1<int> IL2CPP_TYPE_GENERICINST
    // 140 selfTrianglePointIndexArray              NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    public partial class CreateUpdateParticleList : DataModel
    {

        public static CreateUpdateParticleList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateUpdateParticleList() { Pointer= p0 };


            return value;
        }
    }
}
