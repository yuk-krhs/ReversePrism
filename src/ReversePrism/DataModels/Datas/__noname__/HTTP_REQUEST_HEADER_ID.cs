using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_Strings                                string[] IL2CPP_TYPE_SZARRAY
    public partial class HTTP_REQUEST_HEADER_ID
    {

        public static HTTP_REQUEST_HEADER_ID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HTTP_REQUEST_HEADER_ID();


            return value;
        }
    }
}
