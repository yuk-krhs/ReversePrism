using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FieldDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 NumberFieldNumber                        int IL2CPP_TYPE_I4
    // 010 NumberDefaultValue                       0001865F4BC0 ModelPrimitiveType int int int Int32
    // 028 Number                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LabelFieldNumber                         int IL2CPP_TYPE_I4
    // 014 LabelDefaultValue                        00018650F0D0 ModelEnumType Label Label Label Int32
    // 02C Label                                    00018650EE20 ModelEnumType Label Label Label Int32
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 018 TypeDefaultValue                         00018650FAF0 ModelEnumType Type Type Type Int32
    // 030 Type                                     00018650F870 ModelEnumType Type Type Type Int32
    // 000 TypeNameFieldNumber                      int IL2CPP_TYPE_I4
    // 020 TypeNameDefaultValue                     0001866738F0 ModelPrimitiveType string string string String
    // 038 TypeName                                 000186671910 ModelPrimitiveType string string string String
    // 000 ExtendeeFieldNumber                      int IL2CPP_TYPE_I4
    // 028 ExtendeeDefaultValue                     0001866738F0 ModelPrimitiveType string string string String
    // 040 Extendee                                 000186671910 ModelPrimitiveType string string string String
    // 000 DefaultValueFieldNumber                  int IL2CPP_TYPE_I4
    // 030 DefaultValueDefaultValue                 0001866738F0 ModelPrimitiveType string string string String
    // 048 DefaultValue                             000186671910 ModelPrimitiveType string string string String
    // 000 OneofIndexFieldNumber                    int IL2CPP_TYPE_I4
    // 038 OneofIndexDefaultValue                   0001865F4BC0 ModelPrimitiveType int int int Int32
    // 050 OneofIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 JsonNameFieldNumber                      int IL2CPP_TYPE_I4
    // 040 JsonNameDefaultValue                     0001866738F0 ModelPrimitiveType string string string String
    // 058 JsonName                                 000186671910 ModelPrimitiveType string string string String
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 060 Options                                  000186575A80 ModelClassType FieldOptions FieldOptions FieldOptions Pointer
    // 000 Proto3OptionalFieldNumber                int IL2CPP_TYPE_I4
    // 048 Proto3OptionalDefaultValue               000186596D40 ModelPrimitiveType bool bool bool Bool
    // 068 Proto3Optional                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class FieldDescriptorProto : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      NumberDefaultValue                      { get; set; }
        public int                                      Number                                  { get; set; }
        public Label                                    LabelDefaultValue                       { get; set; }
        public Label                                    Label                                   { get; set; }
        public Type                                     TypeDefaultValue                        { get; set; }
        public Type                                     Type                                    { get; set; }
        public string                                   TypeNameDefaultValue                    { get; set; }
        public string                                   TypeName                                { get; set; }
        public string                                   ExtendeeDefaultValue                    { get; set; }
        public string                                   Extendee                                { get; set; }
        public string                                   DefaultValueDefaultValue                { get; set; }
        public string                                   DefaultValue                            { get; set; }
        public int                                      OneofIndexDefaultValue                  { get; set; }
        public int                                      OneofIndex                              { get; set; }
        public string                                   JsonNameDefaultValue                    { get; set; }
        public string                                   JsonName                                { get; set; }
        public FieldOptions?                            Options                                 { get; set; }
        public bool                                     Proto3OptionalDefaultValue              { get; set; }
        public bool                                     Proto3Optional                          { get; set; }

        public static FieldDescriptorProto? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldDescriptorProto() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0245A3B148A8 0x18 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0245A3B14908 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.NumberDefaultValue                        = GetInt32(new IntPtr(p + 0x010)); // 0245A3B14948 0x10 NumberDefaultValue          ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Number                                    = GetInt32(new IntPtr(p + 0x028)); // 0245A3B14968 0x28 Number                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LabelDefaultValue                         = (Label)GetInt32(new IntPtr(p + 0x014)); // 0245A3B149A8 0x14 LabelDefaultValue           ( 00018650F0D0 ModelEnumType Label Label Label Int32 )
            value.Label                                     = (Label)GetInt32(new IntPtr(p + 0x02C)); // 0245A3B149C8 0x2C Label                       ( 00018650EE20 ModelEnumType Label Label Label Int32 )
            value.TypeDefaultValue                          = (Type)GetInt32(new IntPtr(p + 0x018)); // 0245A3B14A08 0x18 TypeDefaultValue            ( 00018650FAF0 ModelEnumType Type Type Type Int32 )
            value.Type                                      = (Type)GetInt32(new IntPtr(p + 0x030)); // 0245A3B14A28 0x30 Type                        ( 00018650F870 ModelEnumType Type Type Type Int32 )
            value.TypeNameDefaultValue                      = GetString(new IntPtr(p + 0x020)); // 0245A3B14A68 0x20 TypeNameDefaultValue        ( 0001866738F0 ModelPrimitiveType string string string String )
            value.TypeName                                  = GetString(new IntPtr(p + 0x038)); // 0245A3B14A88 0x38 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ExtendeeDefaultValue                      = GetString(new IntPtr(p + 0x028)); // 0245A3B14AC8 0x28 ExtendeeDefaultValue        ( 0001866738F0 ModelPrimitiveType string string string String )
            value.Extendee                                  = GetString(new IntPtr(p + 0x040)); // 0245A3B14AE8 0x40 Extendee                    ( 000186671910 ModelPrimitiveType string string string String )
            value.DefaultValueDefaultValue                  = GetString(new IntPtr(p + 0x030)); // 0245A3B14B28 0x30 DefaultValueDefaultValue    ( 0001866738F0 ModelPrimitiveType string string string String )
            value.DefaultValue                              = GetString(new IntPtr(p + 0x048)); // 0245A3B14B48 0x48 DefaultValue                ( 000186671910 ModelPrimitiveType string string string String )
            value.OneofIndexDefaultValue                    = GetInt32(new IntPtr(p + 0x038)); // 0245A3B14B88 0x38 OneofIndexDefaultValue      ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.OneofIndex                                = GetInt32(new IntPtr(p + 0x050)); // 0245A3B14BA8 0x50 OneofIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.JsonNameDefaultValue                      = GetString(new IntPtr(p + 0x040)); // 0245A3B14BE8 0x40 JsonNameDefaultValue        ( 0001866738F0 ModelPrimitiveType string string string String )
            value.JsonName                                  = GetString(new IntPtr(p + 0x058)); // 0245A3B14C08 0x58 JsonName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Options                                   = GetObject<FieldOptions>(new IntPtr(p + 0x060), ReversePrism.DataModels.FieldOptions.FromPointer); // 0245A3B14C48 0x60 Options                     ( 000186575A80 ModelClassType FieldOptions FieldOptions FieldOptions Pointer )
            value.Proto3OptionalDefaultValue                = GetBool(new IntPtr(p + 0x048)); // 0245A3B14C88 0x48 Proto3OptionalDefaultValue  ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.Proto3Optional                            = GetBool(new IntPtr(p + 0x068)); // 0245A3B14CA8 0x68 Proto3Optional              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
