using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 crctab                                   uint[] IL2CPP_TYPE_SZARRAY
    public partial class Sse4_2 : DataModel
    {

        public static Sse4_2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Sse4_2() { Pointer= p0 };


            return value;
        }
    }
}
