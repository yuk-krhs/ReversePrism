using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 fallbackVersion                          string IL2CPP_TYPE_STRING
    // 000 url                                      string IL2CPP_TYPE_STRING
    public partial class DocumentationInfo
    {

        public static DocumentationInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DocumentationInfo();


            return value;
        }
    }
}
