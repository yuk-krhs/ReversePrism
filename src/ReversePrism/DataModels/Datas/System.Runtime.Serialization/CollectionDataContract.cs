using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 CollectionItemName                       0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 030 ChildElementNamespace                    0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 038 ItemContract                             0001865B6200 ModelClassType DataContract DataContract DataContract Pointer
    // 040 Helper                                   000186774090 ModelClassType CollectionDataContractCriticalHelper CollectionDataContractCriticalHelper CollectionDataContractCriticalHelper Pointer
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

            value.CollectionItemName                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC19D0 0x28 CollectionItemName          ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ChildElementNamespace                     = GetObject<XmlDictionaryString>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CC19F0 0x30 ChildElementNamespace       ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.ItemContract                              = GetObject<DataContract>(new IntPtr(p + 0x038), ReversePrism.DataModels.DataContract.FromPointer); // 0245A4CC1A10 0x38 ItemContract                ( 0001865B6200 ModelClassType DataContract DataContract DataContract Pointer )
            value.Helper                                    = GetObject<CollectionDataContractCriticalHelper>(new IntPtr(p + 0x040), ReversePrism.DataModels.CollectionDataContractCriticalHelper.FromPointer); // 0245A4CC1A30 0x40 Helper                      ( 000186774090 ModelClassType CollectionDataContractCriticalHelper CollectionDataContractCriticalHelper CollectionDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
