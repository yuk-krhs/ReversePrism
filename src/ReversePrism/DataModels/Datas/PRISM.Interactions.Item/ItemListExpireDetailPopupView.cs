using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 ModelClassType ItemListExpireDetailListView ItemListExpireDetailListView ItemListExpireDetailListView Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 ViewModel                                ModelClassType ItemListOverlayContentListViewModel ItemListOverlayContentListViewModel ItemListOverlayContentListViewModel Pointer
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ItemListExpireDetailPopupView : DataModel
    {
        public ItemListExpireDetailListView?            ListView                                { get; set; }
        public ItemListOverlayContentListViewModel?     ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ItemListExpireDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListExpireDetailPopupView() { Pointer= p0 };

            value.ListView                                  = GetObject<ItemListExpireDetailListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ItemListExpireDetailListView.FromPointer); // 0x20 ListView                    ( ModelClassType ItemListExpireDetailListView ItemListExpireDetailListView ItemListExpireDetailListView Pointer )
            value.ViewModel                                 = GetObject<ItemListOverlayContentListViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ItemListOverlayContentListViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType ItemListOverlayContentListViewModel ItemListOverlayContentListViewModel ItemListOverlayContentListViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
