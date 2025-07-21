using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_stream                                 ModelClassType Stream Stream Stream Pointer
    // 018 M_surrogates                             ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer
    // 020 M_context                                ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 030 M_objectManager                          ModelClassType ObjectManager ObjectManager ObjectManager Pointer
    // 038 FormatterEnums                           ModelClassType InternalFE InternalFE InternalFE Pointer
    // 040 M_binder                                 ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer
    // 048 TopId                                    ModelPrimitiveType long long long Int64
    // 050 BSimpleAssembly                          ModelPrimitiveType bool bool bool Bool
    // 058 handlerObject                            <object> IL2CPP_TYPE_OBJECT
    // 060 m_topObject                              <object> IL2CPP_TYPE_OBJECT
    // 068 Headers                                  ModelClassListType Header[] Header[] List<Header> Pointer
    // 070 Handler                                  ModelClassType HeaderHandler HeaderHandler HeaderHandler Pointer
    // 078 SerObjectInfoInit                        ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer
    // 080 M_formatterConverter                     ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer
    // 088 Stack                                    ModelClassType SerStack SerStack SerStack Pointer
    // 090 ValueFixupStack                          ModelClassType SerStack SerStack SerStack Pointer
    // 098 crossAppDomainArray                      <object>[] IL2CPP_TYPE_SZARRAY
    // 0A0 BFullDeserialization                     ModelPrimitiveType bool bool bool Bool
    // 0A1 BOldFormatDetected                       ModelPrimitiveType bool bool bool Bool
    // 0A8 ValTypeObjectIdTable                     ModelClassType IntSizedArray IntSizedArray IntSizedArray Pointer
    // 0B0 TypeCache                                ModelClassType NameCache NameCache NameCache Pointer
    // 0B8 PreviousAssemblyString                   ModelPrimitiveType string string string String
    // 0C0 PreviousName                             ModelPrimitiveType string string string String
    // 0C8 PreviousType                             ModelClassType Type Type Type Pointer
    public partial class ObjectReader : DataModel
    {
        public Stream?                                  M_stream                                { get; set; }
        public ISurrogateSelector?                      M_surrogates                            { get; set; }
        public StreamingContext                         M_context                               { get; set; }
        public ObjectManager?                           M_objectManager                         { get; set; }
        public InternalFE?                              FormatterEnums                          { get; set; }
        public SerializationBinder?                     M_binder                                { get; set; }
        public long                                     TopId                                   { get; set; }
        public bool                                     BSimpleAssembly                         { get; set; }
        public List<Header>?                            Headers                                 { get; set; }
        public HeaderHandler?                           Handler                                 { get; set; }
        public SerObjectInfoInit?                       SerObjectInfoInit                       { get; set; }
        public IFormatterConverter?                     M_formatterConverter                    { get; set; }
        public SerStack?                                Stack                                   { get; set; }
        public SerStack?                                ValueFixupStack                         { get; set; }
        public bool                                     BFullDeserialization                    { get; set; }
        public bool                                     BOldFormatDetected                      { get; set; }
        public IntSizedArray?                           ValTypeObjectIdTable                    { get; set; }
        public NameCache?                               TypeCache                               { get; set; }
        public string                                   PreviousAssemblyString                  { get; set; }
        public string                                   PreviousName                            { get; set; }
        public Type?                                    PreviousType                            { get; set; }

        public static ObjectReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectReader() { Pointer= p0 };

            value.M_stream                                  = GetObject<Stream>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stream.FromPointer); // 0x10 M_stream                    ( ModelClassType Stream Stream Stream Pointer )
            value.M_surrogates                              = GetObject<ISurrogateSelector>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISurrogateSelector.FromPointer); // 0x18 M_surrogates                ( ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer )
            value.M_context                                 = (StreamingContext)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_context                   ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.M_objectManager                           = GetObject<ObjectManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.ObjectManager.FromPointer); // 0x30 M_objectManager             ( ModelClassType ObjectManager ObjectManager ObjectManager Pointer )
            value.FormatterEnums                            = GetObject<InternalFE>(new IntPtr(p + 0x038), ReversePrism.DataModels.InternalFE.FromPointer); // 0x38 FormatterEnums              ( ModelClassType InternalFE InternalFE InternalFE Pointer )
            value.M_binder                                  = GetObject<SerializationBinder>(new IntPtr(p + 0x040), ReversePrism.DataModels.SerializationBinder.FromPointer); // 0x40 M_binder                    ( ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer )
            value.TopId                                     = GetInt64(new IntPtr(p + 0x048)); // 0x48 TopId                       ( ModelPrimitiveType long long long Int64 )
            value.BSimpleAssembly                           = GetBool(new IntPtr(p + 0x050)); // 0x50 BSimpleAssembly             ( ModelPrimitiveType bool bool bool Bool )
            value.Headers                                   = GetObjectList<Header>(new IntPtr(p + 0x068), ReversePrism.DataModels.Header.FromPointer); // 0x68 Headers                     ( ModelClassListType Header[] Header[] List<Header> Pointer )
            value.Handler                                   = GetObject<HeaderHandler>(new IntPtr(p + 0x070), ReversePrism.DataModels.HeaderHandler.FromPointer); // 0x70 Handler                     ( ModelClassType HeaderHandler HeaderHandler HeaderHandler Pointer )
            value.SerObjectInfoInit                         = GetObject<SerObjectInfoInit>(new IntPtr(p + 0x078), ReversePrism.DataModels.SerObjectInfoInit.FromPointer); // 0x78 SerObjectInfoInit           ( ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer )
            value.M_formatterConverter                      = GetObject<IFormatterConverter>(new IntPtr(p + 0x080), ReversePrism.DataModels.IFormatterConverter.FromPointer); // 0x80 M_formatterConverter        ( ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer )
            value.Stack                                     = GetObject<SerStack>(new IntPtr(p + 0x088), ReversePrism.DataModels.SerStack.FromPointer); // 0x88 Stack                       ( ModelClassType SerStack SerStack SerStack Pointer )
            value.ValueFixupStack                           = GetObject<SerStack>(new IntPtr(p + 0x090), ReversePrism.DataModels.SerStack.FromPointer); // 0x90 ValueFixupStack             ( ModelClassType SerStack SerStack SerStack Pointer )
            value.BFullDeserialization                      = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 BFullDeserialization        ( ModelPrimitiveType bool bool bool Bool )
            value.BOldFormatDetected                        = GetBool(new IntPtr(p + 0x0A1)); // 0xA1 BOldFormatDetected          ( ModelPrimitiveType bool bool bool Bool )
            value.ValTypeObjectIdTable                      = GetObject<IntSizedArray>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IntSizedArray.FromPointer); // 0xA8 ValTypeObjectIdTable        ( ModelClassType IntSizedArray IntSizedArray IntSizedArray Pointer )
            value.TypeCache                                 = GetObject<NameCache>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.NameCache.FromPointer); // 0xB0 TypeCache                   ( ModelClassType NameCache NameCache NameCache Pointer )
            value.PreviousAssemblyString                    = GetString(new IntPtr(p + 0x0B8)); // 0xB8 PreviousAssemblyString      ( ModelPrimitiveType string string string String )
            value.PreviousName                              = GetString(new IntPtr(p + 0x0C0)); // 0xC0 PreviousName                ( ModelPrimitiveType string string string String )
            value.PreviousType                              = GetObject<Type>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Type.FromPointer); // 0xC8 PreviousType                ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
