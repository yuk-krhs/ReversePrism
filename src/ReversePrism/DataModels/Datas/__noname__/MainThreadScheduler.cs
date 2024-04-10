using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 scheduleAction                           Action`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class MainThreadScheduler : DataModel
    {

        public static MainThreadScheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainThreadScheduler() { Pointer= p0 };


            return value;
        }
    }
}
