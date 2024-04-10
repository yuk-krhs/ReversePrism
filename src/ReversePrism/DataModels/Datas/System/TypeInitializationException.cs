using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 TypeName                                 000186671910 ModelPrimitiveType string string string String
    public partial class TypeInitializationException : DataModel
    {
        public string                                   TypeName                                { get; set; }

        public static TypeInitializationException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeInitializationException() { Pointer= p0 };

            value.TypeName                                  = GetString(new IntPtr(p + 0x090)); // 0245A4D43A70 0x90 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
