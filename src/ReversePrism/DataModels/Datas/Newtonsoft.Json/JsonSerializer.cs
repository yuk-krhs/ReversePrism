using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeNameHandling                         0001866DB0D0 ModelEnumType TypeNameHandling TypeNameHandling TypeNameHandling Int32
    // 014 TypeNameAssemblyFormatHandling           0001866DA290 ModelEnumType TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling Int32
    // 018 PreserveReferencesHandling               00018650FBA0 ModelEnumType PreserveReferencesHandling PreserveReferencesHandling PreserveReferencesHandling Int32
    // 01C ReferenceLoopHandling                    000186633C80 ModelEnumType ReferenceLoopHandling ReferenceLoopHandling ReferenceLoopHandling Int32
    // 020 MissingMemberHandling                    00018661E0B0 ModelEnumType MissingMemberHandling MissingMemberHandling MissingMemberHandling Int32
    // 024 ObjectCreationHandling                   0001866C6A50 ModelEnumType ObjectCreationHandling ObjectCreationHandling ObjectCreationHandling Int32
    // 028 NullValueHandling                        0001866BC370 ModelEnumType NullValueHandling NullValueHandling NullValueHandling Int32
    // 02C DefaultValueHandling                     0001866B73F0 ModelEnumType DefaultValueHandling DefaultValueHandling DefaultValueHandling Int32
    // 030 ConstructorHandling                      00018660EF30 ModelEnumType ConstructorHandling ConstructorHandling ConstructorHandling Int32
    // 034 MetadataPropertyHandling                 00018660D690 ModelEnumType MetadataPropertyHandling MetadataPropertyHandling MetadataPropertyHandling Int32
    // 038 Converters                               000186751520 ModelClassType JsonConverterCollection JsonConverterCollection JsonConverterCollection Pointer
    // 040 ContractResolver                         00018673D510 ModelClassType IContractResolver IContractResolver IContractResolver Pointer
    // 048 TraceWriter                              00018667A870 ModelClassType ITraceWriter ITraceWriter ITraceWriter Pointer
    // 050 EqualityComparer                         000186762290 ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer
    // 058 SerializationBinder                      0001866361D0 ModelClassType ISerializationBinder ISerializationBinder ISerializationBinder Pointer
    // 060 Context                                  0001865B8F40 ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 070 ReferenceResolver                        000186615850 ModelClassType IReferenceResolver IReferenceResolver IReferenceResolver Pointer
    // 078 _formatting                              Nullable`1<Formatting> IL2CPP_TYPE_GENERICINST
    // 080 _dateFormatHandling                      Nullable`1<DateFormatHandling> IL2CPP_TYPE_GENERICINST
    // 088 _dateTimeZoneHandling                    Nullable`1<DateTimeZoneHandling> IL2CPP_TYPE_GENERICINST
    // 090 _dateParseHandling                       Nullable`1<DateParseHandling> IL2CPP_TYPE_GENERICINST
    // 098 _floatFormatHandling                     Nullable`1<FloatFormatHandling> IL2CPP_TYPE_GENERICINST
    // 0A0 _floatParseHandling                      Nullable`1<FloatParseHandling> IL2CPP_TYPE_GENERICINST
    // 0A8 _stringEscapeHandling                    Nullable`1<StringEscapeHandling> IL2CPP_TYPE_GENERICINST
    // 0B0 Culture                                  0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 0B8 _maxDepth                                Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 0C0 MaxDepthSet                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C1 _checkAdditionalContent                  Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0C8 DateFormatString                         000186671910 ModelPrimitiveType string string string String
    // 0D0 DateFormatStringSet                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D8 Error                                    EventHandler`1<ErrorEventArgs> IL2CPP_TYPE_GENERICINST
    public partial class JsonSerializer
    {
        public TypeNameHandling                         TypeNameHandling                        { get; set; }
        public TypeNameAssemblyFormatHandling           TypeNameAssemblyFormatHandling          { get; set; }
        public PreserveReferencesHandling               PreserveReferencesHandling              { get; set; }
        public ReferenceLoopHandling                    ReferenceLoopHandling                   { get; set; }
        public MissingMemberHandling                    MissingMemberHandling                   { get; set; }
        public ObjectCreationHandling                   ObjectCreationHandling                  { get; set; }
        public NullValueHandling                        NullValueHandling                       { get; set; }
        public DefaultValueHandling                     DefaultValueHandling                    { get; set; }
        public ConstructorHandling                      ConstructorHandling                     { get; set; }
        public MetadataPropertyHandling                 MetadataPropertyHandling                { get; set; }
        public JsonConverterCollection?                 Converters                              { get; set; }
        public IContractResolver?                       ContractResolver                        { get; set; }
        public ITraceWriter?                            TraceWriter                             { get; set; }
        public IEqualityComparer?                       EqualityComparer                        { get; set; }
        public ISerializationBinder?                    SerializationBinder                     { get; set; }
        public StreamingContext                         Context                                 { get; set; }
        public IReferenceResolver?                      ReferenceResolver                       { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }
        public bool                                     MaxDepthSet                             { get; set; }
        public string                                   DateFormatString                        { get; set; }
        public bool                                     DateFormatStringSet                     { get; set; }

        public static JsonSerializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSerializer();

            value.TypeNameHandling                          = (TypeNameHandling)GetInt32(new IntPtr(p + 0x010)); // 027003B65488 0x10 TypeNameHandling            ( 0001866DB0D0 ModelEnumType TypeNameHandling TypeNameHandling TypeNameHandling Int32 )
            value.TypeNameAssemblyFormatHandling            = (TypeNameAssemblyFormatHandling)GetInt32(new IntPtr(p + 0x014)); // 027003B654A8 0x14 TypeNameAssemblyFormatHandling ( 0001866DA290 ModelEnumType TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling Int32 )
            value.PreserveReferencesHandling                = (PreserveReferencesHandling)GetInt32(new IntPtr(p + 0x018)); // 027003B654C8 0x18 PreserveReferencesHandling  ( 00018650FBA0 ModelEnumType PreserveReferencesHandling PreserveReferencesHandling PreserveReferencesHandling Int32 )
            value.ReferenceLoopHandling                     = (ReferenceLoopHandling)GetInt32(new IntPtr(p + 0x01C)); // 027003B654E8 0x1C ReferenceLoopHandling       ( 000186633C80 ModelEnumType ReferenceLoopHandling ReferenceLoopHandling ReferenceLoopHandling Int32 )
            value.MissingMemberHandling                     = (MissingMemberHandling)GetInt32(new IntPtr(p + 0x020)); // 027003B65508 0x20 MissingMemberHandling       ( 00018661E0B0 ModelEnumType MissingMemberHandling MissingMemberHandling MissingMemberHandling Int32 )
            value.ObjectCreationHandling                    = (ObjectCreationHandling)GetInt32(new IntPtr(p + 0x024)); // 027003B65528 0x24 ObjectCreationHandling      ( 0001866C6A50 ModelEnumType ObjectCreationHandling ObjectCreationHandling ObjectCreationHandling Int32 )
            value.NullValueHandling                         = (NullValueHandling)GetInt32(new IntPtr(p + 0x028)); // 027003B65548 0x28 NullValueHandling           ( 0001866BC370 ModelEnumType NullValueHandling NullValueHandling NullValueHandling Int32 )
            value.DefaultValueHandling                      = (DefaultValueHandling)GetInt32(new IntPtr(p + 0x02C)); // 027003B65568 0x2C DefaultValueHandling        ( 0001866B73F0 ModelEnumType DefaultValueHandling DefaultValueHandling DefaultValueHandling Int32 )
            value.ConstructorHandling                       = (ConstructorHandling)GetInt32(new IntPtr(p + 0x030)); // 027003B65588 0x30 ConstructorHandling         ( 00018660EF30 ModelEnumType ConstructorHandling ConstructorHandling ConstructorHandling Int32 )
            value.MetadataPropertyHandling                  = (MetadataPropertyHandling)GetInt32(new IntPtr(p + 0x034)); // 027003B655A8 0x34 MetadataPropertyHandling    ( 00018660D690 ModelEnumType MetadataPropertyHandling MetadataPropertyHandling MetadataPropertyHandling Int32 )
            value.Converters                                = GetObject<JsonConverterCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.JsonConverterCollection.FromPointer); // 027003B655C8 0x38 Converters                  ( 000186751520 ModelClassType JsonConverterCollection JsonConverterCollection JsonConverterCollection Pointer )
            value.ContractResolver                          = GetObject<IContractResolver>(new IntPtr(p + 0x040), ReversePrism.DataModels.IContractResolver.FromPointer); // 027003B655E8 0x40 ContractResolver            ( 00018673D510 ModelClassType IContractResolver IContractResolver IContractResolver Pointer )
            value.TraceWriter                               = GetObject<ITraceWriter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ITraceWriter.FromPointer); // 027003B65608 0x48 TraceWriter                 ( 00018667A870 ModelClassType ITraceWriter ITraceWriter ITraceWriter Pointer )
            value.EqualityComparer                          = GetObject<IEqualityComparer>(new IntPtr(p + 0x050), ReversePrism.DataModels.IEqualityComparer.FromPointer); // 027003B65628 0x50 EqualityComparer            ( 000186762290 ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer )
            value.SerializationBinder                       = GetObject<ISerializationBinder>(new IntPtr(p + 0x058), ReversePrism.DataModels.ISerializationBinder.FromPointer); // 027003B65648 0x58 SerializationBinder         ( 0001866361D0 ModelClassType ISerializationBinder ISerializationBinder ISerializationBinder Pointer )
            value.Context                                   = (StreamingContext)GetInt32(new IntPtr(p + 0x060)); // 027003B65668 0x60 Context                     ( 0001865B8F40 ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.ReferenceResolver                         = GetObject<IReferenceResolver>(new IntPtr(p + 0x070), ReversePrism.DataModels.IReferenceResolver.FromPointer); // 027003B65688 0x70 ReferenceResolver           ( 000186615850 ModelClassType IReferenceResolver IReferenceResolver IReferenceResolver Pointer )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CultureInfo.FromPointer); // 027003B65788 0xB0 Culture                     ( 0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.MaxDepthSet                               = GetBool(new IntPtr(p + 0x0C0)); // 027003B657C8 0xC0 MaxDepthSet                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DateFormatString                          = GetString(new IntPtr(p + 0x0C8)); // 027003B65808 0xC8 DateFormatString            ( 000186671910 ModelPrimitiveType string string string String )
            value.DateFormatStringSet                       = GetBool(new IntPtr(p + 0x0D0)); // 027003B65828 0xD0 DateFormatStringSet         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
