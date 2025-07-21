using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GroupToggleButton                        ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer
    // 028 Toggles                                  ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 030 ViewModel                                ModelClassType StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel Pointer
    public partial class StorySortFilterToggleFilterView : DataModel
    {
        public GroupToggleButton?                       GroupToggleButton                       { get; set; }
        public List<ToggleButton>?                      Toggles                                 { get; set; }
        public StorySortFilterToggleFilterViewModel?    ViewModel                               { get; set; }

        public static StorySortFilterToggleFilterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterToggleFilterView() { Pointer= p0 };

            value.GroupToggleButton                         = GetObject<GroupToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.GroupToggleButton.FromPointer); // 0x20 GroupToggleButton           ( ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer )
            value.Toggles                                   = GetObjectList<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 Toggles                     ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ViewModel                                 = GetObject<StorySortFilterToggleFilterViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.StorySortFilterToggleFilterViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel Pointer )

            return value;
        }
    }
}
