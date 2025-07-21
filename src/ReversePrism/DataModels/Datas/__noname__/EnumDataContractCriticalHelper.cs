using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 typeToName                               Dictionary`2<Type, XmlQualifiedName> IL2CPP_TYPE_GENERICINST
    // 008 nameToType                               Dictionary`2<XmlQualifiedName, Type> IL2CPP_TYPE_GENERICINST
    // 060 BaseContractName                         ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 068 Members                                  ModelClassListType List`1<DataMember> List`1<DataMember> List<DataMember> Pointer
    // 070 Values                                   ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer
    // 078 IsULong                                  ModelPrimitiveType bool bool bool Bool
    // 079 IsFlags                                  ModelPrimitiveType bool bool bool Bool
    // 07A HasDataContract                          ModelPrimitiveType bool bool bool Bool
    // 080 ChildElementNames                        ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer
    public partial class EnumDataContractCriticalHelper : DataModel
    {
        public XmlQualifiedName?                        BaseContractName                        { get; set; }
        public List<DataMember>?                        Members                                 { get; set; }
        public List<long>?                              Values                                  { get; set; }
        public bool                                     IsULong                                 { get; set; }
        public bool                                     IsFlags                                 { get; set; }
        public bool                                     HasDataContract                         { get; set; }
        public List<XmlDictionaryString>?               ChildElementNames                       { get; set; }

        public static EnumDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumDataContractCriticalHelper() { Pointer= p0 };

            value.BaseContractName                          = GetObject<XmlQualifiedName>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x60 BaseContractName            ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.Members                                   = GetObjectList<DataMember>(new IntPtr(p + 0x068), ReversePrism.DataModels.DataMember.FromPointer); // 0x68 Members                     ( ModelClassListType List`1<DataMember> List`1<DataMember> List<DataMember> Pointer )
            value.Values                                    = GetInt64List(new IntPtr(p + 0x070)); // 0x70 Values                      ( ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer )
            value.IsULong                                   = GetBool(new IntPtr(p + 0x078)); // 0x78 IsULong                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsFlags                                   = GetBool(new IntPtr(p + 0x079)); // 0x79 IsFlags                     ( ModelPrimitiveType bool bool bool Bool )
            value.HasDataContract                           = GetBool(new IntPtr(p + 0x07A)); // 0x7A HasDataContract             ( ModelPrimitiveType bool bool bool Bool )
            value.ChildElementNames                         = GetObjectList<XmlDictionaryString>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x80 ChildElementNames           ( ModelClassListType XmlDictionaryString[] XmlDictionaryString[] List<XmlDictionaryString> Pointer )

            return value;
        }
    }
}
