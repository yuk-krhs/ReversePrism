using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultReferenceLoopHandling             ReferenceLoopHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultMissingMemberHandling             MissingMemberHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultNullValueHandling                 NullValueHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultDefaultValueHandling              DefaultValueHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultObjectCreationHandling            ObjectCreationHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultPreserveReferencesHandling        PreserveReferencesHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultConstructorHandling               ConstructorHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultTypeNameHandling                  TypeNameHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultMetadataPropertyHandling          MetadataPropertyHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultContext                           StreamingContext IL2CPP_TYPE_VALUETYPE
    // 000 DefaultFormatting                        Formatting IL2CPP_TYPE_VALUETYPE
    // 000 DefaultDateFormatHandling                DateFormatHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultDateTimeZoneHandling              DateTimeZoneHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultDateParseHandling                 DateParseHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultFloatParseHandling                FloatParseHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultFloatFormatHandling               FloatFormatHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultStringEscapeHandling              StringEscapeHandling IL2CPP_TYPE_VALUETYPE
    // 000 DefaultTypeNameAssemblyFormatHandling    TypeNameAssemblyFormatHandling IL2CPP_TYPE_VALUETYPE
    // 010 DefaultCulture                           ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 000 DefaultCheckAdditionalContent            bool IL2CPP_TYPE_BOOLEAN
    // 000 DefaultDateFormatString                  string IL2CPP_TYPE_STRING
    // 000 DefaultMaxDepth                          int IL2CPP_TYPE_I4
    // 010 _formatting                              Nullable`1<Formatting> IL2CPP_TYPE_GENERICINST
    // 018 _dateFormatHandling                      Nullable`1<DateFormatHandling> IL2CPP_TYPE_GENERICINST
    // 020 _dateTimeZoneHandling                    Nullable`1<DateTimeZoneHandling> IL2CPP_TYPE_GENERICINST
    // 028 _dateParseHandling                       Nullable`1<DateParseHandling> IL2CPP_TYPE_GENERICINST
    // 030 _floatFormatHandling                     Nullable`1<FloatFormatHandling> IL2CPP_TYPE_GENERICINST
    // 038 _floatParseHandling                      Nullable`1<FloatParseHandling> IL2CPP_TYPE_GENERICINST
    // 040 _stringEscapeHandling                    Nullable`1<StringEscapeHandling> IL2CPP_TYPE_GENERICINST
    // 048 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 050 _checkAdditionalContent                  Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 054 _maxDepth                                Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 05C MaxDepthSet                              ModelPrimitiveType bool bool bool Bool
    // 060 DateFormatString                         ModelPrimitiveType string string string String
    // 068 DateFormatStringSet                      ModelPrimitiveType bool bool bool Bool
    // 06C _typeNameAssemblyFormatHandling          Nullable`1<TypeNameAssemblyFormatHandling> IL2CPP_TYPE_GENERICINST
    // 074 _defaultValueHandling                    Nullable`1<DefaultValueHandling> IL2CPP_TYPE_GENERICINST
    // 07C _preserveReferencesHandling              Nullable`1<PreserveReferencesHandling> IL2CPP_TYPE_GENERICINST
    // 084 _nullValueHandling                       Nullable`1<NullValueHandling> IL2CPP_TYPE_GENERICINST
    // 08C _objectCreationHandling                  Nullable`1<ObjectCreationHandling> IL2CPP_TYPE_GENERICINST
    // 094 _missingMemberHandling                   Nullable`1<MissingMemberHandling> IL2CPP_TYPE_GENERICINST
    // 09C _referenceLoopHandling                   Nullable`1<ReferenceLoopHandling> IL2CPP_TYPE_GENERICINST
    // 0A8 _context                                 Nullable`1<StreamingContext> IL2CPP_TYPE_GENERICINST
    // 0C0 _constructorHandling                     Nullable`1<ConstructorHandling> IL2CPP_TYPE_GENERICINST
    // 0C8 _typeNameHandling                        Nullable`1<TypeNameHandling> IL2CPP_TYPE_GENERICINST
    // 0D0 _metadataPropertyHandling                Nullable`1<MetadataPropertyHandling> IL2CPP_TYPE_GENERICINST
    // 0D8 <Converters>k__BackingField              IList`1<JsonConverter> IL2CPP_TYPE_GENERICINST
    // 0E0 ContractResolver                         ModelClassType IContractResolver IContractResolver IContractResolver Pointer
    // 0E8 EqualityComparer                         ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer
    // 0F0 <ReferenceResolverProvider>k__BackingField Func`1<IReferenceResolver> IL2CPP_TYPE_GENERICINST
    // 0F8 TraceWriter                              ModelClassType ITraceWriter ITraceWriter ITraceWriter Pointer
    // 100 SerializationBinder                      ModelClassType ISerializationBinder ISerializationBinder ISerializationBinder Pointer
    // 108 <Error>k__BackingField                   EventHandler`1<ErrorEventArgs> IL2CPP_TYPE_GENERICINST
    public partial class JsonSerializerSettings : DataModel
    {
        public CultureInfo?                             DefaultCulture                          { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }
        public bool                                     MaxDepthSet                             { get; set; }
        public string                                   DateFormatString                        { get; set; }
        public bool                                     DateFormatStringSet                     { get; set; }
        public IContractResolver?                       ContractResolver                        { get; set; }
        public IEqualityComparer?                       EqualityComparer                        { get; set; }
        public ITraceWriter?                            TraceWriter                             { get; set; }
        public ISerializationBinder?                    SerializationBinder                     { get; set; }

        public static JsonSerializerSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSerializerSettings() { Pointer= p0 };

            value.DefaultCulture                            = GetObject<CultureInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x10 DefaultCulture              ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x48 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.MaxDepthSet                               = GetBool(new IntPtr(p + 0x05C)); // 0x5C MaxDepthSet                 ( ModelPrimitiveType bool bool bool Bool )
            value.DateFormatString                          = GetString(new IntPtr(p + 0x060)); // 0x60 DateFormatString            ( ModelPrimitiveType string string string String )
            value.DateFormatStringSet                       = GetBool(new IntPtr(p + 0x068)); // 0x68 DateFormatStringSet         ( ModelPrimitiveType bool bool bool Bool )
            value.ContractResolver                          = GetObject<IContractResolver>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IContractResolver.FromPointer); // 0xE0 ContractResolver            ( ModelClassType IContractResolver IContractResolver IContractResolver Pointer )
            value.EqualityComparer                          = GetObject<IEqualityComparer>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.IEqualityComparer.FromPointer); // 0xE8 EqualityComparer            ( ModelClassType IEqualityComparer IEqualityComparer IEqualityComparer Pointer )
            value.TraceWriter                               = GetObject<ITraceWriter>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ITraceWriter.FromPointer); // 0xF8 TraceWriter                 ( ModelClassType ITraceWriter ITraceWriter ITraceWriter Pointer )
            value.SerializationBinder                       = GetObject<ISerializationBinder>(new IntPtr(p + 0x100), ReversePrism.DataModels.ISerializationBinder.FromPointer); // 0x100 SerializationBinder         ( ModelClassType ISerializationBinder ISerializationBinder ISerializationBinder Pointer )

            return value;
        }
    }
}
