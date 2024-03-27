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
    // 030 Slider                                   0001865D5A00 ModelClassType MarkingAttachedSlider MarkingAttachedSlider MarkingAttachedSlider Pointer
    // 038 SliderFill                               0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 040 SliderCurrentMarkings                    000185B833A0 ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer
    // 048 SliderNormalColor                        0001865AA8E0 ModelEnumType Color Color Color Int32
    // 058 SliderAlwaysMaxUsageColor                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 068 RewardObjectImage                        0001866CCDB0 ModelClassType Image Image Image Pointer
    // 070 ProduceRewardText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 PanelObjectImage                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 080 PanelTitleText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 ValueText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ColorData                                000185CC09C8 ModelClassListType ColorData[] ColorData[] List<ColorData> Pointer
    // 098 valueValidator                           Func`2<int, int> IL2CPP_TYPE_GENERICINST
    // 0A0 PreviousValue                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceStaminaUsageSliderView
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
            var value   = new ProduceStaminaUsageSliderView();

            value.AlwaysMaxToggle                           = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DA115DD0 0x20 AlwaysMaxToggle             ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.CurrentValueText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA115DF0 0x28 CurrentValueText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Slider                                    = GetObject<MarkingAttachedSlider>(new IntPtr(p + 0x030), ReversePrism.DataModels.MarkingAttachedSlider.FromPointer); // 0270DA115E10 0x30 Slider                      ( 0001865D5A00 ModelClassType MarkingAttachedSlider MarkingAttachedSlider MarkingAttachedSlider Pointer )
            value.SliderFill                                = GetObject<Graphic>(new IntPtr(p + 0x038), ReversePrism.DataModels.Graphic.FromPointer); // 0270DA115E30 0x38 SliderFill                  ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.SliderCurrentMarkings                     = GetObjectList<Graphic>(new IntPtr(p + 0x040), ReversePrism.DataModels.Graphic.FromPointer); // 0270DA115E50 0x40 SliderCurrentMarkings       ( 000185B833A0 ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer )
            value.SliderNormalColor                         = (Color)GetInt32(new IntPtr(p + 0x048)); // 0270DA115E70 0x48 SliderNormalColor           ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.SliderAlwaysMaxUsageColor                 = (Color)GetInt32(new IntPtr(p + 0x058)); // 0270DA115E90 0x58 SliderAlwaysMaxUsageColor   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.RewardObjectImage                         = GetObject<Image>(new IntPtr(p + 0x068), ReversePrism.DataModels.Image.FromPointer); // 0270DA115EB0 0x68 RewardObjectImage           ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ProduceRewardText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA115ED0 0x70 ProduceRewardText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PanelObjectImage                          = GetObject<Image>(new IntPtr(p + 0x078), ReversePrism.DataModels.Image.FromPointer); // 0270DA115EF0 0x78 PanelObjectImage            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.PanelTitleText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA115F10 0x80 PanelTitleText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValueText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA115F30 0x88 ValueText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ColorData                                 = GetObjectList<ColorData>(new IntPtr(p + 0x090), ReversePrism.DataModels.ColorData.FromPointer); // 0270DA115F50 0x90 ColorData                   ( 000185CC09C8 ModelClassListType ColorData[] ColorData[] List<ColorData> Pointer )
            value.PreviousValue                             = GetInt32(new IntPtr(p + 0x0A0)); // 0270DA115F90 0xA0 PreviousValue               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
