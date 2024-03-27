using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Http                                     Extension`2<MethodOptions, HttpRule> IL2CPP_TYPE_GENERICINST
    public partial class AnnotationsExtensions
    {

        public static AnnotationsExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnotationsExtensions();


            return value;
        }
    }
}
