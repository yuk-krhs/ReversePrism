using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EnumDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 010 _repeated_value_codec                    FieldCodec`1<EnumValueDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 020 Value                                    000185CD4948 ModelClassListType RepeatedField`1<EnumValueDescriptorProto> RepeatedField`1<EnumValueDescriptorProto> List<EnumValueDescriptorProto> Pointer
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 028 Options                                  00018673BF80 ModelClassType EnumOptions EnumOptions EnumOptions Pointer
    // 000 ReservedRangeFieldNumber                 int IL2CPP_TYPE_I4
    // 018 _repeated_reservedRange_codec            FieldCodec`1<EnumReservedRange> IL2CPP_TYPE_GENERICINST
    // 030 ReservedRange                            000185CF8B48 ModelClassListType RepeatedField`1<EnumReservedRange> RepeatedField`1<EnumReservedRange> List<EnumReservedRange> Pointer
    // 000 ReservedNameFieldNumber                  int IL2CPP_TYPE_I4
    // 020 _repeated_reservedName_codec             FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 038 ReservedName                             000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class EnumDescriptorProto : DataModel
    {
        public string                                   Name                                    { get; set; }
        public List<EnumValueDescriptorProto>?          Value                                   { get; set; }
        public EnumOptions?                             Options                                 { get; set; }
        public List<EnumReservedRange>?                 ReservedRange                           { get; set; }
        public List<string>?                            ReservedName                            { get; set; }

        public static EnumDescriptorProto? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumDescriptorProto() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 024660B76710 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetObjectList<EnumValueDescriptorProto>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnumValueDescriptorProto.FromPointer); // 024660B76770 0x20 Value                       ( 000185CD4948 ModelClassListType RepeatedField`1<EnumValueDescriptorProto> RepeatedField`1<EnumValueDescriptorProto> List<EnumValueDescriptorProto> Pointer )
            value.Options                                   = GetObject<EnumOptions>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnumOptions.FromPointer); // 024660B767B0 0x28 Options                     ( 00018673BF80 ModelClassType EnumOptions EnumOptions EnumOptions Pointer )
            value.ReservedRange                             = GetObjectList<EnumReservedRange>(new IntPtr(p + 0x030), ReversePrism.DataModels.EnumReservedRange.FromPointer); // 024660B76810 0x30 ReservedRange               ( 000185CF8B48 ModelClassListType RepeatedField`1<EnumReservedRange> RepeatedField`1<EnumReservedRange> List<EnumReservedRange> Pointer )
            value.ReservedName                              = GetStringList(new IntPtr(p + 0x038)); // 024660B76870 0x38 ReservedName                ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
