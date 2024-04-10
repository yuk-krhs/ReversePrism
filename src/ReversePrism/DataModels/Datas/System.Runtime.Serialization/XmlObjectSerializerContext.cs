using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Serializer                               0001865A5490 ModelClassType XmlObjectSerializer XmlObjectSerializer XmlObjectSerializer Pointer
    // 018 RootTypeDataContract                     0001865B6430 ModelClassType DataContract DataContract DataContract Pointer
    // 020 ScopedKnownTypes                         0001866ECFA0 ModelEnumType ScopedKnownTypes ScopedKnownTypes ScopedKnownTypes Int32
    // 030 serializerKnownDataContracts             Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 038 IsSerializerKnownDataContractsSetExplicit 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 serializerKnownTypeList                  IList`1<Type> IL2CPP_TYPE_GENERICINST
    // 048 DemandedSerializationFormatterPermission 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 DemandedMemberAccessPermission           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04C ItemCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 MaxItemsInObjectGraph                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 StreamingContext                         0001865B8CC0 ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 068 IgnoreExtensionDataObject                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 DataContractResolver                     000186678590 ModelClassType DataContractResolver DataContractResolver DataContractResolver Pointer
    // 078 KnownTypeResolver                        000186774640 ModelClassType KnownTypeDataContractResolver KnownTypeDataContractResolver KnownTypeDataContractResolver Pointer
    // 000 incrementItemCountMethod                 MethodInfo IL2CPP_TYPE_CLASS
    public partial class XmlObjectSerializerContext : DataModel
    {
        public XmlObjectSerializer?                     Serializer                              { get; set; }
        public DataContract?                            RootTypeDataContract                    { get; set; }
        public ScopedKnownTypes                         ScopedKnownTypes                        { get; set; }
        public bool                                     IsSerializerKnownDataContractsSetExplicit { get; set; }
        public bool                                     DemandedSerializationFormatterPermission { get; set; }
        public bool                                     DemandedMemberAccessPermission          { get; set; }
        public int                                      ItemCount                               { get; set; }
        public int                                      MaxItemsInObjectGraph                   { get; set; }
        public StreamingContext                         StreamingContext                        { get; set; }
        public bool                                     IgnoreExtensionDataObject               { get; set; }
        public DataContractResolver?                    DataContractResolver                    { get; set; }
        public KnownTypeDataContractResolver?           KnownTypeResolver                       { get; set; }

        public static XmlObjectSerializerContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlObjectSerializerContext() { Pointer= p0 };

            value.Serializer                                = GetObject<XmlObjectSerializer>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlObjectSerializer.FromPointer); // 0245A4D26B08 0x10 Serializer                  ( 0001865A5490 ModelClassType XmlObjectSerializer XmlObjectSerializer XmlObjectSerializer Pointer )
            value.RootTypeDataContract                      = GetObject<DataContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataContract.FromPointer); // 0245A4D26B28 0x18 RootTypeDataContract        ( 0001865B6430 ModelClassType DataContract DataContract DataContract Pointer )
            value.ScopedKnownTypes                          = (ScopedKnownTypes)GetInt32(new IntPtr(p + 0x020)); // 0245A4D26B48 0x20 ScopedKnownTypes            ( 0001866ECFA0 ModelEnumType ScopedKnownTypes ScopedKnownTypes ScopedKnownTypes Int32 )
            value.IsSerializerKnownDataContractsSetExplicit = GetBool(new IntPtr(p + 0x038)); // 0245A4D26B88 0x38 IsSerializerKnownDataContractsSetExplicit ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DemandedSerializationFormatterPermission  = GetBool(new IntPtr(p + 0x048)); // 0245A4D26BC8 0x48 DemandedSerializationFormatterPermission ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DemandedMemberAccessPermission            = GetBool(new IntPtr(p + 0x049)); // 0245A4D26BE8 0x49 DemandedMemberAccessPermission ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ItemCount                                 = GetInt32(new IntPtr(p + 0x04C)); // 0245A4D26C08 0x4C ItemCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxItemsInObjectGraph                     = GetInt32(new IntPtr(p + 0x050)); // 0245A4D26C28 0x50 MaxItemsInObjectGraph       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StreamingContext                          = (StreamingContext)GetInt32(new IntPtr(p + 0x058)); // 0245A4D26C48 0x58 StreamingContext            ( 0001865B8CC0 ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.IgnoreExtensionDataObject                 = GetBool(new IntPtr(p + 0x068)); // 0245A4D26C68 0x68 IgnoreExtensionDataObject   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DataContractResolver                      = GetObject<DataContractResolver>(new IntPtr(p + 0x070), ReversePrism.DataModels.DataContractResolver.FromPointer); // 0245A4D26C88 0x70 DataContractResolver        ( 000186678590 ModelClassType DataContractResolver DataContractResolver DataContractResolver Pointer )
            value.KnownTypeResolver                         = GetObject<KnownTypeDataContractResolver>(new IntPtr(p + 0x078), ReversePrism.DataModels.KnownTypeDataContractResolver.FromPointer); // 0245A4D26CA8 0x78 KnownTypeResolver           ( 000186774640 ModelClassType KnownTypeDataContractResolver KnownTypeDataContractResolver KnownTypeDataContractResolver Pointer )

            return value;
        }
    }
}
