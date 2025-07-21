using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Product                                  ModelPrimitiveType string string string String
    public partial class AssemblyProductAttribute : DataModel
    {
        public string                                   Product                                 { get; set; }

        public static AssemblyProductAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyProductAttribute() { Pointer= p0 };

            value.Product                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Product                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
