using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WfWriter                                 0001865D5930 ModelClassType XmlWellFormedWriter XmlWellFormedWriter XmlWellFormedWriter Pointer
    public partial class NamespaceResolverProxy
    {
        public XmlWellFormedWriter?                     WfWriter                                { get; set; }

        public static NamespaceResolverProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceResolverProxy();

            value.WfWriter                                  = GetObject<XmlWellFormedWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlWellFormedWriter.FromPointer); // 0270D7407C90 0x10 WfWriter                    ( 0001865D5930 ModelClassType XmlWellFormedWriter XmlWellFormedWriter XmlWellFormedWriter Pointer )

            return value;
        }
    }
}
