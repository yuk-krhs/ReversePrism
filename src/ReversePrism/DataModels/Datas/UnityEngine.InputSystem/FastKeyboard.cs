using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 metadata                                 string IL2CPP_TYPE_STRING
    public partial class FastKeyboard : DataModel
    {

        public static FastKeyboard? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FastKeyboard() { Pointer= p0 };


            return value;
        }
    }
}
