using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Font                                   0001865AD0A0 ModelClassType Font Font Font Pointer
    // 020 M_box                                    0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 028 M_button                                 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 030 M_toggle                                 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 038 M_label                                  0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 040 M_textField                              0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 048 M_textArea                               0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 050 M_window                                 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 058 M_horizontalSlider                       0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 060 M_horizontalSliderThumb                  0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 068 M_horizontalSliderThumbExtent            0001865DF960 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 070 M_verticalSlider                         0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 078 M_verticalSliderThumb                    0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 080 M_verticalSliderThumbExtent              0001865DF960 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 088 M_SliderMixed                            0001865DF960 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 090 M_horizontalScrollbar                    0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 098 M_horizontalScrollbarThumb               0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 0A0 M_horizontalScrollbarLeftButton          0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 0A8 M_horizontalScrollbarRightButton         0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 0B0 M_verticalScrollbar                      0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 0B8 M_verticalScrollbarThumb                 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 0C0 M_verticalScrollbarUpButton              0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 0C8 M_verticalScrollbarDownButton            0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 0D0 M_ScrollView                             0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer
    // 0D8 M_CustomStyles                           000185B80E50 ModelClassListType GUIStyle[] GUIStyle[] List<GUIStyle> Pointer
    // 0E0 M_Settings                               0001865DE0F0 ModelClassType GUISettings GUISettings GUISettings Pointer
    // 000 ms_Error                                 GUIStyle IL2CPP_TYPE_CLASS
    // 0E8 m_Styles                                 Dictionary`2<string, GUIStyle> IL2CPP_TYPE_GENERICINST
    // 008 m_SkinChanged                            SkinChangedDelegate IL2CPP_TYPE_CLASS
    // 010 Current                                  0001865DE830 ModelClassType GUISkin GUISkin GUISkin Pointer
    public partial class GUISkin
    {
        public Font?                                    M_Font                                  { get; set; }
        public GUIStyle?                                M_box                                   { get; set; }
        public GUIStyle?                                M_button                                { get; set; }
        public GUIStyle?                                M_toggle                                { get; set; }
        public GUIStyle?                                M_label                                 { get; set; }
        public GUIStyle?                                M_textField                             { get; set; }
        public GUIStyle?                                M_textArea                              { get; set; }
        public GUIStyle?                                M_window                                { get; set; }
        public GUIStyle?                                M_horizontalSlider                      { get; set; }
        public GUIStyle?                                M_horizontalSliderThumb                 { get; set; }
        public GUIStyle?                                M_horizontalSliderThumbExtent           { get; set; }
        public GUIStyle?                                M_verticalSlider                        { get; set; }
        public GUIStyle?                                M_verticalSliderThumb                   { get; set; }
        public GUIStyle?                                M_verticalSliderThumbExtent             { get; set; }
        public GUIStyle?                                M_SliderMixed                           { get; set; }
        public GUIStyle?                                M_horizontalScrollbar                   { get; set; }
        public GUIStyle?                                M_horizontalScrollbarThumb              { get; set; }
        public GUIStyle?                                M_horizontalScrollbarLeftButton         { get; set; }
        public GUIStyle?                                M_horizontalScrollbarRightButton        { get; set; }
        public GUIStyle?                                M_verticalScrollbar                     { get; set; }
        public GUIStyle?                                M_verticalScrollbarThumb                { get; set; }
        public GUIStyle?                                M_verticalScrollbarUpButton             { get; set; }
        public GUIStyle?                                M_verticalScrollbarDownButton           { get; set; }
        public GUIStyle?                                M_ScrollView                            { get; set; }
        public List<GUIStyle>?                          M_CustomStyles                          { get; set; }
        public GUISettings?                             M_Settings                              { get; set; }
        public GUISkin?                                 Current                                 { get; set; }

        public static GUISkin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUISkin();

            value.M_Font                                    = GetObject<Font>(new IntPtr(p + 0x018), ReversePrism.DataModels.Font.FromPointer); // 0270021D4FE0 0x18 M_Font                      ( 0001865AD0A0 ModelClassType Font Font Font Pointer )
            value.M_box                                     = GetObject<GUIStyle>(new IntPtr(p + 0x020), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5000 0x20 M_box                       ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_button                                  = GetObject<GUIStyle>(new IntPtr(p + 0x028), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5020 0x28 M_button                    ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_toggle                                  = GetObject<GUIStyle>(new IntPtr(p + 0x030), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5040 0x30 M_toggle                    ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_label                                   = GetObject<GUIStyle>(new IntPtr(p + 0x038), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5060 0x38 M_label                     ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_textField                               = GetObject<GUIStyle>(new IntPtr(p + 0x040), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5080 0x40 M_textField                 ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_textArea                                = GetObject<GUIStyle>(new IntPtr(p + 0x048), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D50A0 0x48 M_textArea                  ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_window                                  = GetObject<GUIStyle>(new IntPtr(p + 0x050), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D50C0 0x50 M_window                    ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_horizontalSlider                        = GetObject<GUIStyle>(new IntPtr(p + 0x058), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D50E0 0x58 M_horizontalSlider          ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_horizontalSliderThumb                   = GetObject<GUIStyle>(new IntPtr(p + 0x060), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5100 0x60 M_horizontalSliderThumb     ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_horizontalSliderThumbExtent             = GetObject<GUIStyle>(new IntPtr(p + 0x068), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5120 0x68 M_horizontalSliderThumbExtent ( 0001865DF960 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_verticalSlider                          = GetObject<GUIStyle>(new IntPtr(p + 0x070), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5140 0x70 M_verticalSlider            ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_verticalSliderThumb                     = GetObject<GUIStyle>(new IntPtr(p + 0x078), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5160 0x78 M_verticalSliderThumb       ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_verticalSliderThumbExtent               = GetObject<GUIStyle>(new IntPtr(p + 0x080), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5180 0x80 M_verticalSliderThumbExtent ( 0001865DF960 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_SliderMixed                             = GetObject<GUIStyle>(new IntPtr(p + 0x088), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D51A0 0x88 M_SliderMixed               ( 0001865DF960 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_horizontalScrollbar                     = GetObject<GUIStyle>(new IntPtr(p + 0x090), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D51C0 0x90 M_horizontalScrollbar       ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_horizontalScrollbarThumb                = GetObject<GUIStyle>(new IntPtr(p + 0x098), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D51E0 0x98 M_horizontalScrollbarThumb  ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_horizontalScrollbarLeftButton           = GetObject<GUIStyle>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5200 0xA0 M_horizontalScrollbarLeftButton ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_horizontalScrollbarRightButton          = GetObject<GUIStyle>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5220 0xA8 M_horizontalScrollbarRightButton ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_verticalScrollbar                       = GetObject<GUIStyle>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5240 0xB0 M_verticalScrollbar         ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_verticalScrollbarThumb                  = GetObject<GUIStyle>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5260 0xB8 M_verticalScrollbarThumb    ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_verticalScrollbarUpButton               = GetObject<GUIStyle>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D5280 0xC0 M_verticalScrollbarUpButton ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_verticalScrollbarDownButton             = GetObject<GUIStyle>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D52A0 0xC8 M_verticalScrollbarDownButton ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_ScrollView                              = GetObject<GUIStyle>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D52C0 0xD0 M_ScrollView                ( 0001865DEDB0 ModelClassType GUIStyle GUIStyle GUIStyle Pointer )
            value.M_CustomStyles                            = GetObjectList<GUIStyle>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.GUIStyle.FromPointer); // 0270021D52E0 0xD8 M_CustomStyles              ( 000185B80E50 ModelClassListType GUIStyle[] GUIStyle[] List<GUIStyle> Pointer )
            value.M_Settings                                = GetObject<GUISettings>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.GUISettings.FromPointer); // 0270021D5300 0xE0 M_Settings                  ( 0001865DE0F0 ModelClassType GUISettings GUISettings GUISettings Pointer )
            value.Current                                   = GetObject<GUISkin>(new IntPtr(p + 0x010), ReversePrism.DataModels.GUISkin.FromPointer); // 0270021D5380 0x10 Current                     ( 0001865DE830 ModelClassType GUISkin GUISkin GUISkin Pointer )

            return value;
        }
    }
}
