using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ParamName                                ModelPrimitiveType string string string String
    public partial class ArgumentException : DataModel
    {
        public string                                   ParamName                               { get; set; }

        public static ArgumentException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArgumentException() { Pointer= p0 };

            value.ParamName                                 = GetString(new IntPtr(p + 0x090)); // 0x90 ParamName                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
