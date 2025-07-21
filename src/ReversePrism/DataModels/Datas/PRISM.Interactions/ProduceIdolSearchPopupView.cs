using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SortFilterTabGroup                       ModelClassType UISortFilterTabGroup UISortFilterTabGroup UISortFilterTabGroup Pointer
    // 028 SortView                                 ModelClassType ProduceIdolSortView ProduceIdolSortView ProduceIdolSortView Pointer
    // 030 FilterView                               ModelClassType ProduceIdolFilterView ProduceIdolFilterView ProduceIdolFilterView Pointer
    // 038 onClick                                  Subject`1<Nullable`1<int>> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.SortFilterTabGroup                        = GetObject<UISortFilterTabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UISortFilterTabGroup.FromPointer); // 0x20 SortFilterTabGroup          ( ModelClassType UISortFilterTabGroup UISortFilterTabGroup UISortFilterTabGroup Pointer )
            value.SortView                                  = GetObject<ProduceIdolSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceIdolSortView.FromPointer); // 0x28 SortView                    ( ModelClassType ProduceIdolSortView ProduceIdolSortView ProduceIdolSortView Pointer )
            value.FilterView                                = GetObject<ProduceIdolFilterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdolFilterView.FromPointer); // 0x30 FilterView                  ( ModelClassType ProduceIdolFilterView ProduceIdolFilterView ProduceIdolFilterView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
