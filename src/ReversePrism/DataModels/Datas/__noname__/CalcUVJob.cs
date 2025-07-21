using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 020 aabb                                     NativeReference`1<AABB> IL2CPP_TYPE_GENERICINST
    // 030 uvs                                      NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    public partial class CalcUVJob : DataModel
    {

        public static CalcUVJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcUVJob() { Pointer= p0 };


            return value;
        }
    }
}
