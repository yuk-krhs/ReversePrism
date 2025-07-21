using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 IsSurplus                                ModelPrimitiveType bool bool bool Bool
    // 059 PieceConversion                          ModelPrimitiveType bool bool bool Bool
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

            value.IsSurplus                                 = GetBool(new IntPtr(p + 0x058)); // 0x58 IsSurplus                   ( ModelPrimitiveType bool bool bool Bool )
            value.PieceConversion                           = GetBool(new IntPtr(p + 0x059)); // 0x59 PieceConversion             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
