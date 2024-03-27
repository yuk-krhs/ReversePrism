using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UssStyle                                 0001866736C0 ModelPrimitiveType string string string String
    public partial class CustomStyleAttribute
    {
        public string                                   UssStyle                                { get; set; }

        public static CustomStyleAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomStyleAttribute();

            value.UssStyle                                  = GetString(new IntPtr(p + 0x010)); // 0270DB2A48B0 0x10 UssStyle                    ( 0001866736C0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
