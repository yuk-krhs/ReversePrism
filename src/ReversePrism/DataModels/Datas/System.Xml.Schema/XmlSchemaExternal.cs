using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Location                                 000186671910 ModelPrimitiveType string string string String
    // 040 BaseUri                                  0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 048 Schema                                   0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 050 Id                                       000186671910 ModelPrimitiveType string string string String
    // 058 MoreAttributes                           000185CB3608 ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer
    // 060 Compositor                               0001865F4050 ModelEnumType Compositor Compositor Compositor Int32
    public partial class XmlSchemaExternal
    {
        public string                                   Location                                { get; set; }
        public Uri?                                     BaseUri                                 { get; set; }
        public XmlSchema?                               Schema                                  { get; set; }
        public string                                   Id                                      { get; set; }
        public List<XmlAttribute>?                      MoreAttributes                          { get; set; }
        public Compositor                               Compositor                              { get; set; }

        public static XmlSchemaExternal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaExternal();

            value.Location                                  = GetString(new IntPtr(p + 0x038)); // 0270D752BB40 0x38 Location                    ( 000186671910 ModelPrimitiveType string string string String )
            value.BaseUri                                   = GetObject<Uri>(new IntPtr(p + 0x040), ReversePrism.DataModels.Uri.FromPointer); // 0270D752BB60 0x40 BaseUri                     ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlSchema.FromPointer); // 0270D752BB80 0x48 Schema                      ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.Id                                        = GetString(new IntPtr(p + 0x050)); // 0270D752BBA0 0x50 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.MoreAttributes                            = GetObjectList<XmlAttribute>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlAttribute.FromPointer); // 0270D752BBC0 0x58 MoreAttributes              ( 000185CB3608 ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer )
            value.Compositor                                = (Compositor)GetInt32(new IntPtr(p + 0x060)); // 0270D752BBE0 0x60 Compositor                  ( 0001865F4050 ModelEnumType Compositor Compositor Compositor Int32 )

            return value;
        }
    }
}
