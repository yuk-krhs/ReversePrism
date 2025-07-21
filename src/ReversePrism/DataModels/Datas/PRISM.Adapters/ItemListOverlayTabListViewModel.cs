using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Products                                 ModelClassListType IHavingProductStatus[] IHavingProductStatus[] List<IHavingProductStatus> Pointer
    // 018 ContentListModels                        ModelClassListType ItemListOverlayContentListViewModel[] ItemListOverlayContentListViewModel[] List<ItemListOverlayContentListViewModel> Pointer
    // 020 TabType                                  ModelEnumType TabType TabType TabType Int32
    // 024 ExistsUseLimitedItem                     ModelPrimitiveType bool bool bool Bool
    // 028 CurrentIndex                             ModelPrimitiveType int int int Int32
    public partial class ItemListOverlayTabListViewModel : DataModel
    {
        public List<IHavingProductStatus>?              Products                                { get; set; }
        public List<ItemListOverlayContentListViewModel>? ContentListModels                       { get; set; }
        public TabType                                  TabType                                 { get; set; }
        public bool                                     ExistsUseLimitedItem                    { get; set; }
        public int                                      CurrentIndex                            { get; set; }

        public static ItemListOverlayTabListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListOverlayTabListViewModel() { Pointer= p0 };

            value.Products                                  = GetObjectList<IHavingProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x10 Products                    ( ModelClassListType IHavingProductStatus[] IHavingProductStatus[] List<IHavingProductStatus> Pointer )
            value.ContentListModels                         = GetObjectList<ItemListOverlayContentListViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ItemListOverlayContentListViewModel.FromPointer); // 0x18 ContentListModels           ( ModelClassListType ItemListOverlayContentListViewModel[] ItemListOverlayContentListViewModel[] List<ItemListOverlayContentListViewModel> Pointer )
            value.TabType                                   = (TabType)GetInt32(new IntPtr(p + 0x020)); // 0x20 TabType                     ( ModelEnumType TabType TabType TabType Int32 )
            value.ExistsUseLimitedItem                      = GetBool(new IntPtr(p + 0x024)); // 0x24 ExistsUseLimitedItem        ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 CurrentIndex                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
