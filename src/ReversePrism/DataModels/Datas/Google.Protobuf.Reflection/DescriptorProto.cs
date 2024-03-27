using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DescriptorProto> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 FieldFieldNumber                         int IL2CPP_TYPE_I4
    // 010 _repeated_field_codec                    FieldCodec`1<FieldDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 020 Field                                    000185CD8B38 ModelClassListType RepeatedField`1<FieldDescriptorProto> RepeatedField`1<FieldDescriptorProto> List<FieldDescriptorProto> Pointer
    // 000 ExtensionFieldNumber                     int IL2CPP_TYPE_I4
    // 018 _repeated_extension_codec                FieldCodec`1<FieldDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 028 Extension                                000185CD8B38 ModelClassListType RepeatedField`1<FieldDescriptorProto> RepeatedField`1<FieldDescriptorProto> List<FieldDescriptorProto> Pointer
    // 000 NestedTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 020 _repeated_nestedType_codec               FieldCodec`1<DescriptorProto> IL2CPP_TYPE_GENERICINST
    // 030 NestedType                               000185CD3518 ModelClassListType RepeatedField`1<DescriptorProto> RepeatedField`1<DescriptorProto> List<DescriptorProto> Pointer
    // 000 EnumTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 028 _repeated_enumType_codec                 FieldCodec`1<EnumDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 038 EnumType                                 000185CD4528 ModelClassListType RepeatedField`1<EnumDescriptorProto> RepeatedField`1<EnumDescriptorProto> List<EnumDescriptorProto> Pointer
    // 000 ExtensionRangeFieldNumber                int IL2CPP_TYPE_I4
    // 030 _repeated_extensionRange_codec           FieldCodec`1<ExtensionRange> IL2CPP_TYPE_GENERICINST
    // 040 ExtensionRange                           000185CF84A8 ModelClassListType RepeatedField`1<ExtensionRange> RepeatedField`1<ExtensionRange> List<ExtensionRange> Pointer
    // 000 OneofDeclFieldNumber                     int IL2CPP_TYPE_I4
    // 038 _repeated_oneofDecl_codec                FieldCodec`1<OneofDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 048 OneofDecl                                000185CE8168 ModelClassListType RepeatedField`1<OneofDescriptorProto> RepeatedField`1<OneofDescriptorProto> List<OneofDescriptorProto> Pointer
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 050 Options                                  0001866089F0 ModelClassType MessageOptions MessageOptions MessageOptions Pointer
    // 000 ReservedRangeFieldNumber                 int IL2CPP_TYPE_I4
    // 040 _repeated_reservedRange_codec            FieldCodec`1<ReservedRange> IL2CPP_TYPE_GENERICINST
    // 058 ReservedRange                            000185CF86E8 ModelClassListType RepeatedField`1<ReservedRange> RepeatedField`1<ReservedRange> List<ReservedRange> Pointer
    // 000 ReservedNameFieldNumber                  int IL2CPP_TYPE_I4
    // 048 _repeated_reservedName_codec             FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 060 ReservedName                             000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class DescriptorProto
    {
        public string                                   Name                                    { get; set; }
        public List<FieldDescriptorProto>?              Field                                   { get; set; }
        public List<FieldDescriptorProto>?              Extension                               { get; set; }
        public List<DescriptorProto>?                   NestedType                              { get; set; }
        public List<EnumDescriptorProto>?               EnumType                                { get; set; }
        public List<ExtensionRange>?                    ExtensionRange                          { get; set; }
        public List<OneofDescriptorProto>?              OneofDecl                               { get; set; }
        public MessageOptions?                          Options                                 { get; set; }
        public List<ReservedRange>?                     ReservedRange                           { get; set; }
        public List<string>?                            ReservedName                            { get; set; }

        public static DescriptorProto? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DescriptorProto();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D0B8A7E8 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Field                                     = GetObjectList<FieldDescriptorProto>(new IntPtr(p + 0x020), ReversePrism.DataModels.FieldDescriptorProto.FromPointer); // 0270D0B8A848 0x20 Field                       ( 000185CD8B38 ModelClassListType RepeatedField`1<FieldDescriptorProto> RepeatedField`1<FieldDescriptorProto> List<FieldDescriptorProto> Pointer )
            value.Extension                                 = GetObjectList<FieldDescriptorProto>(new IntPtr(p + 0x028), ReversePrism.DataModels.FieldDescriptorProto.FromPointer); // 0270D0B8A8A8 0x28 Extension                   ( 000185CD8B38 ModelClassListType RepeatedField`1<FieldDescriptorProto> RepeatedField`1<FieldDescriptorProto> List<FieldDescriptorProto> Pointer )
            value.NestedType                                = GetObjectList<DescriptorProto>(new IntPtr(p + 0x030), ReversePrism.DataModels.DescriptorProto.FromPointer); // 0270D0B8A908 0x30 NestedType                  ( 000185CD3518 ModelClassListType RepeatedField`1<DescriptorProto> RepeatedField`1<DescriptorProto> List<DescriptorProto> Pointer )
            value.EnumType                                  = GetObjectList<EnumDescriptorProto>(new IntPtr(p + 0x038), ReversePrism.DataModels.EnumDescriptorProto.FromPointer); // 0270D0B8A968 0x38 EnumType                    ( 000185CD4528 ModelClassListType RepeatedField`1<EnumDescriptorProto> RepeatedField`1<EnumDescriptorProto> List<EnumDescriptorProto> Pointer )
            value.ExtensionRange                            = GetObjectList<ExtensionRange>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExtensionRange.FromPointer); // 0270D0B8A9C8 0x40 ExtensionRange              ( 000185CF84A8 ModelClassListType RepeatedField`1<ExtensionRange> RepeatedField`1<ExtensionRange> List<ExtensionRange> Pointer )
            value.OneofDecl                                 = GetObjectList<OneofDescriptorProto>(new IntPtr(p + 0x048), ReversePrism.DataModels.OneofDescriptorProto.FromPointer); // 0270D0B8AA28 0x48 OneofDecl                   ( 000185CE8168 ModelClassListType RepeatedField`1<OneofDescriptorProto> RepeatedField`1<OneofDescriptorProto> List<OneofDescriptorProto> Pointer )
            value.Options                                   = GetObject<MessageOptions>(new IntPtr(p + 0x050), ReversePrism.DataModels.MessageOptions.FromPointer); // 0270D0B8AA68 0x50 Options                     ( 0001866089F0 ModelClassType MessageOptions MessageOptions MessageOptions Pointer )
            value.ReservedRange                             = GetObjectList<ReservedRange>(new IntPtr(p + 0x058), ReversePrism.DataModels.ReservedRange.FromPointer); // 0270D0B8AAC8 0x58 ReservedRange               ( 000185CF86E8 ModelClassListType RepeatedField`1<ReservedRange> RepeatedField`1<ReservedRange> List<ReservedRange> Pointer )
            value.ReservedName                              = GetStringList(new IntPtr(p + 0x060)); // 0270D0B8AB28 0x60 ReservedName                ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}
