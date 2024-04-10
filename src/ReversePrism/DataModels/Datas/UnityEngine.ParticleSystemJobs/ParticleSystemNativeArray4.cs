using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 x                                        NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 020 y                                        NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 030 z                                        NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 040 w                                        NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    public partial class ParticleSystemNativeArray4 : DataModel
    {

        public static ParticleSystemNativeArray4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParticleSystemNativeArray4() { Pointer= p0 };


            return value;
        }
    }
}
