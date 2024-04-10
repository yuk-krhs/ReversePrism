using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Option> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Value                                    0001866C54A0 ModelClassType Any Any Any Pointer
    public partial class Option : DataModel
    {
        public string                                   Name                                    { get; set; }
        public Any?                                     Value                                   { get; set; }

        public static Option? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Option() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 02466A4B6D68 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetObject<Any>(new IntPtr(p + 0x020), ReversePrism.DataModels.Any.FromPointer); // 02466A4B6DA8 0x20 Value                       ( 0001866C54A0 ModelClassType Any Any Any Pointer )

            return value;
        }
    }
}
