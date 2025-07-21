using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MissionModelLists                        ModelClassListType List`1<SpecialMissionListViewModel> List`1<SpecialMissionListViewModel> List<SpecialMissionListViewModel> Pointer
    // 018 CurrentSpecialMission                    ModelClassType SpecialMission SpecialMission SpecialMission Pointer
    // 020 CurrentStepMission                       ModelClassType SpecialMissionStep SpecialMissionStep SpecialMissionStep Pointer
    // 028 NextStepMission                          ModelClassType SpecialMissionStep SpecialMissionStep SpecialMissionStep Pointer
    // 030 SpecialMissionList                       ModelClassListType List`1<SpecialMission> List`1<SpecialMission> List<SpecialMission> Pointer
    // 038 SelectSpecialMissionId                   ModelPrimitiveType int int int Int32
    // 03C SelectTabIndex                           ModelPrimitiveType int int int Int32
    public partial class SpecialMissionPopupViewModel : DataModel
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
            var value   = new SpecialMissionPopupViewModel() { Pointer= p0 };

            value.MissionModelLists                         = GetObjectList<SpecialMissionListViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SpecialMissionListViewModel.FromPointer); // 0x10 MissionModelLists           ( ModelClassListType List`1<SpecialMissionListViewModel> List`1<SpecialMissionListViewModel> List<SpecialMissionListViewModel> Pointer )
            value.CurrentSpecialMission                     = GetObject<SpecialMission>(new IntPtr(p + 0x018), ReversePrism.DataModels.SpecialMission.FromPointer); // 0x18 CurrentSpecialMission       ( ModelClassType SpecialMission SpecialMission SpecialMission Pointer )
            value.CurrentStepMission                        = GetObject<SpecialMissionStep>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpecialMissionStep.FromPointer); // 0x20 CurrentStepMission          ( ModelClassType SpecialMissionStep SpecialMissionStep SpecialMissionStep Pointer )
            value.NextStepMission                           = GetObject<SpecialMissionStep>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpecialMissionStep.FromPointer); // 0x28 NextStepMission             ( ModelClassType SpecialMissionStep SpecialMissionStep SpecialMissionStep Pointer )
            value.SpecialMissionList                        = GetObjectList<SpecialMission>(new IntPtr(p + 0x030), ReversePrism.DataModels.SpecialMission.FromPointer); // 0x30 SpecialMissionList          ( ModelClassListType List`1<SpecialMission> List`1<SpecialMission> List<SpecialMission> Pointer )
            value.SelectSpecialMissionId                    = GetInt32(new IntPtr(p + 0x038)); // 0x38 SelectSpecialMissionId      ( ModelPrimitiveType int int int Int32 )
            value.SelectTabIndex                            = GetInt32(new IntPtr(p + 0x03C)); // 0x3C SelectTabIndex              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
