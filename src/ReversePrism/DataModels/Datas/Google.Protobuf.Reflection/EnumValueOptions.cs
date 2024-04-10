using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EnumValueOptions> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 _extensions                              ExtensionSet`1<EnumValueOptions> IL2CPP_TYPE_GENERICINST
    // 020 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DeprecatedFieldNumber                    int IL2CPP_TYPE_I4
    // 008 DeprecatedDefaultValue                   bool IL2CPP_TYPE_BOOLEAN
    // 024 Deprecated                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 UninterpretedOptionFieldNumber           int IL2CPP_TYPE_I4
    // 010 _repeated_uninterpretedOption_codec      FieldCodec`1<UninterpretedOption> IL2CPP_TYPE_GENERICINST
    // 028 UninterpretedOption                      000185CF62B8 ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer
    public partial class EnumValueOptions : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public bool                                     Deprecated                              { get; set; }
        public List<UninterpretedOption>?               UninterpretedOption                     { get; set; }

        public static EnumValueOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumValueOptions() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x020)); // 0245A3B0F980 0x20 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Deprecated                                = GetBool(new IntPtr(p + 0x024)); // 0245A3B0F9E0 0x24 Deprecated                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UninterpretedOption                       = GetObjectList<UninterpretedOption>(new IntPtr(p + 0x028), ReversePrism.DataModels.UninterpretedOption.FromPointer); // 0245A3B0FA40 0x28 UninterpretedOption         ( 000185CF62B8 ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer )

            return value;
        }
    }
}
