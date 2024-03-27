using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CustomHttpPattern> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 KindFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Kind                                     000186671910 ModelPrimitiveType string string string String
    // 000 PathFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Path                                     000186671910 ModelPrimitiveType string string string String
    public partial class CustomHttpPattern
    {
        public string                                   Kind                                    { get; set; }
        public string                                   Path                                    { get; set; }

        public static CustomHttpPattern? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomHttpPattern();

            value.Kind                                      = GetString(new IntPtr(p + 0x018)); // 0270DA7D4A28 0x18 Kind                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Path                                      = GetString(new IntPtr(p + 0x020)); // 0270DA7D4A68 0x20 Path                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
