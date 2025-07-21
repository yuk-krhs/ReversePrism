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
    // 018 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 _repeated_name_codec                     FieldCodec`1<NamePart> IL2CPP_TYPE_GENERICINST
    // 020 Name                                     ModelClassListType RepeatedField`1<NamePart> RepeatedField`1<NamePart> List<NamePart> Pointer
    // 000 IdentifierValueFieldNumber               int IL2CPP_TYPE_I4
    // 010 IdentifierValueDefaultValue              ModelPrimitiveType string string string String
    // 028 IdentifierValue                          ModelPrimitiveType string string string String
    // 000 PositiveIntValueFieldNumber              int IL2CPP_TYPE_I4
    // 018 PositiveIntValueDefaultValue             ModelPrimitiveType ulong ulong ulong UInt64
    // 030 PositiveIntValue                         ModelPrimitiveType ulong ulong ulong UInt64
    // 000 NegativeIntValueFieldNumber              int IL2CPP_TYPE_I4
    // 020 NegativeIntValueDefaultValue             ModelPrimitiveType long long long Int64
    // 038 NegativeIntValue                         ModelPrimitiveType long long long Int64
    // 000 DoubleValueFieldNumber                   int IL2CPP_TYPE_I4
    // 028 DoubleValueDefaultValue                  ModelPrimitiveType double double double Double
    // 040 DoubleValue                              ModelPrimitiveType double double double Double
    // 000 StringValueFieldNumber                   int IL2CPP_TYPE_I4
    // 030 StringValueDefaultValue                  ModelClassType ByteString ByteString ByteString Pointer
    // 048 StringValue                              ModelClassType ByteString ByteString ByteString Pointer
    // 000 AggregateValueFieldNumber                int IL2CPP_TYPE_I4
    // 038 AggregateValueDefaultValue               ModelPrimitiveType string string string String
    // 050 AggregateValue                           ModelPrimitiveType string string string String
    public partial class UninterpretedOption : DataModel
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
            var value   = new UninterpretedOption() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetObjectList<NamePart>(new IntPtr(p + 0x020), ReversePrism.DataModels.NamePart.FromPointer); // 0x20 Name                        ( ModelClassListType RepeatedField`1<NamePart> RepeatedField`1<NamePart> List<NamePart> Pointer )
            value.IdentifierValueDefaultValue               = GetString(new IntPtr(p + 0x010)); // 0x10 IdentifierValueDefaultValue ( ModelPrimitiveType string string string String )
            value.IdentifierValue                           = GetString(new IntPtr(p + 0x028)); // 0x28 IdentifierValue             ( ModelPrimitiveType string string string String )
            value.PositiveIntValueDefaultValue              = GetUInt64(new IntPtr(p + 0x018)); // 0x18 PositiveIntValueDefaultValue ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.PositiveIntValue                          = GetUInt64(new IntPtr(p + 0x030)); // 0x30 PositiveIntValue            ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.NegativeIntValueDefaultValue              = GetInt64(new IntPtr(p + 0x020)); // 0x20 NegativeIntValueDefaultValue ( ModelPrimitiveType long long long Int64 )
            value.NegativeIntValue                          = GetInt64(new IntPtr(p + 0x038)); // 0x38 NegativeIntValue            ( ModelPrimitiveType long long long Int64 )
            value.DoubleValueDefaultValue                   = GetDouble(new IntPtr(p + 0x028)); // 0x28 DoubleValueDefaultValue     ( ModelPrimitiveType double double double Double )
            value.DoubleValue                               = GetDouble(new IntPtr(p + 0x040)); // 0x40 DoubleValue                 ( ModelPrimitiveType double double double Double )
            value.StringValueDefaultValue                   = GetObject<ByteString>(new IntPtr(p + 0x030), ReversePrism.DataModels.ByteString.FromPointer); // 0x30 StringValueDefaultValue     ( ModelClassType ByteString ByteString ByteString Pointer )
            value.StringValue                               = GetObject<ByteString>(new IntPtr(p + 0x048), ReversePrism.DataModels.ByteString.FromPointer); // 0x48 StringValue                 ( ModelClassType ByteString ByteString ByteString Pointer )
            value.AggregateValueDefaultValue                = GetString(new IntPtr(p + 0x038)); // 0x38 AggregateValueDefaultValue  ( ModelPrimitiveType string string string String )
            value.AggregateValue                            = GetString(new IntPtr(p + 0x050)); // 0x50 AggregateValue              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
