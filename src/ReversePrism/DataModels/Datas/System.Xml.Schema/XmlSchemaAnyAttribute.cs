using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 058 ProcessContents                          0001865B2700 ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32
    // 060 NamespaceList                            00018667E0F0 ModelClassType NamespaceList NamespaceList NamespaceList Pointer
    public partial class XmlSchemaAnyAttribute
    {
        public string                                   Ns                                      { get; set; }
        public XmlSchemaContentProcessing               ProcessContents                         { get; set; }
        public NamespaceList?                           NamespaceList                           { get; set; }

        public static XmlSchemaAnyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaAnyAttribute();

            value.Ns                                        = GetString(new IntPtr(p + 0x050)); // 0270D752F638 0x50 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.ProcessContents                           = (XmlSchemaContentProcessing)GetInt32(new IntPtr(p + 0x058)); // 0270D752F658 0x58 ProcessContents             ( 0001865B2700 ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32 )
            value.NamespaceList                             = GetObject<NamespaceList>(new IntPtr(p + 0x060), ReversePrism.DataModels.NamespaceList.FromPointer); // 0270D752F678 0x60 NamespaceList               ( 00018667E0F0 ModelClassType NamespaceList NamespaceList NamespaceList Pointer )

            return value;
        }
    }
}
