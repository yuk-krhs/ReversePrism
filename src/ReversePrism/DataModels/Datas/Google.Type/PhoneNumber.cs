using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PhoneNumber> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 E164NumberFieldNumber                    int IL2CPP_TYPE_I4
    // 000 ShortCodeFieldNumber                     int IL2CPP_TYPE_I4
    // 000 ExtensionFieldNumber                     int IL2CPP_TYPE_I4
    // 018 Extension                                000186671910 ModelPrimitiveType string string string String
    // 020 kind_                                    <object> IL2CPP_TYPE_OBJECT
    // 028 KindCase                                 000186568910 ModelEnumType KindOneofCase KindOneofCase KindOneofCase Int32
    public partial class PhoneNumber
    {
        public string                                   Extension                               { get; set; }
        public KindOneofCase                            KindCase                                { get; set; }

        public static PhoneNumber? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhoneNumber();

            value.Extension                                 = GetString(new IntPtr(p + 0x018)); // 0270DA6AA788 0x18 Extension                   ( 000186671910 ModelPrimitiveType string string string String )
            value.KindCase                                  = (KindOneofCase)GetInt32(new IntPtr(p + 0x028)); // 0270DA6AA7C8 0x28 KindCase                    ( 000186568910 ModelEnumType KindOneofCase KindOneofCase KindOneofCase Int32 )

            return value;
        }
    }
}
