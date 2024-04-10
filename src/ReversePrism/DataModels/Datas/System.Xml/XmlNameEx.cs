using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Flags                                    00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 050 MemberType                               0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 058 SchemaType                               0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
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

            value.Flags                                     = GetSByte(new IntPtr(p + 0x048)); // 0246674B4AD0 0x48 Flags                       ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.MemberType                                = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0246674B4AF0 0x50 MemberType                  ( 0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.SchemaType                                = GetObject<XmlSchemaType>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0246674B4B10 0x58 SchemaType                  ( 0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )

            return value;
        }
    }
}
