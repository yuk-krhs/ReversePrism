using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 transformedID                            NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 parentID                                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 030 localToWorldMatrices                     NativeArray`1<Matrix4x4> IL2CPP_TYPE_GENERICINST
    // 040 positions                                NativeArray`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 050 rotations                                NativeArray`1<Quaternion> IL2CPP_TYPE_GENERICINST
    // 060 scales                                   NativeArray`1<Vector3> IL2CPP_TYPE_GENERICINST
    public partial class TransformDispatchData : DataModel
    {

        public static TransformDispatchData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformDispatchData() { Pointer= p0 };


            return value;
        }
    }
}
