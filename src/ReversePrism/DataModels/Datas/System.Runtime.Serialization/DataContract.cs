using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 018 Ns                                       0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 020 Helper                                   000186577E80 ModelClassType DataContractCriticalHelper DataContractCriticalHelper DataContractCriticalHelper Pointer
    public partial class DataContract : DataModel
    {
        public XmlDictionaryString?                     Name                                    { get; set; }
        public XmlDictionaryString?                     Ns                                      { get; set; }
        public DataContractCriticalHelper?              Helper                                  { get; set; }

        public static DataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataContract() { Pointer= p0 };

            value.Name                                      = GetObject<XmlDictionaryString>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CACAF8 0x10 Name                        ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.Ns                                        = GetObject<XmlDictionaryString>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0245A4CACB18 0x18 Ns                          ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.Helper                                    = GetObject<DataContractCriticalHelper>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataContractCriticalHelper.FromPointer); // 0245A4CACB38 0x20 Helper                      ( 000186577E80 ModelClassType DataContractCriticalHelper DataContractCriticalHelper DataContractCriticalHelper Pointer )

            return value;
        }
    }
}
