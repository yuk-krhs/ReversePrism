using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ns                                       00018657B5D0 ModelClassType XNamespace XNamespace XNamespace Pointer
    // 018 NamespaceName                            000186671910 ModelPrimitiveType string string string String
    public partial class NamespaceCache : DataModel
    {
        public XNamespace?                              Ns                                      { get; set; }
        public string                                   NamespaceName                           { get; set; }

        public static NamespaceCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamespaceCache() { Pointer= p0 };

            value.Ns                                        = GetObject<XNamespace>(new IntPtr(p + 0x010), ReversePrism.DataModels.XNamespace.FromPointer); // 02466BCAE090 0x10 Ns                          ( 00018657B5D0 ModelClassType XNamespace XNamespace XNamespace Pointer )
            value.NamespaceName                             = GetString(new IntPtr(p + 0x018)); // 02466BCAE0B0 0x18 NamespaceName               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
