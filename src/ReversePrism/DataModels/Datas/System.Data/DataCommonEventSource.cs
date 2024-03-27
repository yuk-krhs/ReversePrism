using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Log                                      DataCommonEventSource IL2CPP_TYPE_CLASS
    // 008 s_nextScopeId                            long IL2CPP_TYPE_I8
    public partial class DataCommonEventSource
    {

        public static DataCommonEventSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataCommonEventSource();


            return value;
        }
    }
}
