using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SortFilterTabGroup                       0001866F35E0 ModelClassType UISortFilterTabGroup UISortFilterTabGroup UISortFilterTabGroup Pointer
    // 028 SortView                                 0001865E2F20 ModelClassType SupportCharaSortView SupportCharaSortView SupportCharaSortView Pointer
    // 030 FilterView                               0001865DE1F0 ModelClassType SupportCharaFilterView SupportCharaFilterView SupportCharaFilterView Pointer
    // 038 onClick                                  Subject`1<Nullable`1<int>> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SupportCharaSearchPopupView : DataModel
    {
        public UISortFilterTabGroup?                    SortFilterTabGroup                      { get; set; }
        public SupportCharaSortView?                    SortView                                { get; set; }
        public SupportCharaFilterView?                  FilterView                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SupportCharaSearchPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaSearchPopupView() { Pointer= p0 };

            value.SortFilterTabGroup                        = GetObject<UISortFilterTabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UISortFilterTabGroup.FromPointer); // 02466A3A4DB0 0x20 SortFilterTabGroup          ( 0001866F35E0 ModelClassType UISortFilterTabGroup UISortFilterTabGroup UISortFilterTabGroup Pointer )
            value.SortView                                  = GetObject<SupportCharaSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportCharaSortView.FromPointer); // 02466A3A4DD0 0x28 SortView                    ( 0001865E2F20 ModelClassType SupportCharaSortView SupportCharaSortView SupportCharaSortView Pointer )
            value.FilterView                                = GetObject<SupportCharaFilterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SupportCharaFilterView.FromPointer); // 02466A3A4DF0 0x30 FilterView                  ( 0001865DE1F0 ModelClassType SupportCharaFilterView SupportCharaFilterView SupportCharaFilterView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A3A4E30 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
