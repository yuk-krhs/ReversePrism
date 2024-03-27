using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RootType                                 000186692850 ModelClassType Type Type Type Pointer
    // 018 RootContract                             0001865B6200 ModelClassType DataContract DataContract DataContract Pointer
    // 020 NeedsContractNsAtRoot                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 RootName                                 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 030 RootNamespace                            0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 038 MaxItemsInObjectGraph                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C IgnoreExtensionDataObject                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03D PreserveObjectReferences                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 DataContractSurrogate                    00018674A640 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    // 048 knownTypeCollection                      ReadOnlyCollection`1<Type> IL2CPP_TYPE_GENERICINST
    // 050 knownTypeList                            IList`1<Type> IL2CPP_TYPE_GENERICINST
    // 058 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 060 DataContractResolver                     000186678590 ModelClassType DataContractResolver DataContractResolver DataContractResolver Pointer
    // 068 SerializeReadOnlyTypes                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DataContractSerializer
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
            var value   = new DataContractSerializer();

            value.RootType                                  = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D7CEFD70 0x10 RootType                    ( 000186692850 ModelClassType Type Type Type Pointer )
            value.RootContract                              = GetObject<DataContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataContract.FromPointer); // 0270D7CEFD90 0x18 RootContract                ( 0001865B6200 ModelClassType DataContract DataContract DataContract Pointer )
            value.NeedsContractNsAtRoot                     = GetBool(new IntPtr(p + 0x020)); // 0270D7CEFDB0 0x20 NeedsContractNsAtRoot       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RootName                                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0270D7CEFDD0 0x28 RootName                    ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.RootNamespace                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0270D7CEFDF0 0x30 RootNamespace               ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.MaxItemsInObjectGraph                     = GetInt32(new IntPtr(p + 0x038)); // 0270D7CEFE10 0x38 MaxItemsInObjectGraph       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IgnoreExtensionDataObject                 = GetBool(new IntPtr(p + 0x03C)); // 0270D7CEFE30 0x3C IgnoreExtensionDataObject   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PreserveObjectReferences                  = GetBool(new IntPtr(p + 0x03D)); // 0270D7CEFE50 0x3D PreserveObjectReferences    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 0270D7CEFE70 0x40 DataContractSurrogate       ( 00018674A640 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )
            value.DataContractResolver                      = GetObject<DataContractResolver>(new IntPtr(p + 0x060), ReversePrism.DataModels.DataContractResolver.FromPointer); // 0270D7CEFEF0 0x60 DataContractResolver        ( 000186678590 ModelClassType DataContractResolver DataContractResolver DataContractResolver Pointer )
            value.SerializeReadOnlyTypes                    = GetBool(new IntPtr(p + 0x068)); // 0270D7CEFF10 0x68 SerializeReadOnlyTypes      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
