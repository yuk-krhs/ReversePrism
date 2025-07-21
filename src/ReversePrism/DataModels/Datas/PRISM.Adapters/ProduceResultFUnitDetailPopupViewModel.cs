using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceResultUnitMemberViewModelList     ModelClassListType List`1<ProduceResultUnitMemberViewModel> List`1<ProduceResultUnitMemberViewModel> List<ProduceResultUnitMemberViewModel> Pointer
    // 018 FesUnitStatus                            ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer
    // 020 FUnitDetailViewModel                     ModelClassType FUnitDetailPopupViewModel FUnitDetailPopupViewModel FUnitDetailPopupViewModel Pointer
    // 028 LiveSkillIDs                             ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 030 NewUnitName                              ModelPrimitiveType string string string String
    public partial class ProduceResultFUnitDetailPopupViewModel : DataModel
    {
        public List<ProduceResultUnitMemberViewModel>?  ProduceResultUnitMemberViewModelList    { get; set; }
        public IFesUnitStatus?                          FesUnitStatus                           { get; set; }
        public FUnitDetailPopupViewModel?               FUnitDetailViewModel                    { get; set; }
        public List<int>?                               LiveSkillIDs                            { get; set; }
        public string                                   NewUnitName                             { get; set; }

        public static ProduceResultFUnitDetailPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultFUnitDetailPopupViewModel() { Pointer= p0 };

            value.ProduceResultUnitMemberViewModelList      = GetObjectList<ProduceResultUnitMemberViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceResultUnitMemberViewModel.FromPointer); // 0x10 ProduceResultUnitMemberViewModelList ( ModelClassListType List`1<ProduceResultUnitMemberViewModel> List`1<ProduceResultUnitMemberViewModel> List<ProduceResultUnitMemberViewModel> Pointer )
            value.FesUnitStatus                             = GetObject<IFesUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 0x18 FesUnitStatus               ( ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer )
            value.FUnitDetailViewModel                      = GetObject<FUnitDetailPopupViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.FUnitDetailPopupViewModel.FromPointer); // 0x20 FUnitDetailViewModel        ( ModelClassType FUnitDetailPopupViewModel FUnitDetailPopupViewModel FUnitDetailPopupViewModel Pointer )
            value.LiveSkillIDs                              = GetInt32List(new IntPtr(p + 0x028)); // 0x28 LiveSkillIDs                ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.NewUnitName                               = GetString(new IntPtr(p + 0x030)); // 0x30 NewUnitName                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
