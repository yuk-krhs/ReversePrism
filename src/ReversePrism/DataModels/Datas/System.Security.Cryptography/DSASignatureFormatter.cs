using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Oid                                      000186671910 ModelPrimitiveType string string string String
    public partial class DSASignatureFormatter : DataModel
    {
        public string                                   Oid                                     { get; set; }

        public static DSASignatureFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DSASignatureFormatter() { Pointer= p0 };

            value.Oid                                       = GetString(new IntPtr(p + 0x010)); // 02466192C448 0x10 Oid                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
