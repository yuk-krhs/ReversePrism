using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeNameHandling                         ModelEnumType TypeNameHandling TypeNameHandling TypeNameHandling Int32
    // 014 TypeNameAssemblyFormatHandling           ModelEnumType TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling Int32
    // 018 PreserveReferencesHandling               ModelEnumType PreserveReferencesHandling PreserveReferencesHandling PreserveReferencesHandling Int32
    // 01C ReferenceLoopHandling                    ModelEnumType ReferenceLoopHandling ReferenceLoopHandling ReferenceLoopHandling Int32
    // 020 MissingMemberHandling                    ModelEnumType MissingMemberHandling MissingMemberHandling MissingMemberHandling Int32
    // 024 ObjectCreationHandling                   ModelEnumType ObjectCreationHandling ObjectCreationHandling ObjectCreationHandling Int32
    // 028 NullValueHandling                        ModelEnumType NullValueHandling NullValueHandling NullValueHandling Int32
    // 02C DefaultValueHandling                     ModelEnumType DefaultValueHandling DefaultValueHandling DefaultValueHandling Int32
    // 030 ConstructorHandling                      ModelEnumType ConstructorHandling ConstructorHandling ConstructorHandling Int32
    // 034 MetadataPropertyHandling                 ModelEnumType MetadataPropertyHandling MetadataPropertyHandling MetadataPropertyHandling Int32
    // 038 Converters                               ModelClassType JsonConverterCollection JsonConverterCollection JsonConverterCollection Pointer
    // 040 ContractResolver                         ModelClassType IContractResolver IContractResolver IContractResolver Pointer
    // 048 TraceWriter                              ModelClassType ITraceWriter ITraceWriter ITraceWriter Pointer
    // 050 EqualityComparer                         ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer
    // 058 SerializationBinder                      ModelClassType ISerializationBinder ISerializationBinder ISerializationBinder Pointer
    // 060 Context                                  ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 070 ReferenceResolver                        ModelClassType IReferenceResolver IReferenceResolver IReferenceResolver Pointer
    // 078 _formatting                              Nullable`1<Formatting> IL2CPP_TYPE_GENERICINST
    // 080 _dateFormatHandling                      Nullable`1<DateFormatHandling> IL2CPP_TYPE_GENERICINST
    // 088 _dateTimeZoneHandling                    Nullable`1<DateTimeZoneHandling> IL2CPP_TYPE_GENERICINST
    // 090 _dateParseHandling                       Nullable`1<DateParseHandling> IL2CPP_TYPE_GENERICINST
    // 098 _floatFormatHandling                     Nullable`1<FloatFormatHandling> IL2CPP_TYPE_GENERICINST
    // 0A0 _floatParseHandling                      Nullable`1<FloatParseHandling> IL2CPP_TYPE_GENERICINST
    // 0A8 _stringEscapeHandling                    Nullable`1<StringEscapeHandling> IL2CPP_TYPE_GENERICINST
    // 0B0 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 0B8 _maxDepth                                Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 0C0 MaxDepthSet                              ModelPrimitiveType bool bool bool Bool
    // 0C1 _checkAdditionalContent                  Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 0C8 DateFormatString                         ModelPrimitiveType string string string String
    // 0D0 DateFormatStringSet                      ModelPrimitiveType bool bool bool Bool
    // 0D8 Error                                    EventHandler`1<ErrorEventArgs> IL2CPP_TYPE_GENERICINST
    public partial class JsonSerializer : DataModel
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
            var value   = new JsonSerializer() { Pointer= p0 };

            value.TypeNameHandling                          = (TypeNameHandling)GetInt32(new IntPtr(p + 0x010)); // 0x10 TypeNameHandling            ( ModelEnumType TypeNameHandling TypeNameHandling TypeNameHandling Int32 )
            value.TypeNameAssemblyFormatHandling            = (TypeNameAssemblyFormatHandling)GetInt32(new IntPtr(p + 0x014)); // 0x14 TypeNameAssemblyFormatHandling ( ModelEnumType TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling Int32 )
            value.PreserveReferencesHandling                = (PreserveReferencesHandling)GetInt32(new IntPtr(p + 0x018)); // 0x18 PreserveReferencesHandling  ( ModelEnumType PreserveReferencesHandling PreserveReferencesHandling PreserveReferencesHandling Int32 )
            value.ReferenceLoopHandling                     = (ReferenceLoopHandling)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ReferenceLoopHandling       ( ModelEnumType ReferenceLoopHandling ReferenceLoopHandling ReferenceLoopHandling Int32 )
            value.MissingMemberHandling                     = (MissingMemberHandling)GetInt32(new IntPtr(p + 0x020)); // 0x20 MissingMemberHandling       ( ModelEnumType MissingMemberHandling MissingMemberHandling MissingMemberHandling Int32 )
            value.ObjectCreationHandling                    = (ObjectCreationHandling)GetInt32(new IntPtr(p + 0x024)); // 0x24 ObjectCreationHandling      ( ModelEnumType ObjectCreationHandling ObjectCreationHandling ObjectCreationHandling Int32 )
            value.NullValueHandling                         = (NullValueHandling)GetInt32(new IntPtr(p + 0x028)); // 0x28 NullValueHandling           ( ModelEnumType NullValueHandling NullValueHandling NullValueHandling Int32 )
            value.DefaultValueHandling                      = (DefaultValueHandling)GetInt32(new IntPtr(p + 0x02C)); // 0x2C DefaultValueHandling        ( ModelEnumType DefaultValueHandling DefaultValueHandling DefaultValueHandling Int32 )
            value.ConstructorHandling                       = (ConstructorHandling)GetInt32(new IntPtr(p + 0x030)); // 0x30 ConstructorHandling         ( ModelEnumType ConstructorHandling ConstructorHandling ConstructorHandling Int32 )
            value.MetadataPropertyHandling                  = (MetadataPropertyHandling)GetInt32(new IntPtr(p + 0x034)); // 0x34 MetadataPropertyHandling    ( ModelEnumType MetadataPropertyHandling MetadataPropertyHandling MetadataPropertyHandling Int32 )
            value.Converters                                = GetObject<JsonConverterCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.JsonConverterCollection.FromPointer); // 0x38 Converters                  ( ModelClassType JsonConverterCollection JsonConverterCollection JsonConverterCollection Pointer )
            value.ContractResolver                          = GetObject<IContractResolver>(new IntPtr(p + 0x040), ReversePrism.DataModels.IContractResolver.FromPointer); // 0x40 ContractResolver            ( ModelClassType IContractResolver IContractResolver IContractResolver Pointer )
            value.TraceWriter                               = GetObject<ITraceWriter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ITraceWriter.FromPointer); // 0x48 TraceWriter                 ( ModelClassType ITraceWriter ITraceWriter ITraceWriter Pointer )
            value.EqualityComparer                          = GetObject<IEqualityComparer>(new IntPtr(p + 0x050), ReversePrism.DataModels.IEqualityComparer.FromPointer); // 0x50 EqualityComparer            ( ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer )
            value.SerializationBinder                       = GetObject<ISerializationBinder>(new IntPtr(p + 0x058), ReversePrism.DataModels.ISerializationBinder.FromPointer); // 0x58 SerializationBinder         ( ModelClassType ISerializationBinder ISerializationBinder ISerializationBinder Pointer )
            value.Context                                   = (StreamingContext)GetInt32(new IntPtr(p + 0x060)); // 0x60 Context                     ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.ReferenceResolver                         = GetObject<IReferenceResolver>(new IntPtr(p + 0x070), ReversePrism.DataModels.IReferenceResolver.FromPointer); // 0x70 ReferenceResolver           ( ModelClassType IReferenceResolver IReferenceResolver IReferenceResolver Pointer )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CultureInfo.FromPointer); // 0xB0 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.MaxDepthSet                               = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 MaxDepthSet                 ( ModelPrimitiveType bool bool bool Bool )
            value.DateFormatString                          = GetString(new IntPtr(p + 0x0C8)); // 0xC8 DateFormatString            ( ModelPrimitiveType string string string String )
            value.DateFormatStringSet                       = GetBool(new IntPtr(p + 0x0D0)); // 0xD0 DateFormatStringSet         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
