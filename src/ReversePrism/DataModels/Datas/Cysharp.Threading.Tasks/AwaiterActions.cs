using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InvokeContinuationDelegate               Action`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class AwaiterActions : DataModel
    {

        public static AwaiterActions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwaiterActions() { Pointer= p0 };


            return value;
        }
    }
}
