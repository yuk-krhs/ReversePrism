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
    public partial class LegacyChallengeTourUnitEditParameter
    {
        public int                                      ChallengeTourId                         { get; set; }
        public int                                      SelectUnitIndex                         { get; set; }
        public int                                      SelectStageIndex                        { get; set; }

        public static LegacyChallengeTourUnitEditParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyChallengeTourUnitEditParameter();

            value.ChallengeTourId                           = GetInt32(new IntPtr(p + 0x010)); // 0270D5E3DBE0 0x10 ChallengeTourId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectUnitIndex                           = GetInt32(new IntPtr(p + 0x014)); // 0270D5E3DC00 0x14 SelectUnitIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectStageIndex                          = GetInt32(new IntPtr(p + 0x018)); // 0270D5E3DC20 0x18 SelectStageIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
