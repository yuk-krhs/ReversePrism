using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GroupToggleButton                        00018669D390 ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer
    // 028 Toggles                                  000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 030 ViewModel                                0001865A3EC0 ModelClassType StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel Pointer
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

            value.GroupToggleButton                         = GetObject<GroupToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.GroupToggleButton.FromPointer); // 02466B9D4E38 0x20 GroupToggleButton           ( 00018669D390 ModelClassType GroupToggleButton GroupToggleButton GroupToggleButton Pointer )
            value.Toggles                                   = GetObjectList<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 02466B9D4E58 0x28 Toggles                     ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.ViewModel                                 = GetObject<StorySortFilterToggleFilterViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.StorySortFilterToggleFilterViewModel.FromPointer); // 02466B9D4E78 0x30 ViewModel                   ( 0001865A3EC0 ModelClassType StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel StorySortFilterToggleFilterViewModel Pointer )

            return value;
        }
    }
}
