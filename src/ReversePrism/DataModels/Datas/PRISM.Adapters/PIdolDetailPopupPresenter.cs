using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865CF6E0 ModelClassType IPIdolDetailPopupView IPIdolDetailPopupView IPIdolDetailPopupView Pointer
    // 018 ViewModel                                00018670AC40 ModelClassType PIdolDetailPopupViewModel PIdolDetailPopupViewModel PIdolDetailPopupViewModel Pointer
    // 020 onChangeFavoriteMark                     Subject`1<IProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 028 onChangeIdolSkill                        Subject`1<IProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 030 PIdolDetailPopupViewFactory              0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    public partial class PIdolDetailPopupPresenter
    {
        public IPIdolDetailPopupView?                   View                                    { get; set; }
        public PIdolDetailPopupViewModel?               ViewModel                               { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }

        public static PIdolDetailPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailPopupPresenter();

            value.View                                      = GetObject<IPIdolDetailPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPIdolDetailPopupView.FromPointer); // 0270D5F7A360 0x10 View                        ( 0001865CF6E0 ModelClassType IPIdolDetailPopupView IPIdolDetailPopupView IPIdolDetailPopupView Pointer )
            value.ViewModel                                 = GetObject<PIdolDetailPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.PIdolDetailPopupViewModel.FromPointer); // 0270D5F7A380 0x18 ViewModel                   ( 00018670AC40 ModelClassType PIdolDetailPopupViewModel PIdolDetailPopupViewModel PIdolDetailPopupViewModel Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 0270D5F7A3E0 0x30 PIdolDetailPopupViewFactory ( 0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
