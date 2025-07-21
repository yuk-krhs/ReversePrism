using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 ModelClassType ProduceSupportCharaSelectGridView ProduceSupportCharaSelectGridView ProduceSupportCharaSelectGridView Pointer
    // 028 SortFilterView                           ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 SortSwitch                               ModelClassType UISwitch UISwitch UISwitch Pointer
    // 038 ViewModel                                ModelClassType ProduceSupportCharaSelectPopupViewModel ProduceSupportCharaSelectPopupViewModel ProduceSupportCharaSelectPopupViewModel Pointer
    // 040 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 onReplace                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceSupportCharaSelectPopupView : DataModel
    {
        public ProduceSupportCharaSelectGridView?       GridView                                { get; set; }
        public FilterAndSortView?                       SortFilterView                          { get; set; }
        public UISwitch?                                SortSwitch                              { get; set; }
        public ProduceSupportCharaSelectPopupViewModel? ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProduceSupportCharaSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSupportCharaSelectPopupView() { Pointer= p0 };

            value.GridView                                  = GetObject<ProduceSupportCharaSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceSupportCharaSelectGridView.FromPointer); // 0x20 GridView                    ( ModelClassType ProduceSupportCharaSelectGridView ProduceSupportCharaSelectGridView ProduceSupportCharaSelectGridView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x28 SortFilterView              ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortSwitch                                = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0x30 SortSwitch                  ( ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.ViewModel                                 = GetObject<ProduceSupportCharaSelectPopupViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceSupportCharaSelectPopupViewModel.FromPointer); // 0x38 ViewModel                   ( ModelClassType ProduceSupportCharaSelectPopupViewModel ProduceSupportCharaSelectPopupViewModel ProduceSupportCharaSelectPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x50 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
