using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Exception                              0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 018 m_stackTrace                             <object> IL2CPP_TYPE_OBJECT
    public partial class ExceptionDispatchInfo
    {
        public Exception?                               M_Exception                             { get; set; }

        public static ExceptionDispatchInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExceptionDispatchInfo();

            value.M_Exception                               = GetObject<Exception>(new IntPtr(p + 0x010), ReversePrism.DataModels.Exception.FromPointer); // 0270D6962BB8 0x10 M_Exception                 ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )

            return value;
        }
    }
}
