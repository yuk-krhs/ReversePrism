using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Content                                  ModelClassType XmlSchemaContent XmlSchemaContent XmlSchemaContent Pointer
    // 058 IsMixed                                  ModelPrimitiveType bool bool bool Bool
    // 059 HasMixedAttribute                        ModelPrimitiveType bool bool bool Bool
    public partial class XmlSchemaComplexContent : DataModel
    {
        public XmlSchemaContent?                        Content                                 { get; set; }
        public bool                                     IsMixed                                 { get; set; }
        public bool                                     HasMixedAttribute                       { get; set; }

        public static XmlSchemaComplexContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaComplexContent() { Pointer= p0 };

            value.Content                                   = GetObject<XmlSchemaContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaContent.FromPointer); // 0x50 Content                     ( ModelClassType XmlSchemaContent XmlSchemaContent XmlSchemaContent Pointer )
            value.IsMixed                                   = GetBool(new IntPtr(p + 0x058)); // 0x58 IsMixed                     ( ModelPrimitiveType bool bool bool Bool )
            value.HasMixedAttribute                         = GetBool(new IntPtr(p + 0x059)); // 0x59 HasMixedAttribute           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
