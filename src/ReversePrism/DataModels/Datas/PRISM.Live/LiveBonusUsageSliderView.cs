using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AlwaysMaxToggle                          000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 CurrentValueText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 CampaignBadgeText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 Slider                                   0001865D5A00 ModelClassType MarkingAttachedSlider MarkingAttachedSlider MarkingAttachedSlider Pointer
    // 040 SliderFill                               0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 048 SliderCurrentMarkings                    000185B833A0 ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer
    // 050 SliderNormalColor                        0001865AA8E0 ModelEnumType Color Color Color Int32
    // 060 SliderEventColor                         0001865AA8E0 ModelEnumType Color Color Color Int32
    // 070 SliderAlwaysMaxUsageColor                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 080 RewardObjectImage                        0001866CCDB0 ModelClassType Image Image Image Pointer
    // 088 LiveRewardText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ExpRewardText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 EventPointRewardText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 EventPointRewardObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 PanelColors                              000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    // 0B0 PanelObjectImages                        000185B8B1A0 ModelClassListType Image[] Image[] List<Image> Pointer
    // 0B8 TextTitleColors                          000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    // 0C0 PanelTitleTexts                          000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0C8 TextColors                               000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    // 0D0 ValueTexts                               000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 0D8 FramePanelSprites                        000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 0E0 CampaignAnnotation                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0E8 valueValidator                           Func`2<int, int> IL2CPP_TYPE_GENERICINST
    // 0F0 subject                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 0F8 PreviousValue                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0FC IsEvent                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LiveBonusUsageSliderView
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
            var value   = new LiveBonusUsageSliderView();

            value.AlwaysMaxToggle                           = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D5229BE8 0x20 AlwaysMaxToggle             ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.CurrentValueText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229C08 0x28 CurrentValueText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CampaignBadgeText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229C28 0x30 CampaignBadgeText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Slider                                    = GetObject<MarkingAttachedSlider>(new IntPtr(p + 0x038), ReversePrism.DataModels.MarkingAttachedSlider.FromPointer); // 0270D5229C48 0x38 Slider                      ( 0001865D5A00 ModelClassType MarkingAttachedSlider MarkingAttachedSlider MarkingAttachedSlider Pointer )
            value.SliderFill                                = GetObject<Graphic>(new IntPtr(p + 0x040), ReversePrism.DataModels.Graphic.FromPointer); // 0270D5229C68 0x40 SliderFill                  ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.SliderCurrentMarkings                     = GetObjectList<Graphic>(new IntPtr(p + 0x048), ReversePrism.DataModels.Graphic.FromPointer); // 0270D5229C88 0x48 SliderCurrentMarkings       ( 000185B833A0 ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer )
            value.SliderNormalColor                         = (Color)GetInt32(new IntPtr(p + 0x050)); // 0270D5229CA8 0x50 SliderNormalColor           ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.SliderEventColor                          = (Color)GetInt32(new IntPtr(p + 0x060)); // 0270D5229CC8 0x60 SliderEventColor            ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.SliderAlwaysMaxUsageColor                 = (Color)GetInt32(new IntPtr(p + 0x070)); // 0270D5229CE8 0x70 SliderAlwaysMaxUsageColor   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.RewardObjectImage                         = GetObject<Image>(new IntPtr(p + 0x080), ReversePrism.DataModels.Image.FromPointer); // 0270D5229D08 0x80 RewardObjectImage           ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.LiveRewardText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229D28 0x88 LiveRewardText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExpRewardText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229D48 0x90 ExpRewardText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventPointRewardText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229D68 0x98 EventPointRewardText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventPointRewardObject                    = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5229D88 0xA0 EventPointRewardObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PanelColors                               = GetEnumList<Color>(new IntPtr(p + 0x0A8)); // 0270D5229DA8 0xA8 PanelColors                 ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.PanelObjectImages                         = GetObjectList<Image>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Image.FromPointer); // 0270D5229DC8 0xB0 PanelObjectImages           ( 000185B8B1A0 ModelClassListType Image[] Image[] List<Image> Pointer )
            value.TextTitleColors                           = GetEnumList<Color>(new IntPtr(p + 0x0B8)); // 0270D5229DE8 0xB8 TextTitleColors             ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.PanelTitleTexts                           = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229E08 0xC0 PanelTitleTexts             ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TextColors                                = GetEnumList<Color>(new IntPtr(p + 0x0C8)); // 0270D5229E28 0xC8 TextColors                  ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.ValueTexts                                = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5229E48 0xD0 ValueTexts                  ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.FramePanelSprites                         = GetObjectList<Sprite>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Sprite.FromPointer); // 0270D5229E68 0xD8 FramePanelSprites           ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.CampaignAnnotation                        = GetObject<GameObject>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5229E88 0xE0 CampaignAnnotation          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PreviousValue                             = GetInt32(new IntPtr(p + 0x0F8)); // 0270D5229EE8 0xF8 PreviousValue               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsEvent                                   = GetBool(new IntPtr(p + 0x0FC)); // 0270D5229F08 0xFC IsEvent                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
