using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 000186587250 ModelClassType ProduceSupportCharaSelectGridView ProduceSupportCharaSelectGridView ProduceSupportCharaSelectGridView Pointer
    // 028 SortFilterView                           000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 SortSwitch                               0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer
    // 038 supportCharaDetailPopupViewFactory       PopupViewFactory`1<ISCharaDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 040 supportCharaSearchPopupFactory           PopupViewFactory`1<ISupportCharaSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 048 supportCharaReplacePopupFactory          PopupViewFactory`1<IProduceSupportCharaReplaceConfirmPopupView> IL2CPP_TYPE_GENERICINST
    // 050 ViewModel                                000186588860 ModelClassType ProduceSupportCharaSelectPopupViewModel ProduceSupportCharaSelectPopupViewModel ProduceSupportCharaSelectPopupViewModel Pointer
    // 058 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 060 onReplace                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProduceSupportCharaSelectPopupView
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
            var value   = new ProduceSupportCharaSelectPopupView();

            value.GridView                                  = GetObject<ProduceSupportCharaSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceSupportCharaSelectGridView.FromPointer); // 0270DA1192D8 0x20 GridView                    ( 000186587250 ModelClassType ProduceSupportCharaSelectGridView ProduceSupportCharaSelectGridView ProduceSupportCharaSelectGridView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0270DA1192F8 0x28 SortFilterView              ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortSwitch                                = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0270DA119318 0x30 SortSwitch                  ( 0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.ViewModel                                 = GetObject<ProduceSupportCharaSelectPopupViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceSupportCharaSelectPopupViewModel.FromPointer); // 0270DA119398 0x50 ViewModel                   ( 000186588860 ModelClassType ProduceSupportCharaSelectPopupViewModel ProduceSupportCharaSelectPopupViewModel ProduceSupportCharaSelectPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA1193F8 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
