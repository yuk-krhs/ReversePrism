using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_instance                               ColorPicker IL2CPP_TYPE_CLASS
    // 030 Panel                                    ModelClassType Image Image Image Pointer
    // 038 ColorWheel                               ModelClassType ColorWheelControl ColorWheelControl ColorWheelControl Pointer
    // 040 AlphaSlider                              ModelClassType ColorPickerAlphaSlider ColorPickerAlphaSlider ColorPickerAlphaSlider Pointer
    // 048 RgbaText                                 ModelClassType Text Text Text Pointer
    // 050 RInput                                   ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 058 GInput                                   ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 060 BInput                                   ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 068 AInput                                   ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 070 RgbaLayoutElement                        ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 078 ButtonsLayoutElement                     ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 080 CancelButton                             ModelClassType Button Button Button Pointer
    // 088 OkButton                                 ModelClassType Button Button Button Pointer
    // 090 ReferenceCanvas                          ModelClassType Canvas Canvas Canvas Pointer
    // 098 InitialValue                             ModelEnumType Color Color Color Int32
    // 0A8 OnColorChanged                           ModelClassType OnColorChangedDelegate OnColorChangedDelegate OnColorChangedDelegate Pointer
    // 0B0 OnColorConfirmed                         ModelClassType OnColorChangedDelegate OnColorChangedDelegate OnColorChangedDelegate Pointer
    public partial class ColorPicker : DataModel
    {
        public Image?                                   Panel                                   { get; set; }
        public ColorWheelControl?                       ColorWheel                              { get; set; }
        public ColorPickerAlphaSlider?                  AlphaSlider                             { get; set; }
        public Text?                                    RgbaText                                { get; set; }
        public BoundInputField?                         RInput                                  { get; set; }
        public BoundInputField?                         GInput                                  { get; set; }
        public BoundInputField?                         BInput                                  { get; set; }
        public BoundInputField?                         AInput                                  { get; set; }
        public LayoutElement?                           RgbaLayoutElement                       { get; set; }
        public LayoutElement?                           ButtonsLayoutElement                    { get; set; }
        public Button?                                  CancelButton                            { get; set; }
        public Button?                                  OkButton                                { get; set; }
        public Canvas?                                  ReferenceCanvas                         { get; set; }
        public Color                                    InitialValue                            { get; set; }
        public OnColorChangedDelegate?                  OnColorChanged                          { get; set; }
        public OnColorChangedDelegate?                  OnColorConfirmed                        { get; set; }

        public static ColorPicker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorPicker() { Pointer= p0 };

            value.Panel                                     = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 Panel                       ( ModelClassType Image Image Image Pointer )
            value.ColorWheel                                = GetObject<ColorWheelControl>(new IntPtr(p + 0x038), ReversePrism.DataModels.ColorWheelControl.FromPointer); // 0x38 ColorWheel                  ( ModelClassType ColorWheelControl ColorWheelControl ColorWheelControl Pointer )
            value.AlphaSlider                               = GetObject<ColorPickerAlphaSlider>(new IntPtr(p + 0x040), ReversePrism.DataModels.ColorPickerAlphaSlider.FromPointer); // 0x40 AlphaSlider                 ( ModelClassType ColorPickerAlphaSlider ColorPickerAlphaSlider ColorPickerAlphaSlider Pointer )
            value.RgbaText                                  = GetObject<Text>(new IntPtr(p + 0x048), ReversePrism.DataModels.Text.FromPointer); // 0x48 RgbaText                    ( ModelClassType Text Text Text Pointer )
            value.RInput                                    = GetObject<BoundInputField>(new IntPtr(p + 0x050), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x50 RInput                      ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.GInput                                    = GetObject<BoundInputField>(new IntPtr(p + 0x058), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x58 GInput                      ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.BInput                                    = GetObject<BoundInputField>(new IntPtr(p + 0x060), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x60 BInput                      ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.AInput                                    = GetObject<BoundInputField>(new IntPtr(p + 0x068), ReversePrism.DataModels.BoundInputField.FromPointer); // 0x68 AInput                      ( ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.RgbaLayoutElement                         = GetObject<LayoutElement>(new IntPtr(p + 0x070), ReversePrism.DataModels.LayoutElement.FromPointer); // 0x70 RgbaLayoutElement           ( ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.ButtonsLayoutElement                      = GetObject<LayoutElement>(new IntPtr(p + 0x078), ReversePrism.DataModels.LayoutElement.FromPointer); // 0x78 ButtonsLayoutElement        ( ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.CancelButton                              = GetObject<Button>(new IntPtr(p + 0x080), ReversePrism.DataModels.Button.FromPointer); // 0x80 CancelButton                ( ModelClassType Button Button Button Pointer )
            value.OkButton                                  = GetObject<Button>(new IntPtr(p + 0x088), ReversePrism.DataModels.Button.FromPointer); // 0x88 OkButton                    ( ModelClassType Button Button Button Pointer )
            value.ReferenceCanvas                           = GetObject<Canvas>(new IntPtr(p + 0x090), ReversePrism.DataModels.Canvas.FromPointer); // 0x90 ReferenceCanvas             ( ModelClassType Canvas Canvas Canvas Pointer )
            value.InitialValue                              = (Color)GetInt32(new IntPtr(p + 0x098)); // 0x98 InitialValue                ( ModelEnumType Color Color Color Int32 )
            value.OnColorChanged                            = GetObject<OnColorChangedDelegate>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.OnColorChangedDelegate.FromPointer); // 0xA8 OnColorChanged              ( ModelClassType OnColorChangedDelegate OnColorChangedDelegate OnColorChangedDelegate Pointer )
            value.OnColorConfirmed                          = GetObject<OnColorChangedDelegate>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.OnColorChangedDelegate.FromPointer); // 0xB0 OnColorConfirmed            ( ModelClassType OnColorChangedDelegate OnColorChangedDelegate OnColorChangedDelegate Pointer )

            return value;
        }
    }
}
