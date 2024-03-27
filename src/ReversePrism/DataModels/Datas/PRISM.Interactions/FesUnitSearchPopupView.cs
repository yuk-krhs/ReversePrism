using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SortFilterTabGroup                       0001866F35E0 ModelClassType UISortFilterTabGroup UISortFilterTabGroup UISortFilterTabGroup Pointer
    // 028 SortView                                 00018656DC00 ModelClassType FesUnitSortView FesUnitSortView FesUnitSortView Pointer
    // 030 FilterView                               0001865684F0 ModelClassType FesUnitFilterView FesUnitFilterView FesUnitFilterView Pointer
    // 038 onClick                                  Subject`1<Nullable`1<int>> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FesUnitSearchPopupView
    {
        public UISortFilterTabGroup?                    SortFilterTabGroup                      { get; set; }
        public FesUnitSortView?                         SortView                                { get; set; }
        public FesUnitFilterView?                       FilterView                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static FesUnitSearchPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitSearchPopupView();

            value.SortFilterTabGroup                        = GetObject<UISortFilterTabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UISortFilterTabGroup.FromPointer); // 0270DA2AD970 0x20 SortFilterTabGroup          ( 0001866F35E0 ModelClassType UISortFilterTabGroup UISortFilterTabGroup UISortFilterTabGroup Pointer )
            value.SortView                                  = GetObject<FesUnitSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FesUnitSortView.FromPointer); // 0270DA2AD990 0x28 SortView                    ( 00018656DC00 ModelClassType FesUnitSortView FesUnitSortView FesUnitSortView Pointer )
            value.FilterView                                = GetObject<FesUnitFilterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FesUnitFilterView.FromPointer); // 0270DA2AD9B0 0x30 FilterView                  ( 0001865684F0 ModelClassType FesUnitFilterView FesUnitFilterView FesUnitFilterView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA2AD9F0 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
