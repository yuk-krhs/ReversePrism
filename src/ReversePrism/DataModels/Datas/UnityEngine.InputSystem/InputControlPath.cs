using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Wildcard                                 string IL2CPP_TYPE_STRING
    // 000 DoubleWildcard                           string IL2CPP_TYPE_STRING
    // 000 Separator                                char IL2CPP_TYPE_CHAR
    // 000 SeparatorReplacement                     char IL2CPP_TYPE_CHAR
    public partial class InputControlPath
    {

        public static InputControlPath? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputControlPath();


            return value;
        }
    }
}
