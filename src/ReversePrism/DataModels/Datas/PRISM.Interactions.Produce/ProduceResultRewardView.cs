using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 028 DifficultyBG                             0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 030 DifficultyBGColors                       000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    // 038 DifficultyText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 EpisodeTitleText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 UnitParameterContent                     00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer
    // 050 UnitRankIcon                             0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 058 UnitRankRibbonImage                      0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 060 UnitOverallValueText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 RewardPrefab                             000186573C40 ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer
    // 070 RewardViewArea                           000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 078 RewardItems                              000185CF06F8 ModelClassListType List`1<LiveResultRewardItem> List`1<LiveResultRewardItem> List<LiveResultRewardItem> Pointer
    // 080 AnimatorWithEvent                        0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 088 WaitParameterAnimationFrame              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 08C WaitRewardItemAnimationFrame             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceResultRewardView : DataModel
    {
        public IResourceTag?                            ResourceTag                             { get; set; }
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

            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x020), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A243BD0 0x20 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.DifficultyBG                              = GetObject<Graphic>(new IntPtr(p + 0x028), ReversePrism.DataModels.Graphic.FromPointer); // 02466A243BF0 0x28 DifficultyBG                ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.DifficultyBGColors                        = GetEnumList<Color>(new IntPtr(p + 0x030)); // 02466A243C10 0x30 DifficultyBGColors          ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.DifficultyText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A243C30 0x38 DifficultyText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EpisodeTitleText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A243C50 0x40 EpisodeTitleText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitParameterContent                      = GetObject<ParameterContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.ParameterContent.FromPointer); // 02466A243C70 0x48 UnitParameterContent        ( 00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer )
            value.UnitRankIcon                              = GetObject<UIRawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A243C90 0x50 UnitRankIcon                ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.UnitRankRibbonImage                       = GetObject<UIRawImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A243CB0 0x58 UnitRankRibbonImage         ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.UnitOverallValueText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A243CD0 0x60 UnitOverallValueText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardPrefab                              = GetObject<LiveResultRewardItem>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveResultRewardItem.FromPointer); // 02466A243CF0 0x68 RewardPrefab                ( 000186573C40 ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer )
            value.RewardViewArea                            = GetObject<RectTransform>(new IntPtr(p + 0x070), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A243D10 0x70 RewardViewArea              ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RewardItems                               = GetObjectList<LiveResultRewardItem>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveResultRewardItem.FromPointer); // 02466A243D30 0x78 RewardItems                 ( 000185CF06F8 ModelClassListType List`1<LiveResultRewardItem> List`1<LiveResultRewardItem> List<LiveResultRewardItem> Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x080), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 02466A243D50 0x80 AnimatorWithEvent           ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitParameterAnimationFrame               = GetInt32(new IntPtr(p + 0x088)); // 02466A243D70 0x88 WaitParameterAnimationFrame ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WaitRewardItemAnimationFrame              = GetInt32(new IntPtr(p + 0x08C)); // 02466A243D90 0x8C WaitRewardItemAnimationFrame ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
