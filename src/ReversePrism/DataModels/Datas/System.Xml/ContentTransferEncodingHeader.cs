using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentTransferEncoding                  ModelEnumType ContentTransferEncoding ContentTransferEncoding ContentTransferEncoding Int32
    // 028 ContentTransferEncodingValue             ModelPrimitiveType string string string String
    // 000 Binary                                   ContentTransferEncodingHeader IL2CPP_TYPE_CLASS
    // 008 EightBit                                 ContentTransferEncodingHeader IL2CPP_TYPE_CLASS
    // 010 SevenBit                                 ModelClassType ContentTransferEncodingHeader ContentTransferEncodingHeader ContentTransferEncodingHeader Pointer
    public partial class ContentTransferEncodingHeader : DataModel
    {
        public ContentTransferEncoding                  ContentTransferEncoding                 { get; set; }
        public string                                   ContentTransferEncodingValue            { get; set; }
        public ContentTransferEncodingHeader?           SevenBit                                { get; set; }

        public static ContentTransferEncodingHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentTransferEncodingHeader() { Pointer= p0 };

            value.ContentTransferEncoding                   = (ContentTransferEncoding)GetInt32(new IntPtr(p + 0x020)); // 0x20 ContentTransferEncoding     ( ModelEnumType ContentTransferEncoding ContentTransferEncoding ContentTransferEncoding Int32 )
            value.ContentTransferEncodingValue              = GetString(new IntPtr(p + 0x028)); // 0x28 ContentTransferEncodingValue ( ModelPrimitiveType string string string String )
            value.SevenBit                                  = GetObject<ContentTransferEncodingHeader>(new IntPtr(p + 0x010), ReversePrism.DataModels.ContentTransferEncodingHeader.FromPointer); // 0x10 SevenBit                    ( ModelClassType ContentTransferEncodingHeader ContentTransferEncodingHeader ContentTransferEncodingHeader Pointer )

            return value;
        }
    }
}
