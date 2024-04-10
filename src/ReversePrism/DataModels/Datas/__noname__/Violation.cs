using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Violation> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Type                                     000186671910 ModelPrimitiveType string string string String
    // 000 SubjectFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Subject                                  000186671910 ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 028 Description                              000186671910 ModelPrimitiveType string string string String
    public partial class Violation : DataModel
    {
        public string                                   Type                                    { get; set; }
        public string                                   Subject                                 { get; set; }
        public string                                   Description                             { get; set; }

        public static Violation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Violation() { Pointer= p0 };

            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 02466A732260 0x18 Type                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Subject                                   = GetString(new IntPtr(p + 0x020)); // 02466A7322A0 0x20 Subject                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x028)); // 02466A7322E0 0x28 Description                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
