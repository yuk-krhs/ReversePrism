using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteFilterRow                        0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 028 BtnRest                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 Vm                                       00018656B3B0 ModelClassType FesUnitSearchPopupViewModel FesUnitSearchPopupViewModel FesUnitSearchPopupViewModel Pointer
    public partial class FesUnitFilterView : DataModel
    {
        public UIFilterGroup?                           FavoriteFilterRow                       { get; set; }
        public UIButton?                                BtnRest                                 { get; set; }
        public FesUnitSearchPopupViewModel?             Vm                                      { get; set; }

        public static FesUnitFilterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitFilterView() { Pointer= p0 };

            value.FavoriteFilterRow                         = GetObject<UIFilterGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 02466A300E10 0x20 FavoriteFilterRow           ( 0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.BtnRest                                   = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466A300E30 0x28 BtnRest                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Vm                                        = GetObject<FesUnitSearchPopupViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.FesUnitSearchPopupViewModel.FromPointer); // 02466A300E50 0x30 Vm                          ( 00018656B3B0 ModelClassType FesUnitSearchPopupViewModel FesUnitSearchPopupViewModel FesUnitSearchPopupViewModel Pointer )

            return value;
        }
    }
}
