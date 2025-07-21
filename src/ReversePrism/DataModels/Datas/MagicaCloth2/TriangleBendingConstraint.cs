using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 trianglePairArray                        ExNativeArray`1<ulong> IL2CPP_TYPE_GENERICINST
    // 018 restAngleOrVolumeArray                   ExNativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 020 signOrVolumeArray                        ExNativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 028 writeDataArray                           ExNativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 030 writeIndexArray                          ExNativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 038 writeBuffer                              ExNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 000 VolumeScale                              float IL2CPP_TYPE_R4
    public partial class TriangleBendingConstraint : DataModel
    {

        public static TriangleBendingConstraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TriangleBendingConstraint() { Pointer= p0 };


            return value;
        }
    }
}
