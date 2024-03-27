using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 INPUT_FORM_OVERFLOW_LENGTH               int IL2CPP_TYPE_I4
    // 000 EPSILON                                  float IL2CPP_TYPE_R4
    public partial class CommonConstant
    {

        public static CommonConstant? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonConstant();


            return value;
        }
    }
}
