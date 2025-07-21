using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 ModelClassType ProfilePIdolSelectGridView ProfilePIdolSelectGridView ProfilePIdolSelectGridView Pointer
    // 028 SortFilterView                           ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 030 SortSwitch                               ModelClassType UISwitch UISwitch UISwitch Pointer
    // 038 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 ViewModel                                ModelClassType ProfilePIdolSelectViewModel ProfilePIdolSelectViewModel ProfilePIdolSelectViewModel Pointer
    // 050 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfilePIdolSelectPopupView : DataModel
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
            var value   = new ProfilePIdolSelectPopupView() { Pointer= p0 };

            value.GridView                                  = GetObject<ProfilePIdolSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfilePIdolSelectGridView.FromPointer); // 0x20 GridView                    ( ModelClassType ProfilePIdolSelectGridView ProfilePIdolSelectGridView ProfilePIdolSelectGridView Pointer )
            value.SortFilterView                            = GetObject<FilterAndSortView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x28 SortFilterView              ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.SortSwitch                                = GetObject<UISwitch>(new IntPtr(p + 0x030), ReversePrism.DataModels.UISwitch.FromPointer); // 0x30 SortSwitch                  ( ModelClassType UISwitch UISwitch UISwitch Pointer )
            value.ViewModel                                 = GetObject<ProfilePIdolSelectViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProfilePIdolSelectViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType ProfilePIdolSelectViewModel ProfilePIdolSelectViewModel ProfilePIdolSelectViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x50 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
