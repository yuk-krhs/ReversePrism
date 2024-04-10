using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tag                                      000186671910 ModelPrimitiveType string string string String
    public partial class ResourceTag : DataModel
    {
        public string                                   Tag                                     { get; set; }

        public static ResourceTag? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceTag() { Pointer= p0 };

            value.Tag                                       = GetString(new IntPtr(p + 0x010)); // 0245A3973770 0x10 Tag                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
