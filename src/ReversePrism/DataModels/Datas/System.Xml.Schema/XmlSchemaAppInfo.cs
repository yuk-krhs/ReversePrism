using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Source                                   ModelPrimitiveType string string string String
    // 040 Markup                                   ModelClassListType XmlNode[] XmlNode[] List<XmlNode> Pointer
    public partial class XmlSchemaAppInfo : DataModel
    {
        public string                                   Source                                  { get; set; }
        public List<XmlNode>?                           Markup                                  { get; set; }

        public static XmlSchemaAppInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaAppInfo() { Pointer= p0 };

            value.Source                                    = GetString(new IntPtr(p + 0x038)); // 0x38 Source                      ( ModelPrimitiveType string string string String )
            value.Markup                                    = GetObjectList<XmlNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlNode.FromPointer); // 0x40 Markup                      ( ModelClassListType XmlNode[] XmlNode[] List<XmlNode> Pointer )

            return value;
        }
    }
}
