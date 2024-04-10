using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 IsSurplus                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 051 PieceConversion                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PieceSelectGridViewContext : DataModel
    {
        public bool                                     IsSurplus                               { get; set; }
        public bool                                     PieceConversion                         { get; set; }

        public static PieceSelectGridViewContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceSelectGridViewContext() { Pointer= p0 };

            value.IsSurplus                                 = GetBool(new IntPtr(p + 0x050)); // 02466A2A3750 0x50 IsSurplus                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PieceConversion                           = GetBool(new IntPtr(p + 0x051)); // 02466A2A3770 0x51 PieceConversion             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
