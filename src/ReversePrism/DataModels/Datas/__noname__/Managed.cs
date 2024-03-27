using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TryFunctionDelegates                     TryFunction[] IL2CPP_TYPE_SZARRAY
    public partial class Managed
    {

        public static Managed? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Managed();


            return value;
        }
    }
}
