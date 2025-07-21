using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   ModelPrimitiveType int int int Int32
    // 014 ReachingStage                            ModelPrimitiveType int int int Int32
    // 018 AcquiredStar                             ModelPrimitiveType int int int Int32
    // 01C AcquiredStarLimit                        ModelPrimitiveType int int int Int32
    public partial class ProfileEventArchiveInfoTourPopupViewCellModel : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public int                                      ReachingStage                           { get; set; }
        public int                                      AcquiredStar                            { get; set; }
        public int                                      AcquiredStarLimit                       { get; set; }

        public static ProfileEventArchiveInfoTourPopupViewCellModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEventArchiveInfoTourPopupViewCellModel() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.ReachingStage                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 ReachingStage               ( ModelPrimitiveType int int int Int32 )
            value.AcquiredStar                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 AcquiredStar                ( ModelPrimitiveType int int int Int32 )
            value.AcquiredStarLimit                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C AcquiredStarLimit           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
