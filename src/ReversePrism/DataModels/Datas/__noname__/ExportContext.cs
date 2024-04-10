using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Namespaces                               0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 018 NextPrefix                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 XPathBuilder                             000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    public partial class ExportContext : DataModel
    {
        public XmlNamespaceManager?                     Namespaces                              { get; set; }
        public int                                      NextPrefix                              { get; set; }
        public StringBuilder?                           XPathBuilder                            { get; set; }

        public static ExportContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExportContext() { Pointer= p0 };

            value.Namespaces                                = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 024667DD47B8 0x10 Namespaces                  ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.NextPrefix                                = GetInt32(new IntPtr(p + 0x018)); // 024667DD47D8 0x18 NextPrefix                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.XPathBuilder                              = GetObject<StringBuilder>(new IntPtr(p + 0x020), ReversePrism.DataModels.StringBuilder.FromPointer); // 024667DD47F8 0x20 XPathBuilder                ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )

            return value;
        }
    }
}
