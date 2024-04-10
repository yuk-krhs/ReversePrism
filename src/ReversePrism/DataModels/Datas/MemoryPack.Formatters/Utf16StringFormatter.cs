using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  Utf16StringFormatter IL2CPP_TYPE_CLASS
    public partial class Utf16StringFormatter : DataModel
    {

        public static Utf16StringFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Utf16StringFormatter() { Pointer= p0 };


            return value;
        }
    }
}
