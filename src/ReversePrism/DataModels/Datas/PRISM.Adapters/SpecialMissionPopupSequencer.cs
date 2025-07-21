using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                ModelClassType SpecialMissionPopupViewModel SpecialMissionPopupViewModel SpecialMissionPopupViewModel Pointer
    // 018 View                                     ModelClassType ISpecialMissionPopupView ISpecialMissionPopupView ISpecialMissionPopupView Pointer
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

            value.ViewModel                                 = GetObject<SpecialMissionPopupViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SpecialMissionPopupViewModel.FromPointer); // 0x10 ViewModel                   ( ModelClassType SpecialMissionPopupViewModel SpecialMissionPopupViewModel SpecialMissionPopupViewModel Pointer )
            value.View                                      = GetObject<ISpecialMissionPopupView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISpecialMissionPopupView.FromPointer); // 0x18 View                        ( ModelClassType ISpecialMissionPopupView ISpecialMissionPopupView ISpecialMissionPopupView Pointer )

            return value;
        }
    }
}
