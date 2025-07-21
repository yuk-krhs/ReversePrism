using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reader                                   ModelClassType XmlReader XmlReader XmlReader Pointer
    // 018 NsMgr                                    ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
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

            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReader.FromPointer); // 0x10 Reader                      ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.NsMgr                                     = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x18 NsMgr                       ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )

            return value;
        }
    }
}
