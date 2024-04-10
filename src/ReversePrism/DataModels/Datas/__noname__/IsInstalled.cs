using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Ref                                      SharedStatic`1<Long1024> IL2CPP_TYPE_GENERICINST
    public partial class IsInstalled : DataModel
    {

        public static IsInstalled? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IsInstalled() { Pointer= p0 };


            return value;
        }
    }
}
