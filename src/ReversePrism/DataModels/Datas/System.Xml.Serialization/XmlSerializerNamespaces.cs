using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Namespaces                               ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class XmlSerializerNamespaces : DataModel
    {
        public Hashtable?                               Namespaces                              { get; set; }

        public static XmlSerializerNamespaces? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializerNamespaces() { Pointer= p0 };

            value.Namespaces                                = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 Namespaces                  ( ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
