using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001866222D0 ModelClassType ISCTrainingExecutionConfirmedPopupView ISCTrainingExecutionConfirmedPopupView ISCTrainingExecutionConfirmedPopupView Pointer
    // 018 Vm                                       0001866A2EF0 ModelClassType SCTrainingExecutionConfirmedPopupViewModel SCTrainingExecutionConfirmedPopupViewModel SCTrainingExecutionConfirmedPopupViewModel Pointer
    public partial class SCTrainingExecutionConfirmedPopupPresenter : DataModel
    {
        public ISCTrainingExecutionConfirmedPopupView?  View                                    { get; set; }
        public SCTrainingExecutionConfirmedPopupViewModel? Vm                                      { get; set; }

        public static SCTrainingExecutionConfirmedPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCTrainingExecutionConfirmedPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ISCTrainingExecutionConfirmedPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISCTrainingExecutionConfirmedPopupView.FromPointer); // 02466600D4B0 0x10 View                        ( 0001866222D0 ModelClassType ISCTrainingExecutionConfirmedPopupView ISCTrainingExecutionConfirmedPopupView ISCTrainingExecutionConfirmedPopupView Pointer )
            value.Vm                                        = GetObject<SCTrainingExecutionConfirmedPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SCTrainingExecutionConfirmedPopupViewModel.FromPointer); // 02466600D4D0 0x18 Vm                          ( 0001866A2EF0 ModelClassType SCTrainingExecutionConfirmedPopupViewModel SCTrainingExecutionConfirmedPopupViewModel SCTrainingExecutionConfirmedPopupViewModel Pointer )

            return value;
        }
    }
}
