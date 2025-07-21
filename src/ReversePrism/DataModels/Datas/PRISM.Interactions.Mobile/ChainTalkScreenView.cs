using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Background                               ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer
    // 028 Header                                   ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 030 LoadingBackgroundBody                    ModelClassType GameObject GameObject GameObject Pointer
    // 038 LoadingBackgroundImage                   ModelClassType UIImage UIImage UIImage Pointer
    // 040 TouchArea                                ModelClassType UIButton UIButton UIButton Pointer
    // 048 HamburgerButton                          ModelClassType ChainTalkHamburgerButton ChainTalkHamburgerButton ChainTalkHamburgerButton Pointer
    // 050 MenuButtonParent                         ModelClassType GameObject GameObject GameObject Pointer
    // 058 ProfileMenuButton                        ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer
    // 060 GroupMemberMenuButton                    ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer
    // 068 TalkHistoryMenuButton                    ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer
    // 070 PlaceholderText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ChoiceButtonGroup                        ModelClassType ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup Pointer
    // 080 UnreadScrollerView                       ModelClassType ChainTalkUnreadScrollerView ChainTalkUnreadScrollerView ChainTalkUnreadScrollerView Pointer
    // 088 ReadScrollerView                         ModelClassType ChainTalkReadScrollerView ChainTalkReadScrollerView ChainTalkReadScrollerView Pointer
    // 090 EmptyViewImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 098 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    public partial class ChainTalkScreenView : DataModel
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

        public static ChainTalkScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkScreenView() { Pointer= p0 };

            value.Background                                = GetObject<MobileScreenBackground>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenBackground.FromPointer); // 0x20 Background                  ( ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer )
            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0x28 Header                      ( ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.LoadingBackgroundBody                     = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 LoadingBackgroundBody       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LoadingBackgroundImage                    = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0x38 LoadingBackgroundImage      ( ModelClassType UIImage UIImage UIImage Pointer )
            value.TouchArea                                 = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 TouchArea                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.HamburgerButton                           = GetObject<ChainTalkHamburgerButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChainTalkHamburgerButton.FromPointer); // 0x48 HamburgerButton             ( ModelClassType ChainTalkHamburgerButton ChainTalkHamburgerButton ChainTalkHamburgerButton Pointer )
            value.MenuButtonParent                          = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 MenuButtonParent            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ProfileMenuButton                         = GetObject<ChainTalkMenuButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.ChainTalkMenuButton.FromPointer); // 0x58 ProfileMenuButton           ( ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer )
            value.GroupMemberMenuButton                     = GetObject<ChainTalkMenuButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ChainTalkMenuButton.FromPointer); // 0x60 GroupMemberMenuButton       ( ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer )
            value.TalkHistoryMenuButton                     = GetObject<ChainTalkMenuButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.ChainTalkMenuButton.FromPointer); // 0x68 TalkHistoryMenuButton       ( ModelClassType ChainTalkMenuButton ChainTalkMenuButton ChainTalkMenuButton Pointer )
            value.PlaceholderText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 PlaceholderText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ChoiceButtonGroup                         = GetObject<ChainTalkChoiceButtonGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.ChainTalkChoiceButtonGroup.FromPointer); // 0x78 ChoiceButtonGroup           ( ModelClassType ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup ChainTalkChoiceButtonGroup Pointer )
            value.UnreadScrollerView                        = GetObject<ChainTalkUnreadScrollerView>(new IntPtr(p + 0x080), ReversePrism.DataModels.ChainTalkUnreadScrollerView.FromPointer); // 0x80 UnreadScrollerView          ( ModelClassType ChainTalkUnreadScrollerView ChainTalkUnreadScrollerView ChainTalkUnreadScrollerView Pointer )
            value.ReadScrollerView                          = GetObject<ChainTalkReadScrollerView>(new IntPtr(p + 0x088), ReversePrism.DataModels.ChainTalkReadScrollerView.FromPointer); // 0x88 ReadScrollerView            ( ModelClassType ChainTalkReadScrollerView ChainTalkReadScrollerView ChainTalkReadScrollerView Pointer )
            value.EmptyViewImage                            = GetObject<UIImage>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIImage.FromPointer); // 0x90 EmptyViewImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x098), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x98 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )

            return value;
        }
    }
}
