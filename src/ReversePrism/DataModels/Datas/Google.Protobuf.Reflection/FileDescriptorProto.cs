using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FileDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 PackageFieldNumber                       int IL2CPP_TYPE_I4
    // 010 PackageDefaultValue                      0001866738F0 ModelPrimitiveType string string string String
    // 020 Package                                  000186671910 ModelPrimitiveType string string string String
    // 000 DependencyFieldNumber                    int IL2CPP_TYPE_I4
    // 018 _repeated_dependency_codec               FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 028 Dependency                               000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 PublicDependencyFieldNumber              int IL2CPP_TYPE_I4
    // 020 _repeated_publicDependency_codec         FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 030 PublicDependency                         000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 WeakDependencyFieldNumber                int IL2CPP_TYPE_I4
    // 028 _repeated_weakDependency_codec           FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 038 WeakDependency                           000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 MessageTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 030 _repeated_messageType_codec              FieldCodec`1<DescriptorProto> IL2CPP_TYPE_GENERICINST
    // 040 MessageType                              000185CD3518 ModelClassListType RepeatedField`1<DescriptorProto> RepeatedField`1<DescriptorProto> List<DescriptorProto> Pointer
    // 000 EnumTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 038 _repeated_enumType_codec                 FieldCodec`1<EnumDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 048 EnumType                                 000185CD4528 ModelClassListType RepeatedField`1<EnumDescriptorProto> RepeatedField`1<EnumDescriptorProto> List<EnumDescriptorProto> Pointer
    // 000 ServiceFieldNumber                       int IL2CPP_TYPE_I4
    // 040 _repeated_service_codec                  FieldCodec`1<ServiceDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 050 Service                                  000185CF0A98 ModelClassListType RepeatedField`1<ServiceDescriptorProto> RepeatedField`1<ServiceDescriptorProto> List<ServiceDescriptorProto> Pointer
    // 000 ExtensionFieldNumber                     int IL2CPP_TYPE_I4
    // 048 _repeated_extension_codec                FieldCodec`1<FieldDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 058 Extension                                000185CD8B38 ModelClassListType RepeatedField`1<FieldDescriptorProto> RepeatedField`1<FieldDescriptorProto> List<FieldDescriptorProto> Pointer
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 060 Options                                  00018657B5A0 ModelClassType FileOptions FileOptions FileOptions Pointer
    // 000 SourceCodeInfoFieldNumber                int IL2CPP_TYPE_I4
    // 068 SourceCodeInfo                           0001865394D0 ModelClassType SourceCodeInfo SourceCodeInfo SourceCodeInfo Pointer
    // 000 SyntaxFieldNumber                        int IL2CPP_TYPE_I4
    // 050 SyntaxDefaultValue                       0001866738F0 ModelPrimitiveType string string string String
    // 070 Syntax                                   000186671910 ModelPrimitiveType string string string String
    public partial class FileDescriptorProto
    {
        public string                                   Name                                    { get; set; }
        public string                                   PackageDefaultValue                     { get; set; }
        public string                                   Package                                 { get; set; }
        public List<string>?                            Dependency                              { get; set; }
        public List<int>?                               PublicDependency                        { get; set; }
        public List<int>?                               WeakDependency                          { get; set; }
        public List<DescriptorProto>?                   MessageType                             { get; set; }
        public List<EnumDescriptorProto>?               EnumType                                { get; set; }
        public List<ServiceDescriptorProto>?            Service                                 { get; set; }
        public List<FieldDescriptorProto>?              Extension                               { get; set; }
        public FileOptions?                             Options                                 { get; set; }
        public SourceCodeInfo?                          SourceCodeInfo                          { get; set; }
        public string                                   SyntaxDefaultValue                      { get; set; }
        public string                                   Syntax                                  { get; set; }

        public static FileDescriptorProto? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileDescriptorProto();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D0BB80C0 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.PackageDefaultValue                       = GetString(new IntPtr(p + 0x010)); // 0270D0BB8100 0x10 PackageDefaultValue         ( 0001866738F0 ModelPrimitiveType string string string String )
            value.Package                                   = GetString(new IntPtr(p + 0x020)); // 0270D0BB8120 0x20 Package                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Dependency                                = GetStringList(new IntPtr(p + 0x028)); // 0270D0BB8180 0x28 Dependency                  ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.PublicDependency                          = GetInt32List(new IntPtr(p + 0x030)); // 0270D0BB81E0 0x30 PublicDependency            ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.WeakDependency                            = GetInt32List(new IntPtr(p + 0x038)); // 0270D0BB8240 0x38 WeakDependency              ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.MessageType                               = GetObjectList<DescriptorProto>(new IntPtr(p + 0x040), ReversePrism.DataModels.DescriptorProto.FromPointer); // 0270D0BB82A0 0x40 MessageType                 ( 000185CD3518 ModelClassListType RepeatedField`1<DescriptorProto> RepeatedField`1<DescriptorProto> List<DescriptorProto> Pointer )
            value.EnumType                                  = GetObjectList<EnumDescriptorProto>(new IntPtr(p + 0x048), ReversePrism.DataModels.EnumDescriptorProto.FromPointer); // 0270D0BB8300 0x48 EnumType                    ( 000185CD4528 ModelClassListType RepeatedField`1<EnumDescriptorProto> RepeatedField`1<EnumDescriptorProto> List<EnumDescriptorProto> Pointer )
            value.Service                                   = GetObjectList<ServiceDescriptorProto>(new IntPtr(p + 0x050), ReversePrism.DataModels.ServiceDescriptorProto.FromPointer); // 0270D0BB8360 0x50 Service                     ( 000185CF0A98 ModelClassListType RepeatedField`1<ServiceDescriptorProto> RepeatedField`1<ServiceDescriptorProto> List<ServiceDescriptorProto> Pointer )
            value.Extension                                 = GetObjectList<FieldDescriptorProto>(new IntPtr(p + 0x058), ReversePrism.DataModels.FieldDescriptorProto.FromPointer); // 0270D0BB83C0 0x58 Extension                   ( 000185CD8B38 ModelClassListType RepeatedField`1<FieldDescriptorProto> RepeatedField`1<FieldDescriptorProto> List<FieldDescriptorProto> Pointer )
            value.Options                                   = GetObject<FileOptions>(new IntPtr(p + 0x060), ReversePrism.DataModels.FileOptions.FromPointer); // 0270D0BB8400 0x60 Options                     ( 00018657B5A0 ModelClassType FileOptions FileOptions FileOptions Pointer )
            value.SourceCodeInfo                            = GetObject<SourceCodeInfo>(new IntPtr(p + 0x068), ReversePrism.DataModels.SourceCodeInfo.FromPointer); // 0270D0BB8440 0x68 SourceCodeInfo              ( 0001865394D0 ModelClassType SourceCodeInfo SourceCodeInfo SourceCodeInfo Pointer )
            value.SyntaxDefaultValue                        = GetString(new IntPtr(p + 0x050)); // 0270D0BB8480 0x50 SyntaxDefaultValue          ( 0001866738F0 ModelPrimitiveType string string string String )
            value.Syntax                                    = GetString(new IntPtr(p + 0x070)); // 0270D0BB84A0 0x70 Syntax                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
