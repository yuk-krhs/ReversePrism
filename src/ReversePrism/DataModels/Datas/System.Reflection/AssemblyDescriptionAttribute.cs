using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Description                              ModelPrimitiveType string string string String
    public partial class AssemblyDescriptionAttribute : DataModel
    {
        public string                                   Description                             { get; set; }

        public static AssemblyDescriptionAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyDescriptionAttribute() { Pointer= p0 };

            value.Description                               = GetString(new IntPtr(p + 0x010)); // 0x10 Description                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
