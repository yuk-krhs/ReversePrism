using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExtensionRangeOptions> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 _extensions                              ExtensionSet`1<ExtensionRangeOptions> IL2CPP_TYPE_GENERICINST
    // 020 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 UninterpretedOptionFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_uninterpretedOption_codec      FieldCodec`1<UninterpretedOption> IL2CPP_TYPE_GENERICINST
    // 028 UninterpretedOption                      ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer
    // 000 DeclarationFieldNumber                   int IL2CPP_TYPE_I4
    // 010 _repeated_declaration_codec              FieldCodec`1<Declaration> IL2CPP_TYPE_GENERICINST
    // 030 Declaration                              ModelClassListType RepeatedField`1<Declaration> RepeatedField`1<Declaration> List<Declaration> Pointer
    // 000 FeaturesFieldNumber                      int IL2CPP_TYPE_I4
    // 038 Features                                 ModelClassType FeatureSet FeatureSet FeatureSet Pointer
    // 000 VerificationFieldNumber                  int IL2CPP_TYPE_I4
    // 018 VerificationDefaultValue                 ModelEnumType VerificationState VerificationState VerificationState Int32
    // 040 Verification                             ModelEnumType VerificationState VerificationState VerificationState Int32
    public partial class ExtensionRangeOptions : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public List<UninterpretedOption>?               UninterpretedOption                     { get; set; }
        public List<Declaration>?                       Declaration                             { get; set; }
        public FeatureSet?                              Features                                { get; set; }
        public VerificationState                        VerificationDefaultValue                { get; set; }
        public VerificationState                        Verification                            { get; set; }

        public static ExtensionRangeOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionRangeOptions() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.UninterpretedOption                       = GetObjectList<UninterpretedOption>(new IntPtr(p + 0x028), ReversePrism.DataModels.UninterpretedOption.FromPointer); // 0x28 UninterpretedOption         ( ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer )
            value.Declaration                               = GetObjectList<Declaration>(new IntPtr(p + 0x030), ReversePrism.DataModels.Declaration.FromPointer); // 0x30 Declaration                 ( ModelClassListType RepeatedField`1<Declaration> RepeatedField`1<Declaration> List<Declaration> Pointer )
            value.Features                                  = GetObject<FeatureSet>(new IntPtr(p + 0x038), ReversePrism.DataModels.FeatureSet.FromPointer); // 0x38 Features                    ( ModelClassType FeatureSet FeatureSet FeatureSet Pointer )
            value.VerificationDefaultValue                  = (VerificationState)GetInt32(new IntPtr(p + 0x018)); // 0x18 VerificationDefaultValue    ( ModelEnumType VerificationState VerificationState VerificationState Int32 )
            value.Verification                              = (VerificationState)GetInt32(new IntPtr(p + 0x040)); // 0x40 Verification                ( ModelEnumType VerificationState VerificationState VerificationState Int32 )

            return value;
        }
    }
}
