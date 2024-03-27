using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 valueChangeCallback                      Action`4<InputControl, double, InputEventPtr, long> IL2CPP_TYPE_GENERICINST
    // 018 timerExpiredCallback                     Action`4<InputControl, double, long, int> IL2CPP_TYPE_GENERICINST
    public partial class StateChangeMonitorDelegate
    {

        public static StateChangeMonitorDelegate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StateChangeMonitorDelegate();


            return value;
        }
    }
}
