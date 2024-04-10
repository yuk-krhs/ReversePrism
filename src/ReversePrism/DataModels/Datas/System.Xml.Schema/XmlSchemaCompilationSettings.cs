using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EnableUpaCheck                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlSchemaCompilationSettings : DataModel
    {
        public bool                                     EnableUpaCheck                          { get; set; }

        public static XmlSchemaCompilationSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaCompilationSettings() { Pointer= p0 };

            value.EnableUpaCheck                            = GetBool(new IntPtr(p + 0x010)); // 02466753F498 0x10 EnableUpaCheck              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
