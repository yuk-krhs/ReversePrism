using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865CEDB0 ModelClassType IPITrainingExecutionConfirmedPopupView IPITrainingExecutionConfirmedPopupView IPITrainingExecutionConfirmedPopupView Pointer
    // 018 Vm                                       000186707280 ModelClassType PITrainingExecutionConfirmedPopupViewModel PITrainingExecutionConfirmedPopupViewModel PITrainingExecutionConfirmedPopupViewModel Pointer
    public partial class PITrainingExecutionConfirmedPopupPresenter
    {
        public IPITrainingExecutionConfirmedPopupView?  View                                    { get; set; }
        public PITrainingExecutionConfirmedPopupViewModel? Vm                                      { get; set; }

        public static PITrainingExecutionConfirmedPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PITrainingExecutionConfirmedPopupPresenter();

            value.View                                      = GetObject<IPITrainingExecutionConfirmedPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPITrainingExecutionConfirmedPopupView.FromPointer); // 0270D5F8D650 0x10 View                        ( 0001865CEDB0 ModelClassType IPITrainingExecutionConfirmedPopupView IPITrainingExecutionConfirmedPopupView IPITrainingExecutionConfirmedPopupView Pointer )
            value.Vm                                        = GetObject<PITrainingExecutionConfirmedPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.PITrainingExecutionConfirmedPopupViewModel.FromPointer); // 0270D5F8D670 0x18 Vm                          ( 000186707280 ModelClassType PITrainingExecutionConfirmedPopupViewModel PITrainingExecutionConfirmedPopupViewModel PITrainingExecutionConfirmedPopupViewModel Pointer )

            return value;
        }
    }
}
