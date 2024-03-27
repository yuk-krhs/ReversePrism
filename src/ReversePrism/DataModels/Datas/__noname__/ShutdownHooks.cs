using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 staticLock                               <object> IL2CPP_TYPE_OBJECT
    // 008 hooksRegistered                          bool IL2CPP_TYPE_BOOLEAN
    public partial class ShutdownHooks
    {

        public static ShutdownHooks? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShutdownHooks();


            return value;
        }
    }
}
