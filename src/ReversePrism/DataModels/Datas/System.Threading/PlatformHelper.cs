using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_processorCount                         int IL2CPP_TYPE_I4
    // 004 s_lastProcessorCountRefreshTicks         int IL2CPP_TYPE_I4
    // 008 IsSingleProcessor                        bool IL2CPP_TYPE_BOOLEAN
    public partial class PlatformHelper : DataModel
    {

        public static PlatformHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlatformHelper() { Pointer= p0 };


            return value;
        }
    }
}
