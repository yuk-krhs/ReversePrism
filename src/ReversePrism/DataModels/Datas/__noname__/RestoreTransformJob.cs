using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 flagList                                 NativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 020 localPositionArray                       NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 localRotationArray                       NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 040 teamIdArray                              NativeArray`1<short> IL2CPP_TYPE_GENERICINST
    // 050 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    public partial class RestoreTransformJob : DataModel
    {

        public static RestoreTransformJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RestoreTransformJob() { Pointer= p0 };


            return value;
        }
    }
}
