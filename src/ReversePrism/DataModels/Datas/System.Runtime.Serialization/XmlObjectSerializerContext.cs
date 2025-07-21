using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Serializer                               ModelClassType XmlObjectSerializer XmlObjectSerializer XmlObjectSerializer Pointer
    // 018 RootTypeDataContract                     ModelClassType DataContract DataContract DataContract Pointer
    // 020 ScopedKnownTypes                         ModelEnumType ScopedKnownTypes ScopedKnownTypes ScopedKnownTypes Int32
    // 030 serializerKnownDataContracts             Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 038 IsSerializerKnownDataContractsSetExplicit ModelPrimitiveType bool bool bool Bool
    // 040 serializerKnownTypeList                  IList`1<Type> IL2CPP_TYPE_GENERICINST
    // 048 DemandedSerializationFormatterPermission ModelPrimitiveType bool bool bool Bool
    // 049 DemandedMemberAccessPermission           ModelPrimitiveType bool bool bool Bool
    // 04C ItemCount                                ModelPrimitiveType int int int Int32
    // 050 MaxItemsInObjectGraph                    ModelPrimitiveType int int int Int32
    // 058 StreamingContext                         ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 068 IgnoreExtensionDataObject                ModelPrimitiveType bool bool bool Bool
    // 070 DataContractResolver                     ModelClassType DataContractResolver DataContractResolver DataContractResolver Pointer
    // 078 KnownTypeResolver                        ModelClassType KnownTypeDataContractResolver KnownTypeDataContractResolver KnownTypeDataContractResolver Pointer
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

            value.Serializer                                = GetObject<XmlObjectSerializer>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlObjectSerializer.FromPointer); // 0x10 Serializer                  ( ModelClassType XmlObjectSerializer XmlObjectSerializer XmlObjectSerializer Pointer )
            value.RootTypeDataContract                      = GetObject<DataContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataContract.FromPointer); // 0x18 RootTypeDataContract        ( ModelClassType DataContract DataContract DataContract Pointer )
            value.ScopedKnownTypes                          = (ScopedKnownTypes)GetInt32(new IntPtr(p + 0x020)); // 0x20 ScopedKnownTypes            ( ModelEnumType ScopedKnownTypes ScopedKnownTypes ScopedKnownTypes Int32 )
            value.IsSerializerKnownDataContractsSetExplicit = GetBool(new IntPtr(p + 0x038)); // 0x38 IsSerializerKnownDataContractsSetExplicit ( ModelPrimitiveType bool bool bool Bool )
            value.DemandedSerializationFormatterPermission  = GetBool(new IntPtr(p + 0x048)); // 0x48 DemandedSerializationFormatterPermission ( ModelPrimitiveType bool bool bool Bool )
            value.DemandedMemberAccessPermission            = GetBool(new IntPtr(p + 0x049)); // 0x49 DemandedMemberAccessPermission ( ModelPrimitiveType bool bool bool Bool )
            value.ItemCount                                 = GetInt32(new IntPtr(p + 0x04C)); // 0x4C ItemCount                   ( ModelPrimitiveType int int int Int32 )
            value.MaxItemsInObjectGraph                     = GetInt32(new IntPtr(p + 0x050)); // 0x50 MaxItemsInObjectGraph       ( ModelPrimitiveType int int int Int32 )
            value.StreamingContext                          = (StreamingContext)GetInt32(new IntPtr(p + 0x058)); // 0x58 StreamingContext            ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.IgnoreExtensionDataObject                 = GetBool(new IntPtr(p + 0x068)); // 0x68 IgnoreExtensionDataObject   ( ModelPrimitiveType bool bool bool Bool )
            value.DataContractResolver                      = GetObject<DataContractResolver>(new IntPtr(p + 0x070), ReversePrism.DataModels.DataContractResolver.FromPointer); // 0x70 DataContractResolver        ( ModelClassType DataContractResolver DataContractResolver DataContractResolver Pointer )
            value.KnownTypeResolver                         = GetObject<KnownTypeDataContractResolver>(new IntPtr(p + 0x078), ReversePrism.DataModels.KnownTypeDataContractResolver.FromPointer); // 0x78 KnownTypeResolver           ( ModelClassType KnownTypeDataContractResolver KnownTypeDataContractResolver KnownTypeDataContractResolver Pointer )

            return value;
        }
    }
}
