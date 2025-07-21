using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstChallengeTourId                       ModelPrimitiveType int int int Int32
    // 018 StageNumber                              ModelPrimitiveType int int int Int32
    // 01C StageType                                ModelPrimitiveType int int int Int32
    // 020 MstRivalUnitId                           ModelPrimitiveType int int int Int32
    public partial class MstChallengeTourStage : DataModel
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
            var value   = new MstChallengeTourStage() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstChallengeTourId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstChallengeTourId          ( ModelPrimitiveType int int int Int32 )
            value.StageNumber                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 StageNumber                 ( ModelPrimitiveType int int int Int32 )
            value.StageType                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C StageType                   ( ModelPrimitiveType int int int Int32 )
            value.MstRivalUnitId                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstRivalUnitId              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
