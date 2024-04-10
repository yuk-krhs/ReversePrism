using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Advice> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 018 Description                              000186671910 ModelPrimitiveType string string string String
    public partial class Advice : DataModel
    {
        public string                                   Description                             { get; set; }

        public static Advice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Advice() { Pointer= p0 };

            value.Description                               = GetString(new IntPtr(p + 0x018)); // 02466A7DA350 0x18 Description                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
