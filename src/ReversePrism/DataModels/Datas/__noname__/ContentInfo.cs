using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContentType                              000186671910 ModelPrimitiveType string string string String
    // 018 Content                                  00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer
    public partial class ContentInfo
    {
        public string                                   ContentType                             { get; set; }
        public ASN1?                                    Content                                 { get; set; }

        public static ContentInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentInfo();

            value.ContentType                               = GetString(new IntPtr(p + 0x010)); // 0270DB378770 0x10 ContentType                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Content                                   = GetObject<ASN1>(new IntPtr(p + 0x018), ReversePrism.DataModels.ASN1.FromPointer); // 0270DB378790 0x18 Content                     ( 00018666CD50 ModelClassType ASN1 ASN1 ASN1 Pointer )

            return value;
        }
    }
}
