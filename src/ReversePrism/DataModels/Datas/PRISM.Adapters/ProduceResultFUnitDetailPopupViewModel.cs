using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceResultUnitMemberViewModelList     000185CFCC78 ModelClassListType List`1<ProduceResultUnitMemberViewModel> List`1<ProduceResultUnitMemberViewModel> List<ProduceResultUnitMemberViewModel> Pointer
    // 018 FesUnitStatus                            00018650A5E0 ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer
    // 020 FUnitDetailViewModel                     00018654AEB0 ModelClassType FUnitDetailPopupViewModel FUnitDetailPopupViewModel FUnitDetailPopupViewModel Pointer
    // 028 LiveSkillIDs                             000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 030 NewUnitName                              000186671910 ModelPrimitiveType string string string String
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

            value.ProduceResultUnitMemberViewModelList      = GetObjectList<ProduceResultUnitMemberViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceResultUnitMemberViewModel.FromPointer); // 024665FA8760 0x10 ProduceResultUnitMemberViewModelList ( 000185CFCC78 ModelClassListType List`1<ProduceResultUnitMemberViewModel> List`1<ProduceResultUnitMemberViewModel> List<ProduceResultUnitMemberViewModel> Pointer )
            value.FesUnitStatus                             = GetObject<IFesUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 024665FA8780 0x18 FesUnitStatus               ( 00018650A5E0 ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer )
            value.FUnitDetailViewModel                      = GetObject<FUnitDetailPopupViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.FUnitDetailPopupViewModel.FromPointer); // 024665FA87A0 0x20 FUnitDetailViewModel        ( 00018654AEB0 ModelClassType FUnitDetailPopupViewModel FUnitDetailPopupViewModel FUnitDetailPopupViewModel Pointer )
            value.LiveSkillIDs                              = GetInt32List(new IntPtr(p + 0x028)); // 024665FA87C0 0x28 LiveSkillIDs                ( 000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.NewUnitName                               = GetString(new IntPtr(p + 0x030)); // 024665FA87E0 0x30 NewUnitName                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
