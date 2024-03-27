using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 newline                                  bool[] IL2CPP_TYPE_SZARRAY
    // 008 newlineChar                              char IL2CPP_TYPE_CHAR
    public partial class UnexceptionalStreamReader
    {

        public static UnexceptionalStreamReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnexceptionalStreamReader();


            return value;
        }
    }
}
