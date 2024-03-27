using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FieldViolation> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FieldFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Field                                    000186671910 ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 020 Description                              000186671910 ModelPrimitiveType string string string String
    public partial class FieldViolation
    {
        public string                                   Field                                   { get; set; }
        public string                                   Description                             { get; set; }

        public static FieldViolation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldViolation();

            value.Field                                     = GetString(new IntPtr(p + 0x018)); // 0270DA6EFDA0 0x18 Field                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 0270DA6EFDE0 0x20 Description                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
