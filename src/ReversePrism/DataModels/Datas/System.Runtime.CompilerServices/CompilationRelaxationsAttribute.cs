using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_relaxations                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CompilationRelaxationsAttribute : DataModel
    {
        public int                                      M_relaxations                           { get; set; }

        public static CompilationRelaxationsAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompilationRelaxationsAttribute() { Pointer= p0 };

            value.M_relaxations                             = GetInt32(new IntPtr(p + 0x010)); // 024666D0F8C8 0x10 M_relaxations               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
