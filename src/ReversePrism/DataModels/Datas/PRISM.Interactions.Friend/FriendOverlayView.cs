using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CategoryListView                         0001865C1F50 ModelClassType FriendCategoryListView FriendCategoryListView FriendCategoryListView Pointer
    // 028 ListView                                 0001865C6CD0 ModelClassType FriendListView FriendListView FriendListView Pointer
    // 030 CloseButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 EmptyText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 FooterPanelView                          0001865C2D20 ModelClassType FriendFooterPanelView FriendFooterPanelView FriendFooterPanelView Pointer
    // 048 TextLabel                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TextPoint                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 SortButtonObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 SortButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 IdSearchButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 RefreshButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 idSearchPopupViewFactory                 PopupViewFactory`1<IFriendIDSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 080 friendUserProfilePopupViewFactory        PopupViewFactory`1<IProfileFriendUserProfilePopupView> IL2CPP_TYPE_GENERICINST
    // 088 pIdolDetailPopupViewFactory              PopupViewFactory`1<IPIdolDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 090 achievementDetailPopupViewFactory        PopupViewFactory`1<IAchievementDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 098 profileOverlayFactory                    OverlayViewFactory`1<IProfileUserSelfOverlayView> IL2CPP_TYPE_GENERICINST
    // 0A0 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 0A8 ViewModel                                0001865CCD30 ModelClassType FriendViewModel FriendViewModel FriendViewModel Pointer
    // 0B0 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class FriendOverlayView
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
            var value   = new FriendOverlayView();

            value.CategoryListView                          = GetObject<FriendCategoryListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.FriendCategoryListView.FromPointer); // 0270DBDE6878 0x20 CategoryListView            ( 0001865C1F50 ModelClassType FriendCategoryListView FriendCategoryListView FriendCategoryListView Pointer )
            value.ListView                                  = GetObject<FriendListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.FriendListView.FromPointer); // 0270DBDE6898 0x28 ListView                    ( 0001865C6CD0 ModelClassType FriendListView FriendListView FriendListView Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DBDE68B8 0x30 CloseButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE68D8 0x38 EmptyText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FooterPanelView                           = GetObject<FriendFooterPanelView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FriendFooterPanelView.FromPointer); // 0270DBDE68F8 0x40 FooterPanelView             ( 0001865C2D20 ModelClassType FriendFooterPanelView FriendFooterPanelView FriendFooterPanelView Pointer )
            value.TextLabel                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE6918 0x48 TextLabel                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TextPoint                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE6938 0x50 TextPoint                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SortButtonObject                          = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBDE6958 0x58 SortButtonObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SortButton                                = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBDE6978 0x60 SortButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IdSearchButton                            = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBDE6998 0x68 IdSearchButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.RefreshButton                             = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBDE69B8 0x70 RefreshButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<FriendViewModel>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.FriendViewModel.FromPointer); // 0270DBDE6A98 0xA8 ViewModel                   ( 0001865CCD30 ModelClassType FriendViewModel FriendViewModel FriendViewModel Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DBDE6AB8 0xB0 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
