using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EnumValueDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 NumberFieldNumber                        int IL2CPP_TYPE_I4
    // 010 NumberDefaultValue                       0001865F4BC0 ModelPrimitiveType int int int Int32
    // 028 Number                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Options                                  00018673D500 ModelClassType EnumValueOptions EnumValueOptions EnumValueOptions Pointer
    public partial class EnumValueDescriptorProto
    {
        public int                                      HasBits0                                { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      NumberDefaultValue                      { get; set; }
        public int                                      Number                                  { get; set; }
        public EnumValueOptions?                        Options                                 { get; set; }

        public static EnumValueDescriptorProto? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumValueDescriptorProto();

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D0B8F798 0x18 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0270D0B8F7F8 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.NumberDefaultValue                        = GetInt32(new IntPtr(p + 0x010)); // 0270D0B8F838 0x10 NumberDefaultValue          ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Number                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D0B8F858 0x28 Number                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Options                                   = GetObject<EnumValueOptions>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnumValueOptions.FromPointer); // 0270D0B8F898 0x30 Options                     ( 00018673D500 ModelClassType EnumValueOptions EnumValueOptions EnumValueOptions Pointer )

            return value;
        }
    }
}
