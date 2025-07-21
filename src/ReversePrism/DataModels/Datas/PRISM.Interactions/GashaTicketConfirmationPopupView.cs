using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtTopMsg                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ImgItem                                  ModelClassType RawImage RawImage RawImage Pointer
    // 030 TxtItem                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 BtnMin                                   ModelClassType UIButton UIButton UIButton Pointer
    // 040 BtnMinus                                 ModelClassType UIButton UIButton UIButton Pointer
    // 048 TxtVolue                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 BtnPlus                                  ModelClassType UIButton UIButton UIButton Pointer
    // 058 BtnMax                                   ModelClassType UIButton UIButton UIButton Pointer
    // 060 TxtBefor                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtAfter                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TxtExChangePointBefore                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 TxtExChangePointAfter                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 GoExChangePoint                          ModelClassType GameObject GameObject GameObject Pointer
    // 088 GoBtnMIn                                 ModelClassType GameObject GameObject GameObject Pointer
    // 090 GobtnMinus                               ModelClassType GameObject GameObject GameObject Pointer
    // 098 GobtnPlus                                ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 GobtnMax                                 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 BtnItem                                  ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0B0 ImgMiniItem                              ModelClassType RawImage RawImage RawImage Pointer
    // 0B8 TxtTokutei                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 BtnTokutei                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0C8 currentTicketCount                       ReactiveProperty`1<long> IL2CPP_TYPE_GENERICINST
    // 0D0 onClosed                                 Subject`1<long> IL2CPP_TYPE_GENERICINST
    // 0D8 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaTicketConfirmationPopupView : DataModel
    {
        public UITextMeshProUGUI?                       TxtTopMsg                               { get; set; }
        public RawImage?                                ImgItem                                 { get; set; }
        public UITextMeshProUGUI?                       TxtItem                                 { get; set; }
        public UIButton?                                BtnMin                                  { get; set; }
        public UIButton?                                BtnMinus                                { get; set; }
        public UITextMeshProUGUI?                       TxtVolue                                { get; set; }
        public UIButton?                                BtnPlus                                 { get; set; }
        public UIButton?                                BtnMax                                  { get; set; }
        public UITextMeshProUGUI?                       TxtBefor                                { get; set; }
        public UITextMeshProUGUI?                       TxtAfter                                { get; set; }
        public UITextMeshProUGUI?                       TxtExChangePointBefore                  { get; set; }
        public UITextMeshProUGUI?                       TxtExChangePointAfter                   { get; set; }
        public GameObject?                              GoExChangePoint                         { get; set; }
        public GameObject?                              GoBtnMIn                                { get; set; }
        public GameObject?                              GobtnMinus                              { get; set; }
        public GameObject?                              GobtnPlus                               { get; set; }
        public GameObject?                              GobtnMax                                { get; set; }
        public ButtonBase?                              BtnItem                                 { get; set; }
        public RawImage?                                ImgMiniItem                             { get; set; }
        public UITextMeshProUGUI?                       TxtTokutei                              { get; set; }
        public ButtonBase?                              BtnTokutei                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaTicketConfirmationPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaTicketConfirmationPopupView() { Pointer= p0 };

            value.TxtTopMsg                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtTopMsg                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgItem                                   = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 ImgItem                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtItem                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtItem                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnMin                                    = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnMin                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnMinus                                  = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 BtnMinus                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtVolue                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtVolue                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnPlus                                   = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 BtnPlus                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnMax                                    = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 BtnMax                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtBefor                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtBefor                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfter                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TxtAfter                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointBefore                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TxtExChangePointBefore      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExChangePointAfter                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 TxtExChangePointAfter       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoExChangePoint                           = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 GoExChangePoint             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoBtnMIn                                  = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 GoBtnMIn                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GobtnMinus                                = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 GobtnMinus                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GobtnPlus                                 = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 GobtnPlus                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GobtnMax                                  = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 GobtnMax                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnItem                                   = GetObject<ButtonBase>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xA8 BtnItem                     ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ImgMiniItem                               = GetObject<RawImage>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.RawImage.FromPointer); // 0xB0 ImgMiniItem                 ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtTokutei                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB8 TxtTokutei                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnTokutei                                = GetObject<ButtonBase>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xC0 BtnTokutei                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0xD8 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
