using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WfWriter                                 ModelClassType XmlWellFormedWriter XmlWellFormedWriter XmlWellFormedWriter Pointer
    public partial class NamespaceResolverProxy : DataModel
    {
        public XmlWellFormedWriter?                     WfWriter                                { get; set; }

        public static NamespaceResolverProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceResolverProxy() { Pointer= p0 };

            value.WfWriter                                  = GetObject<XmlWellFormedWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlWellFormedWriter.FromPointer); // 0x10 WfWriter                    ( ModelClassType XmlWellFormedWriter XmlWellFormedWriter XmlWellFormedWriter Pointer )

            return value;
        }
    }
}
