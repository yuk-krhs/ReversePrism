using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CaptureText                              000186671910 ModelPrimitiveType string string string String
    // 018 CaptureXText                             0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 020 CaptureStream                            0001865FB790 ModelClassType MemoryStream MemoryStream MemoryStream Pointer
    public partial class AttributeValue : DataModel
    {
        public string                                   CaptureText                             { get; set; }
        public XmlDictionaryString?                     CaptureXText                            { get; set; }
        public MemoryStream?                            CaptureStream                           { get; set; }

        public static AttributeValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeValue() { Pointer= p0 };

            value.CaptureText                               = GetString(new IntPtr(p + 0x010)); // 024667C98FD8 0x10 CaptureText                 ( 000186671910 ModelPrimitiveType string string string String )
            value.CaptureXText                              = GetObject<XmlDictionaryString>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 024667C98FF8 0x18 CaptureXText                ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.CaptureStream                             = GetObject<MemoryStream>(new IntPtr(p + 0x020), ReversePrism.DataModels.MemoryStream.FromPointer); // 024667C99018 0x20 CaptureStream               ( 0001865FB790 ModelClassType MemoryStream MemoryStream MemoryStream Pointer )

            return value;
        }
    }
}
