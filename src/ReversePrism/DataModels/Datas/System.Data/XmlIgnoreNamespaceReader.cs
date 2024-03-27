using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 NamespacesToIgnore                       000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class XmlIgnoreNamespaceReader
    {
        public List<string>?                            NamespacesToIgnore                      { get; set; }

        public static XmlIgnoreNamespaceReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlIgnoreNamespaceReader();

            value.NamespacesToIgnore                        = GetStringList(new IntPtr(p + 0x030)); // 0270D896F718 0x30 NamespacesToIgnore          ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
