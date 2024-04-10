using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxItemsInObjectGraph                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 RootName                                 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 020 RootNamespace                            0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 028 <KnownTypes>k__BackingField              IEnumerable`1<Type> IL2CPP_TYPE_GENERICINST
    // 030 IgnoreExtensionDataObject                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 PreserveObjectReferences                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 DataContractSurrogate                    00018674A640 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    // 040 DataContractResolver                     000186678590 ModelClassType DataContractResolver DataContractResolver DataContractResolver Pointer
    // 048 SerializeReadOnlyTypes                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DataContractSerializerSettings : DataModel
    {
        public int                                      MaxItemsInObjectGraph                   { get; set; }
        public XmlDictionaryString?                     RootName                                { get; set; }
        public XmlDictionaryString?                     RootNamespace                           { get; set; }
        public bool                                     IgnoreExtensionDataObject               { get; set; }
        public bool                                     PreserveObjectReferences                { get; set; }
        public IDataContractSurrogate?                  DataContractSurrogate                   { get; set; }
        public DataContractResolver?                    DataContractResolver                    { get; set; }
        public bool                                     SerializeReadOnlyTypes                  { get; set; }

        public static DataContractSerializerSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataContractSerializerSettings() { Pointer= p0 };

            value.MaxItemsInObjectGraph                     = GetInt32(new IntPtr(p + 0x010)); // 024667D737C8 0x10 MaxItemsInObjectGraph       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RootName                                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 024667D737E8 0x18 RootName                    ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.RootNamespace                             = GetObject<XmlDictionaryString>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 024667D73808 0x20 RootNamespace               ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.IgnoreExtensionDataObject                 = GetBool(new IntPtr(p + 0x030)); // 024667D73848 0x30 IgnoreExtensionDataObject   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PreserveObjectReferences                  = GetBool(new IntPtr(p + 0x031)); // 024667D73868 0x31 PreserveObjectReferences    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 024667D73888 0x38 DataContractSurrogate       ( 00018674A640 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )
            value.DataContractResolver                      = GetObject<DataContractResolver>(new IntPtr(p + 0x040), ReversePrism.DataModels.DataContractResolver.FromPointer); // 024667D738A8 0x40 DataContractResolver        ( 000186678590 ModelClassType DataContractResolver DataContractResolver DataContractResolver Pointer )
            value.SerializeReadOnlyTypes                    = GetBool(new IntPtr(p + 0x048)); // 024667D738C8 0x48 SerializeReadOnlyTypes      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
