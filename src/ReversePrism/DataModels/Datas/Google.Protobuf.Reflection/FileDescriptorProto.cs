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
    // 018 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 020 Name                                     ModelPrimitiveType string string string String
    // 000 PackageFieldNumber                       int IL2CPP_TYPE_I4
    // 010 PackageDefaultValue                      ModelPrimitiveType string string string String
    // 028 Package                                  ModelPrimitiveType string string string String
    // 000 DependencyFieldNumber                    int IL2CPP_TYPE_I4
    // 018 _repeated_dependency_codec               FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 030 Dependency                               ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 PublicDependencyFieldNumber              int IL2CPP_TYPE_I4
    // 020 _repeated_publicDependency_codec         FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 038 PublicDependency                         ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 WeakDependencyFieldNumber                int IL2CPP_TYPE_I4
    // 028 _repeated_weakDependency_codec           FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 040 WeakDependency                           ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 MessageTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 030 _repeated_messageType_codec              FieldCodec`1<DescriptorProto> IL2CPP_TYPE_GENERICINST
    // 048 MessageType                              ModelClassListType RepeatedField`1<DescriptorProto> RepeatedField`1<DescriptorProto> List<DescriptorProto> Pointer
    // 000 EnumTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 038 _repeated_enumType_codec                 FieldCodec`1<EnumDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 050 EnumType                                 ModelClassListType RepeatedField`1<EnumDescriptorProto> RepeatedField`1<EnumDescriptorProto> List<EnumDescriptorProto> Pointer
    // 000 ServiceFieldNumber                       int IL2CPP_TYPE_I4
    // 040 _repeated_service_codec                  FieldCodec`1<ServiceDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 058 Service                                  ModelClassListType RepeatedField`1<ServiceDescriptorProto> RepeatedField`1<ServiceDescriptorProto> List<ServiceDescriptorProto> Pointer
    // 000 ExtensionFieldNumber                     int IL2CPP_TYPE_I4
    // 048 _repeated_extension_codec                FieldCodec`1<FieldDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 060 Extension                                ModelClassListType RepeatedField`1<FieldDescriptorProto> RepeatedField`1<FieldDescriptorProto> List<FieldDescriptorProto> Pointer
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 068 Options                                  ModelClassType FileOptions FileOptions FileOptions Pointer
    // 000 SourceCodeInfoFieldNumber                int IL2CPP_TYPE_I4
    // 070 SourceCodeInfo                           ModelClassType SourceCodeInfo SourceCodeInfo SourceCodeInfo Pointer
    // 000 SyntaxFieldNumber                        int IL2CPP_TYPE_I4
    // 050 SyntaxDefaultValue                       ModelPrimitiveType string string string String
    // 078 Syntax                                   ModelPrimitiveType string string string String
    // 000 EditionFieldNumber                       int IL2CPP_TYPE_I4
    // 058 EditionDefaultValue                      ModelEnumType Edition Edition Edition Int32
    // 080 Edition                                  ModelEnumType Edition Edition Edition Int32
    public partial class FileDescriptorProto : DataModel
    {
        public int                                      HasBits0                                { get; set; }
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
        public Edition                                  EditionDefaultValue                     { get; set; }
        public Edition                                  Edition                                 { get; set; }

        public static FileDescriptorProto? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileDescriptorProto() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.PackageDefaultValue                       = GetString(new IntPtr(p + 0x010)); // 0x10 PackageDefaultValue         ( ModelPrimitiveType string string string String )
            value.Package                                   = GetString(new IntPtr(p + 0x028)); // 0x28 Package                     ( ModelPrimitiveType string string string String )
            value.Dependency                                = GetStringList(new IntPtr(p + 0x030)); // 0x30 Dependency                  ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.PublicDependency                          = GetInt32List(new IntPtr(p + 0x038)); // 0x38 PublicDependency            ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.WeakDependency                            = GetInt32List(new IntPtr(p + 0x040)); // 0x40 WeakDependency              ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.MessageType                               = GetObjectList<DescriptorProto>(new IntPtr(p + 0x048), ReversePrism.DataModels.DescriptorProto.FromPointer); // 0x48 MessageType                 ( ModelClassListType RepeatedField`1<DescriptorProto> RepeatedField`1<DescriptorProto> List<DescriptorProto> Pointer )
            value.EnumType                                  = GetObjectList<EnumDescriptorProto>(new IntPtr(p + 0x050), ReversePrism.DataModels.EnumDescriptorProto.FromPointer); // 0x50 EnumType                    ( ModelClassListType RepeatedField`1<EnumDescriptorProto> RepeatedField`1<EnumDescriptorProto> List<EnumDescriptorProto> Pointer )
            value.Service                                   = GetObjectList<ServiceDescriptorProto>(new IntPtr(p + 0x058), ReversePrism.DataModels.ServiceDescriptorProto.FromPointer); // 0x58 Service                     ( ModelClassListType RepeatedField`1<ServiceDescriptorProto> RepeatedField`1<ServiceDescriptorProto> List<ServiceDescriptorProto> Pointer )
            value.Extension                                 = GetObjectList<FieldDescriptorProto>(new IntPtr(p + 0x060), ReversePrism.DataModels.FieldDescriptorProto.FromPointer); // 0x60 Extension                   ( ModelClassListType RepeatedField`1<FieldDescriptorProto> RepeatedField`1<FieldDescriptorProto> List<FieldDescriptorProto> Pointer )
            value.Options                                   = GetObject<FileOptions>(new IntPtr(p + 0x068), ReversePrism.DataModels.FileOptions.FromPointer); // 0x68 Options                     ( ModelClassType FileOptions FileOptions FileOptions Pointer )
            value.SourceCodeInfo                            = GetObject<SourceCodeInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.SourceCodeInfo.FromPointer); // 0x70 SourceCodeInfo              ( ModelClassType SourceCodeInfo SourceCodeInfo SourceCodeInfo Pointer )
            value.SyntaxDefaultValue                        = GetString(new IntPtr(p + 0x050)); // 0x50 SyntaxDefaultValue          ( ModelPrimitiveType string string string String )
            value.Syntax                                    = GetString(new IntPtr(p + 0x078)); // 0x78 Syntax                      ( ModelPrimitiveType string string string String )
            value.EditionDefaultValue                       = (Edition)GetInt32(new IntPtr(p + 0x058)); // 0x58 EditionDefaultValue         ( ModelEnumType Edition Edition Edition Int32 )
            value.Edition                                   = (Edition)GetInt32(new IntPtr(p + 0x080)); // 0x80 Edition                     ( ModelEnumType Edition Edition Edition Int32 )

            return value;
        }
    }
}
