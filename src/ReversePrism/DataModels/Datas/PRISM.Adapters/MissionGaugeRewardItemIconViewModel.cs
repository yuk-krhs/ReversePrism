using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelClassType IMissionGaugeRewardStatus IMissionGaugeRewardStatus IMissionGaugeRewardStatus Pointer
    public partial class MissionGaugeRewardItemIconViewModel : DataModel
    {
        public IMissionGaugeRewardStatus?               Status                                  { get; set; }

        public static MissionGaugeRewardItemIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionGaugeRewardItemIconViewModel() { Pointer= p0 };

            value.Status                                    = GetObject<IMissionGaugeRewardStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMissionGaugeRewardStatus.FromPointer); // 0x10 Status                      ( ModelClassType IMissionGaugeRewardStatus IMissionGaugeRewardStatus IMissionGaugeRewardStatus Pointer )

            return value;
        }
    }
}
