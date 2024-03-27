using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Copyright                                000186672F10 ModelPrimitiveType string string string String
    public partial class AssemblyCopyrightAttribute
    {
        public string                                   Copyright                               { get; set; }

        public static AssemblyCopyrightAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyCopyrightAttribute();

            value.Copyright                                 = GetString(new IntPtr(p + 0x010)); // 0270D6CE8850 0x10 Copyright                   ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
