using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FeatureSetDefaults> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 DefaultsFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_defaults_codec                 FieldCodec`1<FeatureSetEditionDefault> IL2CPP_TYPE_GENERICINST
    // 020 Defaults                                 ModelClassListType RepeatedField`1<FeatureSetEditionDefault> RepeatedField`1<FeatureSetEditionDefault> List<FeatureSetEditionDefault> Pointer
    // 000 MinimumEditionFieldNumber                int IL2CPP_TYPE_I4
    // 010 MinimumEditionDefaultValue               ModelEnumType Edition Edition Edition Int32
    // 028 MinimumEdition                           ModelEnumType Edition Edition Edition Int32
    // 000 MaximumEditionFieldNumber                int IL2CPP_TYPE_I4
    // 014 MaximumEditionDefaultValue               ModelEnumType Edition Edition Edition Int32
    // 02C MaximumEdition                           ModelEnumType Edition Edition Edition Int32
    public partial class FeatureSetDefaults : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public List<FeatureSetEditionDefault>?          Defaults                                { get; set; }
        public Edition                                  MinimumEditionDefaultValue              { get; set; }
        public Edition                                  MinimumEdition                          { get; set; }
        public Edition                                  MaximumEditionDefaultValue              { get; set; }
        public Edition                                  MaximumEdition                          { get; set; }

        public static FeatureSetDefaults? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FeatureSetDefaults() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Defaults                                  = GetObjectList<FeatureSetEditionDefault>(new IntPtr(p + 0x020), ReversePrism.DataModels.FeatureSetEditionDefault.FromPointer); // 0x20 Defaults                    ( ModelClassListType RepeatedField`1<FeatureSetEditionDefault> RepeatedField`1<FeatureSetEditionDefault> List<FeatureSetEditionDefault> Pointer )
            value.MinimumEditionDefaultValue                = (Edition)GetInt32(new IntPtr(p + 0x010)); // 0x10 MinimumEditionDefaultValue  ( ModelEnumType Edition Edition Edition Int32 )
            value.MinimumEdition                            = (Edition)GetInt32(new IntPtr(p + 0x028)); // 0x28 MinimumEdition              ( ModelEnumType Edition Edition Edition Int32 )
            value.MaximumEditionDefaultValue                = (Edition)GetInt32(new IntPtr(p + 0x014)); // 0x14 MaximumEditionDefaultValue  ( ModelEnumType Edition Edition Edition Int32 )
            value.MaximumEdition                            = (Edition)GetInt32(new IntPtr(p + 0x02C)); // 0x2C MaximumEdition              ( ModelEnumType Edition Edition Edition Int32 )

            return value;
        }
    }
}
