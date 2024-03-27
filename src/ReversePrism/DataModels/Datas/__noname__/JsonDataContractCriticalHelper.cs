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
    // 010 DataContractCache                        000185B8EFB0 ModelClassListType JsonDataContract[] JsonDataContract[] List<JsonDataContract> Pointer
    // 018 DataContractID                           0001865F38E0 ModelPrimitiveType int int int Int32
    // 020 TypeHandleRef                            0001866D6940 ModelClassType TypeHandleRef TypeHandleRef TypeHandleRef Pointer
    // 028 typeToIDCache                            Dictionary`2<TypeHandleRef, IntRef> IL2CPP_TYPE_GENERICINST
    // 010 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 018 TraditionalDataContract                  0001865B6200 ModelClassType DataContract DataContract DataContract Pointer
    // 020 TypeName                                 000186671910 ModelPrimitiveType string string string String
    public partial class JsonDataContractCriticalHelper
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
            var value   = new JsonDataContractCriticalHelper();

            value.DataContractCache                         = GetObjectList<JsonDataContract>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonDataContract.FromPointer); // 027004D37CA0 0x10 DataContractCache           ( 000185B8EFB0 ModelClassListType JsonDataContract[] JsonDataContract[] List<JsonDataContract> Pointer )
            value.DataContractID                            = GetInt32(new IntPtr(p + 0x018)); // 027004D37CC0 0x18 DataContractID              ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.TypeHandleRef                             = GetObject<TypeHandleRef>(new IntPtr(p + 0x020), ReversePrism.DataModels.TypeHandleRef.FromPointer); // 027004D37CE0 0x20 TypeHandleRef               ( 0001866D6940 ModelClassType TypeHandleRef TypeHandleRef TypeHandleRef Pointer )
            value.TraditionalDataContract                   = GetObject<DataContract>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataContract.FromPointer); // 027004D37D40 0x18 TraditionalDataContract     ( 0001865B6200 ModelClassType DataContract DataContract DataContract Pointer )
            value.TypeName                                  = GetString(new IntPtr(p + 0x020)); // 027004D37D60 0x20 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
