using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 cacheLock                                <object> IL2CPP_TYPE_OBJECT
    // 008 createDataContractLock                   <object> IL2CPP_TYPE_OBJECT
    // 010 DataContractCache                        ModelClassListType JsonDataContract[] JsonDataContract[] List<JsonDataContract> Pointer
    // 018 DataContractID                           ModelPrimitiveType int int int Int32
    // 020 TypeHandleRef                            ModelClassType TypeHandleRef TypeHandleRef TypeHandleRef Pointer
    // 028 typeToIDCache                            Dictionary`2<TypeHandleRef, IntRef> IL2CPP_TYPE_GENERICINST
    // 010 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 018 TraditionalDataContract                  ModelClassType DataContract DataContract DataContract Pointer
    // 020 TypeName                                 ModelPrimitiveType string string string String
    public partial class JsonDataContractCriticalHelper : DataModel
    {
        public List<JsonDataContract>?                  DataContractCache                       { get; set; }
        public int                                      DataContractID                          { get; set; }
        public TypeHandleRef?                           TypeHandleRef                           { get; set; }
        public DataContract?                            TraditionalDataContract                 { get; set; }
        public string                                   TypeName                                { get; set; }

        public static JsonDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonDataContractCriticalHelper() { Pointer= p0 };

            value.DataContractCache                         = GetObjectList<JsonDataContract>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonDataContract.FromPointer); // 0x10 DataContractCache           ( ModelClassListType JsonDataContract[] JsonDataContract[] List<JsonDataContract> Pointer )
            value.DataContractID                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 DataContractID              ( ModelPrimitiveType int int int Int32 )
            value.TypeHandleRef                             = GetObject<TypeHandleRef>(new IntPtr(p + 0x020), ReversePrism.DataModels.TypeHandleRef.FromPointer); // 0x20 TypeHandleRef               ( ModelClassType TypeHandleRef TypeHandleRef TypeHandleRef Pointer )
            value.TraditionalDataContract                   = GetObject<DataContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataContract.FromPointer); // 0x18 TraditionalDataContract     ( ModelClassType DataContract DataContract DataContract Pointer )
            value.TypeName                                  = GetString(new IntPtr(p + 0x020)); // 0x20 TypeName                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
