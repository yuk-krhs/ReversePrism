using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PanicFunction                            PanicFunction_ IL2CPP_TYPE_CLASS
    public partial class JobsUtility
    {

        public static JobsUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JobsUtility();


            return value;
        }
    }
}
