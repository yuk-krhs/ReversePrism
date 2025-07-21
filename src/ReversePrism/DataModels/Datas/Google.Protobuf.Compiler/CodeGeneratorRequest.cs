using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CodeGeneratorRequest> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FileToGenerateFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_fileToGenerate_codec           FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 018 FileToGenerate                           ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 010 ParameterDefaultValue                    ModelPrimitiveType string string string String
    // 020 Parameter                                ModelPrimitiveType string string string String
    // 000 ProtoFileFieldNumber                     int IL2CPP_TYPE_I4
    // 018 _repeated_protoFile_codec                FieldCodec`1<FileDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 028 ProtoFile                                ModelClassListType RepeatedField`1<FileDescriptorProto> RepeatedField`1<FileDescriptorProto> List<FileDescriptorProto> Pointer
    // 000 SourceFileDescriptorsFieldNumber         int IL2CPP_TYPE_I4
    // 020 _repeated_sourceFileDescriptors_codec    FieldCodec`1<FileDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 030 SourceFileDescriptors                    ModelClassListType RepeatedField`1<FileDescriptorProto> RepeatedField`1<FileDescriptorProto> List<FileDescriptorProto> Pointer
    // 000 CompilerVersionFieldNumber               int IL2CPP_TYPE_I4
    // 038 CompilerVersion                          ModelClassType Version Version Version Pointer
    public partial class CodeGeneratorRequest : DataModel
    {
        public List<string>?                            FileToGenerate                          { get; set; }
        public string                                   ParameterDefaultValue                   { get; set; }
        public string                                   Parameter                               { get; set; }
        public List<FileDescriptorProto>?               ProtoFile                               { get; set; }
        public List<FileDescriptorProto>?               SourceFileDescriptors                   { get; set; }
        public Version?                                 CompilerVersion                         { get; set; }

        public static CodeGeneratorRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CodeGeneratorRequest() { Pointer= p0 };

            value.FileToGenerate                            = GetStringList(new IntPtr(p + 0x018)); // 0x18 FileToGenerate              ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.ParameterDefaultValue                     = GetString(new IntPtr(p + 0x010)); // 0x10 ParameterDefaultValue       ( ModelPrimitiveType string string string String )
            value.Parameter                                 = GetString(new IntPtr(p + 0x020)); // 0x20 Parameter                   ( ModelPrimitiveType string string string String )
            value.ProtoFile                                 = GetObjectList<FileDescriptorProto>(new IntPtr(p + 0x028), ReversePrism.DataModels.FileDescriptorProto.FromPointer); // 0x28 ProtoFile                   ( ModelClassListType RepeatedField`1<FileDescriptorProto> RepeatedField`1<FileDescriptorProto> List<FileDescriptorProto> Pointer )
            value.SourceFileDescriptors                     = GetObjectList<FileDescriptorProto>(new IntPtr(p + 0x030), ReversePrism.DataModels.FileDescriptorProto.FromPointer); // 0x30 SourceFileDescriptors       ( ModelClassListType RepeatedField`1<FileDescriptorProto> RepeatedField`1<FileDescriptorProto> List<FileDescriptorProto> Pointer )
            value.CompilerVersion                           = GetObject<Version>(new IntPtr(p + 0x038), ReversePrism.DataModels.Version.FromPointer); // 0x38 CompilerVersion             ( ModelClassType Version Version Version Pointer )

            return value;
        }
    }
}
