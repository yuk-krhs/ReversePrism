using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Configuration                            ModelPrimitiveType string string string String
    public partial class AssemblyConfigurationAttribute : DataModel
    {
        public string                                   Configuration                           { get; set; }

        public static AssemblyConfigurationAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyConfigurationAttribute() { Pointer= p0 };

            value.Configuration                             = GetString(new IntPtr(p + 0x010)); // 0x10 Configuration               ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
