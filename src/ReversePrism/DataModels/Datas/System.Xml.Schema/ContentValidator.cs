using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContentType                              ModelEnumType XmlSchemaContentType XmlSchemaContentType XmlSchemaContentType Int32
    // 014 IsOpen                                   ModelPrimitiveType bool bool bool Bool
    // 015 IsEmptiable                              ModelPrimitiveType bool bool bool Bool
    // 000 Empty                                    ContentValidator IL2CPP_TYPE_CLASS
    // 008 TextOnly                                 ContentValidator IL2CPP_TYPE_CLASS
    // 010 Mixed                                    ModelClassType ContentValidator ContentValidator ContentValidator Pointer
    // 018 Any                                      ModelClassType ContentValidator ContentValidator ContentValidator Pointer
    public partial class ContentValidator : DataModel
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
            var value   = new ContentValidator() { Pointer= p0 };

            value.ContentType                               = (XmlSchemaContentType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ContentType                 ( ModelEnumType XmlSchemaContentType XmlSchemaContentType XmlSchemaContentType Int32 )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x014)); // 0x14 IsOpen                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsEmptiable                               = GetBool(new IntPtr(p + 0x015)); // 0x15 IsEmptiable                 ( ModelPrimitiveType bool bool bool Bool )
            value.Mixed                                     = GetObject<ContentValidator>(new IntPtr(p + 0x010), ReversePrism.DataModels.ContentValidator.FromPointer); // 0x10 Mixed                       ( ModelClassType ContentValidator ContentValidator ContentValidator Pointer )
            value.Any                                       = GetObject<ContentValidator>(new IntPtr(p + 0x018), ReversePrism.DataModels.ContentValidator.FromPointer); // 0x18 Any                         ( ModelClassType ContentValidator ContentValidator ContentValidator Pointer )

            return value;
        }
    }
}
