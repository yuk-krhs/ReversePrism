using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<JwtLocation> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 HeaderFieldNumber                        int IL2CPP_TYPE_I4
    // 000 QueryFieldNumber                         int IL2CPP_TYPE_I4
    // 000 ValuePrefixFieldNumber                   int IL2CPP_TYPE_I4
    // 018 ValuePrefix                              ModelPrimitiveType string string string String
    // 020 in_                                      <object> IL2CPP_TYPE_OBJECT
    // 028 InCase                                   ModelEnumType InOneofCase InOneofCase InOneofCase Int32
    public partial class JwtLocation : DataModel
    {
        public string                                   ValuePrefix                             { get; set; }
        public InOneofCase                              InCase                                  { get; set; }

        public static JwtLocation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JwtLocation() { Pointer= p0 };

            value.ValuePrefix                               = GetString(new IntPtr(p + 0x018)); // 0x18 ValuePrefix                 ( ModelPrimitiveType string string string String )
            value.InCase                                    = (InOneofCase)GetInt32(new IntPtr(p + 0x028)); // 0x28 InCase                      ( ModelEnumType InOneofCase InOneofCase InOneofCase Int32 )

            return value;
        }
    }
}
