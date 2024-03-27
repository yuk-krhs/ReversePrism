using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_value                                  char IL2CPP_TYPE_CHAR
    // 000 MaxValue                                 char IL2CPP_TYPE_CHAR
    // 000 MinValue                                 char IL2CPP_TYPE_CHAR
    // 000 s_categoryForLatin1                      sbyte[] IL2CPP_TYPE_SZARRAY
    // 000 UNICODE_PLANE00_END                      int IL2CPP_TYPE_I4
    // 000 UNICODE_PLANE01_START                    int IL2CPP_TYPE_I4
    // 000 UNICODE_PLANE16_END                      int IL2CPP_TYPE_I4
    // 000 HIGH_SURROGATE_START                     int IL2CPP_TYPE_I4
    // 000 LOW_SURROGATE_END                        int IL2CPP_TYPE_I4
    public partial class Char
    {

        public static Char? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Char();


            return value;
        }
    }
}
