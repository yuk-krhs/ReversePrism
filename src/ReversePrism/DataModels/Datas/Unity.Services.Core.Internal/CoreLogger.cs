using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Tag                                      string IL2CPP_TYPE_STRING
    // 000 VerboseLoggingDefine                     string IL2CPP_TYPE_STRING
    // 000 k_TelemetryLoggingDefine                 string IL2CPP_TYPE_STRING
    public partial class CoreLogger : DataModel
    {

        public static CoreLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreLogger() { Pointer= p0 };


            return value;
        }
    }
}
