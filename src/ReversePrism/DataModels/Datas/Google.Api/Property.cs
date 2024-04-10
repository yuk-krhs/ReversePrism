using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Property> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Type                                     00018656EA00 ModelEnumType PropertyType PropertyType PropertyType Int32
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 028 Description                              000186671910 ModelPrimitiveType string string string String
    public partial class Property : DataModel
    {
        public string                                   Name                                    { get; set; }
        public PropertyType                             Type                                    { get; set; }
        public string                                   Description                             { get; set; }

        public static Property? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Property() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 02466A7E3C60 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = (PropertyType)GetInt32(new IntPtr(p + 0x020)); // 02466A7E3CA0 0x20 Type                        ( 00018656EA00 ModelEnumType PropertyType PropertyType PropertyType Int32 )
            value.Description                               = GetString(new IntPtr(p + 0x028)); // 02466A7E3CE0 0x28 Description                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
