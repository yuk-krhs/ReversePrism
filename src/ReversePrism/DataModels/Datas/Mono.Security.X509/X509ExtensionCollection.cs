using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ReadOnly                                 ModelPrimitiveType bool bool bool Bool
    public partial class X509ExtensionCollection : DataModel
    {
        public bool                                     ReadOnly                                { get; set; }

        public static X509ExtensionCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ExtensionCollection() { Pointer= p0 };

            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 ReadOnly                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
