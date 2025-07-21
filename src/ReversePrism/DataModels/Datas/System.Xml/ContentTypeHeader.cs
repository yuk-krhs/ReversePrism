using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  ContentTypeHeader IL2CPP_TYPE_CLASS
    // 020 MediaType                                ModelPrimitiveType string string string String
    // 028 SubType                                  ModelPrimitiveType string string string String
    // 030 parameters                               Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class ContentTypeHeader : DataModel
    {
        public string                                   MediaType                               { get; set; }
        public string                                   SubType                                 { get; set; }

        public static ContentTypeHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentTypeHeader() { Pointer= p0 };

            value.MediaType                                 = GetString(new IntPtr(p + 0x020)); // 0x20 MediaType                   ( ModelPrimitiveType string string string String )
            value.SubType                                   = GetString(new IntPtr(p + 0x028)); // 0x28 SubType                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
