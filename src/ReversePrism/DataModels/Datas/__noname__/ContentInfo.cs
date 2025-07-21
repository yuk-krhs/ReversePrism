using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContentType                              ModelPrimitiveType string string string String
    // 018 Content                                  ModelClassType ASN1 ASN1 ASN1 Pointer
    public partial class ContentInfo : DataModel
    {
        public string                                   ContentType                             { get; set; }
        public ASN1?                                    Content                                 { get; set; }

        public static ContentInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentInfo() { Pointer= p0 };

            value.ContentType                               = GetString(new IntPtr(p + 0x010)); // 0x10 ContentType                 ( ModelPrimitiveType string string string String )
            value.Content                                   = GetObject<ASN1>(new IntPtr(p + 0x018), ReversePrism.DataModels.ASN1.FromPointer); // 0x18 Content                     ( ModelClassType ASN1 ASN1 ASN1 Pointer )

            return value;
        }
    }
}
