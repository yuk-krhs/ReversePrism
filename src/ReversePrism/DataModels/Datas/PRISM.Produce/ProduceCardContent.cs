using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CardImage                                0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 CardUnitFrame                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 030 CardNoUnitFrame                          0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 038 VoDaViMeMultiView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 040 CostText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CardDescriptionText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 EffectIconAreas                          000185B997F0 ModelClassListType PCardEffectIconAreaContent[] PCardEffectIconAreaContent[] List<PCardEffectIconAreaContent> Pointer
    // 058 CardRankArea                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 CardRankIcons                            000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 068 NonActiveGrayOut                         0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 070 CardClickButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 078 ProduceCardOutGameDetailPopupContentPrefab 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    public partial class ProduceCardContent
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
            var value   = new ProduceCardContent();

            value.CardImage                                 = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5BC0590 0x20 CardImage                   ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CardUnitFrame                             = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5BC05B0 0x28 CardUnitFrame               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CardNoUnitFrame                           = GetObject<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5BC05D0 0x30 CardNoUnitFrame             ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x038), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270D5BC05F0 0x38 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.CostText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5BC0610 0x40 CostText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CardDescriptionText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5BC0630 0x48 CardDescriptionText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EffectIconAreas                           = GetObjectList<PCardEffectIconAreaContent>(new IntPtr(p + 0x050), ReversePrism.DataModels.PCardEffectIconAreaContent.FromPointer); // 0270D5BC0650 0x50 EffectIconAreas             ( 000185B997F0 ModelClassListType PCardEffectIconAreaContent[] PCardEffectIconAreaContent[] List<PCardEffectIconAreaContent> Pointer )
            value.CardRankArea                              = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5BC0670 0x58 CardRankArea                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CardRankIcons                             = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5BC0690 0x60 CardRankIcons               ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.NonActiveGrayOut                          = GetObject<UIGrayOutController>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270D5BC06B0 0x68 NonActiveGrayOut            ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.CardClickButton                           = GetObject<UIButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5BC06D0 0x70 CardClickButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ProduceCardOutGameDetailPopupContentPrefab = GetObject<PopupContentBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270D5BC06F0 0x78 ProduceCardOutGameDetailPopupContentPrefab ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )

            return value;
        }
    }
}
