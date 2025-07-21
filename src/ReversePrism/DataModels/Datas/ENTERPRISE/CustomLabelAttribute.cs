using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveType string string string String
    public partial class CustomLabelAttribute : DataModel
    {
        public string                                   Value                                   { get; set; }

        public static CustomLabelAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomLabelAttribute() { Pointer= p0 };

            value.Value                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
