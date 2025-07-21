using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FilterView                               ModelClassType SupportCharaFilterCellListView SupportCharaFilterCellListView SupportCharaFilterCellListView Pointer
    // 028 BtnRest                                  ModelClassType UIButton UIButton UIButton Pointer
    public partial class SupportCharaFilterView : DataModel
    {
        public SupportCharaFilterCellListView?          FilterView                              { get; set; }
        public UIButton?                                BtnRest                                 { get; set; }

        public static SupportCharaFilterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaFilterView() { Pointer= p0 };

            value.FilterView                                = GetObject<SupportCharaFilterCellListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportCharaFilterCellListView.FromPointer); // 0x20 FilterView                  ( ModelClassType SupportCharaFilterCellListView SupportCharaFilterCellListView SupportCharaFilterCellListView Pointer )
            value.BtnRest                                   = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 BtnRest                     ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
