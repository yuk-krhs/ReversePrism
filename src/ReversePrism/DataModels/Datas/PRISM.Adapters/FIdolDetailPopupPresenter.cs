using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186773C50 ModelClassType IFIdolDetailPopupView IFIdolDetailPopupView IFIdolDetailPopupView Pointer
    // 018 ViewModel                                000186543830 ModelClassType FIdolDetailPopupViewModel FIdolDetailPopupViewModel FIdolDetailPopupViewModel Pointer
    // 020 onChangeFavoriteMark                     Subject`1<IFesIdolStatus> IL2CPP_TYPE_GENERICINST
    // 028 FIdolDetailPopupViewFactory              000186774150 ModelClassType IFIdolDetailPopupViewFactory IFIdolDetailPopupViewFactory IFIdolDetailPopupViewFactory Pointer
    public partial class FIdolDetailPopupPresenter
    {
        public IFIdolDetailPopupView?                   View                                    { get; set; }
        public FIdolDetailPopupViewModel?               ViewModel                               { get; set; }
        public IFIdolDetailPopupViewFactory?            FIdolDetailPopupViewFactory             { get; set; }

        public static FIdolDetailPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FIdolDetailPopupPresenter();

            value.View                                      = GetObject<IFIdolDetailPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFIdolDetailPopupView.FromPointer); // 0270D5F31FF0 0x10 View                        ( 000186773C50 ModelClassType IFIdolDetailPopupView IFIdolDetailPopupView IFIdolDetailPopupView Pointer )
            value.ViewModel                                 = GetObject<FIdolDetailPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.FIdolDetailPopupViewModel.FromPointer); // 0270D5F32010 0x18 ViewModel                   ( 000186543830 ModelClassType FIdolDetailPopupViewModel FIdolDetailPopupViewModel FIdolDetailPopupViewModel Pointer )
            value.FIdolDetailPopupViewFactory               = GetObject<IFIdolDetailPopupViewFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.IFIdolDetailPopupViewFactory.FromPointer); // 0270D5F32050 0x28 FIdolDetailPopupViewFactory ( 000186774150 ModelClassType IFIdolDetailPopupViewFactory IFIdolDetailPopupViewFactory IFIdolDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
