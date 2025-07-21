using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CodeGeneratorResponse> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 ErrorFieldNumber                         int IL2CPP_TYPE_I4
    // 008 ErrorDefaultValue                        string IL2CPP_TYPE_STRING
    // 020 Error                                    ModelPrimitiveType string string string String
    // 000 SupportedFeaturesFieldNumber             int IL2CPP_TYPE_I4
    // 010 SupportedFeaturesDefaultValue            ModelPrimitiveType ulong ulong ulong UInt64
    // 028 SupportedFeatures                        ModelPrimitiveType ulong ulong ulong UInt64
    // 000 MinimumEditionFieldNumber                int IL2CPP_TYPE_I4
    // 018 MinimumEditionDefaultValue               ModelPrimitiveType int int int Int32
    // 030 MinimumEdition                           ModelPrimitiveType int int int Int32
    // 000 MaximumEditionFieldNumber                int IL2CPP_TYPE_I4
    // 01C MaximumEditionDefaultValue               ModelPrimitiveType int int int Int32
    // 034 MaximumEdition                           ModelPrimitiveType int int int Int32
    // 000 FileFieldNumber                          int IL2CPP_TYPE_I4
    // 020 _repeated_file_codec                     FieldCodec`1<File> IL2CPP_TYPE_GENERICINST
    // 038 File                                     ModelClassListType RepeatedField`1<File> RepeatedField`1<File> List<File> Pointer
    public partial class CodeGeneratorResponse : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public string                                   Error                                   { get; set; }
        public ulong                                    SupportedFeaturesDefaultValue           { get; set; }
        public ulong                                    SupportedFeatures                       { get; set; }
        public int                                      MinimumEditionDefaultValue              { get; set; }
        public int                                      MinimumEdition                          { get; set; }
        public int                                      MaximumEditionDefaultValue              { get; set; }
        public int                                      MaximumEdition                          { get; set; }
        public List<File>?                              File                                    { get; set; }

        public static CodeGeneratorResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CodeGeneratorResponse() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Error                                     = GetString(new IntPtr(p + 0x020)); // 0x20 Error                       ( ModelPrimitiveType string string string String )
            value.SupportedFeaturesDefaultValue             = GetUInt64(new IntPtr(p + 0x010)); // 0x10 SupportedFeaturesDefaultValue ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.SupportedFeatures                         = GetUInt64(new IntPtr(p + 0x028)); // 0x28 SupportedFeatures           ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.MinimumEditionDefaultValue                = GetInt32(new IntPtr(p + 0x018)); // 0x18 MinimumEditionDefaultValue  ( ModelPrimitiveType int int int Int32 )
            value.MinimumEdition                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 MinimumEdition              ( ModelPrimitiveType int int int Int32 )
            value.MaximumEditionDefaultValue                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MaximumEditionDefaultValue  ( ModelPrimitiveType int int int Int32 )
            value.MaximumEdition                            = GetInt32(new IntPtr(p + 0x034)); // 0x34 MaximumEdition              ( ModelPrimitiveType int int int Int32 )
            value.File                                      = GetObjectList<File>(new IntPtr(p + 0x038), ReversePrism.DataModels.File.FromPointer); // 0x38 File                        ( ModelClassListType RepeatedField`1<File> RepeatedField`1<File> List<File> Pointer )

            return value;
        }
    }
}
