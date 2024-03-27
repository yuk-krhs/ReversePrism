using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContentType                              0001865B30E0 ModelEnumType XmlSchemaContentType XmlSchemaContentType XmlSchemaContentType Int32
    // 014 IsOpen                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 015 IsEmptiable                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 Empty                                    ContentValidator IL2CPP_TYPE_CLASS
    // 008 TextOnly                                 ContentValidator IL2CPP_TYPE_CLASS
    // 010 Mixed                                    000186612B90 ModelClassType ContentValidator ContentValidator ContentValidator Pointer
    // 018 Any                                      000186612B90 ModelClassType ContentValidator ContentValidator ContentValidator Pointer
    public partial class ContentValidator
    {
        public XmlSchemaContentType                     ContentType                             { get; set; }
        public bool                                     IsOpen                                  { get; set; }
        public bool                                     IsEmptiable                             { get; set; }
        public ContentValidator?                        Mixed                                   { get; set; }
        public ContentValidator?                        Any                                     { get; set; }

        public static ContentValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentValidator();

            value.ContentType                               = (XmlSchemaContentType)GetInt32(new IntPtr(p + 0x010)); // 0270D747C1E8 0x10 ContentType                 ( 0001865B30E0 ModelEnumType XmlSchemaContentType XmlSchemaContentType XmlSchemaContentType Int32 )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x014)); // 0270D747C208 0x14 IsOpen                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsEmptiable                               = GetBool(new IntPtr(p + 0x015)); // 0270D747C228 0x15 IsEmptiable                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Mixed                                     = GetObject<ContentValidator>(new IntPtr(p + 0x010), ReversePrism.DataModels.ContentValidator.FromPointer); // 0270D747C288 0x10 Mixed                       ( 000186612B90 ModelClassType ContentValidator ContentValidator ContentValidator Pointer )
            value.Any                                       = GetObject<ContentValidator>(new IntPtr(p + 0x018), ReversePrism.DataModels.ContentValidator.FromPointer); // 0270D747C2A8 0x18 Any                         ( 000186612B90 ModelClassType ContentValidator ContentValidator ContentValidator Pointer )

            return value;
        }
    }
}
