using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FirstName                                sbyte IL2CPP_TYPE_U1
    // 000 Name                                     sbyte IL2CPP_TYPE_U1
    // 000 None                                     sbyte IL2CPP_TYPE_U1
    public partial class CharType
    {

        public static CharType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharType();


            return value;
        }
    }
}
