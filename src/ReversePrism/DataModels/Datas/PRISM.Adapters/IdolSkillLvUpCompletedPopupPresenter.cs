using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186577820 ModelClassType IIdolSkillLvUpCompletedPopupView IIdolSkillLvUpCompletedPopupView IIdolSkillLvUpCompletedPopupView Pointer
    // 018 Vm                                       0001866C0580 ModelClassType IdolSkillLvUpCompletedPopupViewModel IdolSkillLvUpCompletedPopupViewModel IdolSkillLvUpCompletedPopupViewModel Pointer
    // 020 onDetail                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillLvUpCompletedPopupPresenter : DataModel
    {
        public IIdolSkillLvUpCompletedPopupView?        View                                    { get; set; }
        public IdolSkillLvUpCompletedPopupViewModel?    Vm                                      { get; set; }

        public static IdolSkillLvUpCompletedPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillLvUpCompletedPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IIdolSkillLvUpCompletedPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIdolSkillLvUpCompletedPopupView.FromPointer); // 024665FCE9F8 0x10 View                        ( 000186577820 ModelClassType IIdolSkillLvUpCompletedPopupView IIdolSkillLvUpCompletedPopupView IIdolSkillLvUpCompletedPopupView Pointer )
            value.Vm                                        = GetObject<IdolSkillLvUpCompletedPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolSkillLvUpCompletedPopupViewModel.FromPointer); // 024665FCEA18 0x18 Vm                          ( 0001866C0580 ModelClassType IdolSkillLvUpCompletedPopupViewModel IdolSkillLvUpCompletedPopupViewModel IdolSkillLvUpCompletedPopupViewModel Pointer )

            return value;
        }
    }
}
