using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ctrlHandlerAdded                         bool IL2CPP_TYPE_BOOLEAN
    // 008 cancelHandler                            WindowsCancelHandler IL2CPP_TYPE_CLASS
    public partial class WindowsConsole
    {

        public static WindowsConsole? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WindowsConsole();


            return value;
        }
    }
}
