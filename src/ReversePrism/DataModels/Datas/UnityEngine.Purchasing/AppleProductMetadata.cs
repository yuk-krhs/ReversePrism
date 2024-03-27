using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 IsFamilyShareable                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class AppleProductMetadata
    {
        public bool                                     IsFamilyShareable                       { get; set; }

        public static AppleProductMetadata? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppleProductMetadata();

            value.IsFamilyShareable                         = GetBool(new IntPtr(p + 0x040)); // 0270069138C8 0x40 IsFamilyShareable           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
