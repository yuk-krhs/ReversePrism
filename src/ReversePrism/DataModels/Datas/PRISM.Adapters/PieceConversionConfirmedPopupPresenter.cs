using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865D6110 ModelClassType IPieceConversionConfirmedPopupView IPieceConversionConfirmedPopupView IPieceConversionConfirmedPopupView Pointer
    // 018 Vm                                       000186742090 ModelClassType PieceConversionConfirmedPopupViewModel PieceConversionConfirmedPopupViewModel PieceConversionConfirmedPopupViewModel Pointer
    public partial class PieceConversionConfirmedPopupPresenter
    {
        public IPieceConversionConfirmedPopupView?      View                                    { get; set; }
        public PieceConversionConfirmedPopupViewModel?  Vm                                      { get; set; }

        public static PieceConversionConfirmedPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceConversionConfirmedPopupPresenter();

            value.View                                      = GetObject<IPieceConversionConfirmedPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPieceConversionConfirmedPopupView.FromPointer); // 0270D5F8CA60 0x10 View                        ( 0001865D6110 ModelClassType IPieceConversionConfirmedPopupView IPieceConversionConfirmedPopupView IPieceConversionConfirmedPopupView Pointer )
            value.Vm                                        = GetObject<PieceConversionConfirmedPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.PieceConversionConfirmedPopupViewModel.FromPointer); // 0270D5F8CA80 0x18 Vm                          ( 000186742090 ModelClassType PieceConversionConfirmedPopupViewModel PieceConversionConfirmedPopupViewModel PieceConversionConfirmedPopupViewModel Pointer )

            return value;
        }
    }
}
