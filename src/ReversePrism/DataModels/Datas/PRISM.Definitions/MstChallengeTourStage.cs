using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstChallengeTourId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 StageNumber                              0001865F4260 ModelPrimitiveType int int int Int32
    // 01C StageType                                0001865F4260 ModelPrimitiveType int int int Int32
    // 020 MstRivalUnitId                           0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstChallengeTourStage
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstChallengeTourId                      { get; set; }
        public int                                      StageNumber                             { get; set; }
        public int                                      StageType                               { get; set; }
        public int                                      MstRivalUnitId                          { get; set; }

        public static MstChallengeTourStage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstChallengeTourStage();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004625578 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstChallengeTourId                        = GetInt32(new IntPtr(p + 0x014)); // 027004625598 0x14 MstChallengeTourId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StageNumber                               = GetInt32(new IntPtr(p + 0x018)); // 0270046255B8 0x18 StageNumber                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StageType                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270046255D8 0x1C StageType                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstRivalUnitId                            = GetInt32(new IntPtr(p + 0x020)); // 0270046255F8 0x20 MstRivalUnitId              ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
