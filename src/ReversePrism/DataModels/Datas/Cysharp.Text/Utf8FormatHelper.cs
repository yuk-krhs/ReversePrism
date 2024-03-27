using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 sp                                       sbyte IL2CPP_TYPE_U1
    public partial class Utf8FormatHelper
    {

        public static Utf8FormatHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Utf8FormatHelper();


            return value;
        }
    }
}
