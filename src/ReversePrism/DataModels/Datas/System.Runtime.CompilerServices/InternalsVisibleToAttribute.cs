using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AssemblyName                             ModelPrimitiveType string string string String
    // 018 AllInternalsVisible                      ModelPrimitiveType bool bool bool Bool
    public partial class InternalsVisibleToAttribute : DataModel
    {
        public string                                   AssemblyName                            { get; set; }
        public bool                                     AllInternalsVisible                     { get; set; }

        public static InternalsVisibleToAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalsVisibleToAttribute() { Pointer= p0 };

            value.AssemblyName                              = GetString(new IntPtr(p + 0x010)); // 0x10 AssemblyName                ( ModelPrimitiveType string string string String )
            value.AllInternalsVisible                       = GetBool(new IntPtr(p + 0x018)); // 0x18 AllInternalsVisible         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
