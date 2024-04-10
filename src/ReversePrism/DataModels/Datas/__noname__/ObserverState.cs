using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 observers                                InlinedArray`1<IObserver`1<InputEventPtr>> IL2CPP_TYPE_GENERICINST
    // 028 onEventDelegate                          Action`2<InputEventPtr, InputDevice> IL2CPP_TYPE_GENERICINST
    public partial class ObserverState : DataModel
    {

        public static ObserverState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObserverState() { Pointer= p0 };


            return value;
        }
    }
}
