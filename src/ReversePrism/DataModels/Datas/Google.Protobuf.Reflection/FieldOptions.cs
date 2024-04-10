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
    // 020 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CtypeFieldNumber                         int IL2CPP_TYPE_I4
    // 008 CtypeDefaultValue                        CType IL2CPP_TYPE_VALUETYPE
    // 024 Ctype                                    000186510270 ModelEnumType CType CType CType Int32
    // 000 PackedFieldNumber                        int IL2CPP_TYPE_I4
    // 00C PackedDefaultValue                       bool IL2CPP_TYPE_BOOLEAN
    // 028 Packed                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 JstypeFieldNumber                        int IL2CPP_TYPE_I4
    // 010 JstypeDefaultValue                       000186510F30 ModelEnumType JSType JSType JSType Int32
    // 02C Jstype                                   000186510C70 ModelEnumType JSType JSType JSType Int32
    // 000 LazyFieldNumber                          int IL2CPP_TYPE_I4
    // 014 LazyDefaultValue                         000186596D40 ModelPrimitiveType bool bool bool Bool
    // 030 Lazy                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 DeprecatedFieldNumber                    int IL2CPP_TYPE_I4
    // 015 DeprecatedDefaultValue                   000186596D40 ModelPrimitiveType bool bool bool Bool
    // 031 Deprecated                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 WeakFieldNumber                          int IL2CPP_TYPE_I4
    // 016 WeakDefaultValue                         000186596D40 ModelPrimitiveType bool bool bool Bool
    // 032 Weak                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 UninterpretedOptionFieldNumber           int IL2CPP_TYPE_I4
    // 018 _repeated_uninterpretedOption_codec      FieldCodec`1<UninterpretedOption> IL2CPP_TYPE_GENERICINST
    // 038 UninterpretedOption                      000185CF62B8 ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer
    public partial class FieldOptions : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public CType                                    Ctype                                   { get; set; }
        public bool                                     Packed                                  { get; set; }
        public JSType                                   JstypeDefaultValue                      { get; set; }
        public JSType                                   Jstype                                  { get; set; }
        public bool                                     LazyDefaultValue                        { get; set; }
        public bool                                     Lazy                                    { get; set; }
        public bool                                     DeprecatedDefaultValue                  { get; set; }
        public bool                                     Deprecated                              { get; set; }
        public bool                                     WeakDefaultValue                        { get; set; }
        public bool                                     Weak                                    { get; set; }
        public List<UninterpretedOption>?               UninterpretedOption                     { get; set; }

        public static FieldOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldOptions() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x020)); // 0245A3B15678 0x20 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Ctype                                     = (CType)GetInt32(new IntPtr(p + 0x024)); // 0245A3B156D8 0x24 Ctype                       ( 000186510270 ModelEnumType CType CType CType Int32 )
            value.Packed                                    = GetBool(new IntPtr(p + 0x028)); // 0245A3B15738 0x28 Packed                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.JstypeDefaultValue                        = (JSType)GetInt32(new IntPtr(p + 0x010)); // 0245A3B15778 0x10 JstypeDefaultValue          ( 000186510F30 ModelEnumType JSType JSType JSType Int32 )
            value.Jstype                                    = (JSType)GetInt32(new IntPtr(p + 0x02C)); // 0245A3B15798 0x2C Jstype                      ( 000186510C70 ModelEnumType JSType JSType JSType Int32 )
            value.LazyDefaultValue                          = GetBool(new IntPtr(p + 0x014)); // 0245A3B157D8 0x14 LazyDefaultValue            ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.Lazy                                      = GetBool(new IntPtr(p + 0x030)); // 0245A3B157F8 0x30 Lazy                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DeprecatedDefaultValue                    = GetBool(new IntPtr(p + 0x015)); // 0245A3B15838 0x15 DeprecatedDefaultValue      ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.Deprecated                                = GetBool(new IntPtr(p + 0x031)); // 0245A3B15858 0x31 Deprecated                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WeakDefaultValue                          = GetBool(new IntPtr(p + 0x016)); // 0245A3B15898 0x16 WeakDefaultValue            ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.Weak                                      = GetBool(new IntPtr(p + 0x032)); // 0245A3B158B8 0x32 Weak                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UninterpretedOption                       = GetObjectList<UninterpretedOption>(new IntPtr(p + 0x038), ReversePrism.DataModels.UninterpretedOption.FromPointer); // 0245A3B15918 0x38 UninterpretedOption         ( 000185CF62B8 ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer )

            return value;
        }
    }
}
