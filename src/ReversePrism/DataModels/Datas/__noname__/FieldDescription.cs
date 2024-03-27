using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 name                                     string IL2CPP_TYPE_STRING
    // 000 ussName                                  string IL2CPP_TYPE_STRING
    // 000 read                                     Func`2<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 write                                    WriteDelegate<<var>, <var>, <var>> IL2CPP_TYPE_GENERICINST
    public partial class FieldDescription
    {

        public static FieldDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldDescription();


            return value;
        }
    }
}
