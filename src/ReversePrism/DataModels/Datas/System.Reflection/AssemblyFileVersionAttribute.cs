using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  000186672F10 ModelPrimitiveType string string string String
    public partial class AssemblyFileVersionAttribute : DataModel
    {
        public string                                   Version                                 { get; set; }

        public static AssemblyFileVersionAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyFileVersionAttribute() { Pointer= p0 };

            value.Version                                   = GetString(new IntPtr(p + 0x010)); // 024666D38A70 0x10 Version                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
