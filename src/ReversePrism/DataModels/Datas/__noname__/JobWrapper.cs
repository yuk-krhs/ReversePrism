using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 outputIndices                            NativeList`1<int> IL2CPP_TYPE_GENERICINST
    // 000 appendCount                              int IL2CPP_TYPE_I4
    // 000 JobData                                  <var> IL2CPP_TYPE_VAR
    public partial class JobWrapper : DataModel
    {

        public static JobWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JobWrapper() { Pointer= p0 };


            return value;
        }
    }
}
