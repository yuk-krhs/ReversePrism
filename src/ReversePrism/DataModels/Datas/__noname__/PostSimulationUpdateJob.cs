using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 020 teamIdArray                              NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 030 framePositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 frameRotations                           NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 050 oldFramePositions                        NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 060 oldFrameRotations                        NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    public partial class PostSimulationUpdateJob : DataModel
    {

        public static PostSimulationUpdateJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostSimulationUpdateJob() { Pointer= p0 };


            return value;
        }
    }
}
