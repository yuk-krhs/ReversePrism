using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Source                                   000186671910 ModelPrimitiveType string string string String
    // 040 Language                                 000186671910 ModelPrimitiveType string string string String
    // 048 Markup                                   000185CB3E78 ModelClassListType XmlNode[] XmlNode[] List<XmlNode> Pointer
    // 000 languageType                             XmlSchemaSimpleType IL2CPP_TYPE_CLASS
    public partial class XmlSchemaDocumentation : DataModel
    {
        public string                                   Source                                  { get; set; }
        public string                                   Language                                { get; set; }
        public List<XmlNode>?                           Markup                                  { get; set; }

        public static XmlSchemaDocumentation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaDocumentation() { Pointer= p0 };

            value.Source                                    = GetString(new IntPtr(p + 0x038)); // 024667620340 0x38 Source                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Language                                  = GetString(new IntPtr(p + 0x040)); // 024667620360 0x40 Language                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Markup                                    = GetObjectList<XmlNode>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlNode.FromPointer); // 024667620380 0x48 Markup                      ( 000185CB3E78 ModelClassListType XmlNode[] XmlNode[] List<XmlNode> Pointer )

            return value;
        }
    }
}
