using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 NsMgr                                    ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 058 Reader                                   ModelClassType XmlReader XmlReader XmlReader Pointer
    public partial class BuilderNamespaceManager : DataModel
    {
        public XmlNamespaceManager?                     NsMgr                                   { get; set; }
        public XmlReader?                               Reader                                  { get; set; }

        public static BuilderNamespaceManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BuilderNamespaceManager() { Pointer= p0 };

            value.NsMgr                                     = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x50 NsMgr                       ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlReader.FromPointer); // 0x58 Reader                      ( ModelClassType XmlReader XmlReader XmlReader Pointer )

            return value;
        }
    }
}
