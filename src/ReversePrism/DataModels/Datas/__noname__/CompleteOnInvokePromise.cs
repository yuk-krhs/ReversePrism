using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 _tasks                                   IList`1<Task> IL2CPP_TYPE_GENERICINST
    public partial class CompleteOnInvokePromise
    {

        public static CompleteOnInvokePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompleteOnInvokePromise();


            return value;
        }
    }
}
