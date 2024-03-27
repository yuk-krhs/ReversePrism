using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PIdolSelectResourceTagName               string IL2CPP_TYPE_STRING
    // 020 GridView                                 0001865BB460 ModelClassType ProfilePIdolSelectGridView ProfilePIdolSelectGridView ProfilePIdolSelectGridView Pointer
    // 028 SortFilterView                           000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 SortSwitch                               0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer
    // 038 pIdoleDetailPopupFactory                 PopupViewFactory`1<IPIdolDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 040 pIdolSearchPopupFactory                  PopupViewFactory`1<IProduceIdolSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 048 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 ViewModel                                0001865BCAB0 ModelClassType ProfilePIdolSelectViewModel ProfilePIdolSelectViewModel ProfilePIdolSelectViewModel Pointer
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfilePIdolSelectPopupView
    {
        public ProfilePIdolSelectGridView?              GridView                                { get; set; }
        public FilterAndSortView?                       SortFilterView                          { get; set; }
        public UISwitch?                                SortSwitch                              { get; set; }
        public ProfilePIdolSelectViewModel?             ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfilePIdolSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfilePIdolSelectPopupView();

            value.GridView                                  = GetObject<ProfilePIdolSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfilePIdolSelectGridView.FromPointer); // 0270DB712C18 0x20 GridView                    ( 0001865BB460 ModelClassType ProfilePIdolSelectGridView ProfilePIdolSelectGridView ProfilePIdolSelectGridView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0270DB712C38 0x28 SortFilterView              ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortSwitch                                = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0270DB712C58 0x30 SortSwitch                  ( 0001866F44A0 ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.ViewModel                                 = GetObject<ProfilePIdolSelectViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProfilePIdolSelectViewModel.FromPointer); // 0270DB712CF8 0x58 ViewModel                   ( 0001865BCAB0 ModelClassType ProfilePIdolSelectViewModel ProfilePIdolSelectViewModel ProfilePIdolSelectViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB712D18 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
