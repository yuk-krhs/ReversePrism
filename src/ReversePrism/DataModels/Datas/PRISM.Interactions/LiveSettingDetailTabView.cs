using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 NoteDesignInput                          0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer
    // 048 NoteEffectDesignInput                    0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer
    // 050 ShowNoteEffectToggle                     0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 058 ShowLifeGaugeToggle                      0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 060 ShowLifeWarningToggle                    0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 068 ShowScoreGaugeToggle                     0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 070 ComboShowTypeToggleGroup                 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 ShowPerfectComboEffectToggle             0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 080 JudgementShowTypeToggleGroup             000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 088 JudgementShowPositionTypeToggleGroup     000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 090 ShowJudgementLagTypeToggle               000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 098 ShowSkillCutinToggle                     0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 0A0 ShowSkillEffectToggle                    0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 0A8 ShowKeyBeamToggle                        0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 0B0 LaneCutRateInput                         0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer
    // 0B8 IsMirrorToggle                           0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    public partial class LiveSettingDetailTabView : DataModel
    {
        public NumericInput?                            NoteDesignInput                         { get; set; }
        public NumericInput?                            NoteEffectDesignInput                   { get; set; }
        public ToggleSwitch?                            ShowNoteEffectToggle                    { get; set; }
        public ToggleSwitch?                            ShowLifeGaugeToggle                     { get; set; }
        public ToggleSwitch?                            ShowLifeWarningToggle                   { get; set; }
        public ToggleSwitch?                            ShowScoreGaugeToggle                    { get; set; }
        public ToggleButtonGroup?                       ComboShowTypeToggleGroup                { get; set; }
        public ToggleSwitch?                            ShowPerfectComboEffectToggle            { get; set; }
        public ToggleButtonGroup?                       JudgementShowTypeToggleGroup            { get; set; }
        public ToggleButtonGroup?                       JudgementShowPositionTypeToggleGroup    { get; set; }
        public ToggleButtonGroup?                       ShowJudgementLagTypeToggle              { get; set; }
        public ToggleSwitch?                            ShowSkillCutinToggle                    { get; set; }
        public ToggleSwitch?                            ShowSkillEffectToggle                   { get; set; }
        public ToggleSwitch?                            ShowKeyBeamToggle                       { get; set; }
        public NumericInput?                            LaneCutRateInput                        { get; set; }
        public ToggleSwitch?                            IsMirrorToggle                          { get; set; }

        public static LiveSettingDetailTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSettingDetailTabView() { Pointer= p0 };

            value.NoteDesignInput                           = GetObject<NumericInput>(new IntPtr(p + 0x040), ReversePrism.DataModels.NumericInput.FromPointer); // 02466B48B430 0x40 NoteDesignInput             ( 0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.NoteEffectDesignInput                     = GetObject<NumericInput>(new IntPtr(p + 0x048), ReversePrism.DataModels.NumericInput.FromPointer); // 02466B48B450 0x48 NoteEffectDesignInput       ( 0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.ShowNoteEffectToggle                      = GetObject<ToggleSwitch>(new IntPtr(p + 0x050), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B470 0x50 ShowNoteEffectToggle        ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowLifeGaugeToggle                       = GetObject<ToggleSwitch>(new IntPtr(p + 0x058), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B490 0x58 ShowLifeGaugeToggle         ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowLifeWarningToggle                     = GetObject<ToggleSwitch>(new IntPtr(p + 0x060), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B4B0 0x60 ShowLifeWarningToggle       ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowScoreGaugeToggle                      = GetObject<ToggleSwitch>(new IntPtr(p + 0x068), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B4D0 0x68 ShowScoreGaugeToggle        ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ComboShowTypeToggleGroup                  = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466B48B4F0 0x70 ComboShowTypeToggleGroup    ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ShowPerfectComboEffectToggle              = GetObject<ToggleSwitch>(new IntPtr(p + 0x078), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B510 0x78 ShowPerfectComboEffectToggle ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.JudgementShowTypeToggleGroup              = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466B48B530 0x80 JudgementShowTypeToggleGroup ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.JudgementShowPositionTypeToggleGroup      = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x088), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466B48B550 0x88 JudgementShowPositionTypeToggleGroup ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ShowJudgementLagTypeToggle                = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 02466B48B570 0x90 ShowJudgementLagTypeToggle  ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.ShowSkillCutinToggle                      = GetObject<ToggleSwitch>(new IntPtr(p + 0x098), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B590 0x98 ShowSkillCutinToggle        ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowSkillEffectToggle                     = GetObject<ToggleSwitch>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B5B0 0xA0 ShowSkillEffectToggle       ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowKeyBeamToggle                         = GetObject<ToggleSwitch>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B5D0 0xA8 ShowKeyBeamToggle           ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.LaneCutRateInput                          = GetObject<NumericInput>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.NumericInput.FromPointer); // 02466B48B5F0 0xB0 LaneCutRateInput            ( 0001866C3830 ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.IsMirrorToggle                            = GetObject<ToggleSwitch>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B48B610 0xB8 IsMirrorToggle              ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )

            return value;
        }
    }
}
