using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186774630 ModelClassType IFUnitDetailPopupView IFUnitDetailPopupView IFUnitDetailPopupView Pointer
    // 018 ViewModel                                00018654AC20 ModelClassType FUnitDetailPopupViewModel FUnitDetailPopupViewModel FUnitDetailPopupViewModel Pointer
    // 020 onChangeFavoriteMark                     Subject`1<IFesUnitStatus> IL2CPP_TYPE_GENERICINST
    // 028 onChangeUnitName                         Subject`1<IFesUnitStatus> IL2CPP_TYPE_GENERICINST
    // 030 FUnitDetailPopupViewFactory              000186774B10 ModelClassType IFUnitDetailPopupViewFactory IFUnitDetailPopupViewFactory IFUnitDetailPopupViewFactory Pointer
    public partial class FUnitDetailPopupPresenter
    {
        public IFUnitDetailPopupView?                   View                                    { get; set; }
        public FUnitDetailPopupViewModel?               ViewModel                               { get; set; }
        public IFUnitDetailPopupViewFactory?            FUnitDetailPopupViewFactory             { get; set; }

        public static FUnitDetailPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailPopupPresenter();

            value.View                                      = GetObject<IFUnitDetailPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFUnitDetailPopupView.FromPointer); // 0270D5F40610 0x10 View                        ( 000186774630 ModelClassType IFUnitDetailPopupView IFUnitDetailPopupView IFUnitDetailPopupView Pointer )
            value.ViewModel                                 = GetObject<FUnitDetailPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.FUnitDetailPopupViewModel.FromPointer); // 0270D5F40630 0x18 ViewModel                   ( 00018654AC20 ModelClassType FUnitDetailPopupViewModel FUnitDetailPopupViewModel FUnitDetailPopupViewModel Pointer )
            value.FUnitDetailPopupViewFactory               = GetObject<IFUnitDetailPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.IFUnitDetailPopupViewFactory.FromPointer); // 0270D5F40690 0x30 FUnitDetailPopupViewFactory ( 000186774B10 ModelClassType IFUnitDetailPopupViewFactory IFUnitDetailPopupViewFactory IFUnitDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
