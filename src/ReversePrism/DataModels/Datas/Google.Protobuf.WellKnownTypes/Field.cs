using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Field> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 KindFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Kind                                     ModelEnumType Kind Kind Kind Int32
    // 000 CardinalityFieldNumber                   int IL2CPP_TYPE_I4
    // 01C Cardinality                              ModelEnumType Cardinality Cardinality Cardinality Int32
    // 000 NumberFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Number                                   ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Name                                     ModelPrimitiveType string string string String
    // 000 TypeUrlFieldNumber                       int IL2CPP_TYPE_I4
    // 030 TypeUrl                                  ModelPrimitiveType string string string String
    // 000 OneofIndexFieldNumber                    int IL2CPP_TYPE_I4
    // 038 OneofIndex                               ModelPrimitiveType int int int Int32
    // 000 PackedFieldNumber                        int IL2CPP_TYPE_I4
    // 03C Packed                                   ModelPrimitiveType bool bool bool Bool
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_options_codec                  FieldCodec`1<Option> IL2CPP_TYPE_GENERICINST
    // 040 Options                                  ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer
    // 000 JsonNameFieldNumber                      int IL2CPP_TYPE_I4
    // 048 JsonName                                 ModelPrimitiveType string string string String
    // 000 DefaultValueFieldNumber                  int IL2CPP_TYPE_I4
    // 050 DefaultValue                             ModelPrimitiveType string string string String
    public partial class Field : DataModel
    {
        public Kind                                     Kind                                    { get; set; }
        public Cardinality                              Cardinality                             { get; set; }
        public int                                      Number                                  { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   TypeUrl                                 { get; set; }
        public int                                      OneofIndex                              { get; set; }
        public bool                                     Packed                                  { get; set; }
        public List<Option>?                            Options                                 { get; set; }
        public string                                   JsonName                                { get; set; }
        public string                                   DefaultValue                            { get; set; }

        public static Field? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Field() { Pointer= p0 };

            value.Kind                                      = (Kind)GetInt32(new IntPtr(p + 0x018)); // 0x18 Kind                        ( ModelEnumType Kind Kind Kind Int32 )
            value.Cardinality                               = (Cardinality)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Cardinality                 ( ModelEnumType Cardinality Cardinality Cardinality Int32 )
            value.Number                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 Number                      ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.TypeUrl                                   = GetString(new IntPtr(p + 0x030)); // 0x30 TypeUrl                     ( ModelPrimitiveType string string string String )
            value.OneofIndex                                = GetInt32(new IntPtr(p + 0x038)); // 0x38 OneofIndex                  ( ModelPrimitiveType int int int Int32 )
            value.Packed                                    = GetBool(new IntPtr(p + 0x03C)); // 0x3C Packed                      ( ModelPrimitiveType bool bool bool Bool )
            value.Options                                   = GetObjectList<Option>(new IntPtr(p + 0x040), ReversePrism.DataModels.Option.FromPointer); // 0x40 Options                     ( ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer )
            value.JsonName                                  = GetString(new IntPtr(p + 0x048)); // 0x48 JsonName                    ( ModelPrimitiveType string string string String )
            value.DefaultValue                              = GetString(new IntPtr(p + 0x050)); // 0x50 DefaultValue                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
