using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsUnlocked                               ModelPrimitiveType bool bool bool Bool
    // 014 RemainingCount                           ModelPrimitiveType int int int Int32
    // 018 LiveBonusUsageSettingStatus              ModelClassType SkipLiveLiveBonusUsageSettingStatus SkipLiveLiveBonusUsageSettingStatus SkipLiveLiveBonusUsageSettingStatus Pointer
    public partial class SkipLiveStatus : DataModel
    {
        public bool                                     IsUnlocked                              { get; set; }
        public int                                      RemainingCount                          { get; set; }
        public SkipLiveLiveBonusUsageSettingStatus?     LiveBonusUsageSettingStatus             { get; set; }

        public static SkipLiveStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipLiveStatus() { Pointer= p0 };

            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x010)); // 0x10 IsUnlocked                  ( ModelPrimitiveType bool bool bool Bool )
            value.RemainingCount                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 RemainingCount              ( ModelPrimitiveType int int int Int32 )
            value.LiveBonusUsageSettingStatus               = GetObject<SkipLiveLiveBonusUsageSettingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SkipLiveLiveBonusUsageSettingStatus.FromPointer); // 0x18 LiveBonusUsageSettingStatus ( ModelClassType SkipLiveLiveBonusUsageSettingStatus SkipLiveLiveBonusUsageSettingStatus SkipLiveLiveBonusUsageSettingStatus Pointer )

            return value;
        }
    }
}
