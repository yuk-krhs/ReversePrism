using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Background                               0001866331A0 ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer
    // 028 Header                                   000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 030 LoadingBackgroundBody                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 LoadingBackgroundImage                   0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 040 TouchArea                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 HamburgerButton                          000186560900 ModelClassType ChainTalkHamburgerButton ChainTalkHamburgerButton ChainTalkHamburgerButton Pointer
    // 050 MenuButtonParent                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 ProfileMenuButton                        000186562BC0 ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer
    // 060 GroupMemberMenuButton                    000186562BC0 ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer
    // 068 TalkHistoryMenuButton                    000186562BC0 ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer
    // 070 PlaceholderText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ChoiceButtonGroup                        000186560190 ModelClassType ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup Pointer
    // 080 UnreadScrollerView                       000186567ED0 ModelClassType ChainTalkUnreadScrollerView ChainTalkUnreadScrollerView ChainTalkUnreadScrollerView Pointer
    // 088 ReadScrollerView                         0001865647B0 ModelClassType ChainTalkReadScrollerView ChainTalkReadScrollerView ChainTalkReadScrollerView Pointer
    // 090 EmptyViewImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 098 thumbnailPopupFactory                    PopupViewFactory`1<IThumbnailPopupView> IL2CPP_TYPE_GENERICINST
    // 0A0 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 0A8 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 0B0 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ChainTalkScreenView
    {
        public MobileScreenBackground?                  Background                              { get; set; }
        public MobileScreenHeader?                      Header                                  { get; set; }
        public GameObject?                              LoadingBackgroundBody                   { get; set; }
        public UIImage?                                 LoadingBackgroundImage                  { get; set; }
        public UIButton?                                TouchArea                               { get; set; }
        public ChainTalkHamburgerButton?                HamburgerButton                         { get; set; }
        public GameObject?                              MenuButtonParent                        { get; set; }
        public ChainTalkMenuButton?                     ProfileMenuButton                       { get; set; }
        public ChainTalkMenuButton?                     GroupMemberMenuButton                   { get; set; }
        public ChainTalkMenuButton?                     TalkHistoryMenuButton                   { get; set; }
        public UITextMeshProUGUI?                       PlaceholderText                         { get; set; }
        public ChainTalkChoiceButtonGroup?              ChoiceButtonGroup                       { get; set; }
        public ChainTalkUnreadScrollerView?             UnreadScrollerView                      { get; set; }
        public ChainTalkReadScrollerView?               ReadScrollerView                        { get; set; }
        public UIImage?                                 EmptyViewImage                          { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ChainTalkScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkScreenView();

            value.Background                                = GetObject<MobileScreenBackground>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenBackground.FromPointer); // 0270DB0E5E10 0x20 Background                  ( 0001866331A0 ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer )
            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0270DB0E5E30 0x28 Header                      ( 000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.LoadingBackgroundBody                     = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB0E5E50 0x30 LoadingBackgroundBody       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LoadingBackgroundImage                    = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB0E5E70 0x38 LoadingBackgroundImage      ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.TouchArea                                 = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB0E5E90 0x40 TouchArea                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.HamburgerButton                           = GetObject<ChainTalkHamburgerButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChainTalkHamburgerButton.FromPointer); // 0270DB0E5EB0 0x48 HamburgerButton             ( 000186560900 ModelClassType ChainTalkHamburgerButton ChainTalkHamburgerButton ChainTalkHamburgerButton Pointer )
            value.MenuButtonParent                          = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB0E5ED0 0x50 MenuButtonParent            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProfileMenuButton                         = GetObject<ChainTalkMenuButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.ChainTalkMenuButton.FromPointer); // 0270DB0E5EF0 0x58 ProfileMenuButton           ( 000186562BC0 ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer )
            value.GroupMemberMenuButton                     = GetObject<ChainTalkMenuButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ChainTalkMenuButton.FromPointer); // 0270DB0E5F10 0x60 GroupMemberMenuButton       ( 000186562BC0 ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer )
            value.TalkHistoryMenuButton                     = GetObject<ChainTalkMenuButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.ChainTalkMenuButton.FromPointer); // 0270DB0E5F30 0x68 TalkHistoryMenuButton       ( 000186562BC0 ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer )
            value.PlaceholderText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB0E5F50 0x70 PlaceholderText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ChoiceButtonGroup                         = GetObject<ChainTalkChoiceButtonGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.ChainTalkChoiceButtonGroup.FromPointer); // 0270DB0E5F70 0x78 ChoiceButtonGroup           ( 000186560190 ModelClassType ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup Pointer )
            value.UnreadScrollerView                        = GetObject<ChainTalkUnreadScrollerView>(new IntPtr(p + 0x080), ReversePrism.DataModels.ChainTalkUnreadScrollerView.FromPointer); // 0270DB0E5F90 0x80 UnreadScrollerView          ( 000186567ED0 ModelClassType ChainTalkUnreadScrollerView ChainTalkUnreadScrollerView ChainTalkUnreadScrollerView Pointer )
            value.ReadScrollerView                          = GetObject<ChainTalkReadScrollerView>(new IntPtr(p + 0x088), ReversePrism.DataModels.ChainTalkReadScrollerView.FromPointer); // 0270DB0E5FB0 0x88 ReadScrollerView            ( 0001865647B0 ModelClassType ChainTalkReadScrollerView ChainTalkReadScrollerView ChainTalkReadScrollerView Pointer )
            value.EmptyViewImage                            = GetObject<UIImage>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB0E5FD0 0x90 EmptyViewImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0270DB0E6010 0xA0 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ResourceLoader.FromPointer); // 0270DB0E6030 0xA8 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB0E6050 0xB0 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
