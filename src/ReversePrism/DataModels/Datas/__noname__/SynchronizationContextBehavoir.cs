using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 callbackQueue                            Queue`1<Tuple`2<SendOrPostCallback, <object>>> IL2CPP_TYPE_GENERICINST
    public partial class SynchronizationContextBehavoir
    {

        public static SynchronizationContextBehavoir? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SynchronizationContextBehavoir();


            return value;
        }
    }
}
