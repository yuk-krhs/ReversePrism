using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoArea1                                  ModelClassType GameObject GameObject GameObject Pointer
    // 028 GoArea2                                  ModelClassType GameObject GameObject GameObject Pointer
    // 030 Txt                                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 PFIdolIconView                           ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 040 SCharaIconView                           ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 048 ProductItem                              ModelClassType RewardItem RewardItem RewardItem Pointer
    // 050 RawImage                                 ModelClassType RawImage RawImage RawImage Pointer
    // 058 Image                                    ModelClassType Image Image Image Pointer
    // 060 PaddingArea1                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 PaddingArea2                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 070 SelfElement                              ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 078 IsEnable                                 ModelPrimitiveType bool bool bool Bool
    // 080 UITextMeshProUGUIs                       ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer
    // 088 Index                                    ModelPrimitiveType int int int Int32
    public partial class CmnTableTd : DataModel
    {
        public GameObject?                              GoArea1                                 { get; set; }
        public GameObject?                              GoArea2                                 { get; set; }
        public UITextMeshProUGUI?                       Txt                                     { get; set; }
        public PFIdolIconView?                          PFIdolIconView                          { get; set; }
        public SCharaIconView?                          SCharaIconView                          { get; set; }
        public RewardItem?                              ProductItem                             { get; set; }
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
            var value   = new CmnTableTd() { Pointer= p0 };

            value.GoArea1                                   = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 GoArea1                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoArea2                                   = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GoArea2                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Txt                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 Txt                         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PFIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x38 PFIdolIconView              ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.SCharaIconView                            = GetObject<SCharaIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x40 SCharaIconView              ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.ProductItem                               = GetObject<RewardItem>(new IntPtr(p + 0x048), ReversePrism.DataModels.RewardItem.FromPointer); // 0x48 ProductItem                 ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.RawImage                                  = GetObject<RawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.RawImage.FromPointer); // 0x50 RawImage                    ( ModelClassType RawImage RawImage RawImage Pointer )
            value.Image                                     = GetObject<Image>(new IntPtr(p + 0x058), ReversePrism.DataModels.Image.FromPointer); // 0x58 Image                       ( ModelClassType Image Image Image Pointer )
            value.PaddingArea1                              = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0x60 PaddingArea1                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.PaddingArea2                              = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 0x68 PaddingArea2                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SelfElement                               = GetObject<LayoutElement>(new IntPtr(p + 0x070), ReversePrism.DataModels.LayoutElement.FromPointer); // 0x70 SelfElement                 ( ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.IsEnable                                  = GetBool(new IntPtr(p + 0x078)); // 0x78 IsEnable                    ( ModelPrimitiveType bool bool bool Bool )
            value.UITextMeshProUGUIs                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 UITextMeshProUGUIs          ( ModelClassListType List`1<UITextMeshProUGUI> List`1<UITextMeshProUGUI> List<UITextMeshProUGUI> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x088)); // 0x88 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
