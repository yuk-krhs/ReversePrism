using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_default                                Latin1Encoding IL2CPP_TYPE_CLASS
    // 008 arrayCharBestFit                         char[] IL2CPP_TYPE_SZARRAY
    public partial class Latin1Encoding
    {

        public static Latin1Encoding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Latin1Encoding();


            return value;
        }
    }
}
