using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TypeCount                                int IL2CPP_TYPE_I4
    // 010 indexArray                               ExNativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 018 dataArray                                ExNativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 020 distanceArray                            ExNativeArray`1<float> IL2CPP_TYPE_GENERICINST
    public partial class DistanceConstraint : DataModel
    {

        public static DistanceConstraint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DistanceConstraint() { Pointer= p0 };


            return value;
        }
    }
}
