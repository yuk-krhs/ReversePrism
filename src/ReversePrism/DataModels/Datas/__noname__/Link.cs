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
    // 018 Description                              ModelPrimitiveType string string string String
    // 000 UrlFieldNumber                           int IL2CPP_TYPE_I4
    // 020 Url                                      ModelPrimitiveType string string string String
    public partial class Link : DataModel
    {
        public string                                   Description                             { get; set; }
        public string                                   Url                                     { get; set; }

        public static Link? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Link() { Pointer= p0 };

            value.Description                               = GetString(new IntPtr(p + 0x018)); // 0x18 Description                 ( ModelPrimitiveType string string string String )
            value.Url                                       = GetString(new IntPtr(p + 0x020)); // 0x20 Url                         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
