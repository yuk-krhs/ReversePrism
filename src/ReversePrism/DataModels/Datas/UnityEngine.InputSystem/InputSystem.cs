using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kAssemblyVersion                         string IL2CPP_TYPE_STRING
    // 000 kDocUrl                                  string IL2CPP_TYPE_STRING
    // 000 s_Manager                                InputManager IL2CPP_TYPE_CLASS
    // 008 s_Remote                                 InputRemoting IL2CPP_TYPE_CLASS
    public partial class InputSystem : DataModel
    {

        public static InputSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputSystem() { Pointer= p0 };


            return value;
        }
    }
}
