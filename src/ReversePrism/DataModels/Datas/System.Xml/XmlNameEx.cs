using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Flags                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 050 MemberType                               ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 058 SchemaType                               ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 060 decl                                     <object> IL2CPP_TYPE_OBJECT
    public partial class XmlNameEx : DataModel
    {
        public sbyte                                    Flags                                   { get; set; }
        public XmlSchemaSimpleType?                     MemberType                              { get; set; }
        public XmlSchemaType?                           SchemaType                              { get; set; }

        public static XmlNameEx? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNameEx() { Pointer= p0 };

            value.Flags                                     = GetSByte(new IntPtr(p + 0x048)); // 0x48 Flags                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.MemberType                                = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x50 MemberType                  ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.SchemaType                                = GetObject<XmlSchemaType>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0x58 SchemaType                  ( ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )

            return value;
        }
    }
}
