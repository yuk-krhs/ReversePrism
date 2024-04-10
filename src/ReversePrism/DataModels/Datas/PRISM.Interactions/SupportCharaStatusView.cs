using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SCharaIconRectView                       0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 028 BtnInfo                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 ImgFavorite                              000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 038 BtnFavorite                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 Diamonds                                 0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer
    // 048 TxtAlias                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtLv                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TxtMaxLv                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtTrainingTicketsTotalExp               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TxtExpForNext                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CgExpRemaining                           000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 080 CgExpMax                                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 088 ImgFillColorNext                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 090 ImgFillColorCurrent                      0001866CCDB0 ModelClassType Image Image Image Pointer
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

            value.SCharaIconRectView                        = GetObject<SCharaIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 02466A3C5A18 0x20 SCharaIconRectView          ( 0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.BtnInfo                                   = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3C5A38 0x28 BtnInfo                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ImgFavorite                               = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 02466A3C5A58 0x30 ImgFavorite                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnFavorite                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3C5A78 0x38 BtnFavorite                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Diamonds                                  = GetObject<DiamondDisplay>(new IntPtr(p + 0x040), ReversePrism.DataModels.DiamondDisplay.FromPointer); // 02466A3C5A98 0x40 Diamonds                    ( 0001866CF8A0 ModelClassType DiamondDisplay DiamondDisplay DiamondDisplay Pointer )
            value.TxtAlias                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3C5AB8 0x48 TxtAlias                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3C5AD8 0x50 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3C5AF8 0x58 TxtLv                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMaxLv                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3C5B18 0x60 TxtMaxLv                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtTrainingTicketsTotalExp                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3C5B38 0x68 TxtTrainingTicketsTotalExp  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtExpForNext                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3C5B58 0x70 TxtExpForNext               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgExpRemaining                            = GetObject<CanvasGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3C5B78 0x78 CgExpRemaining              ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgExpMax                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3C5B98 0x80 CgExpMax                    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ImgFillColorNext                          = GetObject<Image>(new IntPtr(p + 0x088), ReversePrism.DataModels.Image.FromPointer); // 02466A3C5BB8 0x88 ImgFillColorNext            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ImgFillColorCurrent                       = GetObject<Image>(new IntPtr(p + 0x090), ReversePrism.DataModels.Image.FromPointer); // 02466A3C5BD8 0x90 ImgFillColorCurrent         ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
