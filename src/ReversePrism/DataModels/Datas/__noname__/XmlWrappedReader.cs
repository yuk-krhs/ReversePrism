using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 NsMgr                                    0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    public partial class XmlWrappedReader : DataModel
    {
        public XmlReader?                               Reader                                  { get; set; }
        public XmlNamespaceManager?                     NsMgr                                   { get; set; }

        public static XmlWrappedReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlWrappedReader() { Pointer= p0 };

            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 024667CB92E8 0x10 Reader                      ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.NsMgr                                     = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 024667CB9308 0x18 NsMgr                       ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )

            return value;
        }
    }
}
