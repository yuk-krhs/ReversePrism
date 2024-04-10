using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 invokeWithoutContextCallback             Action`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class CallbackHelper : DataModel
    {

        public static CallbackHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallbackHelper() { Pointer= p0 };


            return value;
        }
    }
}
