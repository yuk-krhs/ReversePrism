using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgBtn                                   0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 OutLine                                  0001865D3210 ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer
    // 030 TxtTitle                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtCost                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GoBdgDot                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 GoIcoPaid                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 ImgIco                                   000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 058 TxtFukidasiNormal                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TxtFukidasiEmphasis                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtDisable                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 Btn                                      000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 078 GashaPrice                               000186525EE0 ModelClassType IGashaPriceStatus IGashaPriceStatus IGashaPriceStatus Pointer
    // 080 GashaId                                  000186671910 ModelPrimitiveType string string string String
    public partial class GashaButton : DataModel
    {
        public Image?                                   ImgBtn                                  { get; set; }
        public ColorToOutlineForTextMeshProUGUI?        OutLine                                 { get; set; }
        public UITextMeshProUGUI?                       TxtTitle                                { get; set; }
        public UITextMeshProUGUI?                       TxtCost                                 { get; set; }
        public GameObject?                              GoBdgDot                                { get; set; }
        public GameObject?                              GoIcoPaid                               { get; set; }
        public RawImage?                                ImgIco                                  { get; set; }
        public UITextMeshProUGUI?                       TxtFukidasiNormal                       { get; set; }
        public UITextMeshProUGUI?                       TxtFukidasiEmphasis                     { get; set; }
        public UITextMeshProUGUI?                       TxtDisable                              { get; set; }
        public ButtonBase?                              Btn                                     { get; set; }
        public IGashaPriceStatus?                       GashaPrice                              { get; set; }
        public string                                   GashaId                                 { get; set; }

        public static GashaButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaButton() { Pointer= p0 };

            value.ImgBtn                                    = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 024665363570 0x20 ImgBtn                      ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.OutLine                                   = GetObject<ColorToOutlineForTextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.ColorToOutlineForTextMeshProUGUI.FromPointer); // 024665363590 0x28 OutLine                     ( 0001865D3210 ModelClassType ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI ColorToOutlineForTextMeshProUGUI Pointer )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653635B0 0x30 TxtTitle                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCost                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246653635D0 0x38 TxtCost                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoBdgDot                                  = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0246653635F0 0x40 GoBdgDot                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoIcoPaid                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 024665363610 0x48 GoIcoPaid                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ImgIco                                    = GetObject<RawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.RawImage.FromPointer); // 024665363630 0x50 ImgIco                      ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtFukidasiNormal                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665363650 0x58 TxtFukidasiNormal           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtFukidasiEmphasis                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665363670 0x60 TxtFukidasiEmphasis         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtDisable                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665363690 0x68 TxtDisable                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Btn                                       = GetObject<ButtonBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246653636B0 0x70 Btn                         ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GashaPrice                                = GetObject<IGashaPriceStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IGashaPriceStatus.FromPointer); // 0246653636D0 0x78 GashaPrice                  ( 000186525EE0 ModelClassType IGashaPriceStatus IGashaPriceStatus IGashaPriceStatus Pointer )
            value.GashaId                                   = GetString(new IntPtr(p + 0x080)); // 0246653636F0 0x80 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
