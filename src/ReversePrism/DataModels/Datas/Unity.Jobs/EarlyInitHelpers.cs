using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_PendingDelegates                       List`1<EarlyInitFunction> IL2CPP_TYPE_GENERICINST
    public partial class EarlyInitHelpers : DataModel
    {

        public static EarlyInitHelpers? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EarlyInitHelpers() { Pointer= p0 };


            return value;
        }
    }
}
