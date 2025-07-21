using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SortFilterTabGroup                       ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 028 SortContent                              ModelClassType StorySortFilterPopupSortContentView StorySortFilterPopupSortContentView StorySortFilterPopupSortContentView Pointer
    // 030 FilterContent                            ModelClassType StorySortFilterPopupFilterContentView StorySortFilterPopupFilterContentView StorySortFilterPopupFilterContentView Pointer
    // 038 onClose                                  Subject`1<StorySortFilterPopupResult> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    // 048 ViewModel                                ModelClassType StorySortFilterPopupViewModel StorySortFilterPopupViewModel StorySortFilterPopupViewModel Pointer
    // 050 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class StorySortFilterPopupView : DataModel
    {
        public UITabGroupEx?                            SortFilterTabGroup                      { get; set; }
        public StorySortFilterPopupSortContentView?     SortContent                             { get; set; }
        public StorySortFilterPopupFilterContentView?   FilterContent                           { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }
        public StorySortFilterPopupViewModel?           ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static StorySortFilterPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterPopupView() { Pointer= p0 };

            value.SortFilterTabGroup                        = GetObject<UITabGroupEx>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x20 SortFilterTabGroup          ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.SortContent                               = GetObject<StorySortFilterPopupSortContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.StorySortFilterPopupSortContentView.FromPointer); // 0x28 SortContent                 ( ModelClassType StorySortFilterPopupSortContentView StorySortFilterPopupSortContentView StorySortFilterPopupSortContentView Pointer )
            value.FilterContent                             = GetObject<StorySortFilterPopupFilterContentView>(new IntPtr(p + 0x030), ReversePrism.DataModels.StorySortFilterPopupFilterContentView.FromPointer); // 0x30 FilterContent               ( ModelClassType StorySortFilterPopupFilterContentView StorySortFilterPopupFilterContentView StorySortFilterPopupFilterContentView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )
            value.ViewModel                                 = GetObject<StorySortFilterPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.StorySortFilterPopupViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType StorySortFilterPopupViewModel StorySortFilterPopupViewModel StorySortFilterPopupViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x50 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
