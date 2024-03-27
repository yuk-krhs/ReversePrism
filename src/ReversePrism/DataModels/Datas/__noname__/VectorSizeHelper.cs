using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _placeholder                             Vector`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 _byte                                    sbyte IL2CPP_TYPE_U1
    public partial class VectorSizeHelper
    {

        public static VectorSizeHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VectorSizeHelper();


            return value;
        }
    }
}
