using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 worldToViews                             Fixed2`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 090 reflectionProbes                         NativeArray`1<VisibleReflectionProbe> IL2CPP_TYPE_GENERICINST
    // 0A0 minMaxZs                                 NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    public partial class ReflectionProbeMinMaxZJob : DataModel
    {

        public static ReflectionProbeMinMaxZJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionProbeMinMaxZJob() { Pointer= p0 };


            return value;
        }
    }
}
