using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FileOptions> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 _extensions                              ExtensionSet`1<FileOptions> IL2CPP_TYPE_GENERICINST
    // 020 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 JavaPackageFieldNumber                   int IL2CPP_TYPE_I4
    // 008 JavaPackageDefaultValue                  string IL2CPP_TYPE_STRING
    // 028 JavaPackage                              000186671910 ModelPrimitiveType string string string String
    // 000 JavaOuterClassnameFieldNumber            int IL2CPP_TYPE_I4
    // 010 JavaOuterClassnameDefaultValue           0001866738F0 ModelPrimitiveType string string string String
    // 030 JavaOuterClassname                       000186671910 ModelPrimitiveType string string string String
    // 000 JavaMultipleFilesFieldNumber             int IL2CPP_TYPE_I4
    // 018 JavaMultipleFilesDefaultValue            000186596D40 ModelPrimitiveType bool bool bool Bool
    // 038 JavaMultipleFiles                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 JavaGenerateEqualsAndHashFieldNumber     int IL2CPP_TYPE_I4
    // 019 JavaGenerateEqualsAndHashDefaultValue    000186596D40 ModelPrimitiveType bool bool bool Bool
    // 039 JavaGenerateEqualsAndHash                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 JavaStringCheckUtf8FieldNumber           int IL2CPP_TYPE_I4
    // 01A JavaStringCheckUtf8DefaultValue          000186596D40 ModelPrimitiveType bool bool bool Bool
    // 03A JavaStringCheckUtf8                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 OptimizeForFieldNumber                   int IL2CPP_TYPE_I4
    // 01C OptimizeForDefaultValue                  000186511920 ModelEnumType OptimizeMode OptimizeMode OptimizeMode Int32
    // 03C OptimizeFor                              000186511660 ModelEnumType OptimizeMode OptimizeMode OptimizeMode Int32
    // 000 GoPackageFieldNumber                     int IL2CPP_TYPE_I4
    // 020 GoPackageDefaultValue                    0001866738F0 ModelPrimitiveType string string string String
    // 040 GoPackage                                000186671910 ModelPrimitiveType string string string String
    // 000 CcGenericServicesFieldNumber             int IL2CPP_TYPE_I4
    // 028 CcGenericServicesDefaultValue            000186596D40 ModelPrimitiveType bool bool bool Bool
    // 048 CcGenericServices                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 JavaGenericServicesFieldNumber           int IL2CPP_TYPE_I4
    // 029 JavaGenericServicesDefaultValue          000186596D40 ModelPrimitiveType bool bool bool Bool
    // 049 JavaGenericServices                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 PyGenericServicesFieldNumber             int IL2CPP_TYPE_I4
    // 02A PyGenericServicesDefaultValue            000186596D40 ModelPrimitiveType bool bool bool Bool
    // 04A PyGenericServices                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 PhpGenericServicesFieldNumber            int IL2CPP_TYPE_I4
    // 02B PhpGenericServicesDefaultValue           000186596D40 ModelPrimitiveType bool bool bool Bool
    // 04B PhpGenericServices                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 DeprecatedFieldNumber                    int IL2CPP_TYPE_I4
    // 02C DeprecatedDefaultValue                   000186596D40 ModelPrimitiveType bool bool bool Bool
    // 04C Deprecated                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 CcEnableArenasFieldNumber                int IL2CPP_TYPE_I4
    // 02D CcEnableArenasDefaultValue               000186596D40 ModelPrimitiveType bool bool bool Bool
    // 04D CcEnableArenas                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ObjcClassPrefixFieldNumber               int IL2CPP_TYPE_I4
    // 030 ObjcClassPrefixDefaultValue              0001866738F0 ModelPrimitiveType string string string String
    // 050 ObjcClassPrefix                          000186671910 ModelPrimitiveType string string string String
    // 000 CsharpNamespaceFieldNumber               int IL2CPP_TYPE_I4
    // 038 CsharpNamespaceDefaultValue              0001866738F0 ModelPrimitiveType string string string String
    // 058 CsharpNamespace                          000186671910 ModelPrimitiveType string string string String
    // 000 SwiftPrefixFieldNumber                   int IL2CPP_TYPE_I4
    // 040 SwiftPrefixDefaultValue                  0001866738F0 ModelPrimitiveType string string string String
    // 060 SwiftPrefix                              000186671910 ModelPrimitiveType string string string String
    // 000 PhpClassPrefixFieldNumber                int IL2CPP_TYPE_I4
    // 048 PhpClassPrefixDefaultValue               0001866738F0 ModelPrimitiveType string string string String
    // 068 PhpClassPrefix                           000186671910 ModelPrimitiveType string string string String
    // 000 PhpNamespaceFieldNumber                  int IL2CPP_TYPE_I4
    // 050 PhpNamespaceDefaultValue                 0001866738F0 ModelPrimitiveType string string string String
    // 070 PhpNamespace                             000186671910 ModelPrimitiveType string string string String
    // 000 PhpMetadataNamespaceFieldNumber          int IL2CPP_TYPE_I4
    // 058 PhpMetadataNamespaceDefaultValue         0001866738F0 ModelPrimitiveType string string string String
    // 078 PhpMetadataNamespace                     000186671910 ModelPrimitiveType string string string String
    // 000 RubyPackageFieldNumber                   int IL2CPP_TYPE_I4
    // 060 RubyPackageDefaultValue                  0001866738F0 ModelPrimitiveType string string string String
    // 080 RubyPackage                              000186671910 ModelPrimitiveType string string string String
    // 000 UninterpretedOptionFieldNumber           int IL2CPP_TYPE_I4
    // 068 _repeated_uninterpretedOption_codec      FieldCodec`1<UninterpretedOption> IL2CPP_TYPE_GENERICINST
    // 088 UninterpretedOption                      000185CF62B8 ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer
    public partial class FileOptions : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public string                                   JavaPackage                             { get; set; }
        public string                                   JavaOuterClassnameDefaultValue          { get; set; }
        public string                                   JavaOuterClassname                      { get; set; }
        public bool                                     JavaMultipleFilesDefaultValue           { get; set; }
        public bool                                     JavaMultipleFiles                       { get; set; }
        public bool                                     JavaGenerateEqualsAndHashDefaultValue   { get; set; }
        public bool                                     JavaGenerateEqualsAndHash               { get; set; }
        public bool                                     JavaStringCheckUtf8DefaultValue         { get; set; }
        public bool                                     JavaStringCheckUtf8                     { get; set; }
        public OptimizeMode                             OptimizeForDefaultValue                 { get; set; }
        public OptimizeMode                             OptimizeFor                             { get; set; }
        public string                                   GoPackageDefaultValue                   { get; set; }
        public string                                   GoPackage                               { get; set; }
        public bool                                     CcGenericServicesDefaultValue           { get; set; }
        public bool                                     CcGenericServices                       { get; set; }
        public bool                                     JavaGenericServicesDefaultValue         { get; set; }
        public bool                                     JavaGenericServices                     { get; set; }
        public bool                                     PyGenericServicesDefaultValue           { get; set; }
        public bool                                     PyGenericServices                       { get; set; }
        public bool                                     PhpGenericServicesDefaultValue          { get; set; }
        public bool                                     PhpGenericServices                      { get; set; }
        public bool                                     DeprecatedDefaultValue                  { get; set; }
        public bool                                     Deprecated                              { get; set; }
        public bool                                     CcEnableArenasDefaultValue              { get; set; }
        public bool                                     CcEnableArenas                          { get; set; }
        public string                                   ObjcClassPrefixDefaultValue             { get; set; }
        public string                                   ObjcClassPrefix                         { get; set; }
        public string                                   CsharpNamespaceDefaultValue             { get; set; }
        public string                                   CsharpNamespace                         { get; set; }
        public string                                   SwiftPrefixDefaultValue                 { get; set; }
        public string                                   SwiftPrefix                             { get; set; }
        public string                                   PhpClassPrefixDefaultValue              { get; set; }
        public string                                   PhpClassPrefix                          { get; set; }
        public string                                   PhpNamespaceDefaultValue                { get; set; }
        public string                                   PhpNamespace                            { get; set; }
        public string                                   PhpMetadataNamespaceDefaultValue        { get; set; }
        public string                                   PhpMetadataNamespace                    { get; set; }
        public string                                   RubyPackageDefaultValue                 { get; set; }
        public string                                   RubyPackage                             { get; set; }
        public List<UninterpretedOption>?               UninterpretedOption                     { get; set; }

        public static FileOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileOptions() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x020)); // 024660B900A0 0x20 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.JavaPackage                               = GetString(new IntPtr(p + 0x028)); // 024660B90100 0x28 JavaPackage                 ( 000186671910 ModelPrimitiveType string string string String )
            value.JavaOuterClassnameDefaultValue            = GetString(new IntPtr(p + 0x010)); // 024660B90140 0x10 JavaOuterClassnameDefaultValue ( 0001866738F0 ModelPrimitiveType string string string String )
            value.JavaOuterClassname                        = GetString(new IntPtr(p + 0x030)); // 024660B90160 0x30 JavaOuterClassname          ( 000186671910 ModelPrimitiveType string string string String )
            value.JavaMultipleFilesDefaultValue             = GetBool(new IntPtr(p + 0x018)); // 024660B901A0 0x18 JavaMultipleFilesDefaultValue ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.JavaMultipleFiles                         = GetBool(new IntPtr(p + 0x038)); // 024660B901C0 0x38 JavaMultipleFiles           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.JavaGenerateEqualsAndHashDefaultValue     = GetBool(new IntPtr(p + 0x019)); // 024660B90200 0x19 JavaGenerateEqualsAndHashDefaultValue ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.JavaGenerateEqualsAndHash                 = GetBool(new IntPtr(p + 0x039)); // 024660B90220 0x39 JavaGenerateEqualsAndHash   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.JavaStringCheckUtf8DefaultValue           = GetBool(new IntPtr(p + 0x01A)); // 024660B90260 0x1A JavaStringCheckUtf8DefaultValue ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.JavaStringCheckUtf8                       = GetBool(new IntPtr(p + 0x03A)); // 024660B90280 0x3A JavaStringCheckUtf8         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OptimizeForDefaultValue                   = (OptimizeMode)GetInt32(new IntPtr(p + 0x01C)); // 024660B902C0 0x1C OptimizeForDefaultValue     ( 000186511920 ModelEnumType OptimizeMode OptimizeMode OptimizeMode Int32 )
            value.OptimizeFor                               = (OptimizeMode)GetInt32(new IntPtr(p + 0x03C)); // 024660B902E0 0x3C OptimizeFor                 ( 000186511660 ModelEnumType OptimizeMode OptimizeMode OptimizeMode Int32 )
            value.GoPackageDefaultValue                     = GetString(new IntPtr(p + 0x020)); // 024660B90320 0x20 GoPackageDefaultValue       ( 0001866738F0 ModelPrimitiveType string string string String )
            value.GoPackage                                 = GetString(new IntPtr(p + 0x040)); // 024660B90340 0x40 GoPackage                   ( 000186671910 ModelPrimitiveType string string string String )
            value.CcGenericServicesDefaultValue             = GetBool(new IntPtr(p + 0x028)); // 024660B90380 0x28 CcGenericServicesDefaultValue ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.CcGenericServices                         = GetBool(new IntPtr(p + 0x048)); // 024660B903A0 0x48 CcGenericServices           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.JavaGenericServicesDefaultValue           = GetBool(new IntPtr(p + 0x029)); // 024660B903E0 0x29 JavaGenericServicesDefaultValue ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.JavaGenericServices                       = GetBool(new IntPtr(p + 0x049)); // 024660B90400 0x49 JavaGenericServices         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PyGenericServicesDefaultValue             = GetBool(new IntPtr(p + 0x02A)); // 024660B90440 0x2A PyGenericServicesDefaultValue ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.PyGenericServices                         = GetBool(new IntPtr(p + 0x04A)); // 024660B90460 0x4A PyGenericServices           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PhpGenericServicesDefaultValue            = GetBool(new IntPtr(p + 0x02B)); // 024660B904A0 0x2B PhpGenericServicesDefaultValue ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.PhpGenericServices                        = GetBool(new IntPtr(p + 0x04B)); // 024660B904C0 0x4B PhpGenericServices          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DeprecatedDefaultValue                    = GetBool(new IntPtr(p + 0x02C)); // 024660B90500 0x2C DeprecatedDefaultValue      ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.Deprecated                                = GetBool(new IntPtr(p + 0x04C)); // 024660B90520 0x4C Deprecated                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CcEnableArenasDefaultValue                = GetBool(new IntPtr(p + 0x02D)); // 024660B90560 0x2D CcEnableArenasDefaultValue  ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.CcEnableArenas                            = GetBool(new IntPtr(p + 0x04D)); // 024660B90580 0x4D CcEnableArenas              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ObjcClassPrefixDefaultValue               = GetString(new IntPtr(p + 0x030)); // 024660B905C0 0x30 ObjcClassPrefixDefaultValue ( 0001866738F0 ModelPrimitiveType string string string String )
            value.ObjcClassPrefix                           = GetString(new IntPtr(p + 0x050)); // 024660B905E0 0x50 ObjcClassPrefix             ( 000186671910 ModelPrimitiveType string string string String )
            value.CsharpNamespaceDefaultValue               = GetString(new IntPtr(p + 0x038)); // 024660B90620 0x38 CsharpNamespaceDefaultValue ( 0001866738F0 ModelPrimitiveType string string string String )
            value.CsharpNamespace                           = GetString(new IntPtr(p + 0x058)); // 024660B90640 0x58 CsharpNamespace             ( 000186671910 ModelPrimitiveType string string string String )
            value.SwiftPrefixDefaultValue                   = GetString(new IntPtr(p + 0x040)); // 024660B90680 0x40 SwiftPrefixDefaultValue     ( 0001866738F0 ModelPrimitiveType string string string String )
            value.SwiftPrefix                               = GetString(new IntPtr(p + 0x060)); // 024660B906A0 0x60 SwiftPrefix                 ( 000186671910 ModelPrimitiveType string string string String )
            value.PhpClassPrefixDefaultValue                = GetString(new IntPtr(p + 0x048)); // 024660B906E0 0x48 PhpClassPrefixDefaultValue  ( 0001866738F0 ModelPrimitiveType string string string String )
            value.PhpClassPrefix                            = GetString(new IntPtr(p + 0x068)); // 024660B90700 0x68 PhpClassPrefix              ( 000186671910 ModelPrimitiveType string string string String )
            value.PhpNamespaceDefaultValue                  = GetString(new IntPtr(p + 0x050)); // 024660B90740 0x50 PhpNamespaceDefaultValue    ( 0001866738F0 ModelPrimitiveType string string string String )
            value.PhpNamespace                              = GetString(new IntPtr(p + 0x070)); // 024660B90760 0x70 PhpNamespace                ( 000186671910 ModelPrimitiveType string string string String )
            value.PhpMetadataNamespaceDefaultValue          = GetString(new IntPtr(p + 0x058)); // 024660B907A0 0x58 PhpMetadataNamespaceDefaultValue ( 0001866738F0 ModelPrimitiveType string string string String )
            value.PhpMetadataNamespace                      = GetString(new IntPtr(p + 0x078)); // 024660B907C0 0x78 PhpMetadataNamespace        ( 000186671910 ModelPrimitiveType string string string String )
            value.RubyPackageDefaultValue                   = GetString(new IntPtr(p + 0x060)); // 024660B90800 0x60 RubyPackageDefaultValue     ( 0001866738F0 ModelPrimitiveType string string string String )
            value.RubyPackage                               = GetString(new IntPtr(p + 0x080)); // 024660B90820 0x80 RubyPackage                 ( 000186671910 ModelPrimitiveType string string string String )
            value.UninterpretedOption                       = GetObjectList<UninterpretedOption>(new IntPtr(p + 0x088), ReversePrism.DataModels.UninterpretedOption.FromPointer); // 024660B90880 0x88 UninterpretedOption         ( 000185CF62B8 ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer )

            return value;
        }
    }
}
