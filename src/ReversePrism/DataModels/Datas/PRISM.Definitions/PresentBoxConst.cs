using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 OnceMaxItems                             int IL2CPP_TYPE_I4
    // 000 HistoryMasItems                          int IL2CPP_TYPE_I4
    // 000 ResourceTagName                          string IL2CPP_TYPE_STRING
    public partial class PresentBoxConst
    {

        public static PresentBoxConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresentBoxConst();


            return value;
        }
    }
}
