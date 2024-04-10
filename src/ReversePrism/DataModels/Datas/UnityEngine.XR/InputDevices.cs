using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 deviceConnected                          Action`1<InputDevice> IL2CPP_TYPE_GENERICINST
    // 008 deviceDisconnected                       Action`1<InputDevice> IL2CPP_TYPE_GENERICINST
    // 010 deviceConfigChanged                      Action`1<InputDevice> IL2CPP_TYPE_GENERICINST
    public partial class InputDevices : DataModel
    {

        public static InputDevices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputDevices() { Pointer= p0 };


            return value;
        }
    }
}
