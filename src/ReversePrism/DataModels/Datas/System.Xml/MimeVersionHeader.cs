using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  MimeVersionHeader IL2CPP_TYPE_CLASS
    // 020 Version                                  000186671910 ModelPrimitiveType string string string String
    public partial class MimeVersionHeader : DataModel
    {
        public string                                   Version                                 { get; set; }

        public static MimeVersionHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MimeVersionHeader() { Pointer= p0 };

            value.Version                                   = GetString(new IntPtr(p + 0x020)); // 024667CF01C8 0x20 Version                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
