using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_objectQueue                            ModelClassType Queue Queue Queue Pointer
    // 018 M_idGenerator                            ModelClassType ObjectIDGenerator ObjectIDGenerator ObjectIDGenerator Pointer
    // 020 M_currentId                              ModelPrimitiveType int int int Int32
    // 028 M_surrogates                             ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer
    // 030 M_context                                ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 040 SerWriter                                ModelClassType __BinaryWriter __BinaryWriter __BinaryWriter Pointer
    // 048 M_objectManager                          ModelClassType SerializationObjectManager SerializationObjectManager SerializationObjectManager Pointer
    // 050 TopId                                    ModelPrimitiveType long long long Int64
    // 058 TopName                                  ModelPrimitiveType string string string String
    // 060 Headers                                  ModelClassListType Header[] Header[] List<Header> Pointer
    // 068 FormatterEnums                           ModelClassType InternalFE InternalFE InternalFE Pointer
    // 070 M_binder                                 ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer
    // 078 SerObjectInfoInit                        ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer
    // 080 M_formatterConverter                     ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer
    // 088 crossAppDomainArray                      <object>[] IL2CPP_TYPE_SZARRAY
    // 090 previousObj                              <object> IL2CPP_TYPE_OBJECT
    // 098 PreviousId                               ModelPrimitiveType long long long Int64
    // 0A0 PreviousType                             ModelClassType Type Type Type Pointer
    // 0A8 PreviousCode                             ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32
    // 0B0 AssemblyToIdTable                        ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0B8 NiPool                                   ModelClassType SerStack SerStack SerStack Pointer
    public partial class ObjectWriter : DataModel
    {
        public Queue?                                   M_objectQueue                           { get; set; }
        public ObjectIDGenerator?                       M_idGenerator                           { get; set; }
        public int                                      M_currentId                             { get; set; }
        public ISurrogateSelector?                      M_surrogates                            { get; set; }
        public StreamingContext                         M_context                               { get; set; }
        public __BinaryWriter?                          SerWriter                               { get; set; }
        public SerializationObjectManager?              M_objectManager                         { get; set; }
        public long                                     TopId                                   { get; set; }
        public string                                   TopName                                 { get; set; }
        public List<Header>?                            Headers                                 { get; set; }
        public InternalFE?                              FormatterEnums                          { get; set; }
        public SerializationBinder?                     M_binder                                { get; set; }
        public SerObjectInfoInit?                       SerObjectInfoInit                       { get; set; }
        public IFormatterConverter?                     M_formatterConverter                    { get; set; }
        public long                                     PreviousId                              { get; set; }
        public Type?                                    PreviousType                            { get; set; }
        public InternalPrimitiveTypeE                   PreviousCode                            { get; set; }
        public Hashtable?                               AssemblyToIdTable                       { get; set; }
        public SerStack?                                NiPool                                  { get; set; }

        public static ObjectWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectWriter() { Pointer= p0 };

            value.M_objectQueue                             = GetObject<Queue>(new IntPtr(p + 0x010), ReversePrism.DataModels.Queue.FromPointer); // 0x10 M_objectQueue               ( ModelClassType Queue Queue Queue Pointer )
            value.M_idGenerator                             = GetObject<ObjectIDGenerator>(new IntPtr(p + 0x018), ReversePrism.DataModels.ObjectIDGenerator.FromPointer); // 0x18 M_idGenerator               ( ModelClassType ObjectIDGenerator ObjectIDGenerator ObjectIDGenerator Pointer )
            value.M_currentId                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_currentId                 ( ModelPrimitiveType int int int Int32 )
            value.M_surrogates                              = GetObject<ISurrogateSelector>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISurrogateSelector.FromPointer); // 0x28 M_surrogates                ( ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer )
            value.M_context                                 = (StreamingContext)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_context                   ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.SerWriter                                 = GetObject<__BinaryWriter>(new IntPtr(p + 0x040), ReversePrism.DataModels.__BinaryWriter.FromPointer); // 0x40 SerWriter                   ( ModelClassType __BinaryWriter __BinaryWriter __BinaryWriter Pointer )
            value.M_objectManager                           = GetObject<SerializationObjectManager>(new IntPtr(p + 0x048), ReversePrism.DataModels.SerializationObjectManager.FromPointer); // 0x48 M_objectManager             ( ModelClassType SerializationObjectManager SerializationObjectManager SerializationObjectManager Pointer )
            value.TopId                                     = GetInt64(new IntPtr(p + 0x050)); // 0x50 TopId                       ( ModelPrimitiveType long long long Int64 )
            value.TopName                                   = GetString(new IntPtr(p + 0x058)); // 0x58 TopName                     ( ModelPrimitiveType string string string String )
            value.Headers                                   = GetObjectList<Header>(new IntPtr(p + 0x060), ReversePrism.DataModels.Header.FromPointer); // 0x60 Headers                     ( ModelClassListType Header[] Header[] List<Header> Pointer )
            value.FormatterEnums                            = GetObject<InternalFE>(new IntPtr(p + 0x068), ReversePrism.DataModels.InternalFE.FromPointer); // 0x68 FormatterEnums              ( ModelClassType InternalFE InternalFE InternalFE Pointer )
            value.M_binder                                  = GetObject<SerializationBinder>(new IntPtr(p + 0x070), ReversePrism.DataModels.SerializationBinder.FromPointer); // 0x70 M_binder                    ( ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer )
            value.SerObjectInfoInit                         = GetObject<SerObjectInfoInit>(new IntPtr(p + 0x078), ReversePrism.DataModels.SerObjectInfoInit.FromPointer); // 0x78 SerObjectInfoInit           ( ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer )
            value.M_formatterConverter                      = GetObject<IFormatterConverter>(new IntPtr(p + 0x080), ReversePrism.DataModels.IFormatterConverter.FromPointer); // 0x80 M_formatterConverter        ( ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer )
            value.PreviousId                                = GetInt64(new IntPtr(p + 0x098)); // 0x98 PreviousId                  ( ModelPrimitiveType long long long Int64 )
            value.PreviousType                              = GetObject<Type>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Type.FromPointer); // 0xA0 PreviousType                ( ModelClassType Type Type Type Pointer )
            value.PreviousCode                              = (InternalPrimitiveTypeE)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 PreviousCode                ( ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32 )
            value.AssemblyToIdTable                         = GetObject<Hashtable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Hashtable.FromPointer); // 0xB0 AssemblyToIdTable           ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.NiPool                                    = GetObject<SerStack>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.SerStack.FromPointer); // 0xB8 NiPool                      ( ModelClassType SerStack SerStack SerStack Pointer )

            return value;
        }
    }
}
