using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 runtimeVersion                           string IL2CPP_TYPE_STRING
    // 008 <RealtimeSinceStartupSafe>k__BackingField float IL2CPP_TYPE_R4
    public partial class PlatformInformation
    {

        public static PlatformInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlatformInformation();


            return value;
        }
    }
}
