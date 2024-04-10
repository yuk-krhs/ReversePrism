using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ID                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Info                                     00018665E9E0 ModelClassType AchievementInfo AchievementInfo AchievementInfo Pointer
    public partial class AchievementData : DataModel
    {
        public int                                      ID                                      { get; set; }
        public AchievementInfo?                         Info                                    { get; set; }

        public static AchievementData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AchievementData() { Pointer= p0 };

            value.ID                                        = GetInt32(new IntPtr(p + 0x010)); // 02466AE6FBA0 0x10 ID                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Info                                      = GetObject<AchievementInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.AchievementInfo.FromPointer); // 02466AE6FBC0 0x18 Info                        ( 00018665E9E0 ModelClassType AchievementInfo AchievementInfo AchievementInfo Pointer )

            return value;
        }
    }
}
