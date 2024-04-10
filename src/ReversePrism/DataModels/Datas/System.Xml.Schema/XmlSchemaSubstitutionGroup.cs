using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 MembersList                              00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 040 Examplar                                 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    public partial class XmlSchemaSubstitutionGroup : DataModel
    {
        public ArrayList?                               MembersList                             { get; set; }
        public XmlQualifiedName?                        Examplar                                { get; set; }

        public static XmlSchemaSubstitutionGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSubstitutionGroup() { Pointer= p0 };

            value.MembersList                               = GetObject<ArrayList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ArrayList.FromPointer); // 0246675B1BB8 0x38 MembersList                 ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Examplar                                  = GetObject<XmlQualifiedName>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246675B1BD8 0x40 Examplar                    ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}
