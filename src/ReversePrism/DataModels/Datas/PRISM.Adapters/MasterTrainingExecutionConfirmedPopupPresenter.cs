using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865A91A0 ModelClassType IMasterTrainingExecutionConfirmedPopupView IMasterTrainingExecutionConfirmedPopupView IMasterTrainingExecutionConfirmedPopupView Pointer
    // 018 Vm                                       0001865DAE30 ModelClassType MasterTrainingExecutionConfirmedPopupViewModel MasterTrainingExecutionConfirmedPopupViewModel MasterTrainingExecutionConfirmedPopupViewModel Pointer
    public partial class MasterTrainingExecutionConfirmedPopupPresenter
    {
        public IMasterTrainingExecutionConfirmedPopupView? View                                    { get; set; }
        public MasterTrainingExecutionConfirmedPopupViewModel? Vm                                      { get; set; }

        public static MasterTrainingExecutionConfirmedPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MasterTrainingExecutionConfirmedPopupPresenter();

            value.View                                      = GetObject<IMasterTrainingExecutionConfirmedPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMasterTrainingExecutionConfirmedPopupView.FromPointer); // 0270D5F77498 0x10 View                        ( 0001865A91A0 ModelClassType IMasterTrainingExecutionConfirmedPopupView IMasterTrainingExecutionConfirmedPopupView IMasterTrainingExecutionConfirmedPopupView Pointer )
            value.Vm                                        = GetObject<MasterTrainingExecutionConfirmedPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.MasterTrainingExecutionConfirmedPopupViewModel.FromPointer); // 0270D5F774B8 0x18 Vm                          ( 0001865DAE30 ModelClassType MasterTrainingExecutionConfirmedPopupViewModel MasterTrainingExecutionConfirmedPopupViewModel MasterTrainingExecutionConfirmedPopupViewModel Pointer )

            return value;
        }
    }
}
