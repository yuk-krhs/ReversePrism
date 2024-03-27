using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_CollectUrlPattern                      string IL2CPP_TYPE_STRING
    public partial class Ua2CoreInitializeCallback
    {

        public static Ua2CoreInitializeCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Ua2CoreInitializeCallback();


            return value;
        }
    }
}
