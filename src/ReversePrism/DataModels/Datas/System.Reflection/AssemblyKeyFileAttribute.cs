using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 KeyFile                                  000186672F10 ModelPrimitiveType string string string String
    public partial class AssemblyKeyFileAttribute : DataModel
    {
        public string                                   KeyFile                                 { get; set; }

        public static AssemblyKeyFileAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyKeyFileAttribute() { Pointer= p0 };

            value.KeyFile                                   = GetString(new IntPtr(p + 0x010)); // 024666D38B80 0x10 KeyFile                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
