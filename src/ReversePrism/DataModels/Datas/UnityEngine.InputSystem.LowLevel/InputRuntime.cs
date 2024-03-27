using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               IInputRuntime IL2CPP_TYPE_CLASS
    // 008 s_CurrentTimeOffsetToRealtimeSinceStartup double IL2CPP_TYPE_R8
    public partial class InputRuntime
    {

        public static InputRuntime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputRuntime();


            return value;
        }
    }
}
