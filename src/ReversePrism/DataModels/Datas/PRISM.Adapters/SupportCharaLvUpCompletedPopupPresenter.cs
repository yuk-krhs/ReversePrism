using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186666B00 ModelClassType ISupportCharaLvUpCompletedPopupView ISupportCharaLvUpCompletedPopupView ISupportCharaLvUpCompletedPopupView Pointer
    // 018 Vm                                       0001865E07C0 ModelClassType SupportCharaLvUpCompletedPopupViewModel SupportCharaLvUpCompletedPopupViewModel SupportCharaLvUpCompletedPopupViewModel Pointer
    // 020 onDetail                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharaLvUpCompletedPopupPresenter
    {
        public ISupportCharaLvUpCompletedPopupView?     View                                    { get; set; }
        public SupportCharaLvUpCompletedPopupViewModel? Vm                                      { get; set; }

        public static SupportCharaLvUpCompletedPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaLvUpCompletedPopupPresenter();

            value.View                                      = GetObject<ISupportCharaLvUpCompletedPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISupportCharaLvUpCompletedPopupView.FromPointer); // 0270D5F96350 0x10 View                        ( 000186666B00 ModelClassType ISupportCharaLvUpCompletedPopupView ISupportCharaLvUpCompletedPopupView ISupportCharaLvUpCompletedPopupView Pointer )
            value.Vm                                        = GetObject<SupportCharaLvUpCompletedPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SupportCharaLvUpCompletedPopupViewModel.FromPointer); // 0270D5F96370 0x18 Vm                          ( 0001865E07C0 ModelClassType SupportCharaLvUpCompletedPopupViewModel SupportCharaLvUpCompletedPopupViewModel SupportCharaLvUpCompletedPopupViewModel Pointer )

            return value;
        }
    }
}
