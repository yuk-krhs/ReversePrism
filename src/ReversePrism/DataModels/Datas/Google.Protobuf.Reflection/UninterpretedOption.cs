using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UninterpretedOption> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 _repeated_name_codec                     FieldCodec`1<NamePart> IL2CPP_TYPE_GENERICINST
    // 020 Name                                     000185CF9FB8 ModelClassListType RepeatedField`1<NamePart> RepeatedField`1<NamePart> List<NamePart> Pointer
    // 000 IdentifierValueFieldNumber               int IL2CPP_TYPE_I4
    // 010 IdentifierValueDefaultValue              0001866738F0 ModelPrimitiveType string string string String
    // 028 IdentifierValue                          000186671910 ModelPrimitiveType string string string String
    // 000 PositiveIntValueFieldNumber              int IL2CPP_TYPE_I4
    // 018 PositiveIntValueDefaultValue             00018669C990 ModelPrimitiveType ulong ulong ulong UInt64
    // 030 PositiveIntValue                         00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 000 NegativeIntValueFieldNumber              int IL2CPP_TYPE_I4
    // 020 NegativeIntValueDefaultValue             0001865F89E0 ModelPrimitiveType long long long Int64
    // 038 NegativeIntValue                         0001865F7700 ModelPrimitiveType long long long Int64
    // 000 DoubleValueFieldNumber                   int IL2CPP_TYPE_I4
    // 028 DoubleValueDefaultValue                  0001865C3A90 ModelPrimitiveType double double double Double
    // 040 DoubleValue                              0001865C2950 ModelPrimitiveType double double double Double
    // 000 StringValueFieldNumber                   int IL2CPP_TYPE_I4
    // 030 StringValueDefaultValue                  00018659F3A0 ModelClassType ByteString ByteString ByteString Pointer
    // 048 StringValue                              00018659EF10 ModelClassType ByteString ByteString ByteString Pointer
    // 000 AggregateValueFieldNumber                int IL2CPP_TYPE_I4
    // 038 AggregateValueDefaultValue               0001866738F0 ModelPrimitiveType string string string String
    // 050 AggregateValue                           000186671910 ModelPrimitiveType string string string String
    public partial class UninterpretedOption
    {
        public int                                      HasBits0                                { get; set; }
        public List<NamePart>?                          Name                                    { get; set; }
        public string                                   IdentifierValueDefaultValue             { get; set; }
        public string                                   IdentifierValue                         { get; set; }
        public ulong                                    PositiveIntValueDefaultValue            { get; set; }
        public ulong                                    PositiveIntValue                        { get; set; }
        public long                                     NegativeIntValueDefaultValue            { get; set; }
        public long                                     NegativeIntValue                        { get; set; }
        public double                                   DoubleValueDefaultValue                 { get; set; }
        public double                                   DoubleValue                             { get; set; }
        public ByteString?                              StringValueDefaultValue                 { get; set; }
        public ByteString?                              StringValue                             { get; set; }
        public string                                   AggregateValueDefaultValue              { get; set; }
        public string                                   AggregateValue                          { get; set; }

        public static UninterpretedOption? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UninterpretedOption();

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D0CAA848 0x18 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetObjectList<NamePart>(new IntPtr(p + 0x020), ReversePrism.DataModels.NamePart.FromPointer); // 0270D0CAA8A8 0x20 Name                        ( 000185CF9FB8 ModelClassListType RepeatedField`1<NamePart> RepeatedField`1<NamePart> List<NamePart> Pointer )
            value.IdentifierValueDefaultValue               = GetString(new IntPtr(p + 0x010)); // 0270D0CAA8E8 0x10 IdentifierValueDefaultValue ( 0001866738F0 ModelPrimitiveType string string string String )
            value.IdentifierValue                           = GetString(new IntPtr(p + 0x028)); // 0270D0CAA908 0x28 IdentifierValue             ( 000186671910 ModelPrimitiveType string string string String )
            value.PositiveIntValueDefaultValue              = GetUInt64(new IntPtr(p + 0x018)); // 0270D0CAA948 0x18 PositiveIntValueDefaultValue ( 00018669C990 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.PositiveIntValue                          = GetUInt64(new IntPtr(p + 0x030)); // 0270D0CAA968 0x30 PositiveIntValue            ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.NegativeIntValueDefaultValue              = GetInt64(new IntPtr(p + 0x020)); // 0270D0CAA9A8 0x20 NegativeIntValueDefaultValue ( 0001865F89E0 ModelPrimitiveType long long long Int64 )
            value.NegativeIntValue                          = GetInt64(new IntPtr(p + 0x038)); // 0270D0CAA9C8 0x38 NegativeIntValue            ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DoubleValueDefaultValue                   = GetDouble(new IntPtr(p + 0x028)); // 0270D0CAAA08 0x28 DoubleValueDefaultValue     ( 0001865C3A90 ModelPrimitiveType double double double Double )
            value.DoubleValue                               = GetDouble(new IntPtr(p + 0x040)); // 0270D0CAAA28 0x40 DoubleValue                 ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.StringValueDefaultValue                   = GetObject<ByteString>(new IntPtr(p + 0x030), ReversePrism.DataModels.ByteString.FromPointer); // 0270D0CAAA68 0x30 StringValueDefaultValue     ( 00018659F3A0 ModelClassType ByteString ByteString ByteString Pointer )
            value.StringValue                               = GetObject<ByteString>(new IntPtr(p + 0x048), ReversePrism.DataModels.ByteString.FromPointer); // 0270D0CAAA88 0x48 StringValue                 ( 00018659EF10 ModelClassType ByteString ByteString ByteString Pointer )
            value.AggregateValueDefaultValue                = GetString(new IntPtr(p + 0x038)); // 0270D0CAAAC8 0x38 AggregateValueDefaultValue  ( 0001866738F0 ModelPrimitiveType string string string String )
            value.AggregateValue                            = GetString(new IntPtr(p + 0x050)); // 0270D0CAAAE8 0x50 AggregateValue              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
