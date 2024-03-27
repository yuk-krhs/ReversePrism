using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MissionModelLists                        000185D0B008 ModelClassListType List`1<SpecialMissionListViewModel> List`1<SpecialMissionListViewModel> List<SpecialMissionListViewModel> Pointer
    // 018 CurrentSpecialMission                    000186541670 ModelClassType SpecialMission SpecialMission SpecialMission Pointer
    // 020 CurrentStepMission                       000186549510 ModelClassType SpecialMissionStep SpecialMissionStep SpecialMissionStep Pointer
    // 028 NextStepMission                          000186549510 ModelClassType SpecialMissionStep SpecialMissionStep SpecialMissionStep Pointer
    // 030 SpecialMissionList                       000185D0ADD8 ModelClassListType List`1<SpecialMission> List`1<SpecialMission> List<SpecialMission> Pointer
    // 038 SelectSpecialMissionId                   0001865F4260 ModelPrimitiveType int int int Int32
    // 03C SelectTabIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SpecialMissionPopupViewModel
    {
        public List<SpecialMissionListViewModel>?       MissionModelLists                       { get; set; }
        public SpecialMission?                          CurrentSpecialMission                   { get; set; }
        public SpecialMissionStep?                      CurrentStepMission                      { get; set; }
        public SpecialMissionStep?                      NextStepMission                         { get; set; }
        public List<SpecialMission>?                    SpecialMissionList                      { get; set; }
        public int                                      SelectSpecialMissionId                  { get; set; }
        public int                                      SelectTabIndex                          { get; set; }

        public static SpecialMissionPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionPopupViewModel();

            value.MissionModelLists                         = GetObjectList<SpecialMissionListViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SpecialMissionListViewModel.FromPointer); // 0270D63A0930 0x10 MissionModelLists           ( 000185D0B008 ModelClassListType List`1<SpecialMissionListViewModel> List`1<SpecialMissionListViewModel> List<SpecialMissionListViewModel> Pointer )
            value.CurrentSpecialMission                     = GetObject<SpecialMission>(new IntPtr(p + 0x018), ReversePrism.DataModels.SpecialMission.FromPointer); // 0270D63A0950 0x18 CurrentSpecialMission       ( 000186541670 ModelClassType SpecialMission SpecialMission SpecialMission Pointer )
            value.CurrentStepMission                        = GetObject<SpecialMissionStep>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpecialMissionStep.FromPointer); // 0270D63A0970 0x20 CurrentStepMission          ( 000186549510 ModelClassType SpecialMissionStep SpecialMissionStep SpecialMissionStep Pointer )
            value.NextStepMission                           = GetObject<SpecialMissionStep>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpecialMissionStep.FromPointer); // 0270D63A0990 0x28 NextStepMission             ( 000186549510 ModelClassType SpecialMissionStep SpecialMissionStep SpecialMissionStep Pointer )
            value.SpecialMissionList                        = GetObjectList<SpecialMission>(new IntPtr(p + 0x030), ReversePrism.DataModels.SpecialMission.FromPointer); // 0270D63A09B0 0x30 SpecialMissionList          ( 000185D0ADD8 ModelClassListType List`1<SpecialMission> List`1<SpecialMission> List<SpecialMission> Pointer )
            value.SelectSpecialMissionId                    = GetInt32(new IntPtr(p + 0x038)); // 0270D63A09D0 0x38 SelectSpecialMissionId      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SelectTabIndex                            = GetInt32(new IntPtr(p + 0x03C)); // 0270D63A09F0 0x3C SelectTabIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
