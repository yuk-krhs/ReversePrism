using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 ContractNamespaces                       000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 030 MemberNames                              000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 038 MemberNamespaces                         000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 040 ChildElementNamespaces                   000185CB37D8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    // 048 Helper                                   00018676E4C0 ModelClassType ClassDataContractCriticalHelper ClassDataContractCriticalHelper ClassDataContractCriticalHelper Pointer
    public partial class ClassDataContract
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
            var value   = new ClassDataContract();

            value.ContractNamespaces                        = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 027004C829D0 0x28 ContractNamespaces          ( 000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.MemberNames                               = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 027004C829F0 0x30 MemberNames                 ( 000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.MemberNamespaces                          = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 027004C82A10 0x38 MemberNamespaces            ( 000185CB38B8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.ChildElementNamespaces                    = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 027004C82A30 0x40 ChildElementNamespaces      ( 000185CB37D8 ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )
            value.Helper                                    = GetObject<ClassDataContractCriticalHelper>(new IntPtr(p + 0x048), ReversePrism.DataModels.ClassDataContractCriticalHelper.FromPointer); // 027004C82A50 0x48 Helper                      ( 00018676E4C0 ModelClassType ClassDataContractCriticalHelper ClassDataContractCriticalHelper ClassDataContractCriticalHelper Pointer )

            return value;
        }
    }
}
