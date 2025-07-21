using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IPIdolDetailPopupView IPIdolDetailPopupView IPIdolDetailPopupView Pointer
    // 018 ViewModel                                ModelClassType PIdolDetailPopupViewModel PIdolDetailPopupViewModel PIdolDetailPopupViewModel Pointer
    // 020 onChangeFavoriteMark                     Subject`1<IProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 028 onChangeIdolSkill                        Subject`1<IProduceIdolStatus> IL2CPP_TYPE_GENERICINST
    // 030 PIdolDetailPopupViewFactory              ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    public partial class PIdolDetailPopupPresenter : DataModel
    {
        public IPIdolDetailPopupView?                   View                                    { get; set; }
        public PIdolDetailPopupViewModel?               ViewModel                               { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }

        public static PIdolDetailPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IPIdolDetailPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPIdolDetailPopupView.FromPointer); // 0x10 View                        ( ModelClassType IPIdolDetailPopupView IPIdolDetailPopupView IPIdolDetailPopupView Pointer )
            value.ViewModel                                 = GetObject<PIdolDetailPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.PIdolDetailPopupViewModel.FromPointer); // 0x18 ViewModel                   ( ModelClassType PIdolDetailPopupViewModel PIdolDetailPopupViewModel PIdolDetailPopupViewModel Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 0x30 PIdolDetailPopupViewFactory ( ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
