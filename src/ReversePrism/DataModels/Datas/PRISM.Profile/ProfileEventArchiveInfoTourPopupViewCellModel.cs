using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 014 ReachingStage                            0001865F4260 ModelPrimitiveType int int int Int32
    // 018 AcquiredStar                             0001865F4260 ModelPrimitiveType int int int Int32
    // 01C AcquiredStarLimit                        0001865F4260 ModelPrimitiveType int int int Int32
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

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 02466560BC00 0x10 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ReachingStage                             = GetInt32(new IntPtr(p + 0x014)); // 02466560BC20 0x14 ReachingStage               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AcquiredStar                              = GetInt32(new IntPtr(p + 0x018)); // 02466560BC40 0x18 AcquiredStar                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AcquiredStarLimit                         = GetInt32(new IntPtr(p + 0x01C)); // 02466560BC60 0x1C AcquiredStarLimit           ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
