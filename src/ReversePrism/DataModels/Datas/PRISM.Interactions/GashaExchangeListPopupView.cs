using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UITabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 BtnHelp                                  000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 GoItem1                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 GoItem2                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 GoHeadLine                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 GoXml                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 XmlPanel                                 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 058 GashaExchangeItemCell                    000186600CB0 ModelClassType GashaExchangeItemCell GashaExchangeItemCell GashaExchangeItemCell Pointer
    // 060 TxtLimit                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 TxtPrismPoint                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 TxtCaution                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 Xmldata                                  000186671910 ModelPrimitiveType string string string String
    // 080 GashaGaugeItemCells                      000185CDDE28 ModelClassListType List`1<GashaExchangeItemCell> List`1<GashaExchangeItemCell> List<GashaExchangeItemCell> Pointer
    // 088 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaExchangeListPopupView
    {
        public UITabGroup?                              UITabGroup                              { get; set; }
        public ButtonBase?                              BtnHelp                                 { get; set; }
        public GameObject?                              GoItem1                                 { get; set; }
        public GameObject?                              GoItem2                                 { get; set; }
        public GameObject?                              GoHeadLine                              { get; set; }
        public GameObject?                              GoXml                                   { get; set; }
        public XMLPanel?                                XmlPanel                                { get; set; }
        public GashaExchangeItemCell?                   GashaExchangeItemCell                   { get; set; }
        public UITextMeshProUGUI?                       TxtLimit                                { get; set; }
        public UITextMeshProUGUI?                       TxtPrismPoint                           { get; set; }
        public UITextMeshProUGUI?                       TxtCaution                              { get; set; }
        public string                                   Xmldata                                 { get; set; }
        public List<GashaExchangeItemCell>?             GashaGaugeItemCells                     { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaExchangeListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeListPopupView();

            value.UITabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DB9F7720 0x20 UITabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.BtnHelp                                   = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DB9F7740 0x28 BtnHelp                     ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoItem1                                   = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB9F7760 0x30 GoItem1                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoItem2                                   = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB9F7780 0x38 GoItem2                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoHeadLine                                = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB9F77A0 0x40 GoHeadLine                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoXml                                     = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB9F77C0 0x48 GoXml                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.XmlPanel                                  = GetObject<XMLPanel>(new IntPtr(p + 0x050), ReversePrism.DataModels.XMLPanel.FromPointer); // 0270DB9F77E0 0x50 XmlPanel                    ( 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.GashaExchangeItemCell                     = GetObject<GashaExchangeItemCell>(new IntPtr(p + 0x058), ReversePrism.DataModels.GashaExchangeItemCell.FromPointer); // 0270DB9F7800 0x58 GashaExchangeItemCell       ( 000186600CB0 ModelClassType GashaExchangeItemCell GashaExchangeItemCell GashaExchangeItemCell Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9F7820 0x60 TxtLimit                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPrismPoint                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9F7840 0x68 TxtPrismPoint               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCaution                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9F7860 0x70 TxtCaution                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Xmldata                                   = GetString(new IntPtr(p + 0x078)); // 0270DB9F7880 0x78 Xmldata                     ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaGaugeItemCells                       = GetObjectList<GashaExchangeItemCell>(new IntPtr(p + 0x080), ReversePrism.DataModels.GashaExchangeItemCell.FromPointer); // 0270DB9F78A0 0x80 GashaGaugeItemCells         ( 000185CDDE28 ModelClassListType List`1<GashaExchangeItemCell> List`1<GashaExchangeItemCell> List<GashaExchangeItemCell> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB9F78E0 0x90 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
