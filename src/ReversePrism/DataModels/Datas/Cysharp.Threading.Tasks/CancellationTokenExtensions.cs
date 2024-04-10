using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 cancellationTokenCallback                Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 008 disposeCallback                          Action`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class CancellationTokenExtensions : DataModel
    {

        public static CancellationTokenExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CancellationTokenExtensions() { Pointer= p0 };


            return value;
        }
    }
}
