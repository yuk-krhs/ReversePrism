using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  ContentTypeHeader IL2CPP_TYPE_CLASS
    // 020 MediaType                                000186671910 ModelPrimitiveType string string string String
    // 028 SubType                                  000186671910 ModelPrimitiveType string string string String
    // 030 parameters                               Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class ContentTypeHeader
    {
        public string                                   MediaType                               { get; set; }
        public string                                   SubType                                 { get; set; }

        public static ContentTypeHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentTypeHeader();

            value.MediaType                                 = GetString(new IntPtr(p + 0x020)); // 0270D7C90478 0x20 MediaType                   ( 000186671910 ModelPrimitiveType string string string String )
            value.SubType                                   = GetString(new IntPtr(p + 0x028)); // 0270D7C90498 0x28 SubType                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
