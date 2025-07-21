using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 ContractNamespaces                       ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 030 MemberNames                              ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 038 MemberNamespaces                         ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 040 ChildElementNamespaces                   ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 048 Helper                                   ModelClassType ClassDataContractCriticalHelper ClassDataContractCriticalHelper ClassDataContractCriticalHelper Pointer
    public partial class ClassDataContract : DataModel
    {
        public List<XmlDictionaryString>?               ContractNamespaces                      { get; set; }
        public List<XmlDictionaryString>?               MemberNames                             { get; set; }
        public List<XmlDictionaryString>?               MemberNamespaces                        { get; set; }
        public List<XmlDictionaryString>?               ChildElementNamespaces                  { get; set; }
        public ClassDataContractCriticalHelper?         Helper                                  { get; set; }

        public static ClassDataContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClassDataContract() { Pointer= p0 };

            value.ContractNamespaces                        = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x28 ContractNamespaces          ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.MemberNames                               = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x30 MemberNames                 ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.MemberNamespaces                          = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x38 MemberNamespaces            ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.ChildElementNamespaces                    = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x40 ChildElementNamespaces      ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.Helper                                    = GetObject<ClassDataContractCriticalHelper>(new IntPtr(p + 0x048), ReversePrism.DataModels.ClassDataContractCriticalHelper.FromPointer); // 0x48 Helper                      ( ModelClassType ClassDataContractCriticalHelper ClassDataContractCriticalHelper ClassDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
