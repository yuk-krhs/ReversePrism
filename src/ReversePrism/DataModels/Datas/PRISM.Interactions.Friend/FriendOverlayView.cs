using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CategoryListView                         ModelClassType FriendCategoryListView FriendCategoryListView FriendCategoryListView Pointer
    // 028 ListView                                 ModelClassType FriendListView FriendListView FriendListView Pointer
    // 030 CloseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 EmptyText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 FooterPanelView                          ModelClassType FriendFooterPanelView FriendFooterPanelView FriendFooterPanelView Pointer
    // 048 TextLabel                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TextPoint                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 SortButtonObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 060 SortButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 068 IdSearchButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 070 RefreshButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 078 ViewModel                                ModelClassType FriendViewModel FriendViewModel FriendViewModel Pointer
    // 080 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class FriendOverlayView : DataModel
    {
        public FriendCategoryListView?                  CategoryListView                        { get; set; }
        public FriendListView?                          ListView                                { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public FriendFooterPanelView?                   FooterPanelView                         { get; set; }
        public UITextMeshProUGUI?                       TextLabel                               { get; set; }
        public UITextMeshProUGUI?                       TextPoint                               { get; set; }
        public GameObject?                              SortButtonObject                        { get; set; }
        public UIButton?                                SortButton                              { get; set; }
        public UIButton?                                IdSearchButton                          { get; set; }
        public UIButton?                                RefreshButton                           { get; set; }
        public FriendViewModel?                         ViewModel                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static FriendOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendOverlayView() { Pointer= p0 };

            value.CategoryListView                          = GetObject<FriendCategoryListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.FriendCategoryListView.FromPointer); // 0x20 CategoryListView            ( ModelClassType FriendCategoryListView FriendCategoryListView FriendCategoryListView Pointer )
            value.ListView                                  = GetObject<FriendListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FriendListView.FromPointer); // 0x28 ListView                    ( ModelClassType FriendListView FriendListView FriendListView Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 CloseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 EmptyText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FooterPanelView                           = GetObject<FriendFooterPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FriendFooterPanelView.FromPointer); // 0x40 FooterPanelView             ( ModelClassType FriendFooterPanelView FriendFooterPanelView FriendFooterPanelView Pointer )
            value.TextLabel                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TextLabel                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TextPoint                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TextPoint                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SortButtonObject                          = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 SortButtonObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SortButton                                = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 SortButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IdSearchButton                            = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 IdSearchButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RefreshButton                             = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 RefreshButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<FriendViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.FriendViewModel.FromPointer); // 0x78 ViewModel                   ( ModelClassType FriendViewModel FriendViewModel FriendViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x080), ReversePrism.DataModels.IDisposable.FromPointer); // 0x80 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
