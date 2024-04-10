using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SortFilterTabGroup                       0001866F35E0 ModelClassType UISortFilterTabGroup UISortFilterTabGroup UISortFilterTabGroup Pointer
    // 028 SortView                                 00018654FB70 ModelClassType ProduceIdolSortView ProduceIdolSortView ProduceIdolSortView Pointer
    // 030 FilterView                               000186548E60 ModelClassType ProduceIdolFilterView ProduceIdolFilterView ProduceIdolFilterView Pointer
    // 038 onClick                                  Subject`1<Nullable`1<int>> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceIdolSearchPopupView : DataModel
    {
        public UISortFilterTabGroup?                    SortFilterTabGroup                      { get; set; }
        public ProduceIdolSortView?                     SortView                                { get; set; }
        public ProduceIdolFilterView?                   FilterView                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceIdolSearchPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolSearchPopupView() { Pointer= p0 };

            value.SortFilterTabGroup                        = GetObject<UISortFilterTabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UISortFilterTabGroup.FromPointer); // 02466A383820 0x20 SortFilterTabGroup          ( 0001866F35E0 ModelClassType UISortFilterTabGroup UISortFilterTabGroup UISortFilterTabGroup Pointer )
            value.SortView                                  = GetObject<ProduceIdolSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceIdolSortView.FromPointer); // 02466A383840 0x28 SortView                    ( 00018654FB70 ModelClassType ProduceIdolSortView ProduceIdolSortView ProduceIdolSortView Pointer )
            value.FilterView                                = GetObject<ProduceIdolFilterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdolFilterView.FromPointer); // 02466A383860 0x30 FilterView                  ( 000186548E60 ModelClassType ProduceIdolFilterView ProduceIdolFilterView ProduceIdolFilterView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A3838A0 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
