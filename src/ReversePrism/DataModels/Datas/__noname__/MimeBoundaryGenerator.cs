using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 id                                       long IL2CPP_TYPE_I8
    // 008 prefix                                   string IL2CPP_TYPE_STRING
    public partial class MimeBoundaryGenerator
    {

        public static MimeBoundaryGenerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MimeBoundaryGenerator();


            return value;
        }
    }
}
