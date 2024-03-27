using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Link> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 018 Description                              000186671910 ModelPrimitiveType string string string String
    // 000 UrlFieldNumber                           int IL2CPP_TYPE_I4
    // 020 Url                                      000186671910 ModelPrimitiveType string string string String
    public partial class Link
    {
        public string                                   Description                             { get; set; }
        public string                                   Url                                     { get; set; }

        public static Link? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Link();

            value.Description                               = GetString(new IntPtr(p + 0x018)); // 0270DA6FC978 0x18 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x020)); // 0270DA6FC9B8 0x20 Url                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
