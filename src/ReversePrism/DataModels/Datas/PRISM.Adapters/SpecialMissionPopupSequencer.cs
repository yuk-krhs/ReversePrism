using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  IPopupViewFactory`1<ISpecialMissionPopupView> IL2CPP_TYPE_GENERICINST
    // 018 ViewModel                                0001865475D0 ModelClassType SpecialMissionPopupViewModel SpecialMissionPopupViewModel SpecialMissionPopupViewModel Pointer
    // 020 View                                     00018664C370 ModelClassType ISpecialMissionPopupView ISpecialMissionPopupView ISpecialMissionPopupView Pointer
    public partial class SpecialMissionPopupSequencer : DataModel
    {
        public SpecialMissionPopupViewModel?            ViewModel                               { get; set; }
        public ISpecialMissionPopupView?                View                                    { get; set; }

        public static SpecialMissionPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionPopupSequencer() { Pointer= p0 };

            value.ViewModel                                 = GetObject<SpecialMissionPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SpecialMissionPopupViewModel.FromPointer); // 0246667B7690 0x18 ViewModel                   ( 0001865475D0 ModelClassType SpecialMissionPopupViewModel SpecialMissionPopupViewModel SpecialMissionPopupViewModel Pointer )
            value.View                                      = GetObject<ISpecialMissionPopupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISpecialMissionPopupView.FromPointer); // 0246667B76B0 0x20 View                        ( 00018664C370 ModelClassType ISpecialMissionPopupView ISpecialMissionPopupView ISpecialMissionPopupView Pointer )

            return value;
        }
    }
}
