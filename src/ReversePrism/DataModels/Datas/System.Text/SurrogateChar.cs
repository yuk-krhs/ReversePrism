using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 lowChar                                  char IL2CPP_TYPE_CHAR
    // 012 highChar                                 char IL2CPP_TYPE_CHAR
    // 000 MinValue                                 int IL2CPP_TYPE_I4
    // 000 MaxValue                                 int IL2CPP_TYPE_I4
    // 000 surHighMin                               char IL2CPP_TYPE_CHAR
    // 000 surHighMax                               char IL2CPP_TYPE_CHAR
    // 000 surLowMin                                char IL2CPP_TYPE_CHAR
    // 000 surLowMax                                char IL2CPP_TYPE_CHAR
    public partial class SurrogateChar
    {

        public static SurrogateChar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SurrogateChar();


            return value;
        }
    }
}
