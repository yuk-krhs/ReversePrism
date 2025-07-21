using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SCharaIconRectView                       ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 028 BtnInfo                                  ModelClassType UIButton UIButton UIButton Pointer
    // 030 ImgFavorite                              ModelClassType RawImage RawImage RawImage Pointer
    // 038 BtnFavorite                              ModelClassType UIButton UIButton UIButton Pointer
    // 040 Diamonds                                 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 048 TxtAlias                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtName                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtLv                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TxtMaxLv                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtTrainingTicketsTotalExp               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TxtExpForNext                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CgExpRemaining                           ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 080 CgExpMax                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 088 ImgFillColorNext                         ModelClassType Image Image Image Pointer
    // 090 ImgFillColorCurrent                      ModelClassType Image Image Image Pointer
    // 098 onDetail                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A0 onFavorite                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class SupportCharaStatusView : DataModel
    {
        public SCharaIconRectView?                      SCharaIconRectView                      { get; set; }
        public UIButton?                                BtnInfo                                 { get; set; }
        public RawImage?                                ImgFavorite                             { get; set; }
        public UIButton?                                BtnFavorite                             { get; set; }
        public DiamondDisplay?                          Diamonds                                { get; set; }
        public UITextMeshProUGUI?                       TxtAlias                                { get; set; }
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public UITextMeshProUGUI?                       TxtLv                                   { get; set; }
        public UITextMeshProUGUI?                       TxtMaxLv                                { get; set; }
        public UITextMeshProUGUI?                       TxtTrainingTicketsTotalExp              { get; set; }
        public UITextMeshProUGUI?                       TxtExpForNext                           { get; set; }
        public CanvasGroup?                             CgExpRemaining                          { get; set; }
        public CanvasGroup?                             CgExpMax                                { get; set; }
        public Image?                                   ImgFillColorNext                        { get; set; }
        public Image?                                   ImgFillColorCurrent                     { get; set; }

        public static SupportCharaStatusView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaStatusView() { Pointer= p0 };

            value.SCharaIconRectView                        = GetObject<SCharaIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x20 SCharaIconRectView          ( ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.BtnInfo                                   = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 BtnInfo                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgFavorite                               = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 0x30 ImgFavorite                 ( ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnFavorite                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnFavorite                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Diamonds                                  = GetObject<DiamondDisplay>(new IntPtr(p + 0x040), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 0x40 Diamonds                    ( ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.TxtAlias                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtAlias                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 TxtName                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtLv                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMaxLv                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TxtMaxLv                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTrainingTicketsTotalExp                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 TxtTrainingTicketsTotalExp  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExpForNext                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TxtExpForNext               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgExpRemaining                            = GetObject<CanvasGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x78 CgExpRemaining              ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgExpMax                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x80 CgExpMax                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgFillColorNext                          = GetObject<Image>(new IntPtr(p + 0x088), ReversePrism.DataModels.Image.FromPointer); // 0x88 ImgFillColorNext            ( ModelClassType Image Image Image Pointer )
            value.ImgFillColorCurrent                       = GetObject<Image>(new IntPtr(p + 0x090), ReversePrism.DataModels.Image.FromPointer); // 0x90 ImgFillColorCurrent         ( ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
