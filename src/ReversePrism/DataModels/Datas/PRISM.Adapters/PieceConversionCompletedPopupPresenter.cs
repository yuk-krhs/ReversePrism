using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865D5C50 ModelClassType IPieceConversionCompletedPopupView IPieceConversionCompletedPopupView IPieceConversionCompletedPopupView Pointer
    // 018 Vm                                       000186740850 ModelClassType PieceConversionCompletedPopupViewModel PieceConversionCompletedPopupViewModel PieceConversionCompletedPopupViewModel Pointer
    public partial class PieceConversionCompletedPopupPresenter
    {
        public IPieceConversionCompletedPopupView?      View                                    { get; set; }
        public PieceConversionCompletedPopupViewModel?  Vm                                      { get; set; }

        public static PieceConversionCompletedPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceConversionCompletedPopupPresenter();

            value.View                                      = GetObject<IPieceConversionCompletedPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPieceConversionCompletedPopupView.FromPointer); // 0270D5F8C540 0x10 View                        ( 0001865D5C50 ModelClassType IPieceConversionCompletedPopupView IPieceConversionCompletedPopupView IPieceConversionCompletedPopupView Pointer )
            value.Vm                                        = GetObject<PieceConversionCompletedPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.PieceConversionCompletedPopupViewModel.FromPointer); // 0270D5F8C560 0x18 Vm                          ( 000186740850 ModelClassType PieceConversionCompletedPopupViewModel PieceConversionCompletedPopupViewModel PieceConversionCompletedPopupViewModel Pointer )

            return value;
        }
    }
}
