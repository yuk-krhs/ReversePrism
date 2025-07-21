using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RootName                                 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 018 RootNamespace                            ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 020 Context                                  ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 030 Binder                                   ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer
    // 038 SurrogateSelector                        ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer
    // 040 MaxItemsInObjectGraph                    ModelPrimitiveType int int int Int32
    // 044 IgnoreExtensionDataObject                ModelPrimitiveType bool bool bool Bool
    // 048 AssemblyFormat                           ModelEnumType FormatterAssemblyStyle FormatterAssemblyStyle FormatterAssemblyStyle Int32
    // 050 CachedDataContract                       ModelClassType DataContract DataContract DataContract Pointer
    // 000 typeNameCache                            Hashtable IL2CPP_TYPE_CLASS
    // 008 unsafeTypeForwardingEnabled              Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class NetDataContractSerializer : DataModel
    {
        public XmlDictionaryString?                     RootName                                { get; set; }
        public XmlDictionaryString?                     RootNamespace                           { get; set; }
        public StreamingContext                         Context                                 { get; set; }
        public SerializationBinder?                     Binder                                  { get; set; }
        public ISurrogateSelector?                      SurrogateSelector                       { get; set; }
        public int                                      MaxItemsInObjectGraph                   { get; set; }
        public bool                                     IgnoreExtensionDataObject               { get; set; }
        public FormatterAssemblyStyle                   AssemblyFormat                          { get; set; }
        public DataContract?                            CachedDataContract                      { get; set; }

        public static NetDataContractSerializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NetDataContractSerializer() { Pointer= p0 };

            value.RootName                                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x10 RootName                    ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.RootNamespace                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x18 RootNamespace               ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.Context                                   = (StreamingContext)GetInt32(new IntPtr(p + 0x020)); // 0x20 Context                     ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.Binder                                    = GetObject<SerializationBinder>(new IntPtr(p + 0x030), ReversePrism.DataModels.SerializationBinder.FromPointer); // 0x30 Binder                      ( ModelClassType SerializationBinder SerializationBinder SerializationBinder Pointer )
            value.SurrogateSelector                         = GetObject<ISurrogateSelector>(new IntPtr(p + 0x038), ReversePrism.DataModels.ISurrogateSelector.FromPointer); // 0x38 SurrogateSelector           ( ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer )
            value.MaxItemsInObjectGraph                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 MaxItemsInObjectGraph       ( ModelPrimitiveType int int int Int32 )
            value.IgnoreExtensionDataObject                 = GetBool(new IntPtr(p + 0x044)); // 0x44 IgnoreExtensionDataObject   ( ModelPrimitiveType bool bool bool Bool )
            value.AssemblyFormat                            = (FormatterAssemblyStyle)GetInt32(new IntPtr(p + 0x048)); // 0x48 AssemblyFormat              ( ModelEnumType FormatterAssemblyStyle FormatterAssemblyStyle FormatterAssemblyStyle Int32 )
            value.CachedDataContract                        = GetObject<DataContract>(new IntPtr(p + 0x050), ReversePrism.DataModels.DataContract.FromPointer); // 0x50 CachedDataContract          ( ModelClassType DataContract DataContract DataContract Pointer )

            return value;
        }
    }
}
