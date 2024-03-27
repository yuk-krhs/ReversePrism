using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectUnitIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 SelectStageIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourSelectUnitStageSaveData
    {
        public int                                      SelectUnitIndex                         { get; set; }
        public int                                      SelectStageIndex                        { get; set; }

        public static ChallengeTourSelectUnitStageSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourSelectUnitStageSaveData();

            value.SelectUnitIndex                           = GetInt32(new IntPtr(p + 0x010)); // 027003A6E188 0x10 SelectUnitIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectStageIndex                          = GetInt32(new IntPtr(p + 0x014)); // 027003A6E1A8 0x14 SelectStageIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
