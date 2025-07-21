using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<OneofOptions> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 _extensions                              ExtensionSet`1<OneofOptions> IL2CPP_TYPE_GENERICINST
    // 000 FeaturesFieldNumber                      int IL2CPP_TYPE_I4
    // 020 Features                                 ModelClassType FeatureSet FeatureSet FeatureSet Pointer
    // 000 UninterpretedOptionFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_uninterpretedOption_codec      FieldCodec`1<UninterpretedOption> IL2CPP_TYPE_GENERICINST
    // 028 UninterpretedOption                      ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer
    public partial class OneofOptions : DataModel
    {
        public FeatureSet?                              Features                                { get; set; }
        public List<UninterpretedOption>?               UninterpretedOption                     { get; set; }

        public static OneofOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OneofOptions() { Pointer= p0 };

            value.Features                                  = GetObject<FeatureSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.FeatureSet.FromPointer); // 0x20 Features                    ( ModelClassType FeatureSet FeatureSet FeatureSet Pointer )
            value.UninterpretedOption                       = GetObjectList<UninterpretedOption>(new IntPtr(p + 0x028), ReversePrism.DataModels.UninterpretedOption.FromPointer); // 0x28 UninterpretedOption         ( ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer )

            return value;
        }
    }
}
