using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsDefault                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 IsNil                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 SchemaElement                            0001866BED30 ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer
    // 020 SchemaAttribute                          0001865AE470 ModelClassType XmlSchemaAttribute XmlSchemaAttribute XmlSchemaAttribute Pointer
    // 028 SchemaType                               0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 030 MemberType                               0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 038 Validity                                 0001865C35F0 ModelEnumType XmlSchemaValidity XmlSchemaValidity XmlSchemaValidity Int32
    // 03C ContentType                              0001865B30E0 ModelEnumType XmlSchemaContentType XmlSchemaContentType XmlSchemaContentType Int32
    public partial class XmlSchemaInfo : DataModel
    {
        public bool                                     IsDefault                               { get; set; }
        public bool                                     IsNil                                   { get; set; }
        public XmlSchemaElement?                        SchemaElement                           { get; set; }
        public XmlSchemaAttribute?                      SchemaAttribute                         { get; set; }
        public XmlSchemaType?                           SchemaType                              { get; set; }
        public XmlSchemaSimpleType?                     MemberType                              { get; set; }
        public XmlSchemaValidity                        Validity                                { get; set; }
        public XmlSchemaContentType                     ContentType                             { get; set; }

        public static XmlSchemaInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaInfo() { Pointer= p0 };

            value.IsDefault                                 = GetBool(new IntPtr(p + 0x010)); // 024667492548 0x10 IsDefault                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsNil                                     = GetBool(new IntPtr(p + 0x011)); // 024667492568 0x11 IsNil                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SchemaElement                             = GetObject<XmlSchemaElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaElement.FromPointer); // 024667492588 0x18 SchemaElement               ( 0001866BED30 ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer )
            value.SchemaAttribute                           = GetObject<XmlSchemaAttribute>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSchemaAttribute.FromPointer); // 0246674925A8 0x20 SchemaAttribute             ( 0001865AE470 ModelClassType XmlSchemaAttribute XmlSchemaAttribute XmlSchemaAttribute Pointer )
            value.SchemaType                                = GetObject<XmlSchemaType>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0246674925C8 0x28 SchemaType                  ( 0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.MemberType                                = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0246674925E8 0x30 MemberType                  ( 0001866BF5F0 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.Validity                                  = (XmlSchemaValidity)GetInt32(new IntPtr(p + 0x038)); // 024667492608 0x38 Validity                    ( 0001865C35F0 ModelEnumType XmlSchemaValidity XmlSchemaValidity XmlSchemaValidity Int32 )
            value.ContentType                               = (XmlSchemaContentType)GetInt32(new IntPtr(p + 0x03C)); // 024667492628 0x3C ContentType                 ( 0001865B30E0 ModelEnumType XmlSchemaContentType XmlSchemaContentType XmlSchemaContentType Int32 )

            return value;
        }
    }
}
