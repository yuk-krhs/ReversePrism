using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DifficultyBG                             ModelClassType Graphic Graphic Graphic Pointer
    // 028 DifficultyBGColors                       ModelEnumListType Color[] Color[] List<Color> Pointer
    // 030 DifficultyText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 EpisodeTitleText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 UnitParameterContent                     ModelClassType ParameterContent ParameterContent ParameterContent Pointer
    // 048 UnitRankIcon                             ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 050 UnitRankRibbonImage                      ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 058 UnitOverallValueText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 RewardPrefab                             ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer
    // 068 RewardViewArea                           ModelClassType RectTransform RectTransform RectTransform Pointer
    // 070 RewardItems                              ModelClassListType List`1<LiveResultRewardItem> List`1<LiveResultRewardItem> List<LiveResultRewardItem> Pointer
    // 078 AnimatorWithEvent                        ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 080 WaitParameterAnimationFrame              ModelPrimitiveType int int int Int32
    // 084 WaitRewardItemAnimationFrame             ModelPrimitiveType int int int Int32
    public partial class ProduceResultRewardView : DataModel
    {
        public Graphic?                                 DifficultyBG                            { get; set; }
        public List<Color>?                             DifficultyBGColors                      { get; set; }
        public UITextMeshProUGUI?                       DifficultyText                          { get; set; }
        public UITextMeshProUGUI?                       EpisodeTitleText                        { get; set; }
        public ParameterContent?                        UnitParameterContent                    { get; set; }
        public UIRawImage?                              UnitRankIcon                            { get; set; }
        public UIRawImage?                              UnitRankRibbonImage                     { get; set; }
        public UITextMeshProUGUI?                       UnitOverallValueText                    { get; set; }
        public LiveResultRewardItem?                    RewardPrefab                            { get; set; }
        public RectTransform?                           RewardViewArea                          { get; set; }
        public List<LiveResultRewardItem>?              RewardItems                             { get; set; }
        public AnimatorWithEvent?                       AnimatorWithEvent                       { get; set; }
        public int                                      WaitParameterAnimationFrame             { get; set; }
        public int                                      WaitRewardItemAnimationFrame            { get; set; }

        public static ProduceResultRewardView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultRewardView() { Pointer= p0 };

            value.DifficultyBG                              = GetObject<Graphic>(new IntPtr(p + 0x020), ReversePrism.DataModels.Graphic.FromPointer); // 0x20 DifficultyBG                ( ModelClassType Graphic Graphic Graphic Pointer )
            value.DifficultyBGColors                        = GetEnumList<Color>(new IntPtr(p + 0x028)); // 0x28 DifficultyBGColors          ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.DifficultyText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 DifficultyText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EpisodeTitleText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 EpisodeTitleText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitParameterContent                      = GetObject<ParameterContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParameterContent.FromPointer); // 0x40 UnitParameterContent        ( ModelClassType ParameterContent ParameterContent ParameterContent Pointer )
            value.UnitRankIcon                              = GetObject<UIRawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x48 UnitRankIcon                ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.UnitRankRibbonImage                       = GetObject<UIRawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x50 UnitRankRibbonImage         ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.UnitOverallValueText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 UnitOverallValueText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardPrefab                              = GetObject<LiveResultRewardItem>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveResultRewardItem.FromPointer); // 0x60 RewardPrefab                ( ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer )
            value.RewardViewArea                            = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 0x68 RewardViewArea              ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RewardItems                               = GetObjectList<LiveResultRewardItem>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveResultRewardItem.FromPointer); // 0x70 RewardItems                 ( ModelClassListType List`1<LiveResultRewardItem> List`1<LiveResultRewardItem> List<LiveResultRewardItem> Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x078), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x78 AnimatorWithEvent           ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitParameterAnimationFrame               = GetInt32(new IntPtr(p + 0x080)); // 0x80 WaitParameterAnimationFrame ( ModelPrimitiveType int int int Int32 )
            value.WaitRewardItemAnimationFrame              = GetInt32(new IntPtr(p + 0x084)); // 0x84 WaitRewardItemAnimationFrame ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
