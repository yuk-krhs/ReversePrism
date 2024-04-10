using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Spawner                                AdaptivePerformanceManagerSpawner IL2CPP_TYPE_CLASS
    public partial class AdaptivePerformanceInitializer : DataModel
    {

        public static AdaptivePerformanceInitializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceInitializer() { Pointer= p0 };


            return value;
        }
    }
}
