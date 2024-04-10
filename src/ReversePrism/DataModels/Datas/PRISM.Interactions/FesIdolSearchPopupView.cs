using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SortFilterTabGroup                       0001866F35E0 ModelClassType UISortFilterTabGroup UISortFilterTabGroup UISortFilterTabGroup Pointer
    // 028 SortView                                 000186565A30 ModelClassType FesIdolSortView FesIdolSortView FesIdolSortView Pointer
    // 030 FilterView                               000186562040 ModelClassType FesIdolFilterView FesIdolFilterView FesIdolFilterView Pointer
    // 038 onClick                                  Subject`1<Nullable`1<int>> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class FesIdolSearchPopupView : DataModel
    {
        public UISortFilterTabGroup?                    SortFilterTabGroup                      { get; set; }
        public FesIdolSortView?                         SortView                                { get; set; }
        public FesIdolFilterView?                       FilterView                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static FesIdolSearchPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolSearchPopupView() { Pointer= p0 };

            value.SortFilterTabGroup                        = GetObject<UISortFilterTabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UISortFilterTabGroup.FromPointer); // 02466A2FEB38 0x20 SortFilterTabGroup          ( 0001866F35E0 ModelClassType UISortFilterTabGroup UISortFilterTabGroup UISortFilterTabGroup Pointer )
            value.SortView                                  = GetObject<FesIdolSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FesIdolSortView.FromPointer); // 02466A2FEB58 0x28 SortView                    ( 000186565A30 ModelClassType FesIdolSortView FesIdolSortView FesIdolSortView Pointer )
            value.FilterView                                = GetObject<FesIdolFilterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FesIdolFilterView.FromPointer); // 02466A2FEB78 0x30 FilterView                  ( 000186562040 ModelClassType FesIdolFilterView FesIdolFilterView FesIdolFilterView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A2FEBB8 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
