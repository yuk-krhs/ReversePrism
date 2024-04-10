using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 newline_split                            string[] IL2CPP_TYPE_SZARRAY
    public partial class X509Certificate2Collection : DataModel
    {

        public static X509Certificate2Collection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509Certificate2Collection() { Pointer= p0 };


            return value;
        }
    }
}
