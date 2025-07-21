using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedTabType                          ModelEnumType TabType TabType TabType Int32
    // 018 TabListViewModels                        ModelClassListType ItemListOverlayTabListViewModel[] ItemListOverlayTabListViewModel[] List<ItemListOverlayTabListViewModel> Pointer
    public partial class ItemListOverlayViewModel : DataModel
    {
        public TabType                                  SelectedTabType                         { get; set; }
        public List<ItemListOverlayTabListViewModel>?   TabListViewModels                       { get; set; }

        public static ItemListOverlayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListOverlayViewModel() { Pointer= p0 };

            value.SelectedTabType                           = (TabType)GetInt32(new IntPtr(p + 0x010)); // 0x10 SelectedTabType             ( ModelEnumType TabType TabType TabType Int32 )
            value.TabListViewModels                         = GetObjectList<ItemListOverlayTabListViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ItemListOverlayTabListViewModel.FromPointer); // 0x18 TabListViewModels           ( ModelClassListType ItemListOverlayTabListViewModel[] ItemListOverlayTabListViewModel[] List<ItemListOverlayTabListViewModel> Pointer )

            return value;
        }
    }
}
