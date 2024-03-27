using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ReadOnly                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class X509ExtensionCollection
    {
        public bool                                     ReadOnly                                { get; set; }

        public static X509ExtensionCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ExtensionCollection();

            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x018)); // 0270DB37C988 0x18 ReadOnly                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
