using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_isDisableCachingInitialized            bool IL2CPP_TYPE_BOOLEAN
    // 001 s_disableCaching                         bool IL2CPP_TYPE_BOOLEAN
    // 008 s_syncObject                             <object> IL2CPP_TYPE_OBJECT
    public partial class LocalAppContext : DataModel
    {

        public static LocalAppContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalAppContext() { Pointer= p0 };


            return value;
        }
    }
}
