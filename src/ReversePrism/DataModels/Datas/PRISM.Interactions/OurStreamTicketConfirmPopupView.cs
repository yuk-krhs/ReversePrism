using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TopMessageText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 BeforText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 AfterText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ItemText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ItemButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 048 ItemImage                                ModelClassType RawImage RawImage RawImage Pointer
    // 050 MiniItemImage                            ModelClassType RawImage RawImage RawImage Pointer
    // 058 CationText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 SpecifiedCommercialText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 SpecifiedCommercialButton                ModelClassType UIButton UIButton UIButton Pointer
    // 070 onClosed                                 Subject`1<OurStreamTicketConfirmPopupResult> IL2CPP_TYPE_GENERICINST
    // 078 FrameParameter                           ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 080 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 088 ViewModel                                ModelClassType OurStreamTicketConfirmPopupViewModel OurStreamTicketConfirmPopupViewModel OurStreamTicketConfirmPopupViewModel Pointer
    // 090 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class OurStreamTicketConfirmPopupView : DataModel
    {
        public UITextMeshProUGUI?                       TopMessageText                          { get; set; }
        public UITextMeshProUGUI?                       BeforText                               { get; set; }
        public UITextMeshProUGUI?                       AfterText                               { get; set; }
        public UITextMeshProUGUI?                       ItemText                                { get; set; }
        public UIButton?                                ItemButton                              { get; set; }
        public RawImage?                                ItemImage                               { get; set; }
        public RawImage?                                MiniItemImage                           { get; set; }
        public UITextMeshProUGUI?                       CationText                              { get; set; }
        public UITextMeshProUGUI?                       SpecifiedCommercialText                 { get; set; }
        public UIButton?                                SpecifiedCommercialButton               { get; set; }
        public PopupFrameParameter?                     FrameParameter                          { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public OurStreamTicketConfirmPopupViewModel?    ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static OurStreamTicketConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamTicketConfirmPopupView() { Pointer= p0 };

            value.TopMessageText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TopMessageText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BeforText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 BeforText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AfterText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 AfterText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 ItemText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemButton                                = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 ItemButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ItemImage                                 = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 0x48 ItemImage                   ( ModelClassType RawImage RawImage RawImage Pointer )
            value.MiniItemImage                             = GetObject<RawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.RawImage.FromPointer); // 0x50 MiniItemImage               ( ModelClassType RawImage RawImage RawImage Pointer )
            value.CationText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 CationText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpecifiedCommercialText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 SpecifiedCommercialText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpecifiedCommercialButton                 = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 SpecifiedCommercialButton   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FrameParameter                            = GetObject<PopupFrameParameter>(new IntPtr(p + 0x078), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0x78 FrameParameter              ( ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x80 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.ViewModel                                 = GetObject<OurStreamTicketConfirmPopupViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.OurStreamTicketConfirmPopupViewModel.FromPointer); // 0x88 ViewModel                   ( ModelClassType OurStreamTicketConfirmPopupViewModel OurStreamTicketConfirmPopupViewModel OurStreamTicketConfirmPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x90 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
