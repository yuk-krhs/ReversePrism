using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 HighSpeedInput                           0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer
    // 048 NoteOffsetInput                          0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer
    // 050 NoteDrawOffsetInput                      0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer
    // 058 BackgroundBrightnessInput                0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer
    // 060 LaneAlphaInput                           0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer
    // 068 ShowSimultaneousLineToggle               0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 070 UseVibrationToggle                       0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 078 BackgroundModeToggleGroup                000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 080 MvEffectLevelToggleGroup                 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    public partial class LiveSettingLiveTabView : DataModel
    {
        public NumericInput?                            HighSpeedInput                          { get; set; }
        public NumericInput?                            NoteOffsetInput                         { get; set; }
        public NumericInput?                            NoteDrawOffsetInput                     { get; set; }
        public NumericInput?                            BackgroundBrightnessInput               { get; set; }
        public NumericInput?                            LaneAlphaInput                          { get; set; }
        public ToggleSwitch?                            ShowSimultaneousLineToggle              { get; set; }
        public ToggleSwitch?                            UseVibrationToggle                      { get; set; }
        public ToggleButtonGroup?                       BackgroundModeToggleGroup               { get; set; }
        public ToggleButtonGroup?                       MvEffectLevelToggleGroup                { get; set; }

        public static LiveSettingLiveTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSettingLiveTabView() { Pointer= p0 };

            value.HighSpeedInput                            = GetObject<NumericInput>(new IntPtr(p + 0x040), ReversePrism.DataModels.NumericInput.FromPointer); // 02466B48B6D0 0x40 HighSpeedInput              ( 0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.NoteOffsetInput                           = GetObject<NumericInput>(new IntPtr(p + 0x048), ReversePrism.DataModels.NumericInput.FromPointer); // 02466B48B6F0 0x48 NoteOffsetInput             ( 0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.NoteDrawOffsetInput                       = GetObject<NumericInput>(new IntPtr(p + 0x050), ReversePrism.DataModels.NumericInput.FromPointer); // 02466B48B710 0x50 NoteDrawOffsetInput         ( 0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.BackgroundBrightnessInput                 = GetObject<NumericInput>(new IntPtr(p + 0x058), ReversePrism.DataModels.NumericInput.FromPointer); // 02466B48B730 0x58 BackgroundBrightnessInput   ( 0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.LaneAlphaInput                            = GetObject<NumericInput>(new IntPtr(p + 0x060), ReversePrism.DataModels.NumericInput.FromPointer); // 02466B48B750 0x60 LaneAlphaInput              ( 0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.ShowSimultaneousLineToggle                = GetObject<ToggleSwitch>(new IntPtr(p + 0x068), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B770 0x68 ShowSimultaneousLineToggle  ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.UseVibrationToggle                        = GetObject<ToggleSwitch>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B790 0x70 UseVibrationToggle          ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.BackgroundModeToggleGroup                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x078), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466B48B7B0 0x78 BackgroundModeToggleGroup   ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.MvEffectLevelToggleGroup                  = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466B48B7D0 0x80 MvEffectLevelToggleGroup    ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )

            return value;
        }
    }
}
