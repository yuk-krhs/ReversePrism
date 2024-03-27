using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoArea1                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 GoArea2                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 Txt                                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 PFIdolIconView                           000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 040 SCharaIconView                           0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 048 CmnItem                                  0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 050 RawImage                                 000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 058 Image                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 060 PaddingArea1                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 PaddingArea2                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 070 SelfElement                              00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 078 IsEnable                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 UITextMeshProUGUIs                       000185D18A08 ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer
    // 088 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CmnTableTd
    {
        public GameObject?                              GoArea1                                 { get; set; }
        public GameObject?                              GoArea2                                 { get; set; }
        public UITextMeshProUGUI?                       Txt                                     { get; set; }
        public PFIdolIconView?                          PFIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public CmnItem?                                 CmnItem                                 { get; set; }
        public RawImage?                                RawImage                                { get; set; }
        public Image?                                   Image                                   { get; set; }
        public RectTransform?                           PaddingArea1                            { get; set; }
        public RectTransform?                           PaddingArea2                            { get; set; }
        public LayoutElement?                           SelfElement                             { get; set; }
        public bool                                     IsEnable                                { get; set; }
        public List<UITextMeshProUGUI>?                 UITextMeshProUGUIs                      { get; set; }
        public int                                      Index                                   { get; set; }

        public static CmnTableTd? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CmnTableTd();

            value.GoArea1                                   = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4ED60D8 0x20 GoArea1                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoArea2                                   = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4ED60F8 0x28 GoArea2                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Txt                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4ED6118 0x30 Txt                         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PFIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270D4ED6138 0x38 PFIdolIconView              ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270D4ED6158 0x40 SCharaIconView              ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.CmnItem                                   = GetObject<CmnItem>(new IntPtr(p + 0x048), ReversePrism.DataModels.CmnItem.FromPointer); // 0270D4ED6178 0x48 CmnItem                     ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.RawImage                                  = GetObject<RawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.RawImage.FromPointer); // 0270D4ED6198 0x50 RawImage                    ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.Image                                     = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 0270D4ED61B8 0x58 Image                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.PaddingArea1                              = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D4ED61D8 0x60 PaddingArea1                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.PaddingArea2                              = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D4ED61F8 0x68 PaddingArea2                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SelfElement                               = GetObject<LayoutElement>(new IntPtr(p + 0x070), ReversePrism.DataModels.LayoutElement.FromPointer); // 0270D4ED6218 0x70 SelfElement                 ( 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.IsEnable                                  = GetBool(new IntPtr(p + 0x078)); // 0270D4ED6238 0x78 IsEnable                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UITextMeshProUGUIs                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4ED6258 0x80 UITextMeshProUGUIs          ( 000185D18A08 ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x088)); // 0270D4ED6278 0x88 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
