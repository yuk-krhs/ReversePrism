using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 totalCount                               int IL2CPP_TYPE_I4
    // 010 Tag                                      000186672F10 ModelPrimitiveType string string string String
    public partial class ScopedResourceLoader : DataModel
    {
        public string                                   Tag                                     { get; set; }

        public static ScopedResourceLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScopedResourceLoader() { Pointer= p0 };

            value.Tag                                       = GetString(new IntPtr(p + 0x010)); // 0245A3AD0900 0x10 Tag                         ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
