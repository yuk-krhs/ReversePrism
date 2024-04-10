using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CarriageReturnLineFeed                   string IL2CPP_TYPE_STRING
    // 000 Empty                                    string IL2CPP_TYPE_STRING
    // 000 CarriageReturn                           char IL2CPP_TYPE_CHAR
    // 000 LineFeed                                 char IL2CPP_TYPE_CHAR
    // 000 Tab                                      char IL2CPP_TYPE_CHAR
    public partial class StringUtils : DataModel
    {

        public static StringUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringUtils() { Pointer= p0 };


            return value;
        }
    }
}
