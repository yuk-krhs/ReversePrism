using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Shared                                   int IL2CPP_TYPE_I4
    // 000 WhenPaused                               int IL2CPP_TYPE_I4
    // 000 ProduceIngame                            int IL2CPP_TYPE_I4
    // 000 DefaultRenderFPS                         int IL2CPP_TYPE_I4
    // 000 PowerSavingRenderFPS                     int IL2CPP_TYPE_I4
    public partial class FrameRateConstants
    {

        public static FrameRateConstants? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameRateConstants();


            return value;
        }
    }
}
