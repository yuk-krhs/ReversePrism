using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ResourceReference> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Type                                     000186671910 ModelPrimitiveType string string string String
    // 000 ChildTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 020 ChildType                                000186671910 ModelPrimitiveType string string string String
    public partial class ResourceReference : DataModel
    {
        public string                                   Type                                    { get; set; }
        public string                                   ChildType                               { get; set; }

        public static ResourceReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceReference() { Pointer= p0 };

            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 02466A893D10 0x18 Type                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ChildType                                 = GetString(new IntPtr(p + 0x020)); // 02466A893D50 0x20 ChildType                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
