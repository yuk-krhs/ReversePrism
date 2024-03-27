using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 S2AUTH_RESULT_SUCCESS                    int IL2CPP_TYPE_I4
    // 000 S2AUTH_RESULT_RETRY                      int IL2CPP_TYPE_I4
    // 000 S2AUTH_RESULT_FAIL                       int IL2CPP_TYPE_I4
    public partial class S2Auth
    {

        public static S2Auth? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new S2Auth();


            return value;
        }
    }
}
