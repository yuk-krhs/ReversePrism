using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TextLabel                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TextPoint                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 SortButton                               ModelClassType FriendSortButton FriendSortButton FriendSortButton Pointer
    // 038 IdSearchButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 040 RefreshButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 048 ViewModel                                ModelClassType FriendViewModel FriendViewModel FriendViewModel Pointer
    public partial class FriendFooterPanelView : DataModel
    {
        public UITextMeshProUGUI?                       TextLabel                               { get; set; }
        public UITextMeshProUGUI?                       TextPoint                               { get; set; }
        public FriendSortButton?                        SortButton                              { get; set; }
        public UIButton?                                IdSearchButton                          { get; set; }
        public UIButton?                                RefreshButton                           { get; set; }
        public FriendViewModel?                         ViewModel                               { get; set; }

        public static FriendFooterPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendFooterPanelView() { Pointer= p0 };

            value.TextLabel                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TextLabel                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TextPoint                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TextPoint                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SortButton                                = GetObject<FriendSortButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.FriendSortButton.FromPointer); // 0x30 SortButton                  ( ModelClassType FriendSortButton FriendSortButton FriendSortButton Pointer )
            value.IdSearchButton                            = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 IdSearchButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RefreshButton                             = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 RefreshButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<FriendViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.FriendViewModel.FromPointer); // 0x48 ViewModel                   ( ModelClassType FriendViewModel FriendViewModel FriendViewModel Pointer )

            return value;
        }
    }
}
