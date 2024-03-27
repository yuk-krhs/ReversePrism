using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 observer                                 IObserver`1<InputEventPtr> IL2CPP_TYPE_GENERICINST
    public partial class DisposableObserver
    {

        public static DisposableObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisposableObserver();


            return value;
        }
    }
}
