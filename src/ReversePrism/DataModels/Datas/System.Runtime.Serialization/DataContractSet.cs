using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 contracts                                Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 018 processedContracts                       Dictionary`2<DataContract, <object>> IL2CPP_TYPE_GENERICINST
    // 020 DataContractSurrogate                    ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer
    // 028 SurrogateDataTable                       ModelClassType Hashtable Hashtable Hashtable Pointer
    // 030 knownTypesForObject                      Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 038 referencedTypes                          ICollection`1<Type> IL2CPP_TYPE_GENERICINST
    // 040 referencedCollectionTypes                ICollection`1<Type> IL2CPP_TYPE_GENERICINST
    // 048 referencedTypesDictionary                Dictionary`2<XmlQualifiedName, <object>> IL2CPP_TYPE_GENERICINST
    // 050 referencedCollectionTypesDictionary      Dictionary`2<XmlQualifiedName, <object>> IL2CPP_TYPE_GENERICINST
    public partial class DataContractSet : DataModel
    {
        public IDataContractSurrogate?                  DataContractSurrogate                   { get; set; }
        public Hashtable?                               SurrogateDataTable                      { get; set; }

        public static DataContractSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataContractSet() { Pointer= p0 };

            value.DataContractSurrogate                     = GetObject<IDataContractSurrogate>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDataContractSurrogate.FromPointer); // 0x20 DataContractSurrogate       ( ModelClassType IDataContractSurrogate IDataContractSurrogate IDataContractSurrogate Pointer )
            value.SurrogateDataTable                        = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 0x28 SurrogateDataTable          ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
