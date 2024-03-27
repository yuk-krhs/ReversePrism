using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 binaryData                               IList`1<MtomBinaryData> IL2CPP_TYPE_GENERICINST
    // 018 ContentID                                000186671BA0 ModelPrimitiveType string string string String
    // 020 ContentType                              000186671BA0 ModelPrimitiveType string string string String
    // 028 ContentTransferEncoding                  000186671BA0 ModelPrimitiveType string string string String
    // 030 SizeInBytes                              0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class MimePart
    {
        public string                                   ContentID                               { get; set; }
        public string                                   ContentType                             { get; set; }
        public string                                   ContentTransferEncoding                 { get; set; }
        public int                                      SizeInBytes                             { get; set; }

        public static MimePart? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MimePart();

            value.ContentID                                 = GetString(new IntPtr(p + 0x018)); // 0270D7C97ED8 0x18 ContentID                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ContentType                               = GetString(new IntPtr(p + 0x020)); // 0270D7C97EF8 0x20 ContentType                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ContentTransferEncoding                   = GetString(new IntPtr(p + 0x028)); // 0270D7C97F18 0x28 ContentTransferEncoding     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.SizeInBytes                               = GetInt32(new IntPtr(p + 0x030)); // 0270D7C97F38 0x30 SizeInBytes                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
