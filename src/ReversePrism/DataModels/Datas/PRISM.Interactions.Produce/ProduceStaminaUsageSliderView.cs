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
    // 030 Slider                                   ModelClassType MarkingAttachedSlider MarkingAttachedSlider MarkingAttachedSlider Pointer
    // 038 SliderFill                               ModelClassType Graphic Graphic Graphic Pointer
    // 040 SliderCurrentMarkings                    ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer
    // 048 SliderNormalColor                        ModelEnumType Color Color Color Int32
    // 058 SliderAlwaysMaxUsageColor                ModelEnumType Color Color Color Int32
    // 068 RewardObjectImage                        ModelClassType Image Image Image Pointer
    // 070 ProduceRewardText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 PanelObjectImage                         ModelClassType Image Image Image Pointer
    // 080 PanelTitleText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 ValueText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ColorData                                ModelClassListType ColorData[] ColorData[] List<ColorData> Pointer
    // 098 valueValidator                           Func`2<int, int> IL2CPP_TYPE_GENERICINST
    // 0A0 PreviousValue                            ModelPrimitiveType int int int Int32
    public partial class ProduceStaminaUsageSliderView : DataModel
    {
        public ToggleButton?                            AlwaysMaxToggle                         { get; set; }
        public UITextMeshProUGUI?                       CurrentValueText                        { get; set; }
        public MarkingAttachedSlider?                   Slider                                  { get; set; }
        public Graphic?                                 SliderFill                              { get; set; }
        public List<Graphic>?                           SliderCurrentMarkings                   { get; set; }
        public Color                                    SliderNormalColor                       { get; set; }
        public Color                                    SliderAlwaysMaxUsageColor               { get; set; }
        public Image?                                   RewardObjectImage                       { get; set; }
        public UITextMeshProUGUI?                       ProduceRewardText                       { get; set; }
        public Image?                                   PanelObjectImage                        { get; set; }
        public UITextMeshProUGUI?                       PanelTitleText                          { get; set; }
        public UITextMeshProUGUI?                       ValueText                               { get; set; }
        public List<ColorData>?                         ColorData                               { get; set; }
        public int                                      PreviousValue                           { get; set; }

        public static ProduceStaminaUsageSliderView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceStaminaUsageSliderView() { Pointer= p0 };

            value.AlwaysMaxToggle                           = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 AlwaysMaxToggle             ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.CurrentValueText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 CurrentValueText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Slider                                    = GetObject<MarkingAttachedSlider>(new IntPtr(p + 0x030), ReversePrism.DataModels.MarkingAttachedSlider.FromPointer); // 0x30 Slider                      ( ModelClassType MarkingAttachedSlider MarkingAttachedSlider MarkingAttachedSlider Pointer )
            value.SliderFill                                = GetObject<Graphic>(new IntPtr(p + 0x038), ReversePrism.DataModels.Graphic.FromPointer); // 0x38 SliderFill                  ( ModelClassType Graphic Graphic Graphic Pointer )
            value.SliderCurrentMarkings                     = GetObjectList<Graphic>(new IntPtr(p + 0x040), ReversePrism.DataModels.Graphic.FromPointer); // 0x40 SliderCurrentMarkings       ( ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer )
            value.SliderNormalColor                         = (Color)GetInt32(new IntPtr(p + 0x048)); // 0x48 SliderNormalColor           ( ModelEnumType Color Color Color Int32 )
            value.SliderAlwaysMaxUsageColor                 = (Color)GetInt32(new IntPtr(p + 0x058)); // 0x58 SliderAlwaysMaxUsageColor   ( ModelEnumType Color Color Color Int32 )
            value.RewardObjectImage                         = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 0x68 RewardObjectImage           ( ModelClassType Image Image Image Pointer )
            value.ProduceRewardText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 ProduceRewardText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PanelObjectImage                          = GetObject<Image>(new IntPtr(p + 0x078), ReversePrism.DataModels.Image.FromPointer); // 0x78 PanelObjectImage            ( ModelClassType Image Image Image Pointer )
            value.PanelTitleText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 PanelTitleText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValueText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 ValueText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ColorData                                 = GetObjectList<ColorData>(new IntPtr(p + 0x090), ReversePrism.DataModels.ColorData.FromPointer); // 0x90 ColorData                   ( ModelClassListType ColorData[] ColorData[] List<ColorData> Pointer )
            value.PreviousValue                             = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 PreviousValue               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
