using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LetterGroupId                            0001865F4260 ModelPrimitiveType int int int Int32
    public partial class IntroductionUnitLetterArgumentForLegacy : DataModel
    {
        public int                                      LetterGroupId                           { get; set; }

        public static IntroductionUnitLetterArgumentForLegacy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitLetterArgumentForLegacy() { Pointer= p0 };

            value.LetterGroupId                             = GetInt32(new IntPtr(p + 0x010)); // 024665EB1488 0x10 LetterGroupId               ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
