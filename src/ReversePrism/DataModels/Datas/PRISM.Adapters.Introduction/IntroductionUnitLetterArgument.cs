using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LetterGroupId                            ModelPrimitiveType int int int Int32
    public partial class IntroductionUnitLetterArgument : DataModel
    {
        public int                                      LetterGroupId                           { get; set; }

        public static IntroductionUnitLetterArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitLetterArgument() { Pointer= p0 };

            value.LetterGroupId                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 LetterGroupId               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
