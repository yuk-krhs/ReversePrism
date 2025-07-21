using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxPoolCount                             int IL2CPP_TYPE_I4
    // 000 pool                                     Stack`1<TemporaryResourceLoader> IL2CPP_TYPE_GENERICINST
    // 010 Tag                                      ModelPrimitiveType string string string String
    public partial class TemporaryResourceLoader : DataModel
    {
        public string                                   Tag                                     { get; set; }

        public static TemporaryResourceLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TemporaryResourceLoader() { Pointer= p0 };

            value.Tag                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Tag                         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
