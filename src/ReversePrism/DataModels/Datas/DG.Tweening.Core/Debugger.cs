using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _logPriority                             int IL2CPP_TYPE_I4
    // 000 _LogPrefix                               string IL2CPP_TYPE_STRING
    public partial class Debugger : DataModel
    {

        public static Debugger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Debugger() { Pointer= p0 };


            return value;
        }
    }
}
