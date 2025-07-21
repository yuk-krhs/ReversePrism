using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Field                                    ModelPrimitiveType string string string String
    // 018 Operand                                  ModelPrimitiveType string string string String
    // 020 Value                                    ModelPrimitiveType string string string String
    public partial class Filter : DataModel
    {
        public string                                   Field                                   { get; set; }
        public string                                   Operand                                 { get; set; }
        public string                                   Value                                   { get; set; }

        public static Filter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Filter() { Pointer= p0 };

            value.Field                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Field                       ( ModelPrimitiveType string string string String )
            value.Operand                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Operand                     ( ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x020)); // 0x20 Value                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
