using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ServiceOptions> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 _extensions                              ExtensionSet`1<ServiceOptions> IL2CPP_TYPE_GENERICINST
    // 020 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 FeaturesFieldNumber                      int IL2CPP_TYPE_I4
    // 028 Features                                 ModelClassType FeatureSet FeatureSet FeatureSet Pointer
    // 000 DeprecatedFieldNumber                    int IL2CPP_TYPE_I4
    // 008 DeprecatedDefaultValue                   bool IL2CPP_TYPE_BOOLEAN
    // 030 Deprecated                               ModelPrimitiveType bool bool bool Bool
    // 000 UninterpretedOptionFieldNumber           int IL2CPP_TYPE_I4
    // 010 _repeated_uninterpretedOption_codec      FieldCodec`1<UninterpretedOption> IL2CPP_TYPE_GENERICINST
    // 038 UninterpretedOption                      ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer
    public partial class ServiceOptions : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public FeatureSet?                              Features                                { get; set; }
        public bool                                     Deprecated                              { get; set; }
        public List<UninterpretedOption>?               UninterpretedOption                     { get; set; }

        public static ServiceOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServiceOptions() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Features                                  = GetObject<FeatureSet>(new IntPtr(p + 0x028), ReversePrism.DataModels.FeatureSet.FromPointer); // 0x28 Features                    ( ModelClassType FeatureSet FeatureSet FeatureSet Pointer )
            value.Deprecated                                = GetBool(new IntPtr(p + 0x030)); // 0x30 Deprecated                  ( ModelPrimitiveType bool bool bool Bool )
            value.UninterpretedOption                       = GetObjectList<UninterpretedOption>(new IntPtr(p + 0x038), ReversePrism.DataModels.UninterpretedOption.FromPointer); // 0x38 UninterpretedOption         ( ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer )

            return value;
        }
    }
}
