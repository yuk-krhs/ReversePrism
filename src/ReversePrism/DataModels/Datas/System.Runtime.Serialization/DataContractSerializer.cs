using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RootType                                 ModelClassType Type Type Type Pointer
    // 018 RootContract                             ModelClassType DataContract DataContract DataContract Pointer
    // 020 NeedsContractNsAtRoot                    ModelPrimitiveType bool bool bool Bool
    // 028 RootName                                 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 030 RootNamespace                            ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 038 MaxItemsInObjectGraph                    ModelPrimitiveType int int int Int32
    // 03C IgnoreExtensionDataObject                ModelPrimitiveType bool bool bool Bool
    // 03D PreserveObjectReferences                 ModelPrimitiveType bool bool bool Bool
    // 040 DataContractSurrogate                    ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    // 048 knownTypeCollection                      ReadOnlyCollection`1<Type> IL2CPP_TYPE_GENERICINST
    // 050 knownTypeList                            IList`1<Type> IL2CPP_TYPE_GENERICINST
    // 058 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 060 DataContractResolver                     ModelClassType DataContractResolver DataContractResolver DataContractResolver Pointer
    // 068 SerializeReadOnlyTypes                   ModelPrimitiveType bool bool bool Bool
    public partial class DataContractSerializer : DataModel
    {
        public Type?                                    RootType                                { get; set; }
        public DataContract?                            RootContract                            { get; set; }
        public bool                                     NeedsContractNsAtRoot                   { get; set; }
        public XmlDictionaryString?                     RootName                                { get; set; }
        public XmlDictionaryString?                     RootNamespace                           { get; set; }
        public int                                      MaxItemsInObjectGraph                   { get; set; }
        public bool                                     IgnoreExtensionDataObject               { get; set; }
        public bool                                     PreserveObjectReferences                { get; set; }
        public IDataContractSurrogate?                  DataContractSurrogate                   { get; set; }
        public DataContractResolver?                    DataContractResolver                    { get; set; }
        public bool                                     SerializeReadOnlyTypes                  { get; set; }

        public static DataContractSerializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataContractSerializer() { Pointer= p0 };

            value.RootType                                  = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 RootType                    ( ModelClassType Type Type Type Pointer )
            value.RootContract                              = GetObject<DataContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataContract.FromPointer); // 0x18 RootContract                ( ModelClassType DataContract DataContract DataContract Pointer )
            value.NeedsContractNsAtRoot                     = GetBool(new IntPtr(p + 0x020)); // 0x20 NeedsContractNsAtRoot       ( ModelPrimitiveType bool bool bool Bool )
            value.RootName                                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x28 RootName                    ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.RootNamespace                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x30 RootNamespace               ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.MaxItemsInObjectGraph                     = GetInt32(new IntPtr(p + 0x038)); // 0x38 MaxItemsInObjectGraph       ( ModelPrimitiveType int int int Int32 )
            value.IgnoreExtensionDataObject                 = GetBool(new IntPtr(p + 0x03C)); // 0x3C IgnoreExtensionDataObject   ( ModelPrimitiveType bool bool bool Bool )
            value.PreserveObjectReferences                  = GetBool(new IntPtr(p + 0x03D)); // 0x3D PreserveObjectReferences    ( ModelPrimitiveType bool bool bool Bool )
            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 0x40 DataContractSurrogate       ( ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )
            value.DataContractResolver                      = GetObject<DataContractResolver>(new IntPtr(p + 0x060), ReversePrism.DataModels.DataContractResolver.FromPointer); // 0x60 DataContractResolver        ( ModelClassType DataContractResolver DataContractResolver DataContractResolver Pointer )
            value.SerializeReadOnlyTypes                    = GetBool(new IntPtr(p + 0x068)); // 0x68 SerializeReadOnlyTypes      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
