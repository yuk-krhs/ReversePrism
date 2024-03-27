using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DescriptionSeparateStr                   string IL2CPP_TYPE_STRING
    // 060 UnitIcon                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 068 VoDaViMeMultiView                        000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 070 CardNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CardInfoText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 ProduceCardContent                       0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 088 UiTabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 090 UnitIconObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 098 CurrentRankBalloonObjectList             000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 0A0 EfficacyDetailListPopupCaller            00018675DD00 ModelClassType IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller Pointer
    // 0A8 ProduceCard                              0001865E4640 ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    // 0B0 PhaseCharaNames                          000185D16F48 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    public partial class ProduceCardOutGameDetailPopupContent
    {
        public UIRawImage?                              UnitIcon                                { get; set; }
        public VoDaViMeMultiView?                       VoDaViMeMultiView                       { get; set; }
        public UITextMeshProUGUI?                       CardNameText                            { get; set; }
        public UITextMeshProUGUI?                       CardInfoText                            { get; set; }
        public ProduceCardContent?                      ProduceCardContent                      { get; set; }
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public GameObject?                              UnitIconObject                          { get; set; }
        public List<GameObject>?                        CurrentRankBalloonObjectList            { get; set; }
        public IEfficacyDetailListPopupCaller?          EfficacyDetailListPopupCaller           { get; set; }
        public IProduceCardStatus?                      ProduceCard                             { get; set; }
        public List<string>?                            PhaseCharaNames                         { get; set; }

        public static ProduceCardOutGameDetailPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceCardOutGameDetailPopupContent();

            value.UnitIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5CE92A8 0x60 UnitIcon                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x068), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0270D5CE92C8 0x68 VoDaViMeMultiView           ( 000186530920 ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.CardNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5CE92E8 0x70 CardNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CardInfoText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5CE9308 0x78 CardInfoText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProduceCardContent                        = GetObject<ProduceCardContent>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0270D5CE9328 0x80 ProduceCardContent          ( 0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270D5CE9348 0x88 UiTabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.UnitIconObject                            = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5CE9368 0x90 UnitIconObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CurrentRankBalloonObjectList              = GetObjectList<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5CE9388 0x98 CurrentRankBalloonObjectList ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.EfficacyDetailListPopupCaller             = GetObject<IEfficacyDetailListPopupCaller>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IEfficacyDetailListPopupCaller.FromPointer); // 0270D5CE93A8 0xA0 EfficacyDetailListPopupCaller ( 00018675DD00 ModelClassType IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller Pointer )
            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5CE93C8 0xA8 ProduceCard                 ( 0001865E4640 ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )
            value.PhaseCharaNames                           = GetStringList(new IntPtr(p + 0x0B0)); // 0270D5CE93E8 0xB0 PhaseCharaNames             ( 000185D16F48 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )

            return value;
        }
    }
}
