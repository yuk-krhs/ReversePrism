using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Title                                    000186672F10 ModelPrimitiveType string string string String
    public partial class AssemblyTitleAttribute
    {
        public string                                   Title                                   { get; set; }

        public static AssemblyTitleAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyTitleAttribute();

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 0270D6CE8E30 0x10 Title                       ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
