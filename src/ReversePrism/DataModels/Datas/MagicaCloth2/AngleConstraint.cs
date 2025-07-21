using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 lengthBuffer                             NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 020 localPosBuffer                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 030 localRotBuffer                           NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 040 rotationBuffer                           NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 050 restorationVectorBuffer                  NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    public partial class AngleConstraint : DataModel
    {

        public static AngleConstraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AngleConstraint() { Pointer= p0 };


            return value;
        }
    }
}
