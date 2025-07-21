using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Assembly_name                            ModelPrimitiveType string string string String
    // 018 Type_name                                ModelPrimitiveType string string string String
    public partial class TypeEntry : DataModel
    {
        public string                                   Assembly_name                           { get; set; }
        public string                                   Type_name                               { get; set; }

        public static TypeEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeEntry() { Pointer= p0 };

            value.Assembly_name                             = GetString(new IntPtr(p + 0x010)); // 0x10 Assembly_name               ( ModelPrimitiveType string string string String )
            value.Type_name                                 = GetString(new IntPtr(p + 0x018)); // 0x18 Type_name                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
