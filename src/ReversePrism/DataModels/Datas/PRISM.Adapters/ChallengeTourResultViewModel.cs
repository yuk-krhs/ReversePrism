using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StageStatus                              0001867270C0 ModelClassType IChallengeTourStageStatus IChallengeTourStageStatus IChallengeTourStageStatus Pointer
    // 018 UnitIdols                                000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 020 FanCount                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 028 RewardViewModels                         000185B74740 ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer
    // 030 GetRewardViewModels                      000185B74740 ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer
    // 038 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourResultViewModel : DataModel
    {
        public IChallengeTourStageStatus?               StageStatus                             { get; set; }
        public List<UnitIdol>?                          UnitIdols                               { get; set; }
        public int                                      FanCount                                { get; set; }
        public List<ChallengeTourRewardViewModel>?      RewardViewModels                        { get; set; }
        public List<ChallengeTourRewardViewModel>?      GetRewardViewModels                     { get; set; }
        public int                                      UnitId                                  { get; set; }

        public static ChallengeTourResultViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourResultViewModel() { Pointer= p0 };

            value.StageStatus                               = GetObject<IChallengeTourStageStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourStageStatus.FromPointer); // 0246665206B8 0x10 StageStatus                 ( 0001867270C0 ModelClassType IChallengeTourStageStatus IChallengeTourStageStatus IChallengeTourStageStatus Pointer )
            value.UnitIdols                                 = GetObjectList<UnitIdol>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnitIdol.FromPointer); // 0246665206D8 0x18 UnitIdols                   ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.FanCount                                  = GetInt32(new IntPtr(p + 0x020)); // 0246665206F8 0x20 FanCount                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RewardViewModels                          = GetObjectList<ChallengeTourRewardViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourRewardViewModel.FromPointer); // 024666520718 0x28 RewardViewModels            ( 000185B74740 ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer )
            value.GetRewardViewModels                       = GetObjectList<ChallengeTourRewardViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourRewardViewModel.FromPointer); // 024666520738 0x30 GetRewardViewModels         ( 000185B74740 ModelClassListType ChallengeTourRewardViewModel[] ChallengeTourRewardViewModel[] List<ChallengeTourRewardViewModel> Pointer )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x038)); // 024666520758 0x38 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
