using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 080 ProcessContents                          0001865B2700 ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32
    // 088 NamespaceList                            00018667E0F0 ModelClassType NamespaceList NamespaceList NamespaceList Pointer
    public partial class XmlSchemaAny : DataModel
    {
        public string                                   Ns                                      { get; set; }
        public XmlSchemaContentProcessing               ProcessContents                         { get; set; }
        public NamespaceList?                           NamespaceList                           { get; set; }

        public static XmlSchemaAny? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaAny() { Pointer= p0 };

            value.Ns                                        = GetString(new IntPtr(p + 0x078)); // 0246675B3F60 0x78 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.ProcessContents                           = (XmlSchemaContentProcessing)GetInt32(new IntPtr(p + 0x080)); // 0246675B3F80 0x80 ProcessContents             ( 0001865B2700 ModelEnumType XmlSchemaContentProcessing XmlSchemaContentProcessing XmlSchemaContentProcessing Int32 )
            value.NamespaceList                             = GetObject<NamespaceList>(new IntPtr(p + 0x088), ReversePrism.DataModels.NamespaceList.FromPointer); // 0246675B3FA0 0x88 NamespaceList               ( 00018667E0F0 ModelClassType NamespaceList NamespaceList NamespaceList Pointer )

            return value;
        }
    }
}
