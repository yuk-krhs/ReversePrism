using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AlwaysMaxToggle                          ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 CurrentValueText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 CampaignBadgeText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 Slider                                   ModelClassType MarkingAttachedSlider MarkingAttachedSlider MarkingAttachedSlider Pointer
    // 040 SliderFill                               ModelClassType Graphic Graphic Graphic Pointer
    // 048 SliderCurrentMarkings                    ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer
    // 050 SliderNormalColor                        ModelEnumType Color Color Color Int32
    // 060 SliderEventColor                         ModelEnumType Color Color Color Int32
    // 070 SliderAlwaysMaxUsageColor                ModelEnumType Color Color Color Int32
    // 080 RewardObjectImage                        ModelClassType Image Image Image Pointer
    // 088 LiveRewardText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ExpRewardText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 EventPointRewardText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 EventPointRewardObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 EventPointRewardLabel                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 PanelColors                              ModelEnumListType Color[] Color[] List<Color> Pointer
    // 0B8 PanelObjectImages                        ModelClassListType Image[] Image[] List<Image> Pointer
    // 0C0 TextTitleColors                          ModelEnumListType Color[] Color[] List<Color> Pointer
    // 0C8 PanelTitleTexts                          ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0D0 TextColors                               ModelEnumListType Color[] Color[] List<Color> Pointer
    // 0D8 ValueTexts                               ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0E0 FramePanelSprites                        ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 0E8 CampaignAnnotation                       ModelClassType GameObject GameObject GameObject Pointer
    // 0F0 valueValidator                           Func`2<int, int> IL2CPP_TYPE_GENERICINST
    // 0F8 subject                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 100 PreviousValue                            ModelPrimitiveType int int int Int32
    // 104 IsEvent                                  ModelPrimitiveType bool bool bool Bool
    public partial class LiveBonusUsageSliderView : DataModel
    {
        public ToggleButton?                            AlwaysMaxToggle                         { get; set; }
        public UITextMeshProUGUI?                       CurrentValueText                        { get; set; }
        public UITextMeshProUGUI?                       CampaignBadgeText                       { get; set; }
        public MarkingAttachedSlider?                   Slider                                  { get; set; }
        public Graphic?                                 SliderFill                              { get; set; }
        public List<Graphic>?                           SliderCurrentMarkings                   { get; set; }
        public Color                                    SliderNormalColor                       { get; set; }
        public Color                                    SliderEventColor                        { get; set; }
        public Color                                    SliderAlwaysMaxUsageColor               { get; set; }
        public Image?                                   RewardObjectImage                       { get; set; }
        public UITextMeshProUGUI?                       LiveRewardText                          { get; set; }
        public UITextMeshProUGUI?                       ExpRewardText                           { get; set; }
        public UITextMeshProUGUI?                       EventPointRewardText                    { get; set; }
        public GameObject?                              EventPointRewardObject                  { get; set; }
        public UITextMeshProUGUI?                       EventPointRewardLabel                   { get; set; }
        public List<Color>?                             PanelColors                             { get; set; }
        public List<Image>?                             PanelObjectImages                       { get; set; }
        public List<Color>?                             TextTitleColors                         { get; set; }
        public List<UITextMeshProUGUI>?                 PanelTitleTexts                         { get; set; }
        public List<Color>?                             TextColors                              { get; set; }
        public List<UITextMeshProUGUI>?                 ValueTexts                              { get; set; }
        public List<Sprite>?                            FramePanelSprites                       { get; set; }
        public GameObject?                              CampaignAnnotation                      { get; set; }
        public int                                      PreviousValue                           { get; set; }
        public bool                                     IsEvent                                 { get; set; }

        public static LiveBonusUsageSliderView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveBonusUsageSliderView() { Pointer= p0 };

            value.AlwaysMaxToggle                           = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 AlwaysMaxToggle             ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.CurrentValueText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 CurrentValueText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CampaignBadgeText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 CampaignBadgeText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Slider                                    = GetObject<MarkingAttachedSlider>(new IntPtr(p + 0x038), ReversePrism.DataModels.MarkingAttachedSlider.FromPointer); // 0x38 Slider                      ( ModelClassType MarkingAttachedSlider MarkingAttachedSlider MarkingAttachedSlider Pointer )
            value.SliderFill                                = GetObject<Graphic>(new IntPtr(p + 0x040), ReversePrism.DataModels.Graphic.FromPointer); // 0x40 SliderFill                  ( ModelClassType Graphic Graphic Graphic Pointer )
            value.SliderCurrentMarkings                     = GetObjectList<Graphic>(new IntPtr(p + 0x048), ReversePrism.DataModels.Graphic.FromPointer); // 0x48 SliderCurrentMarkings       ( ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer )
            value.SliderNormalColor                         = (Color)GetInt32(new IntPtr(p + 0x050)); // 0x50 SliderNormalColor           ( ModelEnumType Color Color Color Int32 )
            value.SliderEventColor                          = (Color)GetInt32(new IntPtr(p + 0x060)); // 0x60 SliderEventColor            ( ModelEnumType Color Color Color Int32 )
            value.SliderAlwaysMaxUsageColor                 = (Color)GetInt32(new IntPtr(p + 0x070)); // 0x70 SliderAlwaysMaxUsageColor   ( ModelEnumType Color Color Color Int32 )
            value.RewardObjectImage                         = GetObject<Image>(new IntPtr(p + 0x080), ReversePrism.DataModels.Image.FromPointer); // 0x80 RewardObjectImage           ( ModelClassType Image Image Image Pointer )
            value.LiveRewardText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 LiveRewardText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpRewardText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 ExpRewardText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventPointRewardText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x98 EventPointRewardText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventPointRewardObject                    = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 EventPointRewardObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EventPointRewardLabel                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 EventPointRewardLabel       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PanelColors                               = GetEnumList<Color>(new IntPtr(p + 0x0B0)); // 0xB0 PanelColors                 ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.PanelObjectImages                         = GetObjectList<Image>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Image.FromPointer); // 0xB8 PanelObjectImages           ( ModelClassListType Image[] Image[] List<Image> Pointer )
            value.TextTitleColors                           = GetEnumList<Color>(new IntPtr(p + 0x0C0)); // 0xC0 TextTitleColors             ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.PanelTitleTexts                           = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC8 PanelTitleTexts             ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TextColors                                = GetEnumList<Color>(new IntPtr(p + 0x0D0)); // 0xD0 TextColors                  ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.ValueTexts                                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xD8 ValueTexts                  ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.FramePanelSprites                         = GetObjectList<Sprite>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Sprite.FromPointer); // 0xE0 FramePanelSprites           ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.CampaignAnnotation                        = GetObject<GameObject>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.GameObject.FromPointer); // 0xE8 CampaignAnnotation          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PreviousValue                             = GetInt32(new IntPtr(p + 0x100)); // 0x100 PreviousValue               ( ModelPrimitiveType int int int Int32 )
            value.IsEvent                                   = GetBool(new IntPtr(p + 0x104)); // 0x104 IsEvent                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
