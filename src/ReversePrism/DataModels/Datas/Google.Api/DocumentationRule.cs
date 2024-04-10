using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DocumentationRule> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectorFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Selector                                 000186671910 ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 020 Description                              000186671910 ModelPrimitiveType string string string String
    // 000 DeprecationDescriptionFieldNumber        int IL2CPP_TYPE_I4
    // 028 DeprecationDescription                   000186671910 ModelPrimitiveType string string string String
    public partial class DocumentationRule : DataModel
    {
        public string                                   Selector                                { get; set; }
        public string                                   Description                             { get; set; }
        public string                                   DeprecationDescription                  { get; set; }

        public static DocumentationRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DocumentationRule() { Pointer= p0 };

            value.Selector                                  = GetString(new IntPtr(p + 0x018)); // 02466A825F98 0x18 Selector                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 02466A825FD8 0x20 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.DeprecationDescription                    = GetString(new IntPtr(p + 0x028)); // 02466A826018 0x28 DeprecationDescription      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
