using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MinTemperatureLevel                      float IL2CPP_TYPE_R4
    // 000 MaxTemperatureLevel                      float IL2CPP_TYPE_R4
    // 000 MinCpuPerformanceLevel                   int IL2CPP_TYPE_I4
    // 000 MinGpuPerformanceLevel                   int IL2CPP_TYPE_I4
    // 000 UnknownPerformanceLevel                  int IL2CPP_TYPE_I4
    // 000 DefaultAverageFrameCount                 int IL2CPP_TYPE_I4
    public partial class Constants : DataModel
    {

        public static Constants? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Constants() { Pointer= p0 };


            return value;
        }
    }
}
