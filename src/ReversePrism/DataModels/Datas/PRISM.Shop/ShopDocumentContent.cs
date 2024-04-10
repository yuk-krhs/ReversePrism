using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 XmlPanel                                 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 068 BodyString                               000186671910 ModelPrimitiveType string string string String
    // 070 titleTextKeys                            Dictionary`2<ShopDocumentType, string> IL2CPP_TYPE_GENERICINST
    public partial class ShopDocumentContent : DataModel
    {
        public XMLPanel?                                XmlPanel                                { get; set; }
        public string                                   BodyString                              { get; set; }

        public static ShopDocumentContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopDocumentContent() { Pointer= p0 };

            value.XmlPanel                                  = GetObject<XMLPanel>(new IntPtr(p + 0x060), ReversePrism.DataModels.XMLPanel.FromPointer); // 024665575978 0x60 XmlPanel                    ( 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.BodyString                                = GetString(new IntPtr(p + 0x068)); // 024665575998 0x68 BodyString                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
