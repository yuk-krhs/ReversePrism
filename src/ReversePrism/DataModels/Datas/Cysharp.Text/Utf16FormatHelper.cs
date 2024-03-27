using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 sp                                       char IL2CPP_TYPE_CHAR
    public partial class Utf16FormatHelper
    {

        public static Utf16FormatHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Utf16FormatHelper();


            return value;
        }
    }
}
