using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelClassType IMissionGaugeStatus IMissionGaugeStatus IMissionGaugeStatus Pointer
    // 018 RewardItemIconViewModels                 ModelClassListType MissionGaugeRewardItemIconViewModel[] MissionGaugeRewardItemIconViewModel[] List<MissionGaugeRewardItemIconViewModel> Pointer
    // 020 IsAllReceived                            ModelPrimitiveType bool bool bool Bool
    // 021 IsClear                                  ModelPrimitiveType bool bool bool Bool
    // 024 MaxGauge                                 ModelPrimitiveType int int int Int32
    public partial class MissionGaugeViewModel : DataModel
    {
        public IMissionGaugeStatus?                     Status                                  { get; set; }
        public List<MissionGaugeRewardItemIconViewModel>? RewardItemIconViewModels                { get; set; }
        public bool                                     IsAllReceived                           { get; set; }
        public bool                                     IsClear                                 { get; set; }
        public int                                      MaxGauge                                { get; set; }

        public static MissionGaugeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionGaugeViewModel() { Pointer= p0 };

            value.Status                                    = GetObject<IMissionGaugeStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMissionGaugeStatus.FromPointer); // 0x10 Status                      ( ModelClassType IMissionGaugeStatus IMissionGaugeStatus IMissionGaugeStatus Pointer )
            value.RewardItemIconViewModels                  = GetObjectList<MissionGaugeRewardItemIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.MissionGaugeRewardItemIconViewModel.FromPointer); // 0x18 RewardItemIconViewModels    ( ModelClassListType MissionGaugeRewardItemIconViewModel[] MissionGaugeRewardItemIconViewModel[] List<MissionGaugeRewardItemIconViewModel> Pointer )
            value.IsAllReceived                             = GetBool(new IntPtr(p + 0x020)); // 0x20 IsAllReceived               ( ModelPrimitiveType bool bool bool Bool )
            value.IsClear                                   = GetBool(new IntPtr(p + 0x021)); // 0x21 IsClear                     ( ModelPrimitiveType bool bool bool Bool )
            value.MaxGauge                                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 MaxGauge                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
