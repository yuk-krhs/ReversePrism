using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 CollectionItemName                       ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 030 ChildElementNamespace                    ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 038 ItemContract                             ModelClassType DataContract DataContract DataContract Pointer
    // 040 Helper                                   ModelClassType CollectionDataContractCriticalHelper CollectionDataContractCriticalHelper CollectionDataContractCriticalHelper Pointer
    public partial class CollectionDataContract : DataModel
    {
        public XmlDictionaryString?                     CollectionItemName                      { get; set; }
        public XmlDictionaryString?                     ChildElementNamespace                   { get; set; }
        public DataContract?                            ItemContract                            { get; set; }
        public CollectionDataContractCriticalHelper?    Helper                                  { get; set; }

        public static CollectionDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionDataContract() { Pointer= p0 };

            value.CollectionItemName                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x28 CollectionItemName          ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ChildElementNamespace                     = GetObject<XmlDictionaryString>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x30 ChildElementNamespace       ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ItemContract                              = GetObject<DataContract>(new IntPtr(p + 0x038), ReversePrism.DataModels.DataContract.FromPointer); // 0x38 ItemContract                ( ModelClassType DataContract DataContract DataContract Pointer )
            value.Helper                                    = GetObject<CollectionDataContractCriticalHelper>(new IntPtr(p + 0x040), ReversePrism.DataModels.CollectionDataContractCriticalHelper.FromPointer); // 0x40 Helper                      ( ModelClassType CollectionDataContractCriticalHelper CollectionDataContractCriticalHelper CollectionDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
