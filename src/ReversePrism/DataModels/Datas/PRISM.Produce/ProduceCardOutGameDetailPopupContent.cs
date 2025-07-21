using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DescriptionSeparateStr                   string IL2CPP_TYPE_STRING
    // 060 UnitIcon                                 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 068 VoDaViMeMultiView                        ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer
    // 070 CardNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CardInfoText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 ProduceCardContent                       ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 088 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 090 UnitIconObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 098 CurrentRankBalloonObjectList             ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 0A0 EfficacyDetailListPopupCaller            ModelClassType IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller Pointer
    // 0A8 ProduceCard                              ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    // 0B0 PhaseCharaNames                          ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    public partial class ProduceCardOutGameDetailPopupContent : DataModel
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
            var value   = new ProduceCardOutGameDetailPopupContent() { Pointer= p0 };

            value.UnitIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x60 UnitIcon                    ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VoDaViMeMultiView                         = GetObject<VoDaViMeMultiView>(new IntPtr(p + 0x068), ReversePrism.DataModels.VoDaViMeMultiView.FromPointer); // 0x68 VoDaViMeMultiView           ( ModelClassType VoDaViMeMultiView VoDaViMeMultiView VoDaViMeMultiView Pointer )
            value.CardNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 CardNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CardInfoText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 CardInfoText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProduceCardContent                        = GetObject<ProduceCardContent>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0x80 ProduceCardContent          ( ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x88 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.UnitIconObject                            = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 UnitIconObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CurrentRankBalloonObjectList              = GetObjectList<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 CurrentRankBalloonObjectList ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.EfficacyDetailListPopupCaller             = GetObject<IEfficacyDetailListPopupCaller>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IEfficacyDetailListPopupCaller.FromPointer); // 0xA0 EfficacyDetailListPopupCaller ( ModelClassType IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller Pointer )
            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0xA8 ProduceCard                 ( ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )
            value.PhaseCharaNames                           = GetStringList(new IntPtr(p + 0x0B0)); // 0xB0 PhaseCharaNames             ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )

            return value;
        }
    }
}
