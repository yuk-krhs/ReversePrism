using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 AchievementType                          0001865F4260 ModelPrimitiveType int int int Int32
    // 018 AchievementCategory                      0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstAchievement : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      AchievementType                         { get; set; }
        public int                                      AchievementCategory                     { get; set; }

        public static MstAchievement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstAchievement() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A46EE498 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AchievementType                           = GetInt32(new IntPtr(p + 0x014)); // 0245A46EE4B8 0x14 AchievementType             ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AchievementCategory                       = GetInt32(new IntPtr(p + 0x018)); // 0245A46EE4D8 0x18 AchievementCategory         ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
