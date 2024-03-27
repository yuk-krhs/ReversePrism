using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 BaseTypes                                0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 058 MemberTypes                              000185CB4088 ModelClassListType XmlQualifiedName[] XmlQualifiedName[] List<XmlQualifiedName> Pointer
    // 060 BaseMemberTypes                          000185CB4AA8 ModelClassListType XmlSchemaSimpleType[] XmlSchemaSimpleType[] List<XmlSchemaSimpleType> Pointer
    public partial class XmlSchemaSimpleTypeUnion
    {
        public XmlSchemaObjectCollection?               BaseTypes                               { get; set; }
        public List<XmlQualifiedName>?                  MemberTypes                             { get; set; }
        public List<XmlSchemaSimpleType>?               BaseMemberTypes                         { get; set; }

        public static XmlSchemaSimpleTypeUnion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSimpleTypeUnion();

            value.BaseTypes                                 = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0270D75BC118 0x50 BaseTypes                   ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.MemberTypes                               = GetObjectList<XmlQualifiedName>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D75BC138 0x58 MemberTypes                 ( 000185CB4088 ModelClassListType XmlQualifiedName[] XmlQualifiedName[] List<XmlQualifiedName> Pointer )
            value.BaseMemberTypes                           = GetObjectList<XmlSchemaSimpleType>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0270D75BC158 0x60 BaseMemberTypes             ( 000185CB4AA8 ModelClassListType XmlSchemaSimpleType[] XmlSchemaSimpleType[] List<XmlSchemaSimpleType> Pointer )

            return value;
        }
    }
}
