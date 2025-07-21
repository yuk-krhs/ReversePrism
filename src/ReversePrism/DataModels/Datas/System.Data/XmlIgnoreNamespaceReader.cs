using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 NamespacesToIgnore                       ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class XmlIgnoreNamespaceReader : DataModel
    {
        public List<string>?                            NamespacesToIgnore                      { get; set; }

        public static XmlIgnoreNamespaceReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlIgnoreNamespaceReader() { Pointer= p0 };

            value.NamespacesToIgnore                        = GetStringList(new IntPtr(p + 0x030)); // 0x30 NamespacesToIgnore          ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
