using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssemblyFullName                         000186672F10 ModelPrimitiveType string string string String
    public partial class TypeForwardedFromAttribute : DataModel
    {
        public string                                   AssemblyFullName                        { get; set; }

        public static TypeForwardedFromAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeForwardedFromAttribute() { Pointer= p0 };

            value.AssemblyFullName                          = GetString(new IntPtr(p + 0x010)); // 024666D06FC8 0x10 AssemblyFullName            ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
