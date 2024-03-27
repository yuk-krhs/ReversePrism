using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    000186704090 ModelClassType SeasonMissionModel SeasonMissionModel SeasonMissionModel Pointer
    // 018 SeasonMissionMissionListViewModels       000185D06B28 ModelClassListType List`1<SeasonMissionMissionListViewModel> List`1<SeasonMissionMissionListViewModel> List<SeasonMissionMissionListViewModel> Pointer
    // 020 SeasonMissionRewardListViewModels        000185D06D78 ModelClassListType List`1<SeasonMissionRewardListViewModel> List`1<SeasonMissionRewardListViewModel> List<SeasonMissionRewardListViewModel> Pointer
    // 028 RewardScroll                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 MissionFilterModel                       000186701E10 ModelClassType SeasonMissionFilterModel SeasonMissionFilterModel SeasonMissionFilterModel Pointer
    // 038 saveData                                 SavableJsonObject`1<SeasonMissionFilterSaveData> IL2CPP_TYPE_GENERICINST
    // 040 onTabClickChange                         Subject`1<SeasonMissionTabType> IL2CPP_TYPE_GENERICINST
    // 048 TabType                                  000186618470 ModelEnumType SeasonMissionTabType SeasonMissionTabType SeasonMissionTabType Int32
    // 04C PreTabType                               000186618470 ModelEnumType SeasonMissionTabType SeasonMissionTabType SeasonMissionTabType Int32
    // 050 AnimationSkip                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SeasonMissionViewModel
    {
        public SeasonMissionModel?                      Model                                   { get; set; }
        public List<SeasonMissionMissionListViewModel>? SeasonMissionMissionListViewModels      { get; set; }
        public List<SeasonMissionRewardListViewModel>?  SeasonMissionRewardListViewModels       { get; set; }
        public int                                      RewardScroll                            { get; set; }
        public SeasonMissionFilterModel?                MissionFilterModel                      { get; set; }
        public SeasonMissionTabType                     TabType                                 { get; set; }
        public SeasonMissionTabType                     PreTabType                              { get; set; }
        public bool                                     AnimationSkip                           { get; set; }

        public static SeasonMissionViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionViewModel();

            value.Model                                     = GetObject<SeasonMissionModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SeasonMissionModel.FromPointer); // 0270D66BECA8 0x10 Model                       ( 000186704090 ModelClassType SeasonMissionModel SeasonMissionModel SeasonMissionModel Pointer )
            value.SeasonMissionMissionListViewModels        = GetObjectList<SeasonMissionMissionListViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SeasonMissionMissionListViewModel.FromPointer); // 0270D66BECC8 0x18 SeasonMissionMissionListViewModels ( 000185D06B28 ModelClassListType List`1<SeasonMissionMissionListViewModel> List`1<SeasonMissionMissionListViewModel> List<SeasonMissionMissionListViewModel> Pointer )
            value.SeasonMissionRewardListViewModels         = GetObjectList<SeasonMissionRewardListViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.SeasonMissionRewardListViewModel.FromPointer); // 0270D66BECE8 0x20 SeasonMissionRewardListViewModels ( 000185D06D78 ModelClassListType List`1<SeasonMissionRewardListViewModel> List`1<SeasonMissionRewardListViewModel> List<SeasonMissionRewardListViewModel> Pointer )
            value.RewardScroll                              = GetInt32(new IntPtr(p + 0x028)); // 0270D66BED08 0x28 RewardScroll                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MissionFilterModel                        = GetObject<SeasonMissionFilterModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.SeasonMissionFilterModel.FromPointer); // 0270D66BED28 0x30 MissionFilterModel          ( 000186701E10 ModelClassType SeasonMissionFilterModel SeasonMissionFilterModel SeasonMissionFilterModel Pointer )
            value.TabType                                   = (SeasonMissionTabType)GetInt32(new IntPtr(p + 0x048)); // 0270D66BED88 0x48 TabType                     ( 000186618470 ModelEnumType SeasonMissionTabType SeasonMissionTabType SeasonMissionTabType Int32 )
            value.PreTabType                                = (SeasonMissionTabType)GetInt32(new IntPtr(p + 0x04C)); // 0270D66BEDA8 0x4C PreTabType                  ( 000186618470 ModelEnumType SeasonMissionTabType SeasonMissionTabType SeasonMissionTabType Int32 )
            value.AnimationSkip                             = GetBool(new IntPtr(p + 0x050)); // 0270D66BEDC8 0x50 AnimationSkip               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
