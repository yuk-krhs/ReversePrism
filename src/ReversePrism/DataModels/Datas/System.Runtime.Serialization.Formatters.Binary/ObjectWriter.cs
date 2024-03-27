using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_objectQueue                            0001865FFF70 ModelClassType Queue Queue Queue Pointer
    // 018 M_idGenerator                            0001866C8F10 ModelClassType ObjectIDGenerator ObjectIDGenerator ObjectIDGenerator Pointer
    // 020 M_currentId                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_surrogates                             0001865E4F40 ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer
    // 030 M_context                                0001865B8CC0 ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 040 SerWriter                                0001865E5A50 ModelClassType __BinaryWriter __BinaryWriter __BinaryWriter Pointer
    // 048 M_objectManager                          00018672F510 ModelClassType SerializationObjectManager SerializationObjectManager SerializationObjectManager Pointer
    // 050 TopId                                    0001865F7700 ModelPrimitiveType long long long Int64
    // 058 TopName                                  000186671910 ModelPrimitiveType string string string String
    // 060 Headers                                  000185B83DE0 ModelClassListType Header[] Header[] List<Header> Pointer
    // 068 FormatterEnums                           00018671B8C0 ModelClassType InternalFE InternalFE InternalFE Pointer
    // 070 M_binder                                 00018672B3D0 ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer
    // 078 SerObjectInfoInit                        000186728D60 ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer
    // 080 M_formatterConverter                     000186518830 ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer
    // 088 crossAppDomainArray                      <object>[] IL2CPP_TYPE_SZARRAY
    // 090 previousObj                              <object> IL2CPP_TYPE_OBJECT
    // 098 PreviousId                               0001865F7700 ModelPrimitiveType long long long Int64
    // 0A0 PreviousType                             000186692850 ModelClassType Type Type Type Pointer
    // 0A8 PreviousCode                             0001865FCB70 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32
    // 0B0 AssemblyToIdTable                        0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0B8 NiPool                                   0001867294C0 ModelClassType SerStack SerStack SerStack Pointer
    public partial class ObjectWriter
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
            var value   = new ObjectWriter();

            value.M_objectQueue                             = GetObject<Queue>(new IntPtr(p + 0x010), ReversePrism.DataModels.Queue.FromPointer); // 0270D6C2C858 0x10 M_objectQueue               ( 0001865FFF70 ModelClassType Queue Queue Queue Pointer )
            value.M_idGenerator                             = GetObject<ObjectIDGenerator>(new IntPtr(p + 0x018), ReversePrism.DataModels.ObjectIDGenerator.FromPointer); // 0270D6C2C878 0x18 M_idGenerator               ( 0001866C8F10 ModelClassType ObjectIDGenerator ObjectIDGenerator ObjectIDGenerator Pointer )
            value.M_currentId                               = GetInt32(new IntPtr(p + 0x020)); // 0270D6C2C898 0x20 M_currentId                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_surrogates                              = GetObject<ISurrogateSelector>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISurrogateSelector.FromPointer); // 0270D6C2C8B8 0x28 M_surrogates                ( 0001865E4F40 ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer )
            value.M_context                                 = (StreamingContext)GetInt32(new IntPtr(p + 0x030)); // 0270D6C2C8D8 0x30 M_context                   ( 0001865B8CC0 ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.SerWriter                                 = GetObject<__BinaryWriter>(new IntPtr(p + 0x040), ReversePrism.DataModels.__BinaryWriter.FromPointer); // 0270D6C2C8F8 0x40 SerWriter                   ( 0001865E5A50 ModelClassType __BinaryWriter __BinaryWriter __BinaryWriter Pointer )
            value.M_objectManager                           = GetObject<SerializationObjectManager>(new IntPtr(p + 0x048), ReversePrism.DataModels.SerializationObjectManager.FromPointer); // 0270D6C2C918 0x48 M_objectManager             ( 00018672F510 ModelClassType SerializationObjectManager SerializationObjectManager SerializationObjectManager Pointer )
            value.TopId                                     = GetInt64(new IntPtr(p + 0x050)); // 0270D6C2C938 0x50 TopId                       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.TopName                                   = GetString(new IntPtr(p + 0x058)); // 0270D6C2C958 0x58 TopName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Headers                                   = GetObjectList<Header>(new IntPtr(p + 0x060), ReversePrism.DataModels.Header.FromPointer); // 0270D6C2C978 0x60 Headers                     ( 000185B83DE0 ModelClassListType Header[] Header[] List<Header> Pointer )
            value.FormatterEnums                            = GetObject<InternalFE>(new IntPtr(p + 0x068), ReversePrism.DataModels.InternalFE.FromPointer); // 0270D6C2C998 0x68 FormatterEnums              ( 00018671B8C0 ModelClassType InternalFE InternalFE InternalFE Pointer )
            value.M_binder                                  = GetObject<SerializationBinder>(new IntPtr(p + 0x070), ReversePrism.DataModels.SerializationBinder.FromPointer); // 0270D6C2C9B8 0x70 M_binder                    ( 00018672B3D0 ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer )
            value.SerObjectInfoInit                         = GetObject<SerObjectInfoInit>(new IntPtr(p + 0x078), ReversePrism.DataModels.SerObjectInfoInit.FromPointer); // 0270D6C2C9D8 0x78 SerObjectInfoInit           ( 000186728D60 ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer )
            value.M_formatterConverter                      = GetObject<IFormatterConverter>(new IntPtr(p + 0x080), ReversePrism.DataModels.IFormatterConverter.FromPointer); // 0270D6C2C9F8 0x80 M_formatterConverter        ( 000186518830 ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer )
            value.PreviousId                                = GetInt64(new IntPtr(p + 0x098)); // 0270D6C2CA58 0x98 PreviousId                  ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.PreviousType                              = GetObject<Type>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Type.FromPointer); // 0270D6C2CA78 0xA0 PreviousType                ( 000186692850 ModelClassType Type Type Type Pointer )
            value.PreviousCode                              = (InternalPrimitiveTypeE)GetInt32(new IntPtr(p + 0x0A8)); // 0270D6C2CA98 0xA8 PreviousCode                ( 0001865FCB70 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32 )
            value.AssemblyToIdTable                         = GetObject<Hashtable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D6C2CAB8 0xB0 AssemblyToIdTable           ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.NiPool                                    = GetObject<SerStack>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.SerStack.FromPointer); // 0270D6C2CAD8 0xB8 NiPool                      ( 0001867294C0 ModelClassType SerStack SerStack SerStack Pointer )

            return value;
        }
    }
}
