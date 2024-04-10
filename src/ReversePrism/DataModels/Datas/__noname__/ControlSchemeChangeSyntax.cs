using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_UserIndex                              0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class ControlSchemeChangeSyntax : DataModel
    {
        public int                                      M_UserIndex                             { get; set; }

        public static ControlSchemeChangeSyntax? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ControlSchemeChangeSyntax() { Pointer= p0 };

            value.M_UserIndex                               = GetInt32(new IntPtr(p + 0x010)); // 0246677DF338 0x10 M_UserIndex                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
