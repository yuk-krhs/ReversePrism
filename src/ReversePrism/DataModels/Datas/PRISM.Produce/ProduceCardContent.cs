using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CardImage                                ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 CardUnitFrame                            ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 CardNoUnitFrame                          ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 VoDaViMeMultiView                        ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 040 CostText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CardDescriptionText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 EffectIconAreas                          ModelClassListType PCardEffectIconAreaContent[] PCardEffectIconAreaContent[] List<PCardEffectIconAreaContent> Pointer
    // 058 CardRankArea                             ModelClassType GameObject GameObject GameObject Pointer
    // 060 CardRankIcons                            ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 068 NonActiveGrayOut                         ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 070 CardClickButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 078 ProduceCardOutGameDetailPopupContentPrefab ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    public partial class ProduceCardContent : DataModel
    {
        public UIRawImage?                              CardImage                               { get; set; }
        public UIRawImage?                              CardUnitFrame                           { get; set; }
        public UIRawImage?                              CardNoUnitFrame                         { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public UITextMeshProUGUI?                       CostText                                { get; set; }
        public UITextMeshProUGUI?                       CardDescriptionText                     { get; set; }
        public List<PCardEffectIconAreaContent>?        EffectIconAreas                         { get; set; }
        public GameObject?                              CardRankArea                            { get; set; }
        public List<GameObject>?                        CardRankIcons                           { get; set; }
        public UIGrayOutController?                     NonActiveGrayOut                        { get; set; }
        public UIButton?                                CardClickButton                         { get; set; }
        public PopupContentBase?                        ProduceCardOutGameDetailPopupContentPrefab { get; set; }

        public static ProduceCardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardContent() { Pointer= p0 };

            value.CardImage                                 = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 CardImage                   ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CardUnitFrame                             = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 CardUnitFrame               ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CardNoUnitFrame                           = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x30 CardNoUnitFrame             ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x038), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0x38 VoDaViMeMultiView           ( ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.CostText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 CostText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CardDescriptionText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 CardDescriptionText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EffectIconAreas                           = GetObjectList<PCardEffectIconAreaContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.PCardEffectIconAreaContent.FromPointer); // 0x50 EffectIconAreas             ( ModelClassListType PCardEffectIconAreaContent[] PCardEffectIconAreaContent[] List<PCardEffectIconAreaContent> Pointer )
            value.CardRankArea                              = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 CardRankArea                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CardRankIcons                             = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 CardRankIcons               ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.NonActiveGrayOut                          = GetObject<UIGrayOutController>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x68 NonActiveGrayOut            ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.CardClickButton                           = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0x70 CardClickButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ProduceCardOutGameDetailPopupContentPrefab = GetObject<PopupContentBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x78 ProduceCardOutGameDetailPopupContentPrefab ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )

            return value;
        }
    }
}
