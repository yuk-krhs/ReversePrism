using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StageViewModels                          000185B74930 ModelClassListType ChallengeTourStageViewModel[] ChallengeTourStageViewModel[] List<ChallengeTourStageViewModel> Pointer
    // 018 ChallengeTourStatus                      000186727850 ModelClassType IChallengeTourStatus IChallengeTourStatus IChallengeTourStatus Pointer
    // 020 FesUnitModel                             00018650A340 ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer
    // 028 FesUnitDetailViewModel                   00018654AC20 ModelClassType FUnitDetailPopupViewModel FUnitDetailPopupViewModel FUnitDetailPopupViewModel Pointer
    // 030 <ProduceCards>k__BackingField            IEnumerable`1<IProduceCardStatus> IL2CPP_TYPE_GENERICINST
    // 038 PIdolUnitViewModels                      000185B74420 ModelClassListType ChallengeTourPIdolUnitViewModel[] ChallengeTourPIdolUnitViewModel[] List<ChallengeTourPIdolUnitViewModel> Pointer
    // 040 PIdolUnitVoDaViMeParameter               0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 048 StageViewModels                          000185B74930 ModelClassListType ChallengeTourStageViewModel[] ChallengeTourStageViewModel[] List<ChallengeTourStageViewModel> Pointer
    public partial class ChallengeTourUnitViewModel
    {
        public List<ChallengeTourStageViewModel>?       StageViewModels                         { get; set; }
        public IChallengeTourStatus?                    ChallengeTourStatus                     { get; set; }
        public IFesUnitStatus?                          FesUnitModel                            { get; set; }
        public FUnitDetailPopupViewModel?               FesUnitDetailViewModel                  { get; set; }
        public List<ChallengeTourPIdolUnitViewModel>?   PIdolUnitViewModels                     { get; set; }
        public IProduceParameterStatus?                 PIdolUnitVoDaViMeParameter              { get; set; }

        public static ChallengeTourUnitViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitViewModel();

            value.StageViewModels                           = GetObjectList<ChallengeTourStageViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChallengeTourStageViewModel.FromPointer); // 0270D6476400 0x48 StageViewModels             ( 000185B74930 ModelClassListType ChallengeTourStageViewModel[] ChallengeTourStageViewModel[] List<ChallengeTourStageViewModel> Pointer )
            value.ChallengeTourStatus                       = GetObject<IChallengeTourStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChallengeTourStatus.FromPointer); // 0270D6476340 0x18 ChallengeTourStatus         ( 000186727850 ModelClassType IChallengeTourStatus IChallengeTourStatus IChallengeTourStatus Pointer )
            value.FesUnitModel                              = GetObject<IFesUnitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 0270D6476360 0x20 FesUnitModel                ( 00018650A340 ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer )
            value.FesUnitDetailViewModel                    = GetObject<FUnitDetailPopupViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.FUnitDetailPopupViewModel.FromPointer); // 0270D6476380 0x28 FesUnitDetailViewModel      ( 00018654AC20 ModelClassType FUnitDetailPopupViewModel FUnitDetailPopupViewModel FUnitDetailPopupViewModel Pointer )
            value.PIdolUnitViewModels                       = GetObjectList<ChallengeTourPIdolUnitViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourPIdolUnitViewModel.FromPointer); // 0270D64763C0 0x38 PIdolUnitViewModels         ( 000185B74420 ModelClassListType ChallengeTourPIdolUnitViewModel[] ChallengeTourPIdolUnitViewModel[] List<ChallengeTourPIdolUnitViewModel> Pointer )
            value.PIdolUnitVoDaViMeParameter                = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0270D64763E0 0x40 PIdolUnitVoDaViMeParameter  ( 0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )

            return value;
        }
    }
}
