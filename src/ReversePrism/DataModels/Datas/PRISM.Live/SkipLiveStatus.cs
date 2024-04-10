using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsUnlocked                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 014 RemainingCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 LiveBonusUsageSettingStatus              0001865161E0 ModelClassType SkipLiveLiveBonusUsageSettingStatus SkipLiveLiveBonusUsageSettingStatus SkipLiveLiveBonusUsageSettingStatus Pointer
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

            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x010)); // 0246653040F0 0x10 IsUnlocked                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.RemainingCount                            = GetInt32(new IntPtr(p + 0x014)); // 024665304110 0x14 RemainingCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LiveBonusUsageSettingStatus               = GetObject<SkipLiveLiveBonusUsageSettingStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SkipLiveLiveBonusUsageSettingStatus.FromPointer); // 024665304130 0x18 LiveBonusUsageSettingStatus ( 0001865161E0 ModelClassType SkipLiveLiveBonusUsageSettingStatus SkipLiveLiveBonusUsageSettingStatus SkipLiveLiveBonusUsageSettingStatus Pointer )

            return value;
        }
    }
}
