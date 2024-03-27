using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentTransferEncoding                  000186611850 ModelEnumType ContentTransferEncoding ContentTransferEncoding ContentTransferEncoding Int32
    // 028 ContentTransferEncodingValue             000186671910 ModelPrimitiveType string string string String
    // 000 Binary                                   ContentTransferEncodingHeader IL2CPP_TYPE_CLASS
    // 008 EightBit                                 ContentTransferEncodingHeader IL2CPP_TYPE_CLASS
    // 010 SevenBit                                 000186611F90 ModelClassType ContentTransferEncodingHeader ContentTransferEncodingHeader ContentTransferEncodingHeader Pointer
    public partial class ContentTransferEncodingHeader
    {
        public ContentTransferEncoding                  ContentTransferEncoding                 { get; set; }
        public string                                   ContentTransferEncodingValue            { get; set; }
        public ContentTransferEncodingHeader?           SevenBit                                { get; set; }

        public static ContentTransferEncodingHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentTransferEncodingHeader();

            value.ContentTransferEncoding                   = (ContentTransferEncoding)GetInt32(new IntPtr(p + 0x020)); // 0270D7C907A8 0x20 ContentTransferEncoding     ( 000186611850 ModelEnumType ContentTransferEncoding ContentTransferEncoding ContentTransferEncoding Int32 )
            value.ContentTransferEncodingValue              = GetString(new IntPtr(p + 0x028)); // 0270D7C907C8 0x28 ContentTransferEncodingValue ( 000186671910 ModelPrimitiveType string string string String )
            value.SevenBit                                  = GetObject<ContentTransferEncodingHeader>(new IntPtr(p + 0x010), ReversePrism.DataModels.ContentTransferEncodingHeader.FromPointer); // 0270D7C90828 0x10 SevenBit                    ( 000186611F90 ModelClassType ContentTransferEncodingHeader ContentTransferEncodingHeader ContentTransferEncodingHeader Pointer )

            return value;
        }
    }
}
