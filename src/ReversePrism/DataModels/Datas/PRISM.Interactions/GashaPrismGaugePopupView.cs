using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UITabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 GoItem                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 GoXml                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 GoHeadLine                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 XmlPanel                                 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer
    // 048 GashaGaugeItemCell                       000186603A10 ModelClassType GashaGaugeItemCell GashaGaugeItemCell GashaGaugeItemCell Pointer
    // 050 TxtLimit                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TxtPrismPoint                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 Xmldata                                  000186671910 ModelPrimitiveType string string string String
    // 068 GashaGaugeItemCells                      000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 070 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 078 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaPrismGaugePopupView : DataModel
    {
        public UITabGroup?                              UITabGroup                              { get; set; }
        public GameObject?                              GoItem                                  { get; set; }
        public GameObject?                              GoXml                                   { get; set; }
        public GameObject?                              GoHeadLine                              { get; set; }
        public XMLPanel?                                XmlPanel                                { get; set; }
        public GashaGaugeItemCell?                      GashaGaugeItemCell                      { get; set; }
        public UITextMeshProUGUI?                       TxtLimit                                { get; set; }
        public UITextMeshProUGUI?                       TxtPrismPoint                           { get; set; }
        public string                                   Xmldata                                 { get; set; }
        public List<GameObject>?                        GashaGaugeItemCells                     { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaPrismGaugePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaPrismGaugePopupView() { Pointer= p0 };

            value.UITabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466BA99448 0x20 UITabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.GoItem                                    = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA99468 0x28 GoItem                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoXml                                     = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA99488 0x30 GoXml                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoHeadLine                                = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA994A8 0x38 GoHeadLine                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.XmlPanel                                  = GetObject<XMLPanel>(new IntPtr(p + 0x040), ReversePrism.DataModels.XMLPanel.FromPointer); // 02466BA994C8 0x40 XmlPanel                    ( 000186578D80 ModelClassType XMLPanel XMLPanel XMLPanel Pointer )
            value.GashaGaugeItemCell                        = GetObject<GashaGaugeItemCell>(new IntPtr(p + 0x048), ReversePrism.DataModels.GashaGaugeItemCell.FromPointer); // 02466BA994E8 0x48 GashaGaugeItemCell          ( 000186603A10 ModelClassType GashaGaugeItemCell GashaGaugeItemCell GashaGaugeItemCell Pointer )
            value.TxtLimit                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BA99508 0x50 TxtLimit                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtPrismPoint                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BA99528 0x58 TxtPrismPoint               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Xmldata                                   = GetString(new IntPtr(p + 0x060)); // 02466BA99548 0x60 Xmldata                     ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaGaugeItemCells                       = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 02466BA99568 0x68 GashaGaugeItemCells         ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466BA995A8 0x78 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
