using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 TxtTopMsg                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ImgItem                                  ModelClassType RawImage RawImage RawImage Pointer
    // 070 TxtItem                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 BtnMin                                   ModelClassType UIButton UIButton UIButton Pointer
    // 080 BtnMinus                                 ModelClassType UIButton UIButton UIButton Pointer
    // 088 TxtVolue                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 BtnPlus                                  ModelClassType UIButton UIButton UIButton Pointer
    // 098 BtnMax                                   ModelClassType UIButton UIButton UIButton Pointer
    // 0A0 TxtBefor                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 TxtAfter                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 GoBtnMIn                                 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 GobtnMinus                               ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 GobtnPlus                                ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 GobtnMax                                 ModelClassType GameObject GameObject GameObject Pointer
    // 0D0 BtnItem                                  ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0D8 ImgMiniItem                              ModelClassType RawImage RawImage RawImage Pointer
    // 0E0 TxtTokutei                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E8 BtnTokutei                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0F0 closeTask                                UniTaskCompletionSource`1<long> IL2CPP_TYPE_GENERICINST
    // 0F8 currentTicketCount                       ReactiveProperty`1<long> IL2CPP_TYPE_GENERICINST
    public partial class GashaTicketConfirmationContent : DataModel
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
        public GameObject?                              GoBtnMIn                                { get; set; }
        public GameObject?                              GobtnMinus                              { get; set; }
        public GameObject?                              GobtnPlus                               { get; set; }
        public GameObject?                              GobtnMax                                { get; set; }
        public ButtonBase?                              BtnItem                                 { get; set; }
        public RawImage?                                ImgMiniItem                             { get; set; }
        public UITextMeshProUGUI?                       TxtTokutei                              { get; set; }
        public ButtonBase?                              BtnTokutei                              { get; set; }

        public static GashaTicketConfirmationContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaTicketConfirmationContent() { Pointer= p0 };

            value.TxtTopMsg                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtTopMsg                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgItem                                   = GetObject<RawImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.RawImage.FromPointer); // 0x68 ImgItem                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtItem                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TxtItem                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnMin                                    = GetObject<UIButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIButton.FromPointer); // 0x78 BtnMin                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnMinus                                  = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0x80 BtnMinus                    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtVolue                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 TxtVolue                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnPlus                                   = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 0x90 BtnPlus                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnMax                                    = GetObject<UIButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIButton.FromPointer); // 0x98 BtnMax                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtBefor                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA0 TxtBefor                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfter                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 TxtAfter                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoBtnMIn                                  = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0xB0 GoBtnMIn                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GobtnMinus                                = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0xB8 GobtnMinus                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GobtnPlus                                 = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0xC0 GobtnPlus                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GobtnMax                                  = GetObject<GameObject>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GameObject.FromPointer); // 0xC8 GobtnMax                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnItem                                   = GetObject<ButtonBase>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xD0 BtnItem                     ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ImgMiniItem                               = GetObject<RawImage>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.RawImage.FromPointer); // 0xD8 ImgMiniItem                 ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtTokutei                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xE0 TxtTokutei                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnTokutei                                = GetObject<ButtonBase>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xE8 BtnTokutei                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
