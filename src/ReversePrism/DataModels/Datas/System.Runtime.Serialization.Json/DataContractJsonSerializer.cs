using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 knownTypeList                            IList`1<Type> IL2CPP_TYPE_GENERICINST
    // 018 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 020 EmitTypeInformation                      000186726330 ModelEnumType EmitTypeInformation EmitTypeInformation EmitTypeInformation Int32
    // 028 DataContractSurrogate                    00018674A640 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    // 030 IgnoreExtensionDataObject                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 knownTypeCollection                      ReadOnlyCollection`1<Type> IL2CPP_TYPE_GENERICINST
    // 040 MaxItemsInObjectGraph                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 RootContract                             0001865B6200 ModelClassType DataContract DataContract DataContract Pointer
    // 050 RootName                                 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 058 RootNameRequiresMapping                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 RootType                                 000186692850 ModelClassType Type Type Type Pointer
    // 068 SerializeReadOnlyTypes                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 DateTimeFormat                           000186695190 ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer
    // 078 UseSimpleDictionaryFormat                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DataContractJsonSerializer : DataModel
    {
        public EmitTypeInformation                      EmitTypeInformation                     { get; set; }
        public IDataContractSurrogate?                  DataContractSurrogate                   { get; set; }
        public bool                                     IgnoreExtensionDataObject               { get; set; }
        public int                                      MaxItemsInObjectGraph                   { get; set; }
        public DataContract?                            RootContract                            { get; set; }
        public XmlDictionaryString?                     RootName                                { get; set; }
        public bool                                     RootNameRequiresMapping                 { get; set; }
        public Type?                                    RootType                                { get; set; }
        public bool                                     SerializeReadOnlyTypes                  { get; set; }
        public DateTimeFormat?                          DateTimeFormat                          { get; set; }
        public bool                                     UseSimpleDictionaryFormat               { get; set; }

        public static DataContractJsonSerializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataContractJsonSerializer() { Pointer= p0 };

            value.EmitTypeInformation                       = (EmitTypeInformation)GetInt32(new IntPtr(p + 0x020)); // 0245A4C70DE8 0x20 EmitTypeInformation         ( 000186726330 ModelEnumType EmitTypeInformation EmitTypeInformation EmitTypeInformation Int32 )
            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 0245A4C70E08 0x28 DataContractSurrogate       ( 00018674A640 ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )
            value.IgnoreExtensionDataObject                 = GetBool(new IntPtr(p + 0x030)); // 0245A4C70E28 0x30 IgnoreExtensionDataObject   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MaxItemsInObjectGraph                     = GetInt32(new IntPtr(p + 0x040)); // 0245A4C70E68 0x40 MaxItemsInObjectGraph       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RootContract                              = GetObject<DataContract>(new IntPtr(p + 0x048), ReversePrism.DataModels.DataContract.FromPointer); // 0245A4C70E88 0x48 RootContract                ( 0001865B6200 ModelClassType DataContract DataContract DataContract Pointer )
            value.RootName                                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4C70EA8 0x50 RootName                    ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.RootNameRequiresMapping                   = GetBool(new IntPtr(p + 0x058)); // 0245A4C70EC8 0x58 RootNameRequiresMapping     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RootType                                  = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 0245A4C70EE8 0x60 RootType                    ( 000186692850 ModelClassType Type Type Type Pointer )
            value.SerializeReadOnlyTypes                    = GetBool(new IntPtr(p + 0x068)); // 0245A4C70F08 0x68 SerializeReadOnlyTypes      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DateTimeFormat                            = GetObject<DateTimeFormat>(new IntPtr(p + 0x070), ReversePrism.DataModels.DateTimeFormat.FromPointer); // 0245A4C70F28 0x70 DateTimeFormat              ( 000186695190 ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer )
            value.UseSimpleDictionaryFormat                 = GetBool(new IntPtr(p + 0x078)); // 0245A4C70F48 0x78 UseSimpleDictionaryFormat   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
