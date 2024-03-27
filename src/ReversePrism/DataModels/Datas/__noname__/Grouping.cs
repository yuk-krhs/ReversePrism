using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 key                                      <var> IL2CPP_TYPE_VAR
    // 000 hashCode                                 int IL2CPP_TYPE_I4
    // 000 elements                                 <var>[] IL2CPP_TYPE_SZARRAY
    // 000 count                                    int IL2CPP_TYPE_I4
    // 000 hashNext                                 Grouping<<var>, <var>> IL2CPP_TYPE_GENERICINST
    // 000 next                                     Grouping<<var>, <var>> IL2CPP_TYPE_GENERICINST
    public partial class Grouping
    {

        public static Grouping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Grouping();


            return value;
        }
    }
}
