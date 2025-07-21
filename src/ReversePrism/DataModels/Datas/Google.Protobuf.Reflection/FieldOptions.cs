using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FieldOptions> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 _extensions                              ExtensionSet`1<FieldOptions> IL2CPP_TYPE_GENERICINST
    // 020 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 CtypeFieldNumber                         int IL2CPP_TYPE_I4
    // 008 CtypeDefaultValue                        CType IL2CPP_TYPE_VALUETYPE
    // 024 Ctype                                    ModelEnumType CType CType CType Int32
    // 000 PackedFieldNumber                        int IL2CPP_TYPE_I4
    // 00C PackedDefaultValue                       bool IL2CPP_TYPE_BOOLEAN
    // 028 Packed                                   ModelPrimitiveType bool bool bool Bool
    // 000 JstypeFieldNumber                        int IL2CPP_TYPE_I4
    // 010 JstypeDefaultValue                       ModelEnumType JSType JSType JSType Int32
    // 02C Jstype                                   ModelEnumType JSType JSType JSType Int32
    // 000 LazyFieldNumber                          int IL2CPP_TYPE_I4
    // 014 LazyDefaultValue                         ModelPrimitiveType bool bool bool Bool
    // 030 Lazy                                     ModelPrimitiveType bool bool bool Bool
    // 000 UnverifiedLazyFieldNumber                int IL2CPP_TYPE_I4
    // 015 UnverifiedLazyDefaultValue               ModelPrimitiveType bool bool bool Bool
    // 031 UnverifiedLazy                           ModelPrimitiveType bool bool bool Bool
    // 000 DeprecatedFieldNumber                    int IL2CPP_TYPE_I4
    // 016 DeprecatedDefaultValue                   ModelPrimitiveType bool bool bool Bool
    // 032 Deprecated                               ModelPrimitiveType bool bool bool Bool
    // 000 WeakFieldNumber                          int IL2CPP_TYPE_I4
    // 017 WeakDefaultValue                         ModelPrimitiveType bool bool bool Bool
    // 033 Weak                                     ModelPrimitiveType bool bool bool Bool
    // 000 DebugRedactFieldNumber                   int IL2CPP_TYPE_I4
    // 018 DebugRedactDefaultValue                  ModelPrimitiveType bool bool bool Bool
    // 034 DebugRedact                              ModelPrimitiveType bool bool bool Bool
    // 000 RetentionFieldNumber                     int IL2CPP_TYPE_I4
    // 01C RetentionDefaultValue                    ModelEnumType OptionRetention OptionRetention OptionRetention Int32
    // 038 Retention                                ModelEnumType OptionRetention OptionRetention OptionRetention Int32
    // 000 TargetsFieldNumber                       int IL2CPP_TYPE_I4
    // 020 _repeated_targets_codec                  FieldCodec`1<OptionTargetType> IL2CPP_TYPE_GENERICINST
    // 040 Targets                                  ModelEnumListType RepeatedField`1<OptionTargetType> RepeatedField`1<OptionTargetType> List<OptionTargetType> Pointer
    // 000 EditionDefaultsFieldNumber               int IL2CPP_TYPE_I4
    // 028 _repeated_editionDefaults_codec          FieldCodec`1<EditionDefault> IL2CPP_TYPE_GENERICINST
    // 048 EditionDefaults                          ModelClassListType RepeatedField`1<EditionDefault> RepeatedField`1<EditionDefault> List<EditionDefault> Pointer
    // 000 FeaturesFieldNumber                      int IL2CPP_TYPE_I4
    // 050 Features                                 ModelClassType FeatureSet FeatureSet FeatureSet Pointer
    // 000 UninterpretedOptionFieldNumber           int IL2CPP_TYPE_I4
    // 030 _repeated_uninterpretedOption_codec      FieldCodec`1<UninterpretedOption> IL2CPP_TYPE_GENERICINST
    // 058 UninterpretedOption                      ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer
    public partial class FieldOptions : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public CType                                    Ctype                                   { get; set; }
        public bool                                     Packed                                  { get; set; }
        public JSType                                   JstypeDefaultValue                      { get; set; }
        public JSType                                   Jstype                                  { get; set; }
        public bool                                     LazyDefaultValue                        { get; set; }
        public bool                                     Lazy                                    { get; set; }
        public bool                                     UnverifiedLazyDefaultValue              { get; set; }
        public bool                                     UnverifiedLazy                          { get; set; }
        public bool                                     DeprecatedDefaultValue                  { get; set; }
        public bool                                     Deprecated                              { get; set; }
        public bool                                     WeakDefaultValue                        { get; set; }
        public bool                                     Weak                                    { get; set; }
        public bool                                     DebugRedactDefaultValue                 { get; set; }
        public bool                                     DebugRedact                             { get; set; }
        public OptionRetention                          RetentionDefaultValue                   { get; set; }
        public OptionRetention                          Retention                               { get; set; }
        public List<OptionTargetType>?                  Targets                                 { get; set; }
        public List<EditionDefault>?                    EditionDefaults                         { get; set; }
        public FeatureSet?                              Features                                { get; set; }
        public List<UninterpretedOption>?               UninterpretedOption                     { get; set; }

        public static FieldOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldOptions() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Ctype                                     = (CType)GetInt32(new IntPtr(p + 0x024)); // 0x24 Ctype                       ( ModelEnumType CType CType CType Int32 )
            value.Packed                                    = GetBool(new IntPtr(p + 0x028)); // 0x28 Packed                      ( ModelPrimitiveType bool bool bool Bool )
            value.JstypeDefaultValue                        = (JSType)GetInt32(new IntPtr(p + 0x010)); // 0x10 JstypeDefaultValue          ( ModelEnumType JSType JSType JSType Int32 )
            value.Jstype                                    = (JSType)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Jstype                      ( ModelEnumType JSType JSType JSType Int32 )
            value.LazyDefaultValue                          = GetBool(new IntPtr(p + 0x014)); // 0x14 LazyDefaultValue            ( ModelPrimitiveType bool bool bool Bool )
            value.Lazy                                      = GetBool(new IntPtr(p + 0x030)); // 0x30 Lazy                        ( ModelPrimitiveType bool bool bool Bool )
            value.UnverifiedLazyDefaultValue                = GetBool(new IntPtr(p + 0x015)); // 0x15 UnverifiedLazyDefaultValue  ( ModelPrimitiveType bool bool bool Bool )
            value.UnverifiedLazy                            = GetBool(new IntPtr(p + 0x031)); // 0x31 UnverifiedLazy              ( ModelPrimitiveType bool bool bool Bool )
            value.DeprecatedDefaultValue                    = GetBool(new IntPtr(p + 0x016)); // 0x16 DeprecatedDefaultValue      ( ModelPrimitiveType bool bool bool Bool )
            value.Deprecated                                = GetBool(new IntPtr(p + 0x032)); // 0x32 Deprecated                  ( ModelPrimitiveType bool bool bool Bool )
            value.WeakDefaultValue                          = GetBool(new IntPtr(p + 0x017)); // 0x17 WeakDefaultValue            ( ModelPrimitiveType bool bool bool Bool )
            value.Weak                                      = GetBool(new IntPtr(p + 0x033)); // 0x33 Weak                        ( ModelPrimitiveType bool bool bool Bool )
            value.DebugRedactDefaultValue                   = GetBool(new IntPtr(p + 0x018)); // 0x18 DebugRedactDefaultValue     ( ModelPrimitiveType bool bool bool Bool )
            value.DebugRedact                               = GetBool(new IntPtr(p + 0x034)); // 0x34 DebugRedact                 ( ModelPrimitiveType bool bool bool Bool )
            value.RetentionDefaultValue                     = (OptionRetention)GetInt32(new IntPtr(p + 0x01C)); // 0x1C RetentionDefaultValue       ( ModelEnumType OptionRetention OptionRetention OptionRetention Int32 )
            value.Retention                                 = (OptionRetention)GetInt32(new IntPtr(p + 0x038)); // 0x38 Retention                   ( ModelEnumType OptionRetention OptionRetention OptionRetention Int32 )
            value.Targets                                   = GetEnumList<OptionTargetType>(new IntPtr(p + 0x040)); // 0x40 Targets                     ( ModelEnumListType RepeatedField`1<OptionTargetType> RepeatedField`1<OptionTargetType> List<OptionTargetType> Pointer )
            value.EditionDefaults                           = GetObjectList<EditionDefault>(new IntPtr(p + 0x048), ReversePrism.DataModels.EditionDefault.FromPointer); // 0x48 EditionDefaults             ( ModelClassListType RepeatedField`1<EditionDefault> RepeatedField`1<EditionDefault> List<EditionDefault> Pointer )
            value.Features                                  = GetObject<FeatureSet>(new IntPtr(p + 0x050), ReversePrism.DataModels.FeatureSet.FromPointer); // 0x50 Features                    ( ModelClassType FeatureSet FeatureSet FeatureSet Pointer )
            value.UninterpretedOption                       = GetObjectList<UninterpretedOption>(new IntPtr(p + 0x058), ReversePrism.DataModels.UninterpretedOption.FromPointer); // 0x58 UninterpretedOption         ( ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer )

            return value;
        }
    }
}
