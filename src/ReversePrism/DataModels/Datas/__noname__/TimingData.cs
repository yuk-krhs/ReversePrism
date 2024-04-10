using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 startTimeMs                              long IL2CPP_TYPE_I8
    // 000 durationMs                               int IL2CPP_TYPE_I4
    // 000 easingCurve                              Func`2<float, float> IL2CPP_TYPE_GENERICINST
    // 000 easedProgress                            float IL2CPP_TYPE_R4
    // 000 reversingShorteningFactor                float IL2CPP_TYPE_R4
    // 000 isStarted                                bool IL2CPP_TYPE_BOOLEAN
    // 000 delayMs                                  int IL2CPP_TYPE_I4
    public partial class TimingData : DataModel
    {

        public static TimingData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimingData() { Pointer= p0 };


            return value;
        }
    }
}
