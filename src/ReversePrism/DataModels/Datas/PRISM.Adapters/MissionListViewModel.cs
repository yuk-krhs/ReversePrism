using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 RewardItemIconLength                     int IL2CPP_TYPE_I4
    // 010 Status                                   ModelClassType IMissionStatus IMissionStatus IMissionStatus Pointer
    // 018 LastDisplayDate                          ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 RewardItemIconViewModels                 ModelClassListType MissionListRewardItemIconViewModel[] MissionListRewardItemIconViewModel[] List<MissionListRewardItemIconViewModel> Pointer
    // 030 RewardReceiveStatusViewModel             ModelClassType MissionRewardReceiveStatusViewModel MissionRewardReceiveStatusViewModel MissionRewardReceiveStatusViewModel Pointer
    public partial class MissionListViewModel : DataModel
    {
        public IMissionStatus?                          Status                                  { get; set; }
        public DateTime                                 LastDisplayDate                         { get; set; }
        public List<MissionListRewardItemIconViewModel>? RewardItemIconViewModels                { get; set; }
        public MissionRewardReceiveStatusViewModel?     RewardReceiveStatusViewModel            { get; set; }

        public static MissionListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionListViewModel() { Pointer= p0 };

            value.Status                                    = GetObject<IMissionStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMissionStatus.FromPointer); // 0x10 Status                      ( ModelClassType IMissionStatus IMissionStatus IMissionStatus Pointer )
            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x018)); // 0x18 LastDisplayDate             ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.RewardItemIconViewModels                  = GetObjectList<MissionListRewardItemIconViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.MissionListRewardItemIconViewModel.FromPointer); // 0x28 RewardItemIconViewModels    ( ModelClassListType MissionListRewardItemIconViewModel[] MissionListRewardItemIconViewModel[] List<MissionListRewardItemIconViewModel> Pointer )
            value.RewardReceiveStatusViewModel              = GetObject<MissionRewardReceiveStatusViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.MissionRewardReceiveStatusViewModel.FromPointer); // 0x30 RewardReceiveStatusViewModel ( ModelClassType MissionRewardReceiveStatusViewModel MissionRewardReceiveStatusViewModel MissionRewardReceiveStatusViewModel Pointer )

            return value;
        }
    }
}
