using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChallengeTourId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 SelectUnitIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 SelectStageIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourUnitEditArgument : DataModel
    {
        public int                                      ChallengeTourId                         { get; set; }
        public int                                      SelectUnitIndex                         { get; set; }
        public int                                      SelectStageIndex                        { get; set; }

        public static ChallengeTourUnitEditArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitEditArgument() { Pointer= p0 };

            value.ChallengeTourId                           = GetInt32(new IntPtr(p + 0x010)); // 0246664F8D80 0x10 ChallengeTourId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectUnitIndex                           = GetInt32(new IntPtr(p + 0x014)); // 0246664F8DA0 0x14 SelectUnitIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectStageIndex                          = GetInt32(new IntPtr(p + 0x018)); // 0246664F8DC0 0x18 SelectStageIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
