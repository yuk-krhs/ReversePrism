using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 driver                                   IConsoleDriver IL2CPP_TYPE_CLASS
    // 008 is_console                               bool IL2CPP_TYPE_BOOLEAN
    // 009 called_isatty                            bool IL2CPP_TYPE_BOOLEAN
    public partial class ConsoleDriver : DataModel
    {

        public static ConsoleDriver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConsoleDriver() { Pointer= p0 };


            return value;
        }
    }
}
