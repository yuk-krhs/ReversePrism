using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 First                                    char IL2CPP_TYPE_CHAR
    // 012 Last                                     char IL2CPP_TYPE_CHAR
    public partial class SingleRange
    {

        public static SingleRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SingleRange();


            return value;
        }
    }
}
