using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Text                                     ModelPrimitiveType string string string String
    public partial class XText : DataModel
    {
        public string                                   Text                                    { get; set; }

        public static XText? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XText() { Pointer= p0 };

            value.Text                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Text                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
