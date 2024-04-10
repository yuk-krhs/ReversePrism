using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeName                                 000186671910 ModelPrimitiveType string string string String
    public partial class TypeDependencyAttribute : DataModel
    {
        public string                                   TypeName                                { get; set; }

        public static TypeDependencyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeDependencyAttribute() { Pointer= p0 };

            value.TypeName                                  = GetString(new IntPtr(p + 0x010)); // 024666D0FAA8 0x10 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
