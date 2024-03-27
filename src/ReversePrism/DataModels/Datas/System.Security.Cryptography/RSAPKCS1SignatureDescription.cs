using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 HashAlgorithm                            000186671910 ModelPrimitiveType string string string String
    public partial class RSAPKCS1SignatureDescription
    {
        public string                                   HashAlgorithm                           { get; set; }

        public static RSAPKCS1SignatureDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RSAPKCS1SignatureDescription();

            value.HashAlgorithm                             = GetString(new IntPtr(p + 0x030)); // 0270042336A0 0x30 HashAlgorithm               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
