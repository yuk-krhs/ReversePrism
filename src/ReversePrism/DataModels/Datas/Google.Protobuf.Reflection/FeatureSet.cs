using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FeatureSet> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 _extensions                              ExtensionSet`1<FeatureSet> IL2CPP_TYPE_GENERICINST
    // 020 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 FieldPresenceFieldNumber                 int IL2CPP_TYPE_I4
    // 008 FieldPresenceDefaultValue                FieldPresence IL2CPP_TYPE_VALUETYPE
    // 024 FieldPresence                            ModelEnumType FieldPresence FieldPresence FieldPresence Int32
    // 000 EnumTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 00C EnumTypeDefaultValue                     EnumType IL2CPP_TYPE_VALUETYPE
    // 028 EnumType                                 ModelEnumType EnumType EnumType EnumType Int32
    // 000 RepeatedFieldEncodingFieldNumber         int IL2CPP_TYPE_I4
    // 010 RepeatedFieldEncodingDefaultValue        ModelEnumType RepeatedFieldEncoding RepeatedFieldEncoding RepeatedFieldEncoding Int32
    // 02C RepeatedFieldEncoding                    ModelEnumType RepeatedFieldEncoding RepeatedFieldEncoding RepeatedFieldEncoding Int32
    // 000 Utf8ValidationFieldNumber                int IL2CPP_TYPE_I4
    // 014 Utf8ValidationDefaultValue               ModelEnumType Utf8Validation Utf8Validation Utf8Validation Int32
    // 030 Utf8Validation                           ModelEnumType Utf8Validation Utf8Validation Utf8Validation Int32
    // 000 MessageEncodingFieldNumber               int IL2CPP_TYPE_I4
    // 018 MessageEncodingDefaultValue              ModelEnumType MessageEncoding MessageEncoding MessageEncoding Int32
    // 034 MessageEncoding                          ModelEnumType MessageEncoding MessageEncoding MessageEncoding Int32
    // 000 JsonFormatFieldNumber                    int IL2CPP_TYPE_I4
    // 01C JsonFormatDefaultValue                   ModelEnumType JsonFormat JsonFormat JsonFormat Int32
    // 038 JsonFormat                               ModelEnumType JsonFormat JsonFormat JsonFormat Int32
    public partial class FeatureSet : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public FieldPresence                            FieldPresence                           { get; set; }
        public EnumType                                 EnumType                                { get; set; }
        public RepeatedFieldEncoding                    RepeatedFieldEncodingDefaultValue       { get; set; }
        public RepeatedFieldEncoding                    RepeatedFieldEncoding                   { get; set; }
        public Utf8Validation                           Utf8ValidationDefaultValue              { get; set; }
        public Utf8Validation                           Utf8Validation                          { get; set; }
        public MessageEncoding                          MessageEncodingDefaultValue             { get; set; }
        public MessageEncoding                          MessageEncoding                         { get; set; }
        public JsonFormat                               JsonFormatDefaultValue                  { get; set; }
        public JsonFormat                               JsonFormat                              { get; set; }

        public static FeatureSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FeatureSet() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.FieldPresence                             = (FieldPresence)GetInt32(new IntPtr(p + 0x024)); // 0x24 FieldPresence               ( ModelEnumType FieldPresence FieldPresence FieldPresence Int32 )
            value.EnumType                                  = (EnumType)GetInt32(new IntPtr(p + 0x028)); // 0x28 EnumType                    ( ModelEnumType EnumType EnumType EnumType Int32 )
            value.RepeatedFieldEncodingDefaultValue         = (RepeatedFieldEncoding)GetInt32(new IntPtr(p + 0x010)); // 0x10 RepeatedFieldEncodingDefaultValue ( ModelEnumType RepeatedFieldEncoding RepeatedFieldEncoding RepeatedFieldEncoding Int32 )
            value.RepeatedFieldEncoding                     = (RepeatedFieldEncoding)GetInt32(new IntPtr(p + 0x02C)); // 0x2C RepeatedFieldEncoding       ( ModelEnumType RepeatedFieldEncoding RepeatedFieldEncoding RepeatedFieldEncoding Int32 )
            value.Utf8ValidationDefaultValue                = (Utf8Validation)GetInt32(new IntPtr(p + 0x014)); // 0x14 Utf8ValidationDefaultValue  ( ModelEnumType Utf8Validation Utf8Validation Utf8Validation Int32 )
            value.Utf8Validation                            = (Utf8Validation)GetInt32(new IntPtr(p + 0x030)); // 0x30 Utf8Validation              ( ModelEnumType Utf8Validation Utf8Validation Utf8Validation Int32 )
            value.MessageEncodingDefaultValue               = (MessageEncoding)GetInt32(new IntPtr(p + 0x018)); // 0x18 MessageEncodingDefaultValue ( ModelEnumType MessageEncoding MessageEncoding MessageEncoding Int32 )
            value.MessageEncoding                           = (MessageEncoding)GetInt32(new IntPtr(p + 0x034)); // 0x34 MessageEncoding             ( ModelEnumType MessageEncoding MessageEncoding MessageEncoding Int32 )
            value.JsonFormatDefaultValue                    = (JsonFormat)GetInt32(new IntPtr(p + 0x01C)); // 0x1C JsonFormatDefaultValue      ( ModelEnumType JsonFormat JsonFormat JsonFormat Int32 )
            value.JsonFormat                                = (JsonFormat)GetInt32(new IntPtr(p + 0x038)); // 0x38 JsonFormat                  ( ModelEnumType JsonFormat JsonFormat JsonFormat Int32 )

            return value;
        }
    }
}
